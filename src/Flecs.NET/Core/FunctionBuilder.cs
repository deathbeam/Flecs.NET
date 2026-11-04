using System;
using Flecs.NET.Core.BindingContext;
using Flecs.NET.Utilities;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     A wrapper around <see cref="ecs_function_desc_t"/>. Used to create script functions and methods.
/// </summary>
public unsafe struct FunctionBuilder : IEquatable<FunctionBuilder>, IDisposable
{
    private const int MaxParams = 16;

    private ecs_world_t* _world;
    private ecs_function_desc_t _desc;
    private int _paramCount;
    private bool _isMethod;

    private NativeString _name;
    private NativeString* _paramNames;
    private ScriptFunctionContext* _context;

    /// <summary>
    ///     Reference to the world.
    /// </summary>
    internal ref ecs_world_t* WorldPtr => ref _world;

    /// <summary>
    ///     Reference to the desc.
    /// </summary>
    internal ref ecs_function_desc_t Descriptor => ref _desc;

    /// <summary>
    ///     Creates a <see cref="FunctionBuilder"/> with the provided world and function name.
    /// </summary>
    /// <param name="world">The world.</param>
    /// <param name="name">The function name.</param>
    /// <param name="parent">The function parent. Defaults to the current scope.</param>
    /// <param name="isMethod">Whether the function is a method.</param>
    public FunctionBuilder(ecs_world_t* world, string name, ulong parent = 0, bool isMethod = false)
    {
        _world = world;
        _desc = default;
        _paramCount = 0;
        _isMethod = isMethod;
        _name = (NativeString)name;
        _paramNames = Memory.AllocZeroed<NativeString>(MaxParams);
        _context = Memory.AllocZeroed<ScriptFunctionContext>(1);

        Descriptor.name = _name;
        Descriptor.parent = parent != 0 ? parent : ecs_get_scope(world);
    }

    /// <summary>
    ///     Disposes the function builder. This should be called if the function builder
    ///     will be discarded and .Build() isn't called.
    /// </summary>
    public void Dispose()
    {
        _name.Dispose();
        _name = default;

        if (_paramNames != null)
        {
            for (int i = 0; i < _paramCount; i++)
                _paramNames[i].Dispose();

            Memory.Free(_paramNames);
            _paramNames = null;
        }

        _paramCount = 0;

        if (_context != null)
            ScriptFunctionContext.Free(_context);
        _context = null;
    }

    /// <summary>
    ///     Set the function parent.
    /// </summary>
    /// <param name="value">The parent entity.</param>
    /// <returns>Reference to self.</returns>
    public ref FunctionBuilder Parent(ulong value)
    {
        Descriptor.parent = value;
        return ref this;
    }

    /// <summary>
    ///     Set the function return type.
    /// </summary>
    /// <param name="type">The return type entity.</param>
    /// <returns>Reference to self.</returns>
    public ref FunctionBuilder ReturnType(ulong type)
    {
        Descriptor.return_type = type;
        return ref this;
    }

    /// <summary>
    ///     Set the function return type.
    /// </summary>
    /// <typeparam name="T">The return type.</typeparam>
    /// <returns>Reference to self.</returns>
    public ref FunctionBuilder ReturnType<T>()
    {
        return ref ReturnType(Type<T>.Id(WorldPtr));
    }

    /// <summary>
    ///     Add a function parameter.
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="type">The parameter type entity.</param>
    /// <returns>Reference to self.</returns>
    public ref FunctionBuilder Param(string name, ulong type)
    {
        Ecs.Assert(_paramCount < MaxParams - (_isMethod ? 1 : 0), "Too many function parameters");

        NativeString nativeName = (NativeString)name;
        _paramNames[_paramCount] = nativeName;

        Descriptor.@params[_paramCount] = new ecs_script_parameter_t { name = nativeName, type = type };
        _paramCount++;

        return ref this;
    }

    /// <summary>
    ///     Add a function parameter.
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <typeparam name="T">The parameter type.</typeparam>
    /// <returns>Reference to self.</returns>
    public ref FunctionBuilder Param<T>(string name)
    {
        return ref Param(name, Type<T>.Id(WorldPtr));
    }

    /// <summary>
    ///     Set the function callback.
    /// </summary>
    /// <param name="value">The callback.</param>
    /// <returns>Reference to self.</returns>
    public ref FunctionBuilder Callback(Ecs.ScriptFunctionCallback value)
    {
        _context->Callback.Set(value, null);
        Descriptor.callback = &Functions.ScriptFunctionCallback;
        return ref this;
    }

    /// <summary>
    ///     Set the vector function callback for the provided element kind.
    /// </summary>
    /// <param name="kind">The primitive element kind.</param>
    /// <param name="value">The callback.</param>
    /// <returns>Reference to self.</returns>
    public ref FunctionBuilder VectorCallback(ecs_primitive_kind_t kind, Ecs.ScriptVectorFunctionCallback value)
    {
        int index = (int)kind;
        Ecs.Assert(index > 0 && index < ScriptFunctionContext.VectorCallbackCount, "Invalid vector element kind");

        EnsureVectorCallbacks();
        _context->VectorCallbacks[index].Set(value, null);
        SetVectorCallback(index, VectorThunk(index));
        return ref this;
    }

    /// <summary>
    ///     Set the vector function callback for the provided element type.
    /// </summary>
    /// <param name="type">The primitive element type entity.</param>
    /// <param name="value">The callback.</param>
    /// <returns>Reference to self.</returns>
    public ref FunctionBuilder VectorCallback(ulong type, Ecs.ScriptVectorFunctionCallback value)
    {
        EcsPrimitive* primitive = (EcsPrimitive*)ecs_get_id(WorldPtr, type, FLECS_IDEcsPrimitiveID_);
        Ecs.Assert(primitive != null, "Vector element type is not a primitive");
        return ref VectorCallback(primitive->kind, value);
    }

    /// <summary>
    ///     Set the user context that is passed to the function callback.
    /// </summary>
    /// <param name="value">The user context.</param>
    /// <returns>Reference to self.</returns>
    public ref FunctionBuilder Ctx(void* value)
    {
        _context->Ctx = value;
        return ref this;
    }

    /// <summary>
    ///     Build the function.
    /// </summary>
    /// <returns>The function entity.</returns>
    public Entity Build()
    {
        ulong component = _isMethod ? FLECS_IDEcsScriptMethodID_ : FLECS_IDEcsScriptFunctionID_;

        ulong result;
        fixed (ecs_function_desc_t* desc = &Descriptor)
            result = _isMethod ? ecs_method_init(WorldPtr, desc) : ecs_function_init(WorldPtr, desc);

        // The binding context owns the delegate so flecs frees it; ctx->ctx is the raw pointer flecs passes back.
        if (result != 0 && _context != null)
        {
            ecs_script_function_t* function = (ecs_script_function_t*)ecs_ensure_id(
                WorldPtr, result, component, sizeof(ecs_script_function_t));

            function->ctx = _context;
            function->binding_ctx = _context;
            function->binding_ctx_free = &Functions.ScriptFunctionContextFree;
            _context = null;
        }

        Entity entity = new Entity(WorldPtr, result);
        Dispose();
        return entity;
    }

    private void EnsureVectorCallbacks()
    {
        if (_context->VectorCallbacks != null)
            return;

        _context->VectorCallbacks = Memory.AllocZeroed<Callback>(ScriptFunctionContext.VectorCallbackCount);
    }

    private void SetVectorCallback(int index,
        delegate* unmanaged<ecs_function_ctx_t*, int, ecs_value_t*, ecs_value_t*, int, void> value)
    {
        // The inline array cannot be indexed directly because function pointer types cannot be type arguments.
        fixed (ecs_function_desc_t* desc = &_desc)
            ((delegate* unmanaged<ecs_function_ctx_t*, int, ecs_value_t*, ecs_value_t*, int, void>*)&desc->vector_callbacks)[index] = value;
    }

    private static delegate* unmanaged<ecs_function_ctx_t*, int, ecs_value_t*, ecs_value_t*, int, void> VectorThunk(int index)
    {
        return index switch
        {
            1 => &Functions.ScriptVectorFunctionCallback1,
            2 => &Functions.ScriptVectorFunctionCallback2,
            3 => &Functions.ScriptVectorFunctionCallback3,
            4 => &Functions.ScriptVectorFunctionCallback4,
            5 => &Functions.ScriptVectorFunctionCallback5,
            6 => &Functions.ScriptVectorFunctionCallback6,
            7 => &Functions.ScriptVectorFunctionCallback7,
            8 => &Functions.ScriptVectorFunctionCallback8,
            9 => &Functions.ScriptVectorFunctionCallback9,
            10 => &Functions.ScriptVectorFunctionCallback10,
            11 => &Functions.ScriptVectorFunctionCallback11,
            12 => &Functions.ScriptVectorFunctionCallback12,
            13 => &Functions.ScriptVectorFunctionCallback13,
            14 => &Functions.ScriptVectorFunctionCallback14,
            15 => &Functions.ScriptVectorFunctionCallback15,
            16 => &Functions.ScriptVectorFunctionCallback16,
            17 => &Functions.ScriptVectorFunctionCallback17,
            _ => &Functions.ScriptVectorFunctionCallback0
        };
    }

    /// <summary>
    ///     Checks if two <see cref="FunctionBuilder"/> instances are equal.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public bool Equals(FunctionBuilder other)
    {
        return Descriptor == other.Descriptor;
    }

    /// <summary>
    ///     Checks if two <see cref="FunctionBuilder"/> instances are equal.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        return obj is FunctionBuilder other && Equals(other);
    }

    /// <summary>
    ///     Returns the hash code for the <see cref="FunctionBuilder"/>.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return Descriptor.GetHashCode();
    }

    /// <summary>
    ///     Checks if two <see cref="FunctionBuilder"/> instances are equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator ==(FunctionBuilder left, FunctionBuilder right)
    {
        return left.Equals(right);
    }

    /// <summary>
    ///     Checks if two <see cref="FunctionBuilder"/> instances are not equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator !=(FunctionBuilder left, FunctionBuilder right)
    {
        return !(left == right);
    }
}
