using System;
using Flecs.NET.Utilities;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     A wrapper around <see cref="ecs_type_info_t"/>*.
/// </summary>
/// <remarks>
///     <see cref="World.TypeInfo(ulong)"/> returns an invalid instance when the id is not a component. The members
///     dereference the handle, so check <see cref="IsValid"/> first.
/// </remarks>
public readonly unsafe struct TypeInfo : IEquatable<TypeInfo>
{
    private readonly ecs_type_info_t* _handle;

    /// <summary>
    ///     The pointer to the <see cref="ecs_type_info_t"/> object.
    /// </summary>
    public ref readonly ecs_type_info_t* Handle => ref _handle;

    /// <summary>
    ///     Creates a new <see cref="TypeInfo"/> instance with the provided <see cref="ecs_type_info_t"/> pointer.
    /// </summary>
    /// <param name="handle">The handle.</param>
    public TypeInfo(ecs_type_info_t* handle)
    {
        _handle = handle;
    }

    /// <summary>
    ///     Returns true if the type info has a handle.
    /// </summary>
    public bool IsValid => _handle != null;

    /// <summary>
    ///     Size of type.
    /// </summary>
    public int Size => Handle->size;

    /// <summary>
    ///     Alignment of type.
    /// </summary>
    public int Alignment => Handle->alignment;

    /// <summary>
    ///     Handle to component.
    /// </summary>
    public ulong Component => Handle->component;

    /// <summary>
    ///     Type name.
    /// </summary>
    public string Name => NativeString.GetString(Handle->name);

    /// <summary>
    ///     Checks if two <see cref="TypeInfo"/> instances are equal.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public bool Equals(TypeInfo other)
    {
        return Handle == other.Handle;
    }

    /// <summary>
    ///     Checks if two <see cref="TypeInfo"/> instances are equal.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        return obj is TypeInfo other && Equals(other);
    }

    /// <summary>
    ///     Returns the hash code of the <see cref="TypeInfo"/>.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return _handle == null ? 0 : Handle->GetHashCode();
    }

    /// <summary>
    ///     Checks if two <see cref="TypeInfo"/> instances are equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator ==(TypeInfo left, TypeInfo right)
    {
        return left.Equals(right);
    }

    /// <summary>
    ///     Checks if two <see cref="TypeInfo"/> instances are not equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator !=(TypeInfo left, TypeInfo right)
    {
        return !(left == right);
    }
}