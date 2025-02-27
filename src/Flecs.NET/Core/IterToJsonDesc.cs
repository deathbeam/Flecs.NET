using System;
using System.Runtime.CompilerServices;
using Flecs.NET.Utilities;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     A wrapper around ecs_iter_to_json_desc_t.
/// </summary>
public unsafe struct IterToJsonDesc : IEquatable<IterToJsonDesc>
{
    private ecs_iter_to_json_desc_t _desc;

    /// <summary>
    ///     Reference to desc.
    /// </summary>
    public ref ecs_iter_to_json_desc_t Desc => ref _desc;

    /// <summary>
    ///     Default serialization configuration.
    /// </summary>
    public static IterToJsonDesc Default => new IterToJsonDesc()
    {
        Desc = new ecs_iter_to_json_desc_t
        {
            serialize_entity_ids =    false,
            serialize_values =        true,
            serialize_builtin =       false,
            serialize_doc =           false,
            serialize_full_paths =    true,
            serialize_fields =        true,
            serialize_inherited =     false,
            serialize_table =         false,
            serialize_type_info =     false,
            serialize_field_info =    false,
            serialize_query_info =    false,
            serialize_query_plan =    false,
            serialize_query_profile = false,
            dont_serialize_results =  false,
            serialize_alerts =        false,
            serialize_refs =          0,
            serialize_matches =       false
        }
    };

    /// <summary>
    ///     Serialize entity ids.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref IterToJsonDesc EntityIds(bool value = true)
    {
        Desc.serialize_entity_ids = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize component values.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref IterToJsonDesc Values(bool value = true)
    {
        Desc.serialize_values = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize builtin data as components. (e.g. "name", "parent")
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref IterToJsonDesc BuiltIn(bool value = true)
    {
        Desc.serialize_builtin = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize doc attributes.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref IterToJsonDesc Doc(bool value = true)
    {
        Desc.serialize_doc = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize full paths for tags, components and pairs.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref IterToJsonDesc FullPaths(bool value = true)
    {
        Desc.serialize_full_paths = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize field data.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref IterToJsonDesc Fields(bool value = true)
    {
        Desc.serialize_fields = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize inherited components.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref IterToJsonDesc Inherited(bool value = true)
    {
        Desc.serialize_inherited = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize entire table vs. matched components.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref IterToJsonDesc Table(bool value = true)
    {
        Desc.serialize_table = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize type information.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref IterToJsonDesc TypeInfo(bool value = true)
    {
        Desc.serialize_type_info = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize metadata for fields returned by query.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref IterToJsonDesc FieldInfo(bool value = true)
    {
        Desc.serialize_field_info = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize query terms.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref IterToJsonDesc QueryInfo(bool value = true)
    {
        Desc.serialize_query_info = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize query plan.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref IterToJsonDesc QueryPlan(bool value = true)
    {
        Desc.serialize_query_plan = value;
        return ref this;
    }

    /// <summary>
    ///     Profile query performance.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref IterToJsonDesc QueryProfile(bool value = true)
    {
        Desc.serialize_query_profile = value;
        return ref this;
    }

    /// <summary>
    ///     If true, query won't be evaluated.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref IterToJsonDesc DontSerializeResults(bool value = true)
    {
        Desc.dont_serialize_results = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize active alerts for entity.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref IterToJsonDesc SerializeAlerts(bool value = true)
    {
        Desc.serialize_alerts = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize references (incoming edges) for relationship.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref IterToJsonDesc SerializeRefs(ulong value)
    {
        Desc.serialize_refs = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize which queries entity matches with
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref IterToJsonDesc SerializeMatches(bool value = true)
    {
        Desc.serialize_matches = value;
        return ref this;
    }

    /// <summary>
    ///     Query object (required for serialize_query_[plan|profile]).
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref IterToJsonDesc Query(void* value)
    {
        Desc.query = value;
        return ref this;
    }

    /// <summary>
    ///     Checks if two <see cref="IterToJsonDesc"/> instances are equal.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public bool Equals(IterToJsonDesc other)
    {
        return Desc == other.Desc;
    }

    /// <summary>
    ///     Checks if two <see cref="IterToJsonDesc"/> instances are equal.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        return obj is IterToJsonDesc other && Equals(other);
    }

    /// <summary>
    ///     Returns the hash code for the <see cref="IterToJsonDesc"/>.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return Desc.GetHashCode();
    }

    /// <summary>
    ///     Checks if two <see cref="IterToJsonDesc"/> instances are equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator ==(IterToJsonDesc left, IterToJsonDesc right)
    {
        return left.Equals(right);
    }

    /// <summary>
    ///     Checks if two <see cref="IterToJsonDesc"/> instances are not equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator !=(IterToJsonDesc left, IterToJsonDesc right)
    {
        return !(left == right);
    }
}
