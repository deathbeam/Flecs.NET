using System;

namespace Flecs.NET.Core;

/// <summary>
///     Marks a struct whose members are reflected into flecs' meta API automatically.
///     The source generator that emits the registrars ships with the Flecs.NET package.
/// </summary>
[AttributeUsage(AttributeTargets.Struct, Inherited = false)]
public sealed class FlecsStructAttribute : Attribute
{
}
