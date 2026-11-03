// Non-fragmenting Parent storage lets an instance resolve children from its prefab children, like slots.

using Flecs.NET.Core;
using static Flecs.NET.Bindings.flecs;

public static class Prefabs_Slots
{
    public static void Main()
    {
        using World world = World.Create();

        // Create a prefab hierarchy with non-fragmenting Parent storage.
        Entity spaceShip = world.Prefab("SpaceShip");
        Entity engine = world.Prefab(new EcsParent { value = spaceShip }, "Engine");
        Entity cockpit = world.Prefab(new EcsParent { value = spaceShip }, "Cockpit");
        Entity pilotSeat = world.Prefab(new EcsParent { value = cockpit }, "PilotSeat");

        // Create a prefab instance.
        Entity inst = world.Entity("MySpaceship").IsA(spaceShip);

        // Resolve instantiated children from their prefab children; nested children resolve from the instance parent.
        Entity instEngine = inst.Target(engine);
        Entity instCockpit = inst.Target(cockpit);
        Entity instSeat = instCockpit.Target(pilotSeat);

        Console.WriteLine("Instance Engine:  " + instEngine.Path());
        Console.WriteLine("Instance Cockpit: " + instCockpit.Path());
        Console.WriteLine("Instance Seat:    " + instSeat.Path());
    }
}

// Output:
// Instance Engine:  MySpaceship.Engine
// Instance Cockpit: MySpaceship.Cockpit
// Instance Seat:    MySpaceship.Cockpit.PilotSeat
