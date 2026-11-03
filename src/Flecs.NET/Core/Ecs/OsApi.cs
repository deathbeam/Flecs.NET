using System;
using Flecs.NET.Core.BindingContext;
using Flecs.NET.Utilities;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

public static unsafe partial class Ecs
{
    /// <summary>
    ///     Static class for overriding the os api.
    ///     The setters are not thread-safe and should be called at startup, before logging starts.
    /// </summary>
    public static class Os
    {
        internal static OsApiContext Context;

        /// <summary>
        ///     Determines whether the abort function can be overriden by Flecs.NET. If set to false,
        ///     the abort function provided by flecs will be used. This should be set before the first call
        ///     to World.Create();
        /// </summary>
        public static bool OverrideAbort { get; set; } = true;

        /// <summary>
        ///     Determines whether the log function can be overriden by Flecs.NET. If set to false,
        ///     the log provided by flecs will be used. This should be set before the first call
        ///     to World.Create();
        /// </summary>
        public static bool OverrideLog { get; set; } = true;

        /// <summary>
        ///     Determines whether the trace push function can be overriden by Flecs.NET. If set to false,
        ///     the trace push function provided by flecs will be used. This should be set before the first call
        ///     to World.Create();
        /// </summary>
        public static bool OverrideTracePush { get; set; } = true;

        /// <summary>
        ///     Determines whether the trace pop function can be overriden by Flecs.NET. If set to false,
        ///     the trace pop function provided by flecs will be used. This should be set before the first call
        ///     to World.Create();
        /// </summary>
        public static bool OverrideTracePop { get; set; } = true;

        /// <summary>
        ///     Applies the default abort callback and the configured overrides to the native os api.
        /// </summary>
        internal static void OverrideOsApi()
        {
            if (OverrideAbort && Context.Abort == default)
                SetAbort(&DefaultAbort);

            ApplyOsApi();
        }

        /// <summary>
        ///     Reapplies the overrides to the native os api. Flecs installs its default os api on the
        ///     first ecs_init(), which overwrites them, so this has to run after world creation.
        /// </summary>
        internal static void ApplyOsApi()
        {
            if (OverrideAbort)
                ecs_os_api.abort_ = &Functions.AbortCallback;

            if (OverrideLog && Context.Log != default)
                ecs_os_api.log_ = &Functions.LogCallback;

            if (OverrideTracePush && Context.TracePush != default)
                ecs_os_api.perf_trace_push_ = &Functions.TracePushCallback;

            if (OverrideTracePop && Context.TracePop != default)
                ecs_os_api.perf_trace_pop_ = &Functions.TracePopCallback;
        }

        /// <summary>
        ///     Sets os api abort callback.
        /// </summary>
        /// <param name="callback">The callback.</param>
        public static void SetAbort(Action callback)
        {
            Context.Abort.Set(callback, (delegate*<void>)&Functions.AbortCallbackDelegate);
            ApplyOsApi();
        }

        /// <summary>
        ///     Sets os api abort callback.
        /// </summary>
        /// <param name="callback">The callback.</param>
        public static void SetAbort(delegate*<void> callback)
        {
            Context.Abort.Set(callback, (delegate*<void>)&Functions.AbortCallbackPointer);
            ApplyOsApi();
        }

        /// <summary>
        ///     Sets the os api log callback.
        /// </summary>
        /// <param name="callback">The callback.</param>
        public static void SetLog(LogCallback callback)
        {
            Context.Log.Set(callback, (delegate*<int, byte*, int, byte*, void>)&Functions.LogCallbackDelegate);
            ApplyOsApi();
        }

        /// <summary>
        ///     Sets the os api log callback.
        /// </summary>
        /// <param name="callback">The callback.</param>
        public static void SetLog(delegate*<int, string, int, string, void> callback)
        {
            Context.Log.Set(callback, (delegate*<int, byte*, int, byte*, void>)&Functions.LogCallbackPointer);
            ApplyOsApi();
        }

        /// <summary>
        ///     Sets the os api trace push callback.
        /// </summary>
        /// <param name="callback">The callback.</param>
        public static void SetTracePush(TraceCallback callback)
        {
            Context.TracePush.Set(callback, (delegate*<byte*, ulong, byte*, void>)&Functions.TracePushCallbackDelegate);
            ApplyOsApi();
        }

        /// <summary>
        ///     Sets the os api trace push callback.
        /// </summary>
        /// <param name="callback">The callback.</param>
        public static void SetTracePush(delegate*<string, ulong, string, void> callback)
        {
            Context.TracePush.Set(callback, (delegate*<byte*, ulong, byte*, void>)&Functions.TracePushCallbackPointer);
            ApplyOsApi();
        }

        /// <summary>
        ///     Sets the os api trace pop callback.
        /// </summary>
        /// <param name="callback">The callback.</param>
        public static void SetTracePop(TraceCallback callback)
        {
            Context.TracePop.Set(callback, (delegate*<byte*, ulong, byte*, void>)&Functions.TracePopCallbackDelegate);
            ApplyOsApi();
        }

        /// <summary>
        ///     Sets the os api trace pop callback.
        /// </summary>
        /// <param name="callback">The callback.</param>
        public static void SetTracePop(delegate*<string, ulong, string, void> callback)
        {
            Context.TracePop.Set(callback, (delegate*<byte*, ulong, byte*, void>)&Functions.TracePopCallbackPointer);
            ApplyOsApi();
        }

        private static void DefaultAbort()
        {
            int error = ecs_log_last_error();
            string description = error != 0
                ? NativeString.GetString(ecs_strerror(error))
                : "no error code was logged";

            Environment.FailFast(
                $"Application aborted from native code. " +
                $"Flecs error code: {error} ({description}).");
        }
    }
}
