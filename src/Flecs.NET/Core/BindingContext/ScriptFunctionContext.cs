using System;
using Flecs.NET.Utilities;

namespace Flecs.NET.Core.BindingContext;

internal unsafe struct ScriptFunctionContext : IDisposable
{
    public const int VectorCallbackCount = 18;

    public Callback Callback;
    public Callback* VectorCallbacks;
    public void* Ctx;

    public void Dispose()
    {
        Callback.Dispose();

        if (VectorCallbacks == null)
            return;

        for (int i = 0; i < VectorCallbackCount; i++)
            VectorCallbacks[i].Dispose();

        Memory.Free(VectorCallbacks);
        VectorCallbacks = null;
    }

    public static void Free(ScriptFunctionContext* context)
    {
        if (context == null)
            return;
        context->Dispose();
        Memory.Free(context);
    }
}
