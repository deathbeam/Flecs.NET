namespace Flecs.NET.Core;

/// <summary>
///     Implemented by unmanaged value types that register their own opaque reflection, like
///     <see cref="FlecsString64"/> and <see cref="FlecsArray8{T}"/>. The registration runs once
///     per world, when the type is first registered as a component.
/// </summary>
internal interface IFlecsOpaqueType
{
    /// <summary>
    ///     Registers opaque type reflection for the type entity in the provided world.
    /// </summary>
    /// <param name="world">The world.</param>
    /// <param name="type">The type entity of the component.</param>
    void RegisterOpaque(World world, Entity type);
}
