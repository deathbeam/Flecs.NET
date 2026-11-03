using System;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     A parsed script. Parsing is done once with <see cref="World.ScriptParse(string, string)"/>, after which the
///     script can be evaluated any number of times with <see cref="Eval()"/>.
/// </summary>
/// <remarks>
///     This type owns a native script object, so dispose it when it is no longer used.
/// </remarks>
public sealed unsafe class ParsedScript : IDisposable, IEquatable<ParsedScript>
{
    private ecs_script_t* _handle;

    /// <summary>
    ///     Constructs a parsed script from an <see cref="ecs_script_t"/> pointer.
    /// </summary>
    /// <param name="handle">The script handle.</param>
    public ParsedScript(ecs_script_t* handle)
    {
        _handle = handle;
    }

    /// <summary>
    ///     Returns true if the script was parsed successfully.
    /// </summary>
    public bool IsValid => _handle != null;

    /// <summary>
    ///     Evaluates the parsed script.
    /// </summary>
    /// <returns>Zero if success, non-zero if failed.</returns>
    public int Eval()
    {
        return Eval(null, null);
    }

    /// <summary>
    ///     Evaluates the parsed script.
    /// </summary>
    /// <param name="desc">The eval parameters.</param>
    /// <param name="result">The eval result.</param>
    /// <returns>Zero if success, non-zero if failed.</returns>
    public int Eval(ref ecs_script_eval_desc_t desc, ref ecs_script_eval_result_t result)
    {
        fixed (ecs_script_eval_desc_t* descPtr = &desc)
        fixed (ecs_script_eval_result_t* resultPtr = &result)
            return Eval(descPtr, resultPtr);
    }

    /// <summary>
    ///     Evaluates the parsed script.
    /// </summary>
    /// <param name="desc">The eval parameters.</param>
    /// <param name="result">The eval result.</param>
    /// <returns>Zero if success, non-zero if failed.</returns>
    public int Eval(ecs_script_eval_desc_t* desc, ecs_script_eval_result_t* result)
    {
        return _handle == null ? -1 : ecs_script_eval(_handle, desc, result);
    }

    /// <summary>
    ///     Frees the parsed script.
    /// </summary>
    public void Dispose()
    {
        if (_handle == null)
            return;

        ecs_script_free(_handle);
        _handle = null;
    }

    /// <summary>
    ///     Checks if two <see cref="ParsedScript"/> instances are equal.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public bool Equals(ParsedScript? other)
    {
        return ReferenceEquals(this, other) || (other is not null && _handle == other._handle);
    }

    /// <summary>
    ///     Checks if two <see cref="ParsedScript"/> instances are equal.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        return obj is ParsedScript other && Equals(other);
    }

    /// <summary>
    ///     Returns the hash code for the <see cref="ParsedScript"/>.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return ((nint)_handle).GetHashCode();
    }

    /// <summary>
    ///     Checks if two <see cref="ParsedScript"/> instances are equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator ==(ParsedScript? left, ParsedScript? right)
    {
        return left is null ? right is null : left.Equals(right);
    }

    /// <summary>
    ///     Checks if two <see cref="ParsedScript"/> instances are not equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator !=(ParsedScript? left, ParsedScript? right)
    {
        return !(left == right);
    }
}
