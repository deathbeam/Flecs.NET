namespace Flecs.NET.Core;

/// <summary>
///     Interface for <see cref="PageIterable"/> types.
/// </summary>
public interface IPageIterable
{
    /// <summary>
    ///     The underlying <see cref="PageIterable"/> instance.
    /// </summary>
    public ref readonly PageIterable Underlying { get; }

    /// <summary>
    ///     The number of entities to skip.
    /// </summary>
    public int Offset { get; }

    /// <summary>
    ///     The max number of entities to return.
    /// </summary>
    public int Limit { get; }
}
