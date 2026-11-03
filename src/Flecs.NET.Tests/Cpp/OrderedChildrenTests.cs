using Flecs.NET.Core;
using Xunit;

namespace Flecs.NET.Tests.Cpp;

public unsafe class OrderedChildrenTests
{
    [Fact]
    private void IterNoChildren()
    {
        using World world = World.Create();

        Entity parent = world.Entity().Add(Ecs.OrderedChildren);

        int count = 0;
        parent.Children((Entity _) => { count++; });

        Assert.Equal(0, count);
    }

    [Fact]
    private void Children1Table()
    {
        using World world = World.Create();

        Entity parent = world.Entity().Add(Ecs.OrderedChildren);
        Entity childA = world.Entity().ChildOf(parent).Add<Position>();
        Entity childB = world.Entity().ChildOf(parent).Add<Position>();
        Entity childC = world.Entity().ChildOf(parent).Add<Position>();

        int index = 0;
        Entity[] children = [childA, childB, childC];

        parent.Children((Entity e) => { Assert.Equal(children[index++], e); });

        Assert.Equal(3, index);
    }

    [Fact]
    private void Children2Tables()
    {
        using World world = World.Create();

        Entity parent = world.Entity().Add(Ecs.OrderedChildren);
        Entity childA = world.Entity().ChildOf(parent).Add<Position>();
        Entity childB = world.Entity().ChildOf(parent).Add<Velocity>();
        Entity childC = world.Entity().ChildOf(parent).Add<Position>();

        int index = 0;
        Entity[] children = [childA, childB, childC];

        parent.Children((Entity e) => { Assert.Equal(children[index++], e); });

        Assert.Equal(3, index);
    }

    [Fact]
    private void SetChildOrder()
    {
        using World world = World.Create();

        Entity parent = world.Entity().Add(Ecs.OrderedChildren);
        Entity childA = world.Entity().ChildOf(parent).Add<Position>();
        Entity childB = world.Entity().ChildOf(parent).Add<Position>();
        Entity childC = world.Entity().ChildOf(parent).Add<Position>();

        int index = 0;
        Entity[] children = [childA, childB, childC];

        parent.Children((Entity e) => { Assert.Equal(children[index++], e); });
        Assert.Equal(3, index);

        ulong* entities = stackalloc ulong[] { childC, childA, childB };
        parent.SetChildOrder(entities, 3);

        index = 0;
        Entity[] reordered = [childC, childA, childB];

        parent.Children((Entity e) => { Assert.Equal(reordered[index++], e); });
        Assert.Equal(3, index);
    }
}
