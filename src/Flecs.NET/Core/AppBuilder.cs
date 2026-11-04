using System;
using Flecs.NET.Core.BindingContext;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     A wrapper around ecs_app_desc_t.
/// </summary>
public unsafe struct AppBuilder : IEquatable<AppBuilder>
{
    private World _world;
    private ecs_app_desc_t _desc;

    /// <summary>
    ///     The world.
    /// </summary>
    internal World WorldPtr => _world;

    /// <summary>
    ///     Reference to app description.
    /// </summary>
    internal ref ecs_app_desc_t Descriptor => ref _desc;

    /// <summary>
    ///     Creates an app builder for world.
    /// </summary>
    /// <param name="world"></param>
    public AppBuilder(World world)
    {
        _world = world;
        _desc = default;

        ecs_world_info_t* stats = ecs_get_world_info(world);
        Descriptor.target_fps = stats->target_fps;

        if (Math.Abs(Descriptor.target_fps - 0) < 0.01)
            Descriptor.target_fps = 60;
    }

    /// <summary>
    ///     Sets the target fps.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public ref AppBuilder TargetFps(float value)
    {
        Descriptor.target_fps = value;
        return ref this;
    }

    /// <summary>
    ///     Sets the delta time.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public ref AppBuilder DeltaTime(float value)
    {
        Descriptor.delta_time = value;
        return ref this;
    }

    /// <summary>
    ///     Sets the number of threads to use.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public ref AppBuilder Threads(int value)
    {
        Descriptor.threads = value;
        return ref this;
    }

    /// <summary>
    ///     Sets the number of frames to run.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public ref AppBuilder Frames(int value)
    {
        Descriptor.frames = value;
        return ref this;
    }

    /// <summary>
    ///     Enable ecs access over http for the explorer.
    /// </summary>
    /// <param name="port"></param>
    /// <returns></returns>
    public ref AppBuilder EnableRest(ushort port = 0)
    {
        Descriptor.enable_rest = true;
        Descriptor.port = port;
        return ref this;
    }

    /// <summary>
    ///     Periodically collect statistics.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public ref AppBuilder EnableStats(bool value = true)
    {
        Descriptor.enable_stats = value;
        return ref this;
    }

    /// <summary>
    ///     Sets a callback to be run before starting the main loop.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <returns></returns>
    public ref AppBuilder Init(Ecs.AppInitCallback callback)
    {
        WorldPtr.WorldContext.AppInit.Set(callback, (delegate*<World, WorldContext*, void>)&Functions.AppInitCallbackDelegate);
        Descriptor.init = &Functions.AppInitCallback;
        return ref this;
    }

    /// <summary>
    ///     Sets a callback to be run before starting the main loop.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <returns></returns>
    public ref AppBuilder Init(delegate*<World, void> callback)
    {
        WorldPtr.WorldContext.AppInit.Set(callback, (delegate*<World, WorldContext*, void>)&Functions.AppInitCallbackPointer);
        Descriptor.init = &Functions.AppInitCallback;
        return ref this;
    }

    /// <summary>
    ///     Runs the app.
    /// </summary>
    /// <returns></returns>
    public int Run()
    {
        fixed (ecs_app_desc_t* appDesc = &Descriptor)
            return ecs_app_run(WorldPtr, appDesc);
    }

    /// <summary>
    ///     Checks if two <see cref="AppBuilder"/> instances are equal.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public bool Equals(AppBuilder other)
    {
        return Descriptor == other.Descriptor;
    }

    /// <summary>
    ///     Checks if two <see cref="AppBuilder"/> instances are equal.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        return obj is AppBuilder other && Equals(other);
    }

    /// <summary>
    ///     Gets the hash code of the <see cref="AppBuilder"/>.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return Descriptor.GetHashCode();
    }

    /// <summary>
    ///     Checks if two <see cref="AppBuilder"/> instances are equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator ==(AppBuilder left, AppBuilder right)
    {
        return left.Equals(right);
    }

    /// <summary>
    ///     Checks if two <see cref="AppBuilder"/> instances are not equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator !=(AppBuilder left, AppBuilder right)
    {
        return !(left == right);
    }
}