using System;
using Flecs.NET.Collections;
using Flecs.NET.Utilities;

namespace Flecs.NET.Core.BindingContext;

internal unsafe struct WorldContext : IDisposable
{
    public UserContext UserContext;

    public Callback UserContextFree;

    public NativeList<ulong> TypeCache;
    public NativeList<nint> RunPostFrameContexts; // Stores PostFrameContext*
    public NativeList<nint> WorldFinishContexts; // Stores WorldFinishContext*

    public void Dispose()
    {
        UserContext.Dispose();
        UserContextFree.Dispose();
        TypeCache.Dispose();

        foreach (nint ptr in RunPostFrameContexts)
            Memory.Free((PostFrameContext*)ptr);

        foreach (nint ptr in WorldFinishContexts)
            Memory.Free((WorldFinishContext*)ptr);
    }
}
