using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     Populates meta reflection for <see cref="IFlecsStruct"/> types from source-generated
///     registrars. No runtime reflection, so NativeAOT-safe.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static unsafe class StructReflection
{
    private static readonly ConcurrentDictionary<Type, object> Registry = new();

    /// <summary>
    ///     Registers the member-declaration delegate for <typeparamref name="T"/>. Called from
    ///     generated <c>[ModuleInitializer]</c> methods.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Register<T>(Action<Component<T>> registrar)
    {
        Registry[typeof(T)] = registrar;
    }

    /// <summary>
    ///     Adds <c>EcsStruct</c> and runs the registered delegate. Called from
    ///     <c>Type&lt;T&gt;.RegisterComponent</c>; no-op without a registration.
    /// </summary>
    internal static void Apply<T>(World world, Entity type)
    {
        if (!Registry.TryGetValue(typeof(T), out object? registered))
            return;

        Action<Component<T>> registrar = (Action<Component<T>>)registered;

        // Managed structs are boxed behind handles, so their members are unreachable
        // through native offsets. They register as opaque types instead; the generated
        // registrar provides the mirror struct, serialize, and member lookup callbacks.
        bool managed = RuntimeHelpers.IsReferenceOrContainsReferences<T>();

        if (managed ? type.Has<EcsOpaque>() : type.Has<EcsStruct>())
            return;

        ecs_suspend_readonly_state_t state = default;
        world = flecs_suspend_readonly(world, &state);

        try
        {
            UntypedComponent untyped = new UntypedComponent(type.World, type.Id);
            if (!managed)
                untyped.Add<EcsStruct>();
            registrar(new Component<T>(type.World, type.Id));
        }
        finally
        {
            flecs_resume_readonly(world, &state);
        }
    }
}
