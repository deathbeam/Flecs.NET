using System;
using Flecs.NET.Utilities;

namespace Flecs.NET.Core.BindingContext;

internal unsafe struct PostFrameContext : IDisposable
{
    public Callback Callback;

    public void Dispose()
    {
        Callback.Dispose();
    }

    public static void Free(PostFrameContext* context)
    {
        if (context == null)
            return;
        context->Dispose();
        Memory.Free(context);
    }
}
