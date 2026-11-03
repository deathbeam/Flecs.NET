using Flecs.NET.Core;
using Xunit;

namespace Flecs.NET.Tests.Cpp;

[Collection("Addons")]
public unsafe class BuilderOwnershipTests
{
    // The pipeline query owns the builder contexts after Build(), so disposing the builder must not free them twice.
    [Fact]
    public void PipelineBuilderDisposeAfterBuild()
    {
        using World world = World.Create();

        PipelineBuilder builder = world.Pipeline().With(Ecs.System);
        Pipeline pipeline = builder.Build();
        builder.Dispose();

        Assert.True(pipeline != 0);
    }

    // The expression string is owned by the first query, so reusing the builder would read freed memory.
    [Fact]
    public void QueryBuilderReuseWithExprThrows()
    {
        using World world = World.Create();
        world.Component<Position>();

        QueryBuilder builder = world.QueryBuilder().Expr("Position");
        using Query q = builder.Build();

        Assert.Throws<Ecs.AssertionException>(() => builder.Build());
    }

    // Alerts are a flecs module, so ecs_alert_init() requires an explicit import.
    [Fact]
    public void AlertBuilderDisposeAfterBuild()
    {
        using World world = World.Create();
        world.Import<Ecs.Alerts>();

        AlertBuilder builder = world.AlertBuilder<Position>();
        Alert alert = builder.Build();
        builder.Dispose();

        Assert.True((ulong)alert != 0);
    }
}
