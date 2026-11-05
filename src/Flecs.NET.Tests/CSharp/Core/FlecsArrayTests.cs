using System;
using System.Runtime.CompilerServices;
using Flecs.NET.Core;
using Xunit;

namespace Flecs.NET.Tests.CSharp.Core;

public class FlecsArrayTests
{
    [Fact]
    private void Sizes()
    {
        // Count header followed by the inline storage.
        Assert.Equal(4 + 4 * sizeof(int), Unsafe.SizeOf<FlecsArray4<int>>());
        Assert.Equal(4 + 8 * sizeof(int), Unsafe.SizeOf<FlecsArray8<int>>());
        Assert.Equal(4 + 64 * sizeof(int), Unsafe.SizeOf<FlecsArray64<int>>());
        Assert.Equal(4, FlecsArray4<int>.Capacity);
        Assert.Equal(64, FlecsArray64<int>.Capacity);
    }

    [Fact]
    private void AddAndIndex()
    {
        FlecsArray8<int> array = default;

        Assert.Equal(0, array.Count);

        array.Add(1);
        array.Add(2);

        Assert.Equal(2, array.Count);
        Assert.Equal(1, array[0]);
        Assert.Equal(2, array[1]);
        Assert.Equal(new[] { 1, 2 }, array.AsSpan().ToArray());

        array[0] = 10;
        Assert.Equal(10, array[0]);
    }

    [Fact]
    private void Overflow()
    {
        FlecsArray4<int> array = default;

        for (int i = 0; i < FlecsArray4<int>.Capacity; i++)
            array.Add(i);

        Assert.Equal(FlecsArray4<int>.Capacity, array.Count);
        Assert.Throws<InvalidOperationException>(() => array.Add(4));
        Assert.Equal(FlecsArray4<int>.Capacity, array.Count);
    }

    [Fact]
    private void IndexOutOfRange()
    {
        FlecsArray4<int> array = default;
        array.Add(1);

        Assert.Throws<ArgumentOutOfRangeException>(() => _ = array[1]);
        Assert.Throws<ArgumentOutOfRangeException>(() => _ = array[-1]);
        Assert.Throws<ArgumentOutOfRangeException>(() => array.RemoveAt(1));
    }

    [Fact]
    private void RemoveAt()
    {
        FlecsArray8<int> array = [1, 2, 3];

        array.RemoveAt(0);

        Assert.Equal(2, array.Count);
        Assert.Equal(new[] { 2, 3 }, array.AsSpan().ToArray());
    }

    [Fact]
    private void Clear()
    {
        FlecsArray8<int> array = [1, 2, 3];

        array.Clear();

        Assert.Equal(0, array.Count);
        Assert.True(array.AsSpan().IsEmpty);
    }

    [Fact]
    private void CollectionExpression()
    {
        FlecsArray16<int> array = [1, 2, 3];

        Assert.Equal(3, array.Count);
        Assert.Equal(new[] { 1, 2, 3 }, array.AsSpan().ToArray());
        Assert.Throws<InvalidOperationException>(() => _ = (FlecsArray4<int>)[1, 2, 3, 4, 5]);
    }

    [Fact]
    private void Enumeration()
    {
        FlecsArray8<int> array = [1, 2, 3];

        int sum = 0;
        foreach (int item in array)
            sum += item;

        Assert.Equal(6, sum);

        foreach (ref int item in array)
            item *= 2;

        Assert.Equal(new[] { 2, 4, 6 }, array.AsSpan().ToArray());
    }

    [Fact]
    private void EqualityAndHash()
    {
        FlecsArray8<int> a = [1, 2, 3];
        FlecsArray8<int> b = [1, 2, 3];
        FlecsArray8<int> c = [1, 2];

        Assert.Equal(a, b);
        Assert.True(a == b);
        Assert.False(a == c);
        Assert.True(a != c);
        Assert.Equal(a.GetHashCode(), b.GetHashCode());

        // Equality compares the stored elements, not the stale bytes past Count.
        FlecsArray8<int> cleared = [1, 2, 3];
        cleared.Clear();
        Assert.True(cleared == default(FlecsArray8<int>));
        Assert.True(cleared.GetHashCode() == default(FlecsArray8<int>).GetHashCode());
    }

    [Fact]
    private void CopyIsByValue()
    {
        FlecsArray8<int> a = [1, 2, 3];
        FlecsArray8<int> b = a;

        b.Add(4);
        b[0] = 10;

        Assert.Equal(3, a.Count);
        Assert.Equal(new[] { 1, 2, 3 }, a.AsSpan().ToArray());
        Assert.Equal(new[] { 10, 2, 3, 4 }, b.AsSpan().ToArray());
    }

    [Fact]
    private void StructElements()
    {
        FlecsArray4<FlecsString32> array = default;
        array.Add("hello");

        Assert.Equal("hello", array[0].ToString());
    }
}
