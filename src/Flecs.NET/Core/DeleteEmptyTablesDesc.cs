using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     A wrapper around <see cref="ecs_delete_empty_tables_desc_t"/>.
/// </summary>
public unsafe record struct DeleteEmptyTablesDesc()
{
    /// <summary>
    ///     The underlying <see cref="ecs_delete_empty_tables_desc_t"/> instance.
    /// </summary>
    public ecs_delete_empty_tables_desc_t Descriptor;

    /// <summary>
    ///     Initializes a new instance of <see cref="DeleteEmptyTablesDesc"/> with the provided description.
    /// </summary>
    /// <param name="desc">The <see cref="ecs_delete_empty_tables_desc_t"/> instance to wrap.</param>
    public DeleteEmptyTablesDesc(ecs_delete_empty_tables_desc_t desc) : this()
    {
        Descriptor = desc;
    }

    /// <summary>
    ///     Free table data when generation > clear_generation.
    /// </summary>
    public ref ushort ClearGeneration => ref Descriptor.clear_generation;

    /// <summary>
    ///     Delete table when generation > delete_generation.
    /// </summary>
    public ref ushort DeleteGeneration => ref Descriptor.delete_generation;

    /// <summary>
    ///     Amount of time operation is allowed to spend.
    /// </summary>
    public ref double TimeBudgetSeconds => ref Descriptor.time_budget_seconds;

    /// <summary>
    ///     Implicitly converts an <see cref="ecs_delete_empty_tables_desc_t"/> instance to a <see cref="DeleteEmptyTablesDesc"/>.
    /// </summary>
    /// <param name="desc">The <see cref="ecs_delete_empty_tables_desc_t"/> instance to convert.</param>
    /// <returns>A new <see cref="DeleteEmptyTablesDesc"/> instance initialized with the given description.</returns>
    public static implicit operator DeleteEmptyTablesDesc(ecs_delete_empty_tables_desc_t desc)
    {
        return new DeleteEmptyTablesDesc(desc);
    }

    /// <summary>
    ///     Implicitly converts a <see cref="DeleteEmptyTablesDesc"/> instance to an <see cref="ecs_delete_empty_tables_desc_t"/>.
    /// </summary>
    /// <param name="desc">The <see cref="DeleteEmptyTablesDesc"/> instance to convert.</param>
    /// <returns>A new <see cref="ecs_delete_empty_tables_desc_t"/> instance initialized with the given description.</returns>
    public static implicit operator ecs_delete_empty_tables_desc_t(DeleteEmptyTablesDesc desc)
    {
        return desc.Descriptor;
    }
}
