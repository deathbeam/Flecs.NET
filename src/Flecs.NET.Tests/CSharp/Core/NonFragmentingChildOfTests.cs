using Flecs.NET.Core;
using Xunit;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Tests.CSharp.Core;

public class NonFragmentingChildOfTests
{
    [Fact]
    private void SetParent()
    {
        using World world = World.Create();

        Entity parent = world.Entity();
        Entity child = world.Entity().Set(new EcsParent { value = parent });

        Assert.Equal(parent, child.Parent());
        Assert.True(child.IsChildOf(parent));

        int count = 0;
        parent.Children((Entity actual) =>
        {
            Assert.Equal(child, actual);
            count++;
        });

        Assert.Equal(1, count);
    }

    [Fact]
    private void SetParentWithTwoChildren()
    {
        using World world = World.Create();

        Entity parent = world.Entity();
        Entity childA = world.Entity().Set(new EcsParent { value = parent });
        Entity childB = world.Entity().Set(new EcsParent { value = parent });

        int count = 0;
        parent.Children((Entity child) =>
        {
            Assert.Equal(count == 0 ? childA : childB, child);
            count++;
        });

        Assert.Equal(2, count);
    }

    [Fact]
    private void RemoveParent()
    {
        using World world = World.Create();

        Entity parent = world.Entity();
        Entity child = world.Entity().Set(new EcsParent { value = parent });
        child.Remove<EcsParent>();

        Assert.True(child.Parent() == 0);
        Assert.False(child.IsChildOf(parent));

        int count = 0;
        parent.Children((Entity _) => count++);
        Assert.Equal(0, count);
    }

    [Fact]
    private void Reparent()
    {
        using World world = World.Create();

        Entity parentA = world.Entity();
        Entity parentB = world.Entity();
        Entity child = world.Entity().Set(new EcsParent { value = parentA });
        child.Set(new EcsParent { value = parentB });

        int countA = 0;
        parentA.Children((Entity _) => countA++);

        int countB = 0;
        parentB.Children((Entity actual) =>
        {
            Assert.Equal(child, actual);
            countB++;
        });

        Assert.Equal(0, countA);
        Assert.Equal(1, countB);
        Assert.Equal(parentB, child.Parent());
    }

    [Fact]
    private void MixedChildOf()
    {
        using World world = World.Create();

        Entity parent = world.Entity();
        Entity parentComponentChild = world.Entity()
            .Set(new EcsParent { value = parent });
        Entity pairChild = world.Entity().ChildOf(parent);

        int count = 0;
        parent.Children((Entity child) =>
        {
            Assert.Equal(count == 0 ? parentComponentChild : pairChild, child);
            count++;
        });

        Assert.Equal(2, count);
    }

    [Fact]
    private void DeleteParent()
    {
        using World world = World.Create();

        Entity parentA = world.Entity();
        Entity parentB = world.Entity();
        Entity childA = world.Entity().Set(new EcsParent { value = parentA });
        Entity childB = world.Entity().ChildOf(parentA);
        Entity otherChild = world.Entity().Set(new EcsParent { value = parentB });

        parentA.Destruct();

        Assert.False(parentA.IsAlive());
        Assert.False(childA.IsAlive());
        Assert.False(childB.IsAlive());
        Assert.True(otherChild.IsAlive());
    }
}
