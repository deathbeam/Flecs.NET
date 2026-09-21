using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Flecs.NET.Sourcegen;

/// <summary>
///     Emits a <c>[ModuleInitializer]</c> registrar per <c>IFlecsStruct</c> struct.
/// </summary>
[Generator]
public sealed class StructReflectionGenerator : IIncrementalGenerator
{
    private const string InterfaceFullyQualifiedName = "Flecs.NET.Core.IFlecsStruct";

    private static readonly DiagnosticDescriptor OpenGenericTypeRule = new(
        id: "FLECSREFL001",
        title: "IFlecsStruct on open generic type",
        messageFormat: "IFlecsStruct is not supported on open generic type '{0}'",
        category: "Flecs.NET.Reflection",
        defaultSeverity: DiagnosticSeverity.Warning,
        isEnabledByDefault: true);

    private static readonly DiagnosticDescriptor FileScopedTypeRule = new(
        id: "FLECSREFL002",
        title: "IFlecsStruct on file-scoped type",
        messageFormat: "IFlecsStruct is not supported on file-scoped type '{0}'",
        category: "Flecs.NET.Reflection",
        defaultSeverity: DiagnosticSeverity.Warning,
        isEnabledByDefault: true);

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        IncrementalValuesProvider<Output> outputs = context.CompilationProvider.SelectMany(
            (compilation, _) => CollectOutputs(compilation));

        context.RegisterSourceOutput(outputs, Produce);
    }

    private static List<Output> CollectOutputs(Compilation compilation)
    {
        var results = new List<Output>();

        INamedTypeSymbol? iface = compilation.GetTypeByMetadataName(InterfaceFullyQualifiedName);
        if (iface is null)
            return results;

        var seen = new HashSet<INamedTypeSymbol>(SymbolEqualityComparer.Default);

        foreach (SyntaxTree tree in compilation.SyntaxTrees)
        {
            SemanticModel semantic = compilation.GetSemanticModel(tree);
            TypeDeclarationSyntax[] typeDecls = tree.GetRoot()
                .DescendantNodes()
                .OfType<TypeDeclarationSyntax>()
                .ToArray();

            foreach (TypeDeclarationSyntax decl in typeDecls)
            {
                if (semantic.GetDeclaredSymbol(decl) is not { } symbol)
                    continue;

                if (symbol.TypeKind != TypeKind.Struct)
                    continue;

                if (!ImplementsInterface(symbol, iface))
                    continue;

                if (!seen.Add(symbol))
                    continue;

                if (decl.Modifiers.Any(SyntaxKind.FileKeyword))
                {
                    results.Add(new Output(null, Diagnostic.Create(
                        FileScopedTypeRule,
                        symbol.Locations.Length > 0 ? symbol.Locations[0] : null,
                        symbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat))));
                    continue;
                }

                if (symbol.IsUnboundGenericType || symbol.TypeParameters.Length > 0)
                {
                    results.Add(new Output(null, Diagnostic.Create(
                        OpenGenericTypeRule,
                        symbol.Locations.Length > 0 ? symbol.Locations[0] : null,
                        symbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat))));
                    continue;
                }

                results.Add(new Output(BuildModel(symbol), null));
            }
        }

        return results;
    }

    private static bool ImplementsInterface(INamedTypeSymbol type, INamedTypeSymbol iface)
        => type.AllInterfaces.Any(i => SymbolEqualityComparer.Default.Equals(i, iface));

    private static StructModel BuildModel(INamedTypeSymbol structSymbol)
    {
        MemberInfo[] members = CollectMembers(structSymbol);

        string fullyQualifiedType = structSymbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
        string sanitized = SanitizeIdentifier(fullyQualifiedType);

        var nativeBuilder = new StringBuilder();
        var mirrorBuilder = new StringBuilder();
        var serializeBuilder = new StringBuilder();
        var ensureBuilder = new StringBuilder();

        foreach (MemberInfo member in members)
        {
            if (nativeBuilder.Length > 0)
                nativeBuilder.Append('\n');

            nativeBuilder.Append("                component.Member<")
                .Append(member.Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat))
                .Append(">(\"")
                .Append(EscapeString(member.Name))
                .Append("\");");

            if (member.IsField && (member.IsString || member.IsUnmanaged))
            {
                mirrorBuilder.Append(mirrorBuilder.Length > 0 ? ",\n" : "")
                    .Append("                    (\"").Append(EscapeString(member.Name)).Append("\", ")
                    .Append(member.IsString ? "o.RawString()" : $"o.TypeId<{member.Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)}>()")
                    .Append(')');

                serializeBuilder.Append("                ser.Member(\"").Append(EscapeString(member.Name)).Append("\");\n")
                    .Append("                ser.Value(v.").Append(EscapeString(member.Name)).Append(");\n");

                ensureBuilder.Append($"            case \"{EscapeString(member.Name)}\": return ref global::System.Runtime.CompilerServices.Unsafe.As<{member.Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)}, byte>(ref v.{EscapeString(member.Name)});\n");
            }
        }
        string opaqueStatement = mirrorBuilder.Length == 0
            ? ""
            : "else\n" +
              "{\n" +
              "    component.Opaque(o => o\n" +
              "        .AsType(o.MirrorStruct(\n" +
              mirrorBuilder + "))\n" +
              "        .Serialize(static (ref readonly global::Flecs.NET.Core.Ecs.Serializer ser, in " + fullyQualifiedType + " v) =>\n" +
              "        {\n" +
              serializeBuilder +
              "            return 0;\n" +
              "        })\n" +
              "        .EnsureMember(__EnsureMember));\n" +
              "}";

        return new StructModel(
            fullyQualifiedType,
            $"StructReflection.{sanitized}.g.cs",
            $"__FlecsStructReflection_{sanitized}",
            nativeBuilder.ToString(),
            opaqueStatement,
            ensureBuilder.ToString());
    }

    private static MemberInfo[] CollectMembers(INamedTypeSymbol structSymbol)
    {
        var fields = new List<MemberInfo>();
        var properties = new List<MemberInfo>();

        foreach (ISymbol member in structSymbol.GetMembers())
        {
            if (member.DeclaredAccessibility != Accessibility.Public)
                continue;

            switch (member)
            {
                case IFieldSymbol field when !field.IsStatic && !field.IsConst && field.Type is not IPointerTypeSymbol:
                    fields.Add(new MemberInfo(field.Name, field.Type, isField: true));
                    break;
                case IPropertySymbol property when !property.IsStatic && property.Parameters.Length == 0:
                    properties.Add(new MemberInfo(property.Name, property.Type, isField: false));
                    break;
            }
        }

        return fields.Count > 0 ? fields.ToArray() : properties.ToArray();
    }

    private static void Produce(SourceProductionContext spc, Output output)
    {
        if (output.Diagnostic is { } diagnostic)
        {
            spc.ReportDiagnostic(diagnostic);
            return;
        }

        StructModel model = output.Model!.Value;

        string source = $$"""
            // <auto-generated/>
            #nullable enable

            using System.Runtime.CompilerServices;

            namespace Flecs.NET.Generated.StructReflection;

            internal static class {{model.GeneratedClassName}}
            {
                [ModuleInitializer]
                internal static void __Register()
                {
                    global::Flecs.NET.Core.StructReflection.Register<{{model.FullyQualifiedTypeName}}>(static component =>
                    {
                        if (!global::System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences<{{model.FullyQualifiedTypeName}}>())
                        {
            {{model.MemberStatement}}
                        }{{model.OpaqueStatement}}
                    });
                }

                private static ref byte __EnsureMember(ref {{model.FullyQualifiedTypeName}} v, string member)
                {
                    switch (member)
                    {
            {{model.EnsureStatement}}            default: return ref global::System.Runtime.CompilerServices.Unsafe.NullRef<byte>();
                    }
                }
            }
            """;

        spc.AddSource(model.GeneratedFileName, source);
    }

    private static string SanitizeIdentifier(string fullyQualifiedName)
    {
        var builder = new StringBuilder(fullyQualifiedName.Length);
        foreach (char c in fullyQualifiedName)
        {
            if (c == '_' || char.IsLetterOrDigit(c))
                builder.Append(c);
            else
                builder.Append('_');
        }

        return builder.ToString();
    }

    private static string EscapeString(string value)
    {
        var builder = new StringBuilder(value.Length);
        foreach (char c in value)
        {
            switch (c)
            {
                case '\\': builder.Append("\\\\"); break;
                case '"': builder.Append("\\\""); break;
                default: builder.Append(c); break;
            }
        }

        return builder.ToString();
    }

    private readonly struct Output
    {
        public StructModel? Model { get; }
        public Diagnostic? Diagnostic { get; }

        public Output(StructModel? model, Diagnostic? diagnostic)
        {
            Model = model;
            Diagnostic = diagnostic;
        }
    }

    private readonly struct StructModel
    {
        public string FullyQualifiedTypeName { get; }
        public string GeneratedFileName { get; }
        public string GeneratedClassName { get; }
        public string MemberStatement { get; }
        public string OpaqueStatement { get; }
        public string EnsureStatement { get; }

        public StructModel(string fullyQualifiedTypeName, string generatedFileName, string generatedClassName, string memberStatement, string opaqueStatement, string ensureStatement)
        {
            FullyQualifiedTypeName = fullyQualifiedTypeName;
            GeneratedFileName = generatedFileName;
            GeneratedClassName = generatedClassName;
            MemberStatement = memberStatement;
            OpaqueStatement = opaqueStatement;
            EnsureStatement = ensureStatement;
        }
    }

    private readonly struct MemberInfo
    {
        public string Name { get; }
        public ITypeSymbol Type { get; }
        public bool IsField { get; }
        public bool IsString => Type.SpecialType == SpecialType.System_String;
        public bool IsUnmanaged => Type.IsUnmanagedType;

        public MemberInfo(string name, ITypeSymbol type, bool isField)
        {
            Name = name;
            Type = type;
            IsField = isField;
        }
    }
}
