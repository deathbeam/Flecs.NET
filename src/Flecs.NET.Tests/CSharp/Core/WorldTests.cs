using System.Runtime.InteropServices;
using Flecs.NET.Core;
using Flecs.NET.Core.BindingContext;
using Flecs.NET.Utilities;
using Xunit;

namespace Flecs.NET.Tests.CSharp.Core;

public unsafe class WorldTests
{
    [Fact]
    public void RunPostFrameContextsAreFreedAfterRunning()
    {
        using World world = World.Create();

        int count = 0;

        world.System()
            .Iter((Iter it) => it.World().RunPostFrame((World _) => count++));

        for (int i = 0; i < 10; i++)
            world.Progress();

        Assert.Equal(10, count);
        Assert.Equal(0, world.WorldContext.RunPostFrameContexts.Count);
    }

    [Fact]
    public void RunPostFrameWithDirtyContextMemory()
    {
        using World world = World.Create();

        int count = 0;

        world.System().Iter((Iter it) =>
        {
            // Simulate an allocator that returns non-zeroed memory for the context.
            for (int i = 0; i < 16; i++)
            {
                PostFrameContext* context = Memory.Alloc<PostFrameContext>(1);
                context->Callback.Delegate = (GCHandle)(nint)1;
                context->Callback.Invoker = (void*)(nint)1;
                context->Callback.Pointer = (void*)(nint)1;
                Memory.Free(context);
            }

            it.World().RunPostFrame((World _) => count++);
        });

        world.Progress();

        Assert.Equal(1, count);
    }
}
