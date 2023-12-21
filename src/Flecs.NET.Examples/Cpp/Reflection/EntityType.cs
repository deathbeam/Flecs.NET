#if Cpp_Reflection_EntityType

using Flecs.NET.Core;

{
    using World world = World.Create();

    world.Component<TypeWithEntity>()
        .Member(Ecs.Entity, "Entity");

    Entity foo = world.Entity("Foo");

    // Create entity with TypeWithEntity component.
    Entity e = world.Entity()
        .Set<TypeWithEntity>(new(foo));

    // Convert TypeWithEntity component to flecs expression string.
    ref TypeWithEntity reference = ref e.GetMut<TypeWithEntity>();
    Console.WriteLine(world.ToExpr(ref reference)); // {Entity: Foo}

    return 0;
}

public struct TypeWithEntity(ulong entity)
{
    public ulong Entity { get; set; } = entity; // Only naked entity ids are supported at the moment.
}

#endif

// Output:
// {Entity: Foo}
