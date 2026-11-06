using System.Runtime.CompilerServices;

namespace Flecs.NET.Utilities;

/// <summary>
///     Helper macros for working with flecs.
/// </summary>
internal static unsafe class Utils
{
    /// <summary>
    ///     Checks if specific bit is set.
    /// </summary>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsBitSet(int value, int index)
    {
        return (value & (1 << index)) != 0;
    }

    /// <summary>
    ///     Checks if specific bit is set.
    /// </summary>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsBitSet(uint value, int index)
    {
        return (value & (1 << index)) != 0;
    }

    /// <summary>
    ///     Gets the next power of 2 for the provided number.
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int NextPowOf2(int num)
    {
        num--;
        num |= num >> 1;
        num |= num >> 2;
        num |= num >> 4;
        num |= num >> 8;
        num |= num >> 16;
        num++;

        return num;
    }
}
