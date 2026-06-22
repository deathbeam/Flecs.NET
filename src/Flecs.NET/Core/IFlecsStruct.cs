using System.Diagnostics.CodeAnalysis;

namespace Flecs.NET.Core;

/// <summary>
///     Marker interface for structs whose public members should be reflected into flecs' meta
///     API automatically. Requires the Flecs.NET.Sourcegen analyzer; the type must not be
///     file-scoped. Enums are reflected automatically and need no marker.
/// </summary>
[SuppressMessage("Design", "CA1040:Avoid empty interfaces",
    Justification = "Marker interface opted into by the Flecs.NET.Sourcegen analyzer.")]
public interface IFlecsStruct
{
}
