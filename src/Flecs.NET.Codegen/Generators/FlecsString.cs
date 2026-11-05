using Flecs.NET.Codegen.Helpers;

namespace Flecs.NET.Codegen.Generators;

public class FlecsString : GeneratorBase
{
    private static readonly (string Name, int Size)[] Sizes =
    [
        ("FlecsString32", 32),
        ("FlecsString64", 64),
        ("FlecsString128", 128),
        ("FlecsString256", 256),
        ("FlecsString512", 512)
    ];

    public override void Generate()
    {
        foreach ((string name, int size) in Sizes)
        {
            AddSource($"{name}.g.cs", $$"""
                #nullable enable

                using System;
                using System.Diagnostics.CodeAnalysis;
                using System.Runtime.CompilerServices;
                using System.Runtime.InteropServices;
                using System.Text;

                namespace Flecs.NET.Core;

                /// <summary>
                ///     A blittable, fixed-capacity UTF-8 string that can be used as a field in an unmanaged component.
                ///     The total size of the struct is {{size}} bytes: a 2 byte length header followed by the UTF-8 bytes.
                ///     Values are copied by value, there is no ownership, no allocation and no hooks.
                /// </summary>
                public struct {{name}} : IEquatable<{{name}}>, IFlecsOpaqueType
                {
                    /// <summary>
                    ///     The maximum number of UTF-8 bytes this string can store.
                    /// </summary>
                    public const int Capacity = {{size - 2}};

                    private ushort _length;
                    private Buffer _buffer;

                    [InlineArray(Capacity)]
                    private struct Buffer
                    {
                        private byte _element;
                    }

                    /// <summary>
                    ///     Creates a string from the provided value. The value is truncated on a UTF-8 code point
                    ///     boundary when it does not fit. A null value results in an empty string.
                    /// </summary>
                    /// <param name="value">The value to copy.</param>
                    public {{name}}(string? value)
                    {
                        this = default;
                        TryCopyFrom(value.AsSpan());
                    }

                    /// <summary>
                    ///     The number of UTF-8 bytes stored in the string.
                    /// </summary>
                    public readonly int Length => _length;

                    /// <summary>
                    ///     Returns the stored UTF-8 bytes without allocating.
                    /// </summary>
                    /// <returns>A span over the stored UTF-8 bytes.</returns>
                    [UnscopedRef]
                    public readonly ReadOnlySpan<byte> AsSpan()
                    {
                        return MemoryMarshal.CreateReadOnlySpan(ref Unsafe.AsRef(in _buffer[0]), _length);
                    }

                    /// <summary>
                    ///     Copies the provided UTF-8 bytes into the string. Returns false and stores a truncated value
                    ///     on a UTF-8 code point boundary when the value does not fit.
                    /// </summary>
                    /// <param name="value">The UTF-8 bytes to copy.</param>
                    /// <returns>True if the value was copied without truncation.</returns>
                    internal bool TryCopyFrom(ReadOnlySpan<byte> value)
                    {
                        Span<byte> buffer = MemoryMarshal.CreateSpan(ref _buffer[0], Capacity);

                        if (value.Length <= Capacity)
                        {
                            value.CopyTo(buffer);
                            _length = (ushort)value.Length;
                            return true;
                        }

                        // Walk back over continuation bytes so a multi-byte sequence is never split.
                        int length = Capacity;
                        while (length > 0 && (value[length] & 0xC0) == 0x80)
                            length--;

                        value[..length].CopyTo(buffer);
                        _length = (ushort)length;
                        return false;
                    }

                    /// <summary>
                    ///     Encodes the provided characters as UTF-8 and copies them into the string. Returns false and
                    ///     stores a truncated value on a code point boundary when the value does not fit.
                    /// </summary>
                    /// <param name="value">The characters to copy.</param>
                    /// <returns>True if the value was copied without truncation.</returns>
                    internal bool TryCopyFrom(ReadOnlySpan<char> value)
                    {
                        Span<byte> buffer = MemoryMarshal.CreateSpan(ref _buffer[0], Capacity);

                        if (Encoding.UTF8.GetByteCount(value) <= Capacity)
                        {
                            _length = (ushort)Encoding.UTF8.GetBytes(value, buffer);
                            return true;
                        }

                        // Convert stops on a code point boundary, so the stored value never splits a sequence.
                        Encoding.UTF8.GetEncoder().Convert(value, buffer, true, out _, out int bytesUsed, out _);
                        _length = (ushort)bytesUsed;
                        return false;
                    }

                    /// <summary>
                    ///     Returns the stored UTF-8 bytes decoded as a string.
                    /// </summary>
                    /// <returns>The decoded string.</returns>
                    public readonly override string ToString()
                    {
                        return Encoding.UTF8.GetString(AsSpan());
                    }

                    /// <summary>
                    ///     Checks if two {{name}} instances are equal.
                    /// </summary>
                    /// <param name="other">The other instance.</param>
                    /// <returns>True if the instances store the same UTF-8 bytes.</returns>
                    public readonly bool Equals({{name}} other)
                    {
                        return AsSpan().SequenceEqual(other.AsSpan());
                    }

                    /// <summary>
                    ///     Checks if this instance is equal to the provided object.
                    /// </summary>
                    /// <param name="obj">The object to compare with.</param>
                    /// <returns>True if the object is a {{name}} with the same UTF-8 bytes.</returns>
                    public readonly override bool Equals(object? obj)
                    {
                        return obj is {{name}} other && Equals(other);
                    }

                    /// <summary>
                    ///     Returns a content based hash code.
                    /// </summary>
                    /// <returns>The hash code.</returns>
                    public readonly override int GetHashCode()
                    {
                        HashCode hash = default;
                        hash.AddBytes(AsSpan());
                        return hash.ToHashCode();
                    }

                    /// <summary>
                    ///     Checks if two {{name}} instances are equal.
                    /// </summary>
                    /// <param name="left">The left instance.</param>
                    /// <param name="right">The right instance.</param>
                    /// <returns>True if the instances store the same UTF-8 bytes.</returns>
                    public static bool operator ==({{name}} left, {{name}} right)
                    {
                        return left.Equals(right);
                    }

                    /// <summary>
                    ///     Checks if two {{name}} instances are not equal.
                    /// </summary>
                    /// <param name="left">The left instance.</param>
                    /// <param name="right">The right instance.</param>
                    /// <returns>True if the instances store different UTF-8 bytes.</returns>
                    public static bool operator !=({{name}} left, {{name}} right)
                    {
                        return !left.Equals(right);
                    }

                    /// <summary>
                    ///     Converts a string to a {{name}}. The value is truncated on a UTF-8 code point boundary
                    ///     when it does not fit. A null value results in an empty string.
                    /// </summary>
                    /// <param name="value">The value to copy.</param>
                    /// <returns>The converted string.</returns>
                    public static implicit operator {{name}}(string? value)
                    {
                        {{name}} result = default;
                        result.TryCopyFrom(value.AsSpan());
                        return result;
                    }

                    unsafe void IFlecsOpaqueType.RegisterOpaque(World world, Entity type)
                    {
                        Ecs.OpaqueBuilder<{{name}}, byte> builder = new(world.Handle, type.Id);
                        builder
                            .String()
                            .Serialize(static (ref readonly Ecs.Serializer ser, in {{name}} value) => ser.ValueUtf8(value.AsSpan()))
                            .AssignString(static (ref {{name}} value, string str) => value.TryCopyFrom(str))
                            .AssignNull(static (ref {{name}} value) => value = default);
                        builder.Commit();
                    }
                }
                """);
        }
    }
}
