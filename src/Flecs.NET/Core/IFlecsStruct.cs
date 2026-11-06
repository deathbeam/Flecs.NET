using System.Diagnostics.CodeAnalysis;

namespace Flecs.NET.Core;

/// <summary>
///     Marker interface for structs whose members are reflected into flecs' meta API automatically.
///     The source generator that emits the registrars ships with the Flecs.NET package.
/// </summary>
public interface IFlecsStruct
{
}
