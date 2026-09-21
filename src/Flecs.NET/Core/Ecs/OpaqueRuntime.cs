using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Flecs.NET.Utilities;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

public static unsafe partial class Ecs
{
    /// <summary>
    ///     Creates the string type used by the mirror structs of managed opaque types.
    ///     Unlike the registered <see cref="string"/> component (whose values live behind
    ///     handles in component storage), string fields sit inline in boxed structs, so these
    ///     callbacks access values through the raw pointer without dereferencing a handle.
    ///     Called by <see cref="OpaqueBuilder{TComponent,TElement}.RawString"/>.
    /// </summary>
    internal static ulong RawString(ecs_world_t* world)
    {
        ecs_entity_desc_t entityDesc = default;
        ulong entity = ecs_entity_init(world, &entityDesc);
        Ecs.Assert(entity != 0, nameof(ECS_INTERNAL_ERROR));

        ecs_component_desc_t componentDesc = default;
        componentDesc.entity = entity;
        componentDesc.type.size = sizeof(nint);
        componentDesc.type.alignment = sizeof(nint);
        Ecs.Assert(ecs_component_init(world, &componentDesc) != 0, nameof(ECS_INTERNAL_ERROR));

        ecs_opaque_desc_t opaqueDesc = default;
        opaqueDesc.entity = entity;
        opaqueDesc.type.as_type = Ecs.String;
        opaqueDesc.type.serialize = &SerializeRawString;
        opaqueDesc.type.assign_string = &AssignRawString;
        Ecs.Assert(ecs_opaque_init(world, &opaqueDesc) != 0, nameof(ECS_INTERNAL_ERROR));

        return entity;
    }

    /// <summary>
    ///     Creates an anonymous runtime struct type from member name/type pairs. Used as the
    ///     <c>as_type</c> of managed opaque types: the member types describe how the cursor
    ///     assigns values, while offsets are unused (member pointers come from
    ///     <c>ensure_member</c> instead). Called by
    ///     <see cref="OpaqueBuilder{TComponent,TElement}.MirrorStruct"/>.
    /// </summary>
    internal static ulong MirrorStruct(ecs_world_t* world, params (string Name, ulong Type)[] members)
    {
        Ecs.Assert(members.Length > 0, "Mirror struct requires at least one member.");

        ecs_entity_desc_t entityDesc = default;
        ulong entity = ecs_entity_init(world, &entityDesc);
        Ecs.Assert(entity != 0, nameof(ECS_INTERNAL_ERROR));

        UntypedComponent component = new UntypedComponent(world, entity);
        component.Add<EcsStruct>();

        foreach ((string name, ulong type) in members)
            component.Member(type, name);

        return entity;
    }

    [UnmanagedCallersOnly]
    private static int SerializeRawString(ecs_serializer_t* serializer, void* ptr)
    {
        Serializer ser = new(serializer);
        return ser.Value(Unsafe.AsRef<string>(ptr));
    }

    [UnmanagedCallersOnly]
    private static void AssignRawString(void* ptr, byte* value)
    {
        Unsafe.AsRef<string>(ptr) = NativeString.GetString(value);
    }
}
