using Flecs.NET.Codegen.Helpers;
using Flecs.NET.Codegen.Generators;
using Microsoft.CodeAnalysis;

namespace Flecs.NET.Codegen;

[Generator]
public class FlecsGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        context.RegisterPostInitializationOutput(static context =>
        {
            Generate<Alert>(context);
            Generate<AlertBuilder>(context);
            Generate<Component>(context);
            Generate<BindingContext>(context);
            Generate<Ecs>(context);
            Generate<Entity>(context);
            Generate<IIterable>(context);
            Generate<Invoker>(context);
            Generate<IterIterable>(context);
            Generate<Observer>(context);
            Generate<ObserverBuilder>(context);
            Generate<PageIterable>(context);
            Generate<Pipeline>(context);
            Generate<PipelineBuilder>(context);
            Generate<Query>(context);
            Generate<QueryBuilder>(context);
            Generate<System_>(context);
            Generate<SystemBuilder>(context);
            Generate<TimerEntity>(context);
            Generate<TypeHelper>(context);
            Generate<UntypedComponent>(context);
            Generate<WorkerIterable>(context);
            Generate<World>(context);
        });
    }

    private static void Generate<T>(IncrementalGeneratorPostInitializationContext context) where T : GeneratorBase, new()
    {
        new T().Generate(context);
    }
}
