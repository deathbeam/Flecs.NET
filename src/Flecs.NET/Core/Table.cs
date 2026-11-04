using System;
using Flecs.NET.Utilities;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     A table is where entities and components are stored.
/// </summary>
public readonly unsafe partial struct Table : IEquatable<Table>
{
    /// <summary>
    ///     The world pointer.
    /// </summary>
    internal ecs_world_t* WorldPtr { get; }

    /// <summary>
    ///     A reference to the handle.
    /// </summary>
    public ecs_table_t* Handle { get; }

    private readonly int _offset;
    private readonly int _count;
    private readonly bool _isRange;

    /// <summary>
    ///     The offset from the start of the table.
    /// </summary>
    /// <returns>The row offset of the table range.</returns>
    public int Offset()
    {
        return _offset;
    }

    /// <summary>
    ///     The number of entities in the table range.
    /// </summary>
    /// <remarks>
    ///     For a range, this is the count captured at construction. For a whole table, this is the live table
    ///     count, matching C++ table::count().
    /// </remarks>
    /// <returns>The number of entities in the table range.</returns>
    public int Count()
    {
        return _isRange ? _count : Handle == null ? 0 : ecs_table_count(Handle);
    }

    /// <summary>
    ///     Creates a table from the provided world and handle.
    /// </summary>
    /// <param name="world"></param>
    public Table(ecs_world_t* world)
    {
        WorldPtr = world;
        Handle = null;
        _offset = 0;
        _count = 0;
        _isRange = false;
    }

    /// <summary>
    ///     Creates a table from the provided handle.
    /// </summary>
    /// <param name="table"></param>
    public Table(ecs_table_t* table)
    {
        WorldPtr = null;
        Handle = table;
        _offset = 0;
        _count = 0;
        _isRange = false;
    }

    /// <summary>
    ///     Creates a table from the provided world and handle.
    /// </summary>
    /// <param name="world"></param>
    /// <param name="table"></param>
    public Table(ecs_world_t* world, ecs_table_t* table)
    {
        WorldPtr = world;
        Handle = table;
        _offset = 0;
        _count = 0;
        _isRange = false;
    }

    /// <summary>
    ///     Creates a table range form the provided world and handle.
    /// </summary>
    /// <param name="world"></param>
    /// <param name="table"></param>
    /// <param name="offset"></param>
    /// <param name="count"></param>
    public Table(ecs_world_t* world, ecs_table_t* table, int offset, int count)
    {
        WorldPtr = world;
        Handle = table;
        _offset = offset;
        _count = count;
        _isRange = true;
    }

    /// <summary>
    ///     Convert table type to string.
    /// </summary>
    /// <returns></returns>
    public string Str()
    {
        return NativeString.GetStringAndFree(ecs_table_str(WorldPtr, Handle));
    }

    /// <summary>
    ///     Get table type.
    /// </summary>
    /// <returns></returns>
    public FlecsType Type()
    {
        return new FlecsType(WorldPtr, ecs_table_get_type(Handle));
    }

    /// <summary>
    ///     Get the number of allocated elements in the table.
    /// </summary>
    /// <returns></returns>
    public int Size()
    {
        return ecs_table_size(Handle);
    }

    /// <summary>
    ///     Get the array of entity ids.
    /// </summary>
    /// <returns></returns>
    public ulong* Entities()
    {
        return ecs_table_entities(Handle);
    }

    /// <summary>
    ///     Delete entities in the table.
    /// </summary>
    public void ClearEntities()
    {
        ecs_table_clear_entities(WorldPtr, Handle);
    }

    /// <summary>
    ///     Find type index for (component) id.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public int TypeIndex(ulong id)
    {
        return ecs_table_get_type_index(WorldPtr, Handle, id);
    }

    /// <summary>
    ///     Find type index for pair.
    /// </summary>
    /// <param name="first"></param>
    /// <param name="second"></param>
    /// <returns></returns>
    public int TypeIndex(ulong first, ulong second)
    {
        ulong pair = Ecs.Pair(first, second);
        return TypeIndex(pair);
    }

    /// <summary>
    ///     Find type index for type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public int TypeIndex<T>()
    {
        return TypeIndex(Type<T>.Id(WorldPtr));
    }

    /// <summary>
    ///     Find type index for type.
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public int TypeIndex<T>(T value) where T : Enum
    {
        return TypeIndex<T>(Type<T>.Id(WorldPtr, value));
    }

    /// <summary>
    ///     Find type index for pair.
    /// </summary>
    /// <param name="second"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <returns></returns>
    public int TypeIndex<TFirst>(ulong second)
    {
        return TypeIndex(Type<TFirst>.Id(WorldPtr), second);
    }

    /// <summary>
    ///     Find type index for pair.
    /// </summary>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public int TypeIndex<TFirst, TSecond>()
    {
        return TypeIndex(Type<TFirst>.Id(WorldPtr), Type<TSecond>.Id(WorldPtr));
    }

    /// <summary>
    ///     Find type index for pair.
    /// </summary>
    /// <param name="second"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public int TypeIndex<TFirst, TSecond>(TSecond second) where TSecond : Enum
    {
        return TypeIndex<TFirst>(Type<TSecond>.Id(WorldPtr, second));
    }

    /// <summary>
    ///     Find type index for pair.
    /// </summary>
    /// <param name="first"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public int TypeIndex<TFirst, TSecond>(TFirst first) where TFirst : Enum
    {
        return TypeIndexSecond<TSecond>(Type<TFirst>.Id(WorldPtr, first));
    }

    /// <summary>
    ///     Find type index for pair.
    /// </summary>
    /// <param name="first"></param>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public int TypeIndexSecond<TSecond>(ulong first)
    {
        return TypeIndex(first, Type<TSecond>.Id(WorldPtr));
    }

    /// <summary>
    ///     Find column index for (component) id.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public int ColumnIndex(ulong id)
    {
        return ecs_table_get_column_index(WorldPtr, Handle, id);
    }

    /// <summary>
    ///     Find column index for pair.
    /// </summary>
    /// <param name="first"></param>
    /// <param name="second"></param>
    /// <returns></returns>
    public int ColumnIndex(ulong first, ulong second)
    {
        ulong pair = Ecs.Pair(first, second);
        return ColumnIndex(pair);
    }

    /// <summary>
    ///     Find column index for component.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public int ColumnIndex<T>()
    {
        return ColumnIndex(Type<T>.Id(WorldPtr));
    }

    /// <summary>
    ///     Find column index for component.
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public int ColumnIndex<T>(T value) where T : Enum
    {
        return ColumnIndex<T>(Type<T>.Id(WorldPtr, value));
    }

    /// <summary>
    ///     Find column index for pair.
    /// </summary>
    /// <param name="second"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <returns></returns>
    public int ColumnIndex<TFirst>(ulong second)
    {
        ulong pair = Ecs.Pair<TFirst>(second, WorldPtr);
        return ColumnIndex(pair);
    }

    /// <summary>
    ///     Find column index for pair.
    /// </summary>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public int ColumnIndex<TFirst, TSecond>()
    {
        ulong pair = Ecs.Pair<TFirst, TSecond>(WorldPtr);
        return ColumnIndex(pair);
    }

    /// <summary>
    ///     Find column index for pair.
    /// </summary>
    /// <param name="second"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public int ColumnIndex<TFirst, TSecond>(TSecond second) where TSecond : Enum
    {
        return ColumnIndex<TFirst>(Type<TSecond>.Id(WorldPtr, second));
    }

    /// <summary>
    ///     Find column index for pair.
    /// </summary>
    /// <param name="first"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public int ColumnIndex<TFirst, TSecond>(TFirst first) where TFirst : Enum
    {
        return ColumnIndexSecond<TSecond>(Type<TFirst>.Id(WorldPtr, first));
    }

    /// <summary>
    ///     Find column index for pair.
    /// </summary>
    /// <param name="first"></param>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public int ColumnIndexSecond<TSecond>(ulong first)
    {
        ulong pair = Ecs.PairSecond<TSecond>(first, WorldPtr);
        return ColumnIndex(pair);
    }

    /// <summary>
    ///     Test if table has (component) id.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public bool Has(ulong id)
    {
        return TypeIndex(id) != -1;
    }

    /// <summary>
    ///     Test if table has the pair.
    /// </summary>
    /// <param name="first"></param>
    /// <param name="second"></param>
    /// <returns></returns>
    public bool Has(ulong first, ulong second)
    {
        ulong pair = Ecs.Pair(first, second);
        return TypeIndex(pair) != -1;
    }

    /// <summary>
    ///     Test if table has the type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public bool Has<T>()
    {
        return TypeIndex<T>() != -1;
    }

    /// <summary>
    ///     Test if table has the type.
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public bool Has<T>(T value) where T : Enum
    {
        return Has<T>(Type<T>.Id(WorldPtr, value));
    }

    /// <summary>
    ///     Test if table has the pair.
    /// </summary>
    /// <param name="second"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <returns></returns>
    public bool Has<TFirst>(ulong second)
    {
        return TypeIndex<TFirst>(second) != -1;
    }

    /// <summary>
    ///     Test if table has the pair.
    /// </summary>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public bool Has<TFirst, TSecond>()
    {
        return TypeIndex<TFirst, TSecond>() != -1;
    }

    /// <summary>
    ///     Test if table has the pair.
    /// </summary>
    /// <param name="second"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public bool Has<TFirst, TSecond>(TSecond second) where TSecond : Enum
    {
        return Has<TFirst>(Type<TSecond>.Id(WorldPtr, second));
    }

    /// <summary>
    ///     Test if table has the pair.
    /// </summary>
    /// <param name="first"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public bool Has<TFirst, TSecond>(TFirst first) where TFirst : Enum
    {
        return HasSecond<TSecond>(Type<TFirst>.Id(WorldPtr, first));
    }

    /// <summary>
    ///     Test if table has the pair.
    /// </summary>
    /// <param name="first"></param>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public bool HasSecond<TSecond>(ulong first)
    {
        return TypeIndexSecond<TSecond>(first) != -1;
    }

    /// <summary>
    ///     Get pointer to component array by column index.
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public void* GetColumn(int index)
    {
        return ecs_table_get_column(Handle, index, Offset());
    }

    /// <summary>
    ///     Get pointer to component array by component.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public void* GetPtr(ulong id)
    {
        int index = ColumnIndex(id);
        return index == -1 ? null : GetColumn(index);
    }

    /// <summary>
    ///     Get pointer to component array by component.
    /// </summary>
    /// <param name="first"></param>
    /// <param name="second"></param>
    /// <returns></returns>
    public void* GetPtr(ulong first, ulong second)
    {
        ulong pair = Ecs.Pair(first, second);
        return GetPtr(pair);
    }

    /// <summary>
    ///     Get pointer to component array by component.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public T* GetPtr<T>() where T : unmanaged
    {
        Ecs.Assert(Type<T>.Size != 0, nameof(ECS_INVALID_PARAMETER));
        return (T*)GetPtr(Type<T>.Id(WorldPtr));
    }

    /// <summary>
    ///     Get pointer to component array by pair.
    /// </summary>
    /// <param name="second"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <returns></returns>
    public TFirst* GetPtr<TFirst>(ulong second) where TFirst : unmanaged
    {
        Ecs.Assert(Type<TFirst>.Size != 0, nameof(ECS_INVALID_PARAMETER));
        return (TFirst*)GetPtr(Ecs.Pair<TFirst>(second, WorldPtr));
    }

    /// <summary>
    ///     Get pointer to component array by pair.
    /// </summary>
    /// <param name="second"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public TFirst* GetPtr<TFirst, TSecond>(TSecond second)
        where TFirst : unmanaged
        where TSecond : Enum
    {
        return GetPtr<TFirst>(Type<TSecond>.Id(WorldPtr, second));
    }

    /// <summary>
    ///     Get pointer to component array by pair.
    /// </summary>
    /// <param name="first"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public TSecond* GetPtr<TFirst, TSecond>(TFirst first)
        where TFirst : Enum
        where TSecond : unmanaged
    {
        return GetSecondPtr<TSecond>(Type<TFirst>.Id(WorldPtr, first));
    }

    /// <summary>
    ///     Get pointer to component array by pair.
    /// </summary>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public TFirst* GetFirstPtr<TFirst, TSecond>() where TFirst : unmanaged
    {
        Ecs.Assert(Type<TFirst>.Size != 0, nameof(ECS_INVALID_PARAMETER));
        return (TFirst*)GetPtr(Ecs.Pair<TFirst, TSecond>(WorldPtr));
    }

    /// <summary>
    ///     Get pointer to component array by pair.
    /// </summary>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public TSecond* GetSecondPtr<TFirst, TSecond>() where TSecond : unmanaged
    {
        Ecs.Assert(Type<TSecond>.Size != 0, nameof(ECS_INVALID_PARAMETER));
        return (TSecond*)GetPtr(Ecs.Pair<TFirst, TSecond>(WorldPtr));
    }

    /// <summary>
    ///     Get pointer to component array by pair.
    /// </summary>
    /// <param name="first"></param>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public TSecond* GetSecondPtr<TSecond>(ulong first) where TSecond : unmanaged
    {
        Ecs.Assert(Type<TSecond>.Size != 0, nameof(ECS_INVALID_PARAMETER));
        return (TSecond*)GetPtr(Ecs.PairSecond<TSecond>(first, WorldPtr));
    }

    /// <summary>
    ///     Get managed column to component array by component.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public Field<T> Get<T>()
    {
        Ecs.Assert(Type<T>.Size != 0, nameof(ECS_INVALID_PARAMETER));
        return new Field<T>(GetPtr(Type<T>.Id(WorldPtr)), ColumnSize(ColumnIndex<T>()));
    }

    /// <summary>
    ///     Get managed column to component array by pair.
    /// </summary>
    /// <param name="second"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <returns></returns>
    public Field<TFirst> Get<TFirst>(ulong second)
    {
        Ecs.Assert(Type<TFirst>.Size != 0, nameof(ECS_INVALID_PARAMETER));
        ulong pair = Ecs.Pair<TFirst>(second, WorldPtr);
        return new Field<TFirst>(GetPtr(pair), ColumnSize(ColumnIndex<TFirst>()));
    }

    /// <summary>
    ///    Get managed column to component array by pair.
    /// </summary>
    /// <param name="second"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public Field<TFirst> Get<TFirst, TSecond>(TSecond second)
        where TFirst : unmanaged
        where TSecond : Enum
    {
        return Get<TFirst>(Type<TSecond>.Id(WorldPtr, second));
    }

    /// <summary>
    ///     Get managed column to component array by pair.
    /// </summary>
    /// <param name="first"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public Field<TSecond> Get<TFirst, TSecond>(TFirst first)
        where TFirst : Enum
        where TSecond : unmanaged
    {
        return GetSecond<TSecond>(Type<TFirst>.Id(WorldPtr, first));
    }

    /// <summary>
    ///     Get managed column to component array by pair.
    /// </summary>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public Field<TFirst> GetFirst<TFirst, TSecond>()
    {
        Ecs.Assert(Type<TFirst>.Size != 0, nameof(ECS_INVALID_PARAMETER));
        ulong pair = Ecs.Pair<TFirst, TSecond>(WorldPtr);
        return new Field<TFirst>(GetPtr(pair), ColumnSize(ColumnIndex<TFirst, TSecond>()));
    }

    /// <summary>
    ///     Get managed column to component array by pair.
    /// </summary>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public Field<TSecond> GetSecond<TFirst, TSecond>()
    {
        Ecs.Assert(Type<TSecond>.Size != 0, nameof(ECS_INVALID_PARAMETER));
        ulong pair = Ecs.Pair<TFirst, TSecond>(WorldPtr);
        return new Field<TSecond>(GetPtr(pair), ColumnSize(ColumnIndex<TFirst, TSecond>()));
    }

    /// <summary>
    ///     Get managed column to component array by pair.
    /// </summary>
    /// <param name="first"></param>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public Field<TSecond> GetSecond<TSecond>(ulong first)
    {
        Ecs.Assert(Type<TSecond>.Size != 0, nameof(ECS_INVALID_PARAMETER));
        ulong pair = Ecs.PairSecond<TSecond>(first, WorldPtr);
        return new Field<TSecond>(GetPtr(pair), ColumnSize(ColumnIndexSecond<TSecond>(first)));
    }

    /// <summary>
    ///     Get column size.
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public int ColumnSize(int index)
    {
        return (int)ecs_table_get_column_size(Handle, index);
    }

    /// <summary>
    ///     Get depth for given relationship.
    /// </summary>
    /// <param name="rel"></param>
    /// <returns></returns>
    public int Depth(ulong rel)
    {
        return ecs_table_get_depth(WorldPtr, Handle, rel);
    }

    /// <summary>
    ///     Get depth for given relationship.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public int Depth<T>()
    {
        return Depth(Type<T>.Id(WorldPtr));
    }

    /// <summary>
    ///     Get depth for given relationship.
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public int Depth<T>(T value) where T : Enum
    {
        return Depth(Type<T>.Id(WorldPtr, value));
    }

    /// <summary>
    ///     Get the table records array.
    /// </summary>
    /// <returns></returns>
    public ecs_table_records_t Records()
    {
        return flecs_table_records(Handle);
    }

    /// <summary>
    ///     Get the table id.
    /// </summary>
    /// <returns></returns>
    public ulong Id()
    {
        return flecs_table_id(Handle);
    }

    /// <summary>
    ///     Lock the table.
    /// </summary>
    public void Lock()
    {
        ecs_table_lock(WorldPtr, Handle);
    }

    /// <summary>
    ///     Unlock the table.
    /// </summary>
    public void Unlock()
    {
        ecs_table_unlock(WorldPtr, Handle);
    }

    /// <summary>
    ///     Check if the table has the specified flags.
    /// </summary>
    /// <param name="flags">The flags to check for.</param>
    /// <returns>True if the table has the specified flags.</returns>
    public bool HasFlags(uint flags)
    {
        return ecs_table_has_flags(Handle, flags);
    }

    /// <summary>
    ///     Converts a <see cref="Table"/> instance to a <see cref="ecs_table_t"/>*.
    /// </summary>
    /// <param name="table"></param>
    /// <returns></returns>
    public static ecs_table_t* To(Table table)
    {
        return table.Handle;
    }

    /// <summary>
    ///     Converts a <see cref="ecs_table_t"/>* instance to a <see cref="Table"/>.
    /// </summary>
    /// <param name="table"></param>
    /// <returns></returns>
    public static Table From(ecs_table_t* table)
    {
        return new Table(table);
    }

    /// <summary>
    ///     Converts a <see cref="Table"/> instance to a <see cref="ecs_table_t"/>*.
    /// </summary>
    /// <param name="table"></param>
    /// <returns></returns>
    public static implicit operator ecs_table_t*(Table table)
    {
        return To(table);
    }

    /// <summary>
    ///     Converts a <see cref="ecs_table_t"/>* instance to a <see cref="Table"/>.
    /// </summary>
    /// <param name="table"></param>
    /// <returns></returns>
    public static implicit operator Table(ecs_table_t* table)
    {
        return From(table);
    }

    /// <summary>
    ///     Returns a string representation of the table.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return Ecs.IsStageOrWorld(WorldPtr) ? Str() : string.Empty;
    }

    /// <summary>
    ///     Checks if two <see cref="Table"/> instances are equal.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public bool Equals(Table other)
    {
        return Handle == other.Handle;
    }

    /// <summary>
    ///     Checks if two <see cref="Table"/> instance equal.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        return obj is Table other && Equals(other);
    }

    /// <summary>
    ///     Returns the hash code of the <see cref="Table"/>.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return Handle->GetHashCode();
    }

    /// <summary>
    ///     Checks if two <see cref="Table"/> instances are equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator ==(Table left, Table right)
    {
        return left.Equals(right);
    }

    /// <summary>
    ///     Checks if two <see cref="Table"/> instances are not equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator !=(Table left, Table right)
    {
        return !(left == right);
    }
}

// Flecs.NET Extensions
public readonly unsafe partial struct Table
{
    /// <summary>
    ///     Get table that has all components of current table plus the specified id.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Table Add(ulong id)
    {
        return new Table(WorldPtr, ecs_table_add_id(WorldPtr, Handle, id));
    }

    /// <summary>
    ///     Get table that has all components of current table plus the specified pair.
    /// </summary>
    /// <param name="first"></param>
    /// <param name="second"></param>
    /// <returns></returns>
    public Table Add(ulong first, ulong second)
    {
        return Add(Ecs.Pair(first, second));
    }

    /// <summary>
    ///     Get table that has all components of current table plus the specified component.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public Table Add<T>()
    {
        return Add(Type<T>.Id(WorldPtr));
    }

    /// <summary>
    ///     Get table that has all components of current table plus the specified pair.
    /// </summary>
    /// <param name="second"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <returns></returns>
    public Table Add<TFirst>(ulong second)
    {
        return Add(Ecs.Pair<TFirst>(second, WorldPtr));
    }

    /// <summary>
    ///     Get table that has all components of current table plus the specified pair.
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public Table Add<T>(T value) where T : Enum
    {
        return Add<T>(Type<T>.Id(WorldPtr, value));
    }

    /// <summary>
    ///     Get table that has all components of current table plus the specified pair.
    /// </summary>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public Table Add<TFirst, TSecond>()
    {
        return Add(Ecs.Pair<TFirst, TSecond>(WorldPtr));
    }

    /// <summary>
    ///     Get table that has all components of current table plus the specified pair.
    /// </summary>
    /// <param name="second"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public Table Add<TFirst, TSecond>(TSecond second) where TSecond : Enum
    {
        return Add<TFirst>(Type<TSecond>.Id(WorldPtr, second));
    }

    /// <summary>
    ///     Get table that has all components of current table plus the specified pair.
    /// </summary>
    /// <param name="first"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public Table Add<TFirst, TSecond>(TFirst first) where TFirst : Enum
    {
        return AddSecond<TSecond>(Type<TFirst>.Id(WorldPtr, first));
    }

    /// <summary>
    ///     Get table that has all components of current table plus the specified pair.
    /// </summary>
    /// <param name="first"></param>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public Table AddSecond<TSecond>(ulong first)
    {
        return Add(first, Type<TSecond>.Id(WorldPtr));
    }

    /// <summary>
    ///     Get table that has all components of current table minus the specified id.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Table Remove(ulong id)
    {
        return new Table(WorldPtr, ecs_table_remove_id(WorldPtr, Handle, id));
    }

    /// <summary>
    ///     Get table that has all components of current table minus the specified pair.
    /// </summary>
    /// <param name="first"></param>
    /// <param name="second"></param>
    /// <returns></returns>
    public Table Remove(ulong first, ulong second)
    {
        return Remove(Ecs.Pair(first, second));
    }

    /// <summary>
    ///     Get table that has all components of current table minus the specified component.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public Table Remove<T>()
    {
        return Remove(Type<T>.Id(WorldPtr));
    }

    /// <summary>
    ///     Get table that has all components of current table minus the specified pair.
    /// </summary>
    /// <param name="second"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <returns></returns>
    public Table Remove<TFirst>(ulong second)
    {
        return Remove(Ecs.Pair<TFirst>(second, WorldPtr));
    }

    /// <summary>
    ///     Get table that has all components of current table minus the specified pair.
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public Table Remove<T>(T value) where T : Enum
    {
        return Remove<T>(Type<T>.Id(WorldPtr, value));
    }

    /// <summary>
    ///     Get table that has all components of current table minus the specified pair.
    /// </summary>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public Table Remove<TFirst, TSecond>()
    {
        return Remove(Ecs.Pair<TFirst, TSecond>(WorldPtr));
    }

    /// <summary>
    ///     Get table that has all components of current table minus the specified pair.
    /// </summary>
    /// <param name="second"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public Table Remove<TFirst, TSecond>(TSecond second) where TSecond : Enum
    {
        return Remove<TFirst>(Type<TSecond>.Id(WorldPtr, second));
    }

    /// <summary>
    ///     Get table that has all components of current table minus the specified pair.
    /// </summary>
    /// <param name="first"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public Table Remove<TFirst, TSecond>(TFirst first) where TFirst : Enum
    {
        return RemoveSecond<TSecond>(Type<TFirst>.Id(WorldPtr, first));
    }

    /// <summary>
    ///     Get table that has all components of current table minus the specified pair.
    /// </summary>
    /// <param name="first"></param>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public Table RemoveSecond<TSecond>(ulong first)
    {
        return Remove(first, Type<TSecond>.Id(WorldPtr));
    }

    /// <summary>
    ///     Search for id index in table.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public int Search(ulong id)
    {
        return ecs_search(WorldPtr, Handle, id, null);
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <param name="first"></param>
    /// <param name="second"></param>
    /// <returns></returns>
    public int Search(ulong first, ulong second)
    {
        return Search(Ecs.Pair(first, second));
    }

    /// <summary>
    ///     Search for component index in table.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public int Search<T>()
    {
        return Search(Type<T>.Id(WorldPtr));
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <param name="second"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <returns></returns>
    public int Search<TFirst>(ulong second)
    {
        return Search(Ecs.Pair<TFirst>(second, WorldPtr));
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public int Search<T>(T value) where T : Enum
    {
        return Search<T>(Type<T>.Id(WorldPtr, value));
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public int Search<TFirst, TSecond>()
    {
        return Search(Ecs.Pair<TFirst, TSecond>(WorldPtr));
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <param name="second"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public int Search<TFirst, TSecond>(TSecond second) where TSecond : Enum
    {
        return Search<TFirst>(Type<TSecond>.Id(WorldPtr, second));
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <param name="first"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public int Search<TFirst, TSecond>(TFirst first) where TFirst : Enum
    {
        return SearchSecond<TSecond>(Type<TFirst>.Id(WorldPtr, first));
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <param name="first"></param>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public int SearchSecond<TSecond>(ulong first)
    {
        return Search(Ecs.PairSecond<TSecond>(first, WorldPtr));
    }

    /// <summary>
    ///     Search for id in table.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="idOut"></param>
    /// <returns></returns>
    public int Search(ulong id, out ulong idOut)
    {
        fixed (ulong* ptr = &idOut)
        {
            return ecs_search(WorldPtr, Handle, id, ptr);
        }
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <param name="first"></param>
    /// <param name="second"></param>
    /// <param name="idOut"></param>
    /// <returns></returns>
    public int Search(ulong first, ulong second, out ulong idOut)
    {
        return Search(Ecs.Pair(first, second), out idOut);
    }

    /// <summary>
    ///     Search for component index in table.
    /// </summary>
    /// <param name="idOut"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public int Search<T>(out ulong idOut)
    {
        return Search(Type<T>.Id(WorldPtr), out idOut);
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <param name="second"></param>
    /// <param name="idOut"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <returns></returns>
    public int Search<TFirst>(ulong second, out ulong idOut)
    {
        return Search(Ecs.Pair<TFirst>(second, WorldPtr), out idOut);
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="idOut"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public int Search<T>(T value, out ulong idOut) where T : Enum
    {
        return Search<T>(Type<T>.Id(WorldPtr, value), out idOut);
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <param name="idOut"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public int Search<TFirst, TSecond>(out ulong idOut)
    {
        return Search(Ecs.Pair<TFirst, TSecond>(WorldPtr), out idOut);
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <param name="second"></param>
    /// <param name="inOut"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public int Search<TFirst, TSecond>(TSecond second, out ulong inOut) where TSecond : Enum
    {
        return Search<TFirst>(Type<TSecond>.Id(WorldPtr, second), out inOut);
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <param name="first"></param>
    /// <param name="inOut"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public int Search<TFirst, TSecond>(TFirst first, out ulong inOut) where TFirst : Enum
    {
        return SearchSecond<TSecond>(Type<TFirst>.Id(WorldPtr, first), out inOut);
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <param name="first"></param>
    /// <param name="idOut"></param>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public int SearchSecond<TSecond>(ulong first, out ulong idOut)
    {
        return Search(first, Type<TSecond>.Id(WorldPtr), out idOut);
    }

    /// <summary>
    ///     Search for id in table.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="idOut"></param>
    /// <returns></returns>
    public int Search(ulong id, out Id idOut)
    {
        idOut = new Id(WorldPtr);
        return Search(id, out idOut.ValueRef);
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <param name="first"></param>
    /// <param name="second"></param>
    /// <param name="idOut"></param>
    /// <returns></returns>
    public int Search(ulong first, ulong second, out Id idOut)
    {
        return Search(Ecs.Pair(first, second), out idOut);
    }

    /// <summary>
    ///     Search for component index in table.
    /// </summary>
    /// <param name="idOut"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public int Search<T>(out Id idOut)
    {
        return Search(Type<T>.Id(WorldPtr), out idOut);
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="idOut"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public int Search<T>(T value, out Id idOut) where T : Enum
    {
        return Search<T>(Type<T>.Id(WorldPtr, value), out idOut);
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <param name="second"></param>
    /// <param name="idOut"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <returns></returns>
    public int Search<TFirst>(ulong second, out Id idOut)
    {
        return Search(Ecs.Pair<TFirst>(second, WorldPtr), out idOut);
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <param name="idOut"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public int Search<TFirst, TSecond>(out Id idOut)
    {
        return Search(Ecs.Pair<TFirst, TSecond>(WorldPtr), out idOut);
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <param name="second"></param>
    /// <param name="inOut"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public int Search<TFirst, TSecond>(TSecond second, out Id inOut) where TSecond : Enum
    {
        return Search<TFirst>(Type<TSecond>.Id(WorldPtr, second), out inOut);
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <param name="first"></param>
    /// <param name="inOut"></param>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public int Search<TFirst, TSecond>(TFirst first, out Id inOut) where TFirst : Enum
    {
        return SearchSecond<TSecond>(Type<TFirst>.Id(WorldPtr, first), out inOut);
    }

    /// <summary>
    ///     Search for pair index in table.
    /// </summary>
    /// <param name="first"></param>
    /// <param name="idOut"></param>
    /// <typeparam name="TSecond"></typeparam>
    /// <returns></returns>
    public int SearchSecond<TSecond>(ulong first, out Id idOut)
    {
        return Search(first, Type<TSecond>.Id(WorldPtr), out idOut);
    }
}
