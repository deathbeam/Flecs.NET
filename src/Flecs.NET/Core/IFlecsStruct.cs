using System.Diagnostics.CodeAnalysis;

namespace Flecs.NET.Core;

/// <summary>
///     Marker interface for structs whose public members should be reflected into flecs' meta
///     API automatically. Requires the Flecs.NET.Sourcegen analyzer; the type must not be
///     file-scoped. Enums are reflected automatically and need no marker.
/// </summary>
/// <remarks>
///     Native offsets require unmanaged structs and unmanaged reflected members.
///     Unsupported types (including managed structs or managed properties) emit FLECSREFL003.
///     Register an opaque type explicitly with <see cref="Component{TComponent}.Opaque"/>
///     if needed; its member/element callbacks must not return references into movable managed storage.
/// </remarks>
[SuppressMessage("Design", "CA1040:Avoid empty interfaces",
    Justification = "Marker interface opted into by the Flecs.NET.Sourcegen analyzer.")]
public interface IFlecsStruct
{
}
