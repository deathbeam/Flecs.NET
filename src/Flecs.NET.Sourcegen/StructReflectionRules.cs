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

    private ReflectionResult(ReflectionProblem problem, string typeName, string? member, ImmutableArray<ReflectedMember> members)
    {
        Problem = problem;
        TypeName = typeName;
        Member = member;
        Members = members;
    }

    public static ReflectionResult Reflectable(string typeName, ImmutableArray<ReflectedMember> members)
        => new(ReflectionProblem.None, typeName, null, members);

    public static ReflectionResult NotReflectable(ReflectionProblem problem, string typeName, string? member = null)
        => new(problem, typeName, member, ImmutableArray<ReflectedMember>.Empty);
}

/// <summary>
///     The single source of truth for which <c>IFlecsStruct</c> types are reflected and with which
///     members. Used by both the generator and the analyzer so they can never disagree.
/// </summary>
internal static class StructReflectionRules
{
    public const string InterfaceFullyQualifiedName = "Flecs.NET.Core.IFlecsStruct";

    public static ReflectionResult Analyze(INamedTypeSymbol symbol, INamedTypeSymbol iface)
    {
        if (!symbol.AllInterfaces.Any(i => SymbolEqualityComparer.Default.Equals(i, iface)))
            return ReflectionResult.NotReflectable(ReflectionProblem.NotApplicable, string.Empty);

        string typeName = symbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);

        // The registrar is emitted into another file, so it can only name closed, accessible types.
        for (INamedTypeSymbol? type = symbol; type is not null; type = type.ContainingType)
        {
            if (type.TypeParameters.Length > 0)
                return ReflectionResult.NotReflectable(ReflectionProblem.OpenGeneric, typeName);

            if (type.IsFileLocal)
                return ReflectionResult.NotReflectable(ReflectionProblem.FileScoped, typeName);

            if (type.DeclaredAccessibility is not (Accessibility.Public or Accessibility.Internal or Accessibility.ProtectedOrInternal))
                return ReflectionResult.NotReflectable(ReflectionProblem.Inaccessible, typeName);
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
}
