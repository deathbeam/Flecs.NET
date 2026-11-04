using System;
using System.Runtime.CompilerServices;
using Flecs.NET.Utilities;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     A wrapper around a field.
/// </summary>
/// <typeparam name="T">The field type.</typeparam>
public readonly unsafe struct Field<T> : IEquatable<Field<T>>
{
    /// <summary>
    ///     The field pointer.
    /// </summary>
    internal readonly void* Data;

    /// <summary>
    ///     The number of elements in the field.
    /// </summary>
    public readonly int Length;

    /// <summary>
    ///     Initializes a field with the provided pointer and length.
    /// </summary>
    /// <param name="data">The field pointer.</param>
    /// <param name="length">The number of elements in the field.</param>
    public Field(void* data, int length)
    {
        Data = data;
        Length = length;
    }

    /// <summary>
    ///     Whether the field is null.
    /// </summary>
    public bool IsNull => Data == null;

    /// <summary>
    ///     Gets a managed reference to the element at the specified index in the column.
    /// </summary>
    /// <param name="index">The element index.</param>
    public ref T this[int index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Ecs.Assert(index >= 0 && index < Length, nameof(ECS_COLUMN_INDEX_OUT_OF_RANGE));
            Ecs.Assert(Data != null, nameof(ECS_COLUMN_INDEX_OUT_OF_RANGE));
            return ref Managed.GetTypeRef<T>(Data, index);
        }
    }

    /// <summary>
    ///     Checks if two <see cref="Field{T}"/> instances are equal.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public bool Equals(Field<T> other)
    {
        return Data == other.Data;
    }

    /// <summary>
    ///     Checks if two <see cref="Field{T}"/> instances are equal.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        return obj is Field<T> field && Equals(field);
    }

    /// <summary>
    ///     Returns the hash code of the <see cref="Field{T}"/>.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return ((IntPtr)Data).GetHashCode();
    }

    /// <summary>
    ///     Checks if two <see cref="Field{T}"/> instances are equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator ==(Field<T> left, Field<T> right)
    {
        return left.Equals(right);
    }

    /// <summary>
    ///     Checks if two <see cref="Field{T}"/> instances are not equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator !=(Field<T> left, Field<T> right)
    {
        return !(left == right);
    }
}
