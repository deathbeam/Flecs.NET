using System;
using System.Runtime.CompilerServices;
using Flecs.NET.Utilities;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     A wrapper around a field that was matched through component inheritance.
/// </summary>
/// <remarks>
///     Same interface as <see cref="Field{T}"/>, but uses a runtime stride so it can iterate a field whose stored
///     (derived) component is larger than <typeparamref name="T"/>.
/// </remarks>
/// <typeparam name="T">The base component type of the field.</typeparam>
public readonly unsafe struct BaseField<T> : IEquatable<BaseField<T>>
{
    /// <summary>
    ///     The field pointer.
    /// </summary>
    public readonly void* Data;

    /// <summary>
    ///     The stride between elements in the field.
    /// </summary>
    public readonly int Stride;

    /// <summary>
    ///     The number of elements in the field.
    /// </summary>
    public readonly int Length;

    /// <summary>
    ///     Initializes a base field with the provided pointer, stride, and length.
    /// </summary>
    /// <param name="data">The field pointer.</param>
    /// <param name="stride">The stride between elements in the field.</param>
    /// <param name="length">The number of elements in the field.</param>
    public BaseField(void* data, int stride, int length)
    {
        Data = data;
        Stride = stride;
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
            return ref Managed.GetTypeRef<T>((byte*)Data + index * Stride);
        }
    }

    /// <summary>
    ///     Checks if two <see cref="BaseField{T}"/> instances are equal.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public bool Equals(BaseField<T> other)
    {
        return Data == other.Data;
    }

    /// <summary>
    ///     Checks if two <see cref="BaseField{T}"/> instances are equal.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        return obj is BaseField<T> field && Equals(field);
    }

    /// <summary>
    ///     Returns the hash code of the <see cref="BaseField{T}"/>.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return ((IntPtr)Data).GetHashCode();
    }

    /// <summary>
    ///     Checks if two <see cref="BaseField{T}"/> instances are equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator ==(BaseField<T> left, BaseField<T> right)
    {
        return left.Equals(right);
    }

    /// <summary>
    ///     Checks if two <see cref="BaseField{T}"/> instances are not equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator !=(BaseField<T> left, BaseField<T> right)
    {
        return !(left == right);
    }
}
