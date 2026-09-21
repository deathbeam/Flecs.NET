using System.Diagnostics.CodeAnalysis;

namespace Flecs.NET.Core;

/// <summary>
///     Marker interface for structs whose public members should be reflected into flecs' meta
///     API automatically. Requires the Flecs.NET.Sourcegen analyzer; the type must not be
///     file-scoped. Enums are reflected automatically and need no marker.
/// </summary>
/// <remarks>
///     <para>
///         Unmanaged structs register as native structs with offset-based members.
///     </para>
///     <para>
///         Managed structs (containing references, e.g. a <see cref="string"/> field) are
///         stored behind a handle, so offset-based members cannot reach their fields. They are
///         automatically registered as opaque types instead: serialize and member lookup are
///         generated, and de/serialization through flecs' meta API (JSON, scripts, cursors)
///         works. Nested managed structs and property members are not mirrored.
///     </para>
/// </remarks>
[SuppressMessage("Design", "CA1040:Avoid empty interfaces",
    Justification = "Marker interface opted into by the Flecs.NET.Sourcegen analyzer.")]
public interface IFlecsStruct
{
}
