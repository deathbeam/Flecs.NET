namespace Flecs.NET.Core;

/// <summary>
///     Interface for <see cref="IterIterable"/> types.
/// </summary>
public interface IIterIterable
{
    /// <summary>
    ///     The underlying <see cref="IterIterable"/> instance.
    /// </summary>
    public ref readonly IterIterable Underlying { get; }

    /// <summary>
    ///     The iterable type.
    /// </summary>
    public IterableType IterableType { get; }
}
