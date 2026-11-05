using System;
using System.Runtime.CompilerServices;
using System.Text;
using Flecs.NET.Core;
using Xunit;

namespace Flecs.NET.Tests.CSharp.Core;

public class FlecsStringTests
{
    [Fact]
    private void Sizes()
    {
        Assert.Equal(32, Unsafe.SizeOf<FlecsString32>());
        Assert.Equal(64, Unsafe.SizeOf<FlecsString64>());
        Assert.Equal(128, Unsafe.SizeOf<FlecsString128>());
        Assert.Equal(256, Unsafe.SizeOf<FlecsString256>());
        Assert.Equal(512, Unsafe.SizeOf<FlecsString512>());

        Assert.Equal(30, FlecsString32.Capacity);
        Assert.Equal(62, FlecsString64.Capacity);
        Assert.Equal(126, FlecsString128.Capacity);
        Assert.Equal(254, FlecsString256.Capacity);
        Assert.Equal(510, FlecsString512.Capacity);
    }

    [Fact]
    private void Ascii()
    {
        FlecsString64 str = "hello";

        Assert.Equal(5, str.Length);
        Assert.Equal(5, str.AsSpan().Length);
        Assert.Equal("hello", str.ToString());
        Assert.Equal("hello"u8.ToArray(), str.AsSpan().ToArray());
    }

    [Fact]
    private void NullAndEmpty()
    {
        FlecsString64 fromNull = null;
        Assert.Equal(0, fromNull.AsSpan().Length);
        Assert.Equal(0, fromNull.Length);
        Assert.Equal(string.Empty, fromNull.ToString());

        FlecsString64 fromEmpty = string.Empty;
        Assert.Equal(0, fromEmpty.Length);

        FlecsString64 defaulted = default;
        Assert.Equal(0, defaulted.Length);
        Assert.Equal(fromNull, defaulted);
    }

    [Fact]
    private void MultiByte()
    {
        FlecsString64 str = "héllo 🌍";

        Assert.Equal(Encoding.UTF8.GetByteCount("héllo 🌍"), str.Length);
        Assert.Equal("héllo 🌍", str.ToString());
    }

    [Fact]
    private void TruncatesOnCodePointBoundary()
    {
        // 28 ascii bytes followed by a 4 byte code point, 32 bytes do not fit in 30 bytes.
        FlecsString32 str = new string('a', 28) + "🌍";

        Assert.Equal(28, str.Length);
        Assert.Equal(new string('a', 28), str.ToString());

        // 29 ascii bytes followed by a 4 byte code point, the code point is split at byte 30.
        FlecsString32 split = new string('a', 29) + "🌍";

        Assert.Equal(29, split.Length);
        Assert.Equal(new string('a', 29), split.ToString());
    }

    [Fact]
    private void ExactFitIsNotTruncated()
    {
        // 28 ascii bytes followed by a 2 byte code point is exactly 30 bytes.
        FlecsString32 str = new string('a', 28) + "é";

        Assert.Equal(30, str.Length);
        Assert.Equal(new string('a', 28) + "é", str.ToString());
    }

    [Fact]
    private void TryCopyFromChars()
    {
        FlecsString32 str = default;

        Assert.True(str.TryCopyFrom("hello"));
        Assert.Equal("hello", str.ToString());

        Assert.False(str.TryCopyFrom(new string('a', 29) + "🌍"));
        Assert.Equal(29, str.Length);
        Assert.Equal(new string('a', 29), str.ToString());
    }

    [Fact]
    private void TryCopyFromBytes()
    {
        FlecsString32 str = default;

        Assert.True(str.TryCopyFrom("hello"u8));
        Assert.Equal("hello", str.ToString());

        // 29 ascii bytes and a truncated 4 byte code point.
        byte[] bytes = [.. "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"u8, 0xF0, 0x9F, 0x8C];
        Assert.False(str.TryCopyFrom(bytes));
        Assert.Equal(29, str.Length);
        Assert.Equal(new string('a', 29), str.ToString());
    }

    [Fact]
    private void EqualityAndHash()
    {
        FlecsString64 a = "hello";
        FlecsString64 b = "hello";
        FlecsString64 c = "world";

        Assert.Equal(a, b);
        Assert.True(a == b);
        Assert.False(a == c);
        Assert.True(a != c);
        Assert.Equal(a.GetHashCode(), b.GetHashCode());
        Assert.NotEqual(a.GetHashCode(), c.GetHashCode());
    }

    [Fact]
    private void CopyIsByValue()
    {
        FlecsString64 a = "hello";
        FlecsString64 b = a;

        Assert.Equal(a, b);

        b.TryCopyFrom("world");

        Assert.Equal("hello", a.ToString());
        Assert.Equal("world", b.ToString());
    }
}
