using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Flecs.NET.Sourcegen;

/// <summary>
///     Reports why an <c>IFlecsStruct</c> type is not reflected. Kept separate from the generator so
///     the diagnostics are suppressible with <c>#pragma warning disable</c> and .editorconfig.
/// </summary>
[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class StructReflectionAnalyzer : DiagnosticAnalyzer
{
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

    private static readonly DiagnosticDescriptor ManagedTypeRule = new(
        id: "FLECSREFL003",
        title: "IFlecsStruct with managed member",
        messageFormat: "IFlecsStruct cannot reflect '{0}' because member '{1}' is managed; register opaque reflection explicitly if needed",
        category: "Flecs.NET.Reflection",
        defaultSeverity: DiagnosticSeverity.Warning,
        isEnabledByDefault: true);

    private static readonly DiagnosticDescriptor NoMembersRule = new(
        id: "FLECSREFL004",
        title: "IFlecsStruct without instance fields",
        messageFormat: "IFlecsStruct cannot reflect '{0}' because it has no instance fields",
        category: "Flecs.NET.Reflection",
        defaultSeverity: DiagnosticSeverity.Warning,
        isEnabledByDefault: true);

    private static readonly DiagnosticDescriptor InaccessibleTypeRule = new(
        id: "FLECSREFL005",
        title: "IFlecsStruct on inaccessible type",
        messageFormat: "IFlecsStruct is not supported on type '{0}' because it is not accessible from generated code",
        category: "Flecs.NET.Reflection",
        defaultSeverity: DiagnosticSeverity.Warning,
        isEnabledByDefault: true);

    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } = ImmutableArray.Create(
        OpenGenericTypeRule, FileScopedTypeRule, ManagedTypeRule, NoMembersRule, InaccessibleTypeRule);

    public override void Initialize(AnalysisContext context)
    {
        context.EnableConcurrentExecution();
        context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

        context.RegisterCompilationStartAction(static startContext =>
        {
            if (startContext.Compilation.GetTypeByMetadataName(StructReflectionRules.InterfaceFullyQualifiedName) is not { } iface)
                return;

            startContext.RegisterSymbolAction(symbolContext => AnalyzeNamedType(symbolContext, iface), SymbolKind.NamedType);
        });
    }

    private static void AnalyzeNamedType(SymbolAnalysisContext context, INamedTypeSymbol iface)
    {
        if (context.Symbol is not INamedTypeSymbol { TypeKind: TypeKind.Struct } symbol)
            return;

        ReflectionResult result = StructReflectionRules.Analyze(symbol, iface);
        if (result.Problem is ReflectionProblem.None or ReflectionProblem.NotApplicable)
            return;

        DiagnosticDescriptor descriptor = result.Problem switch
        {
            ReflectionProblem.FileScoped => FileScopedTypeRule,
            ReflectionProblem.OpenGeneric => OpenGenericTypeRule,
            ReflectionProblem.Inaccessible => InaccessibleTypeRule,
            ReflectionProblem.Managed => ManagedTypeRule,
            _ => NoMembersRule
        };

        // A symbol action runs once per symbol, so a partial type is reported once, at its first declaration.
        Location? location = result.Member is { } member
            ? symbol.GetMembers(member).FirstOrDefault()?.Locations.FirstOrDefault() ?? symbol.Locations.FirstOrDefault()
            : symbol.Locations.FirstOrDefault();

        object[] args = result.Problem == ReflectionProblem.Managed
            ? new object[] { result.TypeName, result.Member! }
            : new object[] { result.TypeName };

        context.ReportDiagnostic(Diagnostic.Create(descriptor, location, args));
    }
}
