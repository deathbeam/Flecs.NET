// /_/src/Flecs.NET/Generated/Entity/Entity.ComponentCallbacks/T15.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/Entity.cs
using System;

namespace Flecs.NET.Core;

public unsafe partial struct Entity
{
    /// <summary>
    ///     Read 15 components using the provided callback. <br/><br/>
    /// 
    ///     This operation accepts a callback with as arguments the components to
    ///     retrieve. The callback will only be invoked when the entity has all
    ///     the components. <br/><br/>
    ///     
    ///     This operation is faster than individually calling get for each component
    ///     as it only obtains entity metadata once.  <br/><br/>
    ///     
    ///     While the callback is invoked the table in which the components are
    ///     stored is locked, which prevents mutations that could cause invalidation
    ///     of the component references. Note that this is not an actual lock: 
    ///     invalid access causes a runtime panic and so it is still up to the 
    ///     application to ensure access is protected.  <br/><br/>
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// System.String[]
    /// <returns>True if the entity has the specified components.</returns>
    public bool Read<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Ecs.ReadRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> callback)
    {
        return Invoker.Read(World, Id, callback);
    }

    /// <summary>
    ///     Write 15 components using the provided callback. <br/><br/>
    /// 
    ///     This operation accepts a callback with as arguments the components to
    ///     retrieve. The callback will only be invoked when the entity has all
    ///     the components. <br/><br/>
    ///     
    ///     This operation is faster than individually calling get for each component
    ///     as it only obtains entity metadata once.  <br/><br/>
    ///     
    ///     While the callback is invoked the table in which the components are
    ///     stored is locked, which prevents mutations that could cause invalidation
    ///     of the component references. Note that this is not an actual lock: 
    ///     invalid access causes a runtime panic and so it is still up to the 
    ///     application to ensure access is protected.  <br/><br/>
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// System.String[]
    /// <returns>True if the entity has the specified components.</returns>
    public bool Write<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Ecs.WriteRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> callback)
    {
        return Invoker.Write(World, Id, callback);
    }

    /// <summary>
    ///     Ensures 15 components using the provided callback.<br/><br/>
    /// 
    ///     This operation accepts a callback with as arguments the components to
    ///     set. If the entity does not have all of the provided components, they
    ///     will be added. <br/><br/>
    ///
    ///     This operation is faster than individually calling ensure for each component
    ///     as it only obtains entity metadata once. When this operation is called
    ///     while deferred, its performance is equivalent to that of calling ensure
    ///     for each component separately. <br/><br/>
    ///
    ///     The operation will invoke modified for each component after the callback
    ///     has been invoked.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// System.String[]
    /// <returns>Reference to self.</returns>
    public ref Entity Insert<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Ecs.InsertRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> callback)
    {
        Invoker.Insert(World, Id, callback);
        return ref this;
    }
}