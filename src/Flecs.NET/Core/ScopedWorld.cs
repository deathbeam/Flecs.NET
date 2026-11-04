using System;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     Scoped world.
/// </summary>
public unsafe struct ScopedWorld : IDisposable, IEquatable<ScopedWorld>
{
    private ecs_world_t* _world;
    private ulong _prevScope;

    /// <summary>
    ///     A reference to the world.
    /// </summary>
    internal ref ecs_world_t* WorldPtr => ref _world;

    /// <summary>
    ///     Gets the world.
    /// </summary>
    /// <returns>The world.</returns>
    public World World()
    {
        return new World(_world);
    }

    /// <summary>
    ///     The previous scope entity.
    /// </summary>
    internal ulong PrevScope => _prevScope;

    /// <summary>
    ///     Creates a scoped world in the scope of an entity.
    /// </summary>
    /// <param name="world"></param>
    /// <param name="scope"></param>
    public ScopedWorld(ecs_world_t* world, ulong scope)
    {
        _prevScope = ecs_set_scope(world, scope);
        _world = world;
    }

    /// <summary>
    ///     Disposes the scoped world.
    /// </summary>
    public void Dispose()
    {
        ecs_set_scope(_world, _prevScope);
    }

    /// <summary>
    ///     Checks if two <see cref="ScopedWorld"/> instances are equal.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public bool Equals(ScopedWorld other)
    {
        return WorldPtr == other.WorldPtr && PrevScope == other.PrevScope;
    }

    /// <summary>
    ///     Checks if two <see cref="ScopedWorld"/> instances are equal.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        return obj is ScopedWorld other && Equals(other);
    }

    /// <summary>
    ///     Returns the hash code for the <see cref="ScopedWorld"/>.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return HashCode.Combine(_world->GetHashCode(), PrevScope.GetHashCode());
    }

    /// <summary>
    ///     Checks if two <see cref="ScopedWorld"/> instances are equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator ==(ScopedWorld left, ScopedWorld right)
    {
        return left.Equals(right);
    }

    /// <summary>
    ///     Checks if two <see cref="ScopedWorld"/> instances are not equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator !=(ScopedWorld left, ScopedWorld right)
    {
        return !(left == right);
    }
}