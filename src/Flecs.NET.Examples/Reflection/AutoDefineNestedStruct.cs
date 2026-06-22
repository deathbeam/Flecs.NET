using Flecs.NET.Core;
using Flecs.NET.Examples.Reflection.AutoDefineNestedStruct;

// Components
namespace Flecs.NET.Examples.Reflection.AutoDefineNestedStruct
{
    internal record struct Point(int X, int Y) : IFlecsStruct;

    internal record struct Line(Point Start, Point Stop) : IFlecsStruct;
}

public static class Reflection_AutoDefineNestedStruct
{
    public static void Main()
    {
        using World world = World.Create();

        // Register component - Point is reflected transitively as a member type.
        world.Component<Line>();

        // Create entity with Line component as usual.
        Entity e = world.Entity()
            .Set(new Line(new Point(1, 2), new Point(3, 4)));

        // Convert Line component to flecs expression string.
        ref Line reference = ref e.Ensure<Line>();
        Console.WriteLine(world.ToExpr(ref reference));
        // {Start: {X: 1, Y: 2}, Stop: {X: 3, Y: 4}}
    }
}

// Output:
// {Start: {X: 1, Y: 2}, Stop: {X: 3, Y: 4}}
