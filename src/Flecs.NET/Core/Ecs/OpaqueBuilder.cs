using System.ComponentModel;
using System;
using Flecs.NET.Core.BindingContext;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

public static unsafe partial class Ecs
{
    /// <summary>
    ///     Fluent builder that registers opaque type reflection for a component. Opaque
    ///     types map a component to a type known to the flecs reflection framework, like
    ///     a string or a vector, so that it can be serialized and deserialized without
    ///     exposing its layout.
    /// </summary>
    /// <typeparam name="TComponent">The opaque type.</typeparam>
    /// <typeparam name="TElement">The element type of the opaque collection.</typeparam>
    public sealed unsafe class OpaqueBuilder<TComponent, TElement> where TElement : unmanaged
    {
        private readonly OpaqueContext<TComponent, TElement> _context;
        private readonly ecs_world_t* _world;
        private ecs_opaque_desc_t _desc;

        /// <summary>
        ///     The world.
        /// </summary>
        internal ecs_world_t* WorldPtr => _world;

        /// <summary>
        ///     A reference to the opaque type descriptor.
        /// </summary>
        internal ref ecs_opaque_desc_t Descriptor => ref _desc;

        /// <summary>
        ///     Creates an opaque type builder for the provided type entity.
        /// </summary>
        /// <param name="world">The world.</param>
        /// <param name="entity">The type entity of the opaque type.</param>
        public OpaqueBuilder(ecs_world_t* world, ulong entity)
        {
            _world = world;
            _context = new OpaqueContext<TComponent, TElement>(new World(world));
            _desc = default;
            Descriptor.entity = entity;
        }

        /// <summary>
        ///     Sets the type that describes the serialized structure of the opaque type.
        /// </summary>
        /// <param name="type">The type id. (e.g. <see cref="Ecs.String"/>)</param>
        /// <returns>Reference to self.</returns>
        public OpaqueBuilder<TComponent, TElement> AsType(ulong type)
        {
            Descriptor.type.as_type = type;
            return this;
        }

        /// <summary>
        ///     Maps the opaque type to a string.
        /// </summary>
        /// <returns>Reference to self.</returns>
        public OpaqueBuilder<TComponent, TElement> String()
        {
            return AsType(Ecs.String);
        }

        /// <summary>
        ///     Maps the opaque type to a vector of <typeparamref name="TElement"/>.
        /// </summary>
        /// <returns>Reference to self.</returns>
        public OpaqueBuilder<TComponent, TElement> Vector()
        {
            return AsType(new World(WorldPtr).Vector<TElement>());
        }

        /// <summary>
        ///     Maps the opaque type to an array of <typeparamref name="TElement"/>.
        /// </summary>
        /// <param name="count">The number of elements in the array.</param>
        /// <returns>Reference to self.</returns>
        public OpaqueBuilder<TComponent, TElement> Array(int count)
        {
            return AsType(new World(WorldPtr).Array<TElement>(count));
        }

        /// <summary>
        ///     Sets the serialize callback.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <returns>Reference to self.</returns>
        public OpaqueBuilder<TComponent, TElement> Serialize(Ecs.OpaqueSerializeCallback<TComponent> callback)
        {
            _context.Serialize = callback;
            Descriptor.type.serialize = _context.SerializePointer;
            return this;
        }

        /// <summary>
        ///     Sets the random-access struct member serialize callback.
        /// </summary>
        public OpaqueBuilder<TComponent, TElement> SerializeMember(Ecs.OpaqueSerializeMemberCallback<TComponent> callback)
        {
            _context.SerializeMember = callback;
            Descriptor.type.serialize_member = _context.SerializeMemberPointer;
            return this;
        }

        /// <summary>
        ///     Sets the random-access collection element serialize callback.
        /// </summary>
        public OpaqueBuilder<TComponent, TElement> SerializeElement(Ecs.OpaqueSerializeElementCallback<TComponent> callback)
        {
            _context.SerializeElement = callback;
            Descriptor.type.serialize_element = (delegate* unmanaged<ecs_serializer_t*, void*, ulong, int>)_context.SerializeElementPointer;
            return this;
        }

        /// <summary>
        ///     Sets the bool assignment callback.
        /// </summary>
        public OpaqueBuilder<TComponent, TElement> AssignBool(Ecs.OpaqueAssignBoolCallback<TComponent> callback)
        {
            _context.AssignBool = callback;
            Descriptor.type.assign_bool = _context.AssignBoolPointer;
            return this;
        }

        /// <summary>
        ///     Sets the char assignment callback.
        /// </summary>
        public OpaqueBuilder<TComponent, TElement> AssignChar(Ecs.OpaqueAssignCharCallback<TComponent> callback)
        {
            _context.AssignChar = callback;
            Descriptor.type.assign_char = _context.AssignCharPointer;
            return this;
        }

        /// <summary>
        ///     Sets the signed integer assignment callback.
        /// </summary>
        public OpaqueBuilder<TComponent, TElement> AssignInt(Ecs.OpaqueAssignIntCallback<TComponent> callback)
        {
            _context.AssignInt = callback;
            Descriptor.type.assign_int = _context.AssignIntPointer;
            return this;
        }

        /// <summary>
        ///     Sets the unsigned integer assignment callback.
        /// </summary>
        public OpaqueBuilder<TComponent, TElement> AssignUInt(Ecs.OpaqueAssignUIntCallback<TComponent> callback)
        {
            _context.AssignUInt = callback;
            Descriptor.type.assign_uint = _context.AssignUIntPointer;
            return this;
        }

        /// <summary>
        ///     Sets the floating-point assignment callback.
        /// </summary>
        public OpaqueBuilder<TComponent, TElement> AssignFloat(Ecs.OpaqueAssignFloatCallback<TComponent> callback)
        {
            _context.AssignFloat = callback;
            Descriptor.type.assign_float = _context.AssignFloatPointer;
            return this;
        }
        /// <summary>
        ///     Sets the assign string callback.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <returns>Reference to self.</returns>
        public OpaqueBuilder<TComponent, TElement> AssignString(Ecs.OpaqueAssignStringCallback<TComponent> callback)
        {
            _context.AssignString = callback;
            Descriptor.type.assign_string = _context.AssignStringPointer;
            return this;
        }

        /// <summary>
        ///     Sets the entity assignment callback.
        /// </summary>
        public OpaqueBuilder<TComponent, TElement> AssignEntity(Ecs.OpaqueAssignEntityCallback<TComponent> callback)
        {
            _context.AssignEntity = callback;
            Descriptor.type.assign_entity = _context.AssignEntityPointer;
            return this;
        }

        /// <summary>
        ///     Sets the id assignment callback.
        /// </summary>
        public OpaqueBuilder<TComponent, TElement> AssignId(Ecs.OpaqueAssignIdCallback<TComponent> callback)
        {
            _context.AssignId = callback;
            Descriptor.type.assign_id = _context.AssignIdPointer;
            return this;
        }

        /// <summary>
        ///     Sets the null assignment callback.
        /// </summary>
        public OpaqueBuilder<TComponent, TElement> AssignNull(Ecs.OpaqueAssignNullCallback<TComponent> callback)
        {
            _context.AssignNull = callback;
            Descriptor.type.assign_null = _context.AssignNullPointer;
            return this;
        }

        /// <summary>
        ///     Sets the collection clear callback.
        /// </summary>
        public OpaqueBuilder<TComponent, TElement> Clear(Ecs.OpaqueClearCallback<TComponent> callback)
        {
            _context.Clear = callback;
            Descriptor.type.clear = _context.ClearPointer;
            return this;
        }

        /// <summary>
        ///     Sets the struct member lookup callback.
        ///     Returned references must point to storage that cannot move during native access,
        ///     not to fields inside a managed object.
        /// </summary>
        public OpaqueBuilder<TComponent, TElement> EnsureMember(Ecs.OpaqueEnsureMemberCallback<TComponent> callback)
        {
            _context.EnsureMember = callback;
            Descriptor.type.ensure_member = _context.EnsureMemberPointer;
            return this;
        }
        /// <summary>
        ///     Sets the element count callback.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <returns>Reference to self.</returns>
        public OpaqueBuilder<TComponent, TElement> Count(Ecs.OpaqueCountCallback<TComponent> callback)
        {
            _context.Count = callback;
            Descriptor.type.count = _context.CountPointer;
            return this;
        }

        /// <summary>
        ///     Sets the resize callback.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <returns>Reference to self.</returns>
        public OpaqueBuilder<TComponent, TElement> Resize(Ecs.OpaqueResizeCallback<TComponent> callback)
        {
            _context.Resize = callback;
            Descriptor.type.resize = _context.ResizePointer;
            return this;
        }

        /// <summary>
        ///     Sets the ensure element callback.
        ///     Returned references must point to storage that cannot move during native access,
        ///     not to elements of a managed array.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <returns>Reference to self.</returns>
        public OpaqueBuilder<TComponent, TElement> EnsureElement(Ecs.OpaqueEnsureElementCallback<TComponent, TElement> callback)
        {
            _context.EnsureElement = callback;
            Descriptor.type.ensure_element = _context.EnsureElementPointer;
            return this;
        }

        /// <summary>
        ///     Commits the opaque type descriptor. Called when the builder callback
        ///     passed to <see cref="Component{TComponent}.Opaque"/> returns.
        /// </summary>
        internal void Commit()
        {
            Ecs.Assert(Descriptor.type.as_type != 0, "Opaque type must map to a type. Use String, Vector, Array or AsType.");

            fixed (ecs_opaque_desc_t* desc = &Descriptor)
            {
                ulong entity = ecs_opaque_init(WorldPtr, desc);
                Ecs.Assert(entity != 0, nameof(ECS_INVALID_PARAMETER));
            }
        }
    }
}
