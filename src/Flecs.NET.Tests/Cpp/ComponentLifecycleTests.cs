using Flecs.NET.Core;
using Xunit;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Tests.Cpp;

public unsafe class ComponentLifecycleTests
{
    private struct WithoutOperators
    {
        public int Value;
    }

    private static int Compare(World world, ulong id, void* a, void* b)
    {
        ecs_type_info_t* ti = ecs_get_type_info(world, id);
        return ti->hooks.cmp(a, b, ti);
    }

    private static bool AreEqual(World world, ulong id, void* a, void* b)
    {
        ecs_type_info_t* ti = ecs_get_type_info(world, id);
        return ti->hooks.equals(a, b, ti);
    }

    [Fact]
    private void CompareWithoutOperators()
    {
        using World world = World.Create();

        Component<WithoutOperators> component = world.Component<WithoutOperators>();

        ecs_type_hooks_t hooks = component.UntypedComponent.GetHooks();
        Assert.True((hooks.flags & ECS_TYPE_HOOK_CMP_ILLEGAL) != 0);
        Assert.True((hooks.flags & ECS_TYPE_HOOK_EQUALS_ILLEGAL) != 0);

        // Define operator equals via an explicit callback.
        component.OnEquals((ref WithoutOperators a, ref WithoutOperators b, TypeInfo _) => a.Value == b.Value);

        hooks = component.UntypedComponent.GetHooks();
        Assert.True((hooks.flags & ECS_TYPE_HOOK_CMP_ILLEGAL) != 0);
        Assert.True((hooks.flags & ECS_TYPE_HOOK_EQUALS_ILLEGAL) == 0);

        WithoutOperators a = new() { Value = 1 };
        WithoutOperators b = new() { Value = 2 };
        WithoutOperators c = new() { Value = 1 };

        Assert.False(AreEqual(world, component, &a, &b));
        Assert.True(AreEqual(world, component, &a, &c));
        Assert.True(AreEqual(world, component, &a, &a));

        component.OnCompare((ref WithoutOperators a, ref WithoutOperators b, TypeInfo _) => a.Value - b.Value);

        hooks = component.UntypedComponent.GetHooks();
        Assert.True((hooks.flags & ECS_TYPE_HOOK_CMP_ILLEGAL) == 0);
        Assert.True((hooks.flags & ECS_TYPE_HOOK_EQUALS_ILLEGAL) == 0);

        Assert.True(Compare(world, component, &a, &b) < 0);
        Assert.True(Compare(world, component, &b, &a) > 0);
        Assert.Equal(0, Compare(world, component, &a, &c));
        Assert.True(Compare(world, component, &b, &c) > 0);
        Assert.True(Compare(world, component, &c, &b) < 0);
        Assert.Equal(0, Compare(world, component, &b, &b));
    }

    [Fact]
    private void CompareAndEqualsUntyped()
    {
        using World world = World.Create();

        Component<WithoutOperators> component = world.Component<WithoutOperators>();

        component.UntypedComponent.OnEquals(UntypedEquals);

        ecs_type_hooks_t hooks = component.UntypedComponent.GetHooks();
        Assert.True((hooks.flags & ECS_TYPE_HOOK_CMP_ILLEGAL) != 0);
        Assert.True((hooks.flags & ECS_TYPE_HOOK_EQUALS_ILLEGAL) == 0);

        WithoutOperators a = new() { Value = 1 };
        WithoutOperators b = new() { Value = 2 };

        Assert.False(AreEqual(world, component, &a, &b));
        Assert.True(AreEqual(world, component, &a, &a));

        component.UntypedComponent.OnCompare(UntypedCompare);

        hooks = component.UntypedComponent.GetHooks();
        Assert.True((hooks.flags & ECS_TYPE_HOOK_CMP_ILLEGAL) == 0);
        Assert.True((hooks.flags & ECS_TYPE_HOOK_EQUALS_ILLEGAL) == 0);

        Assert.True(Compare(world, component, &a, &b) < 0);
        Assert.True(Compare(world, component, &b, &a) > 0);
        Assert.Equal(0, Compare(world, component, &a, &a));
    }

    [Fact]
    private void SetHooksRoundTrip()
    {
        using World world = World.Create();

        Component<WithoutOperators> component = world.Component<WithoutOperators>();

        ecs_type_hooks_t hooks = component.UntypedComponent.GetHooks();
        component.UntypedComponent.SetHooks(ref hooks);

        Assert.True((component.UntypedComponent.GetHooks().flags & ECS_TYPE_HOOK_CMP_ILLEGAL) != 0);
    }

    [Fact]
    private void DeleteWOnRemoveHookRemovingOtherWStage()
    {
        using World world = World.Create();

        world.Component<Position>().OnRemove((Entity e, ref Position p) => { e.Remove<Velocity>(); });

        Entity e = world.Entity().Add<Position>().Add<Velocity>();

        e.Destruct();

        Assert.False(e.IsAlive());
    }

    private static int UntypedCompare(void* a, void* b, TypeInfo ti)
    {
        return ((WithoutOperators*)a)->Value - ((WithoutOperators*)b)->Value;
    }

    private static bool UntypedEquals(void* a, void* b, TypeInfo ti)
    {
        return ((WithoutOperators*)a)->Value == ((WithoutOperators*)b)->Value;
    }
}
