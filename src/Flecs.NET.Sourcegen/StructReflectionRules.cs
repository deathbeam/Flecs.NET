using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace Flecs.NET.Sourcegen;

internal enum ReflectionProblem
{
    None,
    NotApplicable,
    FileScoped,
    OpenGeneric,
    Inaccessible,
    Managed,
    NoMembers
}

internal readonly struct ReflectedMember
{
    public readonly string Name;
    public readonly string Type;
    public readonly int Count;

    public ReflectedMember(string name, string type, int count)
    {
        Name = name;
        Type = type;
        Count = count;
    }
}

internal readonly struct ReflectionResult
{
    public readonly ReflectionProblem Problem;
    public readonly string TypeName;

    /// <summary>The offending member for <see cref="ReflectionProblem.Managed"/>.</summary>
    public readonly string? Member;

    public readonly ImmutableArray<ReflectedMember> Members;
    public readonly string? ElementType;

    public readonly int ElementCount;

    private ReflectionResult(ReflectionProblem problem, string typeName, string? member,
        ImmutableArray<ReflectedMember> members, string? elementType = null, int elementCount = 0)
    {
        Problem = problem;
        TypeName = typeName;
        Member = member;
        Members = members;
        ElementType = elementType;
        ElementCount = elementCount;
    }

    public static ReflectionResult Reflectable(string typeName, ImmutableArray<ReflectedMember> members)
        => new(ReflectionProblem.None, typeName, null, members);

    public static ReflectionResult ReflectableArray(string typeName, string elementType, int elementCount)
        => new(ReflectionProblem.None, typeName, null, ImmutableArray<ReflectedMember>.Empty, elementType, elementCount);

    public static ReflectionResult NotReflectable(ReflectionProblem problem, string typeName, string? member = null)
        => new(problem, typeName, member, ImmutableArray<ReflectedMember>.Empty);
}

/// <summary>
///     The single source of truth for which <c>[FlecsStruct]</c> types are reflected and with which
///     members. Used by both the generator and the analyzer so they can never disagree.
/// </summary>
internal static class StructReflectionRules
{
    public const string AttributeFullyQualifiedName = "Flecs.NET.Core.FlecsStructAttribute";

    private const string InlineArrayAttributeFullyQualifiedName = "System.Runtime.CompilerServices.InlineArrayAttribute";

    public static ReflectionResult Analyze(INamedTypeSymbol symbol)
    {
        if (!HasFlecsStructAttribute(symbol))
            return ReflectionResult.NotReflectable(ReflectionProblem.NotApplicable, string.Empty);

        string typeName = symbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);

        // The registrar is emitted into another file, so it can only name closed, accessible types.
        ReflectionProblem problem = GetAccessibilityProblem(symbol);
        if (problem != ReflectionProblem.None)
            return ReflectionResult.NotReflectable(problem, typeName);

        // An [InlineArray] type exposes one field but stores N values, so flecs reflects it as an array type.
        if (TryGetInlineArrayCount(symbol, out int elementCount))
        {
            if (symbol.GetMembers().OfType<IFieldSymbol>()
                    .FirstOrDefault(static field => !field.IsStatic && !field.IsConst) is not { } element)
                return ReflectionResult.NotReflectable(ReflectionProblem.NoMembers, typeName);

            if (!element.Type.IsUnmanagedType)
                return ReflectionResult.NotReflectable(ReflectionProblem.Managed, typeName, element.Name);

            // The element type is named by the registrar too, so it must be accessible as well.
            problem = element.Type is INamedTypeSymbol named ? GetAccessibilityProblem(named) : ReflectionProblem.None;
            if (problem != ReflectionProblem.None)
                return ReflectionResult.NotReflectable(problem, typeName);

            // A pointer can't be a generic type argument, and flecs maps a pointer element to uptr (c_utils.c).
            string elementType = element.Type is IPointerTypeSymbol or IFunctionPointerTypeSymbol
                ? "nuint"
                : element.Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);

            return ReflectionResult.ReflectableArray(typeName, elementType, elementCount);
        }

        var members = new List<(string Name, string Type, int Count)>();

        // flecs computes member offsets from declaration order, so every field with storage must be emitted.
        foreach (ISymbol member in symbol.GetMembers())
        {
            if (member is not IFieldSymbol { IsStatic: false, IsConst: false } field)
                continue;

            string name = field.AssociatedSymbol?.Name ?? field.Name;

            if (!field.Type.IsUnmanagedType)
                return ReflectionResult.NotReflectable(ReflectionProblem.Managed, typeName, name);

            if (field.IsFixedSizeBuffer)
            {
                // A fixed-size buffer is a pointer field with inline storage; reflect its element type and count.
                ITypeSymbol element = ((IPointerTypeSymbol)field.Type).PointedAtType;
                members.Add((name, element.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat), field.FixedSize));
            }
            else if (field.Type is IPointerTypeSymbol)
            {
                // flecs maps a pointer member to uptr (c_utils.c), which has the same size as a C# pointer.
                // char* maps to string there, but C# char* points to UTF-16, so uptr is the safe match.
                members.Add((name, "nuint", 0));
            }
            else
            {
                members.Add((name, field.Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat), 0));
            }
        }

        if (members.Count == 0)
            return ReflectionResult.NotReflectable(ReflectionProblem.NoMembers, typeName);

        var reflected = ImmutableArray.CreateBuilder<ReflectedMember>(members.Count);
        foreach ((string name, string type, int count) in members)
            reflected.Add(new ReflectedMember(name, type, count));

        return ReflectionResult.Reflectable(typeName, reflected.MoveToImmutable());
    }

    private static bool HasFlecsStructAttribute(INamedTypeSymbol symbol)
    {
        foreach (AttributeData attribute in symbol.GetAttributes())
        {
            if (attribute.AttributeClass?.ToDisplayString() == AttributeFullyQualifiedName)
                return true;
        }

        return false;
    }

    private static bool TryGetInlineArrayCount(INamedTypeSymbol symbol, out int count)
    {
        foreach (AttributeData attribute in symbol.GetAttributes())
        {
            if (attribute.AttributeClass?.ToDisplayString() == InlineArrayAttributeFullyQualifiedName
                && attribute.ConstructorArguments.Length == 1 && attribute.ConstructorArguments[0].Value is int value)
            {
                count = value;
                return true;
            }
        }

        count = 0;
        return false;
    }

    private static ReflectionProblem GetAccessibilityProblem(INamedTypeSymbol symbol)
    {
        for (INamedTypeSymbol? type = symbol; type is not null; type = type.ContainingType)
        {
            if (type.TypeParameters.Length > 0)
                return ReflectionProblem.OpenGeneric;

            if (type.IsFileLocal)
                return ReflectionProblem.FileScoped;

            if (type.DeclaredAccessibility is not (Accessibility.Public or Accessibility.Internal or Accessibility.ProtectedOrInternal))
                return ReflectionProblem.Inaccessible;
        }

        return ReflectionProblem.None;
    }
}
