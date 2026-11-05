using Flecs.NET.Codegen.Helpers;

namespace Flecs.NET.Codegen.Generators;

public class FlecsArray : GeneratorBase
{
    private static readonly (string Name, int Capacity)[] Capacities =
    [
        ("FlecsArray4", 4),
        ("FlecsArray8", 8),
        ("FlecsArray16", 16),
        ("FlecsArray32", 32),
        ("FlecsArray64", 64),
        ("FlecsArray128", 128),
        ("FlecsArray256", 256),
        ("FlecsArray512", 512)
    ];

    public override void Generate()
    {
        foreach ((string name, int capacity) in Capacities)
            AddSource($"{name}.g.cs", GenerateArray(name, capacity));

        AddSource("FlecsArrayBuilder.g.cs", GenerateBuilder());
    }

    private static string GenerateArray(string name, int capacity)
    {
        return $$"""
            #nullable enable

            using System;
            using System.Collections.Generic;
            using System.Diagnostics.CodeAnalysis;
            using System.Runtime.CompilerServices;
            using System.Runtime.InteropServices;

            namespace Flecs.NET.Core;

            /// <summary>
            ///     A blittable, fixed-capacity array that can be used as a field in an unmanaged component.
            ///     Values are copied by value, there is no ownership, no allocation and no hooks.
            /// </summary>
            /// <typeparam name="T">The element type.</typeparam>
            [CollectionBuilder(typeof(FlecsArrayBuilder), "Create{{capacity}}")]
            public struct {{name}}<T> : IEquatable<{{name}}<T>>, IFlecsOpaqueType where T : unmanaged
            {
                /// <summary>
                ///     The maximum number of elements the array can store.
                /// </summary>
                public const int Capacity = {{capacity}};

                private int _count;
                private Buffer _buffer;

                [InlineArray(Capacity)]
                private struct Buffer
                {
                    private T _element;
                }

                /// <summary>
                ///     The number of elements stored in the array.
                /// </summary>
                public readonly int Count => _count;

                /// <summary>
                ///     Returns the stored elements without allocating.
                /// </summary>
                /// <returns>A span over the stored elements.</returns>
                [UnscopedRef]
                public readonly Span<T> AsSpan()
                {
                    return MemoryMarshal.CreateSpan(ref Unsafe.AsRef(in _buffer[0]), _count);
                }

                /// <summary>
                ///     Returns a reference to the element at the provided index.
                /// </summary>
                /// <param name="index">The element index.</param>
                /// <exception cref="ArgumentOutOfRangeException">The index is out of range.</exception>
                public ref T this[int index]
                {
                    get
                    {
                        if ((uint)index >= (uint)_count)
                            throw new ArgumentOutOfRangeException(nameof(index));

                        return ref Unsafe.AsRef(in _buffer[index]);
                    }
                }

                /// <summary>
                ///     Adds an element to the array.
                /// </summary>
                /// <param name="item">The element to add.</param>
                /// <exception cref="InvalidOperationException">The array is full.</exception>
                public void Add(T item)
                {
                    if (_count == Capacity)
                        throw new InvalidOperationException("The fixed array is full.");

                    _buffer[_count++] = item;
                }

                /// <summary>
                ///     Removes the element at the provided index, shifting the remaining elements down.
                /// </summary>
                /// <param name="index">The element index.</param>
                /// <exception cref="ArgumentOutOfRangeException">The index is out of range.</exception>
                public void RemoveAt(int index)
                {
                    if ((uint)index >= (uint)_count)
                        throw new ArgumentOutOfRangeException(nameof(index));

                    AsSpan().Slice(index + 1).CopyTo(AsSpan().Slice(index));
                    _count--;
                }

                /// <summary>
                ///     Removes all elements from the array.
                /// </summary>
                public void Clear()
                {
                    _count = 0;
                }

                /// <summary>
                ///     Returns an enumerator that iterates through the array without allocating.
                /// </summary>
                /// <returns>The enumerator.</returns>
                public Span<T>.Enumerator GetEnumerator()
                {
                    return MemoryMarshal.CreateSpan(ref Unsafe.AsRef(in _buffer[0]), _count).GetEnumerator();
                }

                /// <summary>
                ///     Checks if two {{name}} instances are equal.
                /// </summary>
                /// <param name="other">The other instance.</param>
                /// <returns>True if the instances store the same elements.</returns>
                public readonly bool Equals({{name}}<T> other)
                {
                    if (_count != other._count)
                        return false;

                    for (int i = 0; i < _count; i++)
                    {
                        if (!EqualityComparer<T>.Default.Equals(_buffer[i], other._buffer[i]))
                            return false;
                    }

                    return true;
                }

                /// <summary>
                ///     Checks if this instance is equal to the provided object.
                /// </summary>
                /// <param name="obj">The object to compare with.</param>
                /// <returns>True if the object is a {{name}} with the same elements.</returns>
                public readonly override bool Equals(object? obj)
                {
                    return obj is {{name}}<T> other && Equals(other);
                }

                /// <summary>
                ///     Returns a content based hash code.
                /// </summary>
                /// <returns>The hash code.</returns>
                public readonly override int GetHashCode()
                {
                    HashCode hash = default;

                    for (int i = 0; i < _count; i++)
                        hash.Add(_buffer[i]);

                    return hash.ToHashCode();
                }

                /// <summary>
                ///     Checks if two {{name}} instances are equal.
                /// </summary>
                /// <param name="left">The left instance.</param>
                /// <param name="right">The right instance.</param>
                /// <returns>True if the instances store the same elements.</returns>
                public static bool operator ==({{name}}<T> left, {{name}}<T> right)
                {
                    return left.Equals(right);
                }

                /// <summary>
                ///     Checks if two {{name}} instances are not equal.
                /// </summary>
                /// <param name="left">The left instance.</param>
                /// <param name="right">The right instance.</param>
                /// <returns>True if the instances store different elements.</returns>
                public static bool operator !=({{name}}<T> left, {{name}}<T> right)
                {
                    return !left.Equals(right);
                }

                // Clamps instead of failing so deserializing a too large value keeps the first elements.
                private void Resize(nuint size)
                {
                    _count = size < Capacity ? (int)size : Capacity;
                }

                // Elements past the capacity are written to a scratch slot and dropped, keeping the first Capacity elements.
                private ref T EnsureElement(nuint index)
                {
                    if (index >= Capacity)
                        return ref Overflow.Value;

                    int i = (int)index;

                    if (i >= _count)
                        _count = i + 1;

                    return ref Unsafe.AsRef(in _buffer[i]);
                }

                // Native memory so the address handed to flecs never moves. Shared garbage, never read.
                private static unsafe class Overflow
                {
                    private static readonly T* Slot = (T*)NativeMemory.AllocZeroed((nuint)sizeof(T));
                    public static ref T Value => ref *Slot;
                }

                unsafe void IFlecsOpaqueType.RegisterOpaque(World world, Entity type)
                {
                    Ecs.OpaqueBuilder<{{name}}<T>, T> builder = new(world.Handle, type.Id);
                    builder
                        .Vector()
                        .Serialize(static (ref readonly Ecs.Serializer ser, in {{name}}<T> value) =>
                        {
                            foreach (ref readonly T element in value.AsSpan())
                                ser.Value(element);

                            return 0;
                        })
                        .Count(static (in {{name}}<T> value) => value.Count)
                        .Resize(static (ref {{name}}<T> value, nuint size) => value.Resize(size))
                        .EnsureElement(static (ref {{name}}<T> value, nuint index) => ref value.EnsureElement(index));
                    builder.Commit();
                }
            }
            """;
    }

    private static string GenerateBuilder()
    {
        string methods = string.Empty;

        foreach ((string name, int capacity) in Capacities)
        {
            methods += $$"""


                    /// <summary>
                    ///     Creates a {{name}} from the provided elements.
                    /// </summary>
                    /// <param name="items">The elements to copy.</param>
                    /// <typeparam name="T">The element type.</typeparam>
                    /// <returns>The created array.</returns>
                    /// <exception cref="InvalidOperationException">The provided elements do not fit in the array.</exception>
                    public static {{name}}<T> Create{{capacity}}<T>(ReadOnlySpan<T> items) where T : unmanaged
                    {
                        {{name}}<T> array = default;

                        foreach (T item in items)
                            array.Add(item);

                        return array;
                    }
                """;
        }

        return $$"""
            #nullable enable

            using System;

            namespace Flecs.NET.Core;

            /// <summary>
            ///     Creates fixed-capacity arrays from collection expressions.
            /// </summary>
            public static class FlecsArrayBuilder
            {{{methods}}
            }
            """;
    }
}
