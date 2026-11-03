// Just like how entities can be associated with a type (like components)
// prefabs can be associated with types as well. Types can be more convenient to
// work with than entity handles, for a few reasons:
//
// - There is no need to pass around or store entity handles
// - Prefabs automatically assume the name of the type
// - Nested types can be used to create prefab hierarchies
//
// While this functionality is not unique to prefabs (the same mechanism is
// used to distribute component handles), prefabs are a good fit, especially
// when combined with prefab hierarchies (see slots example and code below).

using Flecs.NET.Core;

// Create types that mirror the prefab hierarchy.
file struct Turret
{
    public struct Base;
    public struct Head;
}

file struct Railgun
{
    public struct Beam;
}

public static class Prefabs_TypedPrefabs
{
    public static void Main()
    {
        using World world = World.Create();

        // Associate types with prefabs
        world.Prefab<Turret>();
        world.Prefab<Turret.Base>();
        world.Prefab<Turret.Head>();

        world.Prefab<Railgun>().IsA<Turret>();
        world.Prefab<Railgun.Beam>();

        // Create prefab instance.
        Entity inst = world.Entity("MyRailgun").IsA<Railgun>();

        // Get instantiated children by name
        Entity instBase = inst.Lookup("Base");
        Entity instHead = inst.Lookup("Head");
        Entity instBeam = inst.Lookup("Beam");

        Console.WriteLine("Instance Base: " + instBase.Path());
        Console.WriteLine("Instance Head: " + instHead.Path());
        Console.WriteLine("Instance Beam: " + instBeam.Path());
    }
}

// Output:
// Instance Base: MyRailgun.Base
// Instance Head: MyRailgun.Head
// Instance Beam: MyRailgun.Beam
