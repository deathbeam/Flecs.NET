using System;
using Flecs.NET.Core.BindingContext;
using Flecs.NET.Utilities;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     A wrapper around <see cref="ecs_alert_desc_t"/>.
/// </summary>
public unsafe partial struct AlertBuilder : IDisposable, IEquatable<AlertBuilder>, IQueryBuilderBase
{
    private ecs_world_t* _world;
    private ecs_alert_desc_t _desc;
    private QueryBuilder _queryBuilder;
    private int _severityFilterCount;

    /// <summary>
    ///     A reference to the world.
    /// </summary>
    internal ref ecs_world_t* WorldPtr => ref _world;

    /// <summary>
    ///     A reference to the alert description.
    /// </summary>
    internal ref ecs_alert_desc_t Descriptor => ref _desc;

    /// <summary>
    ///     A reference to the query builder.
    /// </summary>
    public ref QueryBuilder QueryBuilder => ref _queryBuilder;

    /// <summary>
    ///     Creates an alert builder for the provided world.
    /// </summary>
    /// <param name="world">The world.</param>
    public AlertBuilder(ecs_world_t* world)
    {
        _world = world;
        _severityFilterCount = default;
        _desc = default;
        _queryBuilder = new QueryBuilder(world);
    }

    /// <summary>
    ///     Creates an alert builder for the provided world.
    /// </summary>
    /// <param name="world">The world.</param>
    /// <param name="entity">The alert entity.</param>
    public AlertBuilder(ecs_world_t* world, ulong entity) : this(world)
    {
        Descriptor.entity = entity;
    }

    /// <summary>
    ///     Creates an alert builder for the provided world.
    /// </summary>
    /// <param name="world">The world.</param>
    /// <param name="name">The alert name.</param>
    public AlertBuilder(ecs_world_t* world, string name) : this(world)
    {
        if (string.IsNullOrEmpty(name))
            return;

        using NativeString nativeName = (NativeString)name;

        ecs_entity_desc_t desc = default;
        desc.name = nativeName;
        desc.sep = Pointers.DefaultSeparator;
        desc.root_sep = Pointers.DefaultSeparator;
        Descriptor.entity = ecs_entity_init(WorldPtr, &desc);
    }

    /// <summary>
    ///     Cleans up native resources. This should be called if the alert builder
    ///     will be discarded and .Build() isn't called.
    /// </summary>
    public void Dispose()
    {
        QueryBuilder.Dispose();
    }

    /// <summary>
    ///     Builds a new alert.
    /// </summary>
    /// <returns></returns>
    public Alert Build()
    {
        QueryBuilder.AssertReusable();

        fixed (ecs_alert_desc_t* alertDesc = &Descriptor)
        {
            alertDesc->query = QueryBuilder.Descriptor;

            Entity entity = new Entity(WorldPtr, ecs_alert_init(WorldPtr, alertDesc));

            if (entity == 0)
                Ecs.Error("Alert failed to init.");

            // The alert query owns the contexts after initialization.
            QueryBuilder.MarkBuilt();

            return new Alert(entity);
        }
    }

    /// <summary>
    ///     Sets the message of the alert.
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public ref AlertBuilder Message(string message)
    {
        NativeString nativeMessage = (NativeString)message;
        QueryBuilder.QueryContext.Strings.Add(nativeMessage);

        Descriptor.message = nativeMessage;
        return ref this;
    }

    /// <summary>
    ///     Sets the brief of the alert.
    /// </summary>
    /// <param name="brief"></param>
    /// <returns></returns>
    public ref AlertBuilder Brief(string brief)
    {
        NativeString nativeBrief = (NativeString)brief;
        QueryBuilder.QueryContext.Strings.Add(nativeBrief);

        Descriptor.brief = nativeBrief;
        return ref this;
    }

    /// <summary>
    ///     Sets the doc name of the alert.
    /// </summary>
    /// <param name="docName"></param>
    /// <returns></returns>
    public ref AlertBuilder DocName(string docName)
    {
        NativeString nativeDocName = (NativeString)docName;
        QueryBuilder.QueryContext.Strings.Add(nativeDocName);

        Descriptor.doc_name = nativeDocName;
        return ref this;
    }

    /// <summary>
    ///     Sets the retain period of the alert
    /// </summary>
    /// <param name="period"></param>
    /// <returns></returns>
    public ref AlertBuilder RetainPeriod(float period)
    {
        Descriptor.retain_period = period;
        return ref this;
    }

    /// <summary>
    ///     Sets the severity of the alert.
    /// </summary>
    /// <param name="kind"></param>
    /// <returns></returns>
    public ref AlertBuilder Severity(ulong kind)
    {
        Descriptor.severity = kind;
        return ref this;
    }

    /// <summary>
    ///     Sets the severity of the alert.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public ref AlertBuilder Severity<T>()
    {
        return ref Severity(Type<T>.Id(WorldPtr));
    }

    /// <summary>
    ///     Adds a severity filter to the alert.
    /// </summary>
    /// <param name="kind"></param>
    /// <param name="with"></param>
    /// <param name="var"></param>
    /// <returns></returns>
    public ref AlertBuilder SeverityFilter(ulong kind, ulong with, string var = "")
    {
        Ecs.Assert(_severityFilterCount < ECS_ALERT_MAX_SEVERITY_FILTERS,
            "Maximum number of severity filters reached");

        ref ecs_alert_severity_filter_t filter = ref Descriptor.severity_filters[_severityFilterCount++];
        filter.severity = kind;
        filter.with = with;

        return ref AlertVar(var);
    }

    /// <summary>
    ///     Adds a severity filter to the alert.
    /// </summary>
    /// <param name="with"></param>
    /// <param name="var"></param>
    /// <typeparam name="TSeverity"></typeparam>
    /// <returns></returns>
    public ref AlertBuilder SeverityFilter<TSeverity>(ulong with, string var = "")
    {
        return ref SeverityFilter(Type<TSeverity>.Id(WorldPtr), with, var);
    }

    /// <summary>
    ///     Adds a severity filter to the alert.
    /// </summary>
    /// <param name="var"></param>
    /// <typeparam name="TSeverity"></typeparam>
    /// <typeparam name="TWith"></typeparam>
    /// <returns></returns>
    public ref AlertBuilder SeverityFilter<TSeverity, TWith>(string var = "")
    {
        return ref SeverityFilter(Type<TSeverity>.Id(WorldPtr), Type<TWith>.Id(WorldPtr), var);
    }

    /// <summary>
    ///     Adds a severity filter to the alert.
    /// </summary>
    /// <param name="withEnum"></param>
    /// <param name="var"></param>
    /// <typeparam name="TSeverity"></typeparam>
    /// <typeparam name="TWithEnum"></typeparam>
    /// <returns></returns>
    public ref AlertBuilder SeverityFilter<TSeverity, TWithEnum>(TWithEnum withEnum, string var = "")
        where TWithEnum : Enum
    {
        return ref SeverityFilter(Type<TSeverity>.Id(WorldPtr), Type<TWithEnum>.Id(WorldPtr, withEnum), var);
    }

    /// <summary>
    ///     Set the member to create an alert for out of range values.
    /// </summary>
    /// <param name="member"></param>
    /// <returns></returns>
    public ref AlertBuilder Member(ulong member)
    {
        Descriptor.member = member;
        return ref this;
    }

    /// <summary>
    ///     Set member to create an alert for out of range of values.
    /// </summary>
    /// <param name="member"></param>
    /// <param name="var"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public ref AlertBuilder Member<T>(string member, string var = "")
    {
        using NativeString nativeMember = (NativeString)member;

        ulong id = Type<T>.Id(WorldPtr);
        ulong memberId = ecs_lookup_path_w_sep(WorldPtr, id, nativeMember,
            Pointers.DefaultSeparator, Pointers.DefaultSeparator, false);

        AlertVar(var);

        return ref Member(memberId);
    }

    /// <summary>
    ///     Set (component) id for member (optional). If Member() is set and id
    ///     is not set, the id will default to the member parent.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public ref AlertBuilder AlertId(ulong id)
    {
        Descriptor.id = id;
        return ref this;
    }

    /// <summary>
    ///     Set source variable for member.
    /// </summary>
    /// <param name="var"></param>
    /// <returns></returns>
    public ref AlertBuilder AlertVar(string var)
    {
        if (string.IsNullOrEmpty(var))
            return ref this;

        NativeString nativeVar = (NativeString)var;
        QueryBuilder.QueryContext.Strings.Add(nativeVar);
        Descriptor.var = nativeVar;

        return ref this;
    }

    /// <summary>
    ///     Checks if two <see cref="AlertBuilder"/> instances are equal.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public bool Equals(AlertBuilder other)
    {
        return Descriptor == other.Descriptor && QueryBuilder == other.QueryBuilder;
    }

    /// <summary>
    ///     Checks if two <see cref="AlertBuilder"/> instances are equal.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        return obj is AlertBuilder other && Equals(other);
    }

    /// <summary>
    ///     Gets the hash code of the <see cref="AlertBuilder"/>.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return HashCode.Combine(Descriptor.GetHashCode(), QueryBuilder.GetHashCode());
    }

    /// <summary>
    ///     Checks if two <see cref="AlertBuilder"/> instances are equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator ==(AlertBuilder left, AlertBuilder right)
    {
        return left.Equals(right);
    }

    /// <summary>
    ///     Checks if two <see cref="AlertBuilder"/> instances are not equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator !=(AlertBuilder left, AlertBuilder right)
    {
        return !(left == right);
    }
}
