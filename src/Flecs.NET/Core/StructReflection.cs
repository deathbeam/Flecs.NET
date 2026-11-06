using System;
using System.ComponentModel;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     Populates meta reflection for <see cref="IFlecsStruct"/> types from source-generated
///     registrars. No runtime reflection, so NativeAOT-safe.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static unsafe class StructReflection<T>
{
    private static Action<UntypedComponent>? _registrar;

    /// <summary>
    ///     Stores the member-declaration delegate for <typeparamref name="T"/>. Called from
    ///     generated <c>[ModuleInitializer]</c> methods.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Register(Action<UntypedComponent> registrar)
    {
        _registrar = registrar;
    }

    /// <summary>
    ///     Adds <c>EcsStruct</c> and runs the registered delegate. Called from
    ///     <c>Type&lt;T&gt;.RegisterComponent</c>; no-op without a registration.
    /// </summary>
    internal static void Apply(World world, Entity type)
    {
        if (_registrar is null || type.Has<EcsStruct>())
            return;

        ecs_suspend_readonly_state_t state = default;
        world = flecs_suspend_readonly(world, &state);

        try
        {
            UntypedComponent component = new UntypedComponent(type.WorldPtr, type.Id);
            component.Add<EcsStruct>();
            _registrar(component);
        }
        finally
        {
            flecs_resume_readonly(world, &state);
        }
    }
}
