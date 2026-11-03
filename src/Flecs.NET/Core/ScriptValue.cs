using System.Diagnostics.CodeAnalysis;
using Flecs.NET.Utilities;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     A wrapper around a script function argument or result value.
/// </summary>
[SuppressMessage("Performance", "CA1815", Justification = "Script values are transient views of callback memory.")]
public unsafe readonly struct ScriptValue
{
    private readonly ecs_value_t* _handle;

    internal ScriptValue(ecs_value_t* handle)
    {
        _handle = handle;
    }

    /// <summary>
    ///     The value type entity.
    /// </summary>
    public ulong Type => _handle->type;

    /// <summary>
    ///     The pointer to the value.
    /// </summary>
    [SuppressMessage("Naming", "CA1721", Justification = "Ptr matches the ecs_value_t field name.")]
    public void* Ptr => _handle->ptr;

    /// <summary>
    ///     Gets a reference to the value.
    /// </summary>
    /// <typeparam name="T">The value type.</typeparam>
    public ref T Get<T>()
    {
        return ref Managed.GetTypeRef<T>(_handle->ptr);
    }

    /// <summary>
    ///     Gets a pointer to the value.
    /// </summary>
    /// <typeparam name="T">The value type.</typeparam>
    public T* GetPtr<T>() where T : unmanaged
    {
        return (T*)_handle->ptr;
    }
}

/// <summary>
///     A view over the arguments passed to a script function callback.
/// </summary>
/// <remarks>
///     For method callbacks the instance value is passed at index 0 and is not included in <see cref="Count"/>.
/// </remarks>
public readonly unsafe ref struct ScriptArgs
{
    private readonly ecs_value_t* _values;
    private readonly int _count;

    internal ScriptArgs(ecs_value_t* values, int count)
    {
        _values = values;
        _count = count;
    }

    /// <summary>
    ///     The number of arguments.
    /// </summary>
    public int Count => _count;

    /// <summary>
    ///     Gets the argument at the specified index.
    /// </summary>
    /// <param name="index">The argument index.</param>
    public ScriptValue this[int index]
    {
        get
        {
            return new ScriptValue(&_values[index]);
        }
    }
}
