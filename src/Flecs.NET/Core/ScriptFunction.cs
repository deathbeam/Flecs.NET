using System.Diagnostics.CodeAnalysis;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     The context of a script function callback.
/// </summary>
[SuppressMessage("Performance", "CA1815", Justification = "A script function context is not compared.")]
public unsafe readonly struct ScriptFunction
{
    private readonly ecs_function_ctx_t _ctx;

    internal ScriptFunction(ecs_function_ctx_t ctx)
    {
        _ctx = ctx;
    }

    /// <summary>
    ///     Gets the world.
    /// </summary>
    /// <returns>The world.</returns>
    public World World()
    {
        return new World(_ctx.world);
    }

    /// <summary>
    ///     The function entity.
    /// </summary>
    public ulong Function => _ctx.function;

    /// <summary>
    ///     The "this" entity, for methods and async functions.
    /// </summary>
    public Entity Entity => new(_ctx.world, _ctx.entity);

    /// <summary>
    ///     The user context set with <see cref="FunctionBuilder.Ctx"/>.
    /// </summary>
    public void* Ctx => _ctx.ctx;
}
