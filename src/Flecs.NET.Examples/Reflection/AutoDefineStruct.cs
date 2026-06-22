using Flecs.NET.Core;
using Flecs.NET.Examples.Reflection.AutoDefineStruct;

// Components
namespace Flecs.NET.Examples.Reflection.AutoDefineStruct
{
    internal record struct Position(float X, float Y) : IFlecsStruct;
}

public static class Reflection_AutoDefineStruct
{
    public static void Main()
    {
        using World world = World.Create();

        // Register component - members are reflected automatically via IFlecsStruct.
        world.Component<Position>();

        // Create entity with Position as usual.
        Entity e = world.Entity()
            .Set(new Position(10, 20));

        // Convert position component to flecs expression string.
        ref Position reference = ref e.Ensure<Position>();
        Console.WriteLine(world.ToExpr(ref reference)); // {X: 10, Y: 20}
    }
}

// Output:
// {X: 10, Y: 20}
