using Flecs.NET.Core;
using Xunit;

namespace Flecs.NET.Tests.Cpp;

public unsafe class ComponentTraitsTests
{
    [Fact]
    private void SparseGetGetMut()
    {
        using World world = World.Create();

        world.Component<TraitSparse>().Add(Ecs.Sparse);

        Entity e = world.Entity().Set(new TraitSparse(10, 20));

        ref readonly TraitSparse v = ref e.Get<TraitSparse>();
        Assert.Equal(10, v.X);
        Assert.Equal(20, v.Y);

        ref TraitSparse mv = ref e.GetMut<TraitSparse>();
        mv.X = 30;
        mv.Y = 40;

        TraitSparse* p = e.GetPtr<TraitSparse>();
        Assert.True(p != null);
        Assert.Equal(30, p->X);
        Assert.Equal(40, p->Y);
    }

    [Fact]
    private void SparseTryGetNotFound()
    {
        using World world = World.Create();

        world.Component<TraitSparse>().Add(Ecs.Sparse);

        Entity e = world.Entity();
        Assert.True(e.GetPtr<TraitSparse>() == null);
        Assert.True(e.GetMutPtr<TraitSparse>() == null);
    }

    [Fact]
    private void DontFragmentGetGetMut()
    {
        using World world = World.Create();

        world.Component<TraitDontFragment>().Add(Ecs.DontFragment);

        Entity e = world.Entity().Set(new TraitDontFragment(10, 20));

        ref readonly TraitDontFragment v = ref e.Get<TraitDontFragment>();
        Assert.Equal(10, v.X);
        Assert.Equal(20, v.Y);

        ref TraitDontFragment mv = ref e.GetMut<TraitDontFragment>();
        mv.X = 30;
        mv.Y = 40;

        TraitDontFragment* p = e.GetPtr<TraitDontFragment>();
        Assert.True(p != null);
        Assert.Equal(30, p->X);
        Assert.Equal(40, p->Y);

        Assert.True(world.Entity().GetPtr<TraitDontFragment>() == null);
    }

    [Fact]
    private void OnInstantiateOverrideGetGetMut()
    {
        using World world = World.Create();

        world.Component<TraitOnInstantiateOverride>().Add(Ecs.OnInstantiate, Ecs.Copy);

        Entity e = world.Entity().Set(new TraitOnInstantiateOverride(10, 20));

        ref readonly TraitOnInstantiateOverride v = ref e.Get<TraitOnInstantiateOverride>();
        Assert.Equal(10, v.X);
        Assert.Equal(20, v.Y);

        ref TraitOnInstantiateOverride mv = ref e.GetMut<TraitOnInstantiateOverride>();
        mv.X = 30;
        mv.Y = 40;

        TraitOnInstantiateOverride* p = e.GetPtr<TraitOnInstantiateOverride>();
        Assert.True(p != null);
        Assert.Equal(30, p->X);
        Assert.Equal(40, p->Y);

        Assert.True(world.Entity().GetPtr<TraitOnInstantiateOverride>() == null);
    }

    [Fact]
    private void OnInstantiateDontInheritGetGetMut()
    {
        using World world = World.Create();

        world.Component<TraitOnInstantiateDontInherit>().Add(Ecs.OnInstantiate, Ecs.DontInherit);

        Entity e = world.Entity().Set(new TraitOnInstantiateDontInherit(10, 20));

        ref readonly TraitOnInstantiateDontInherit v = ref e.Get<TraitOnInstantiateDontInherit>();
        Assert.Equal(10, v.X);
        Assert.Equal(20, v.Y);

        ref TraitOnInstantiateDontInherit mv = ref e.GetMut<TraitOnInstantiateDontInherit>();
        mv.X = 30;
        mv.Y = 40;

        TraitOnInstantiateDontInherit* p = e.GetPtr<TraitOnInstantiateDontInherit>();
        Assert.True(p != null);
        Assert.Equal(30, p->X);
        Assert.Equal(40, p->Y);
    }

    [Fact]
    private void OnInstantiateInheritGetInherited()
    {
        using World world = World.Create();

        world.Component<TraitOnInstantiateInherit>().Add(Ecs.OnInstantiate, Ecs.Inherit);

        Entity @base = world.Prefab().Set(new TraitOnInstantiateInherit(10, 20));
        Entity inst = world.Entity().IsA(@base);

        TraitOnInstantiateInherit* p = inst.GetPtr<TraitOnInstantiateInherit>();
        Assert.True(p != null);
        Assert.Equal(10, p->X);
        Assert.Equal(20, p->Y);

        Assert.True(inst.GetMutPtr<TraitOnInstantiateInherit>() == null);
    }

    [Fact]
    private void NoTraitsGetInherited()
    {
        using World world = World.Create();

        world.Component<TraitNone>().Add(Ecs.OnInstantiate, Ecs.Inherit);

        Entity @base = world.Prefab().Set(new TraitNone(10, 20));
        Entity inst = world.Entity().IsA(@base);

        TraitNone* p = inst.GetPtr<TraitNone>();
        Assert.True(p != null);
        Assert.Equal(10, p->X);
        Assert.Equal(20, p->Y);

        Assert.True(inst.GetMutPtr<TraitNone>() == null);
    }

    [Fact]
    private void DynamicInheritDenseOwned()
    {
        using World world = World.Create();

        world.Component<TraitNone>().Add(Ecs.OnInstantiate, Ecs.Inherit);

        Entity e = world.Entity().Set(new TraitNone(10, 20));

        TraitNone* p = e.GetPtr<TraitNone>();
        Assert.True(p != null);
        Assert.Equal(10, p->X);
        Assert.Equal(20, p->Y);

        TraitNone* mp = e.GetMutPtr<TraitNone>();
        Assert.True(mp != null);
        mp->X = 30;
        Assert.Equal(30, e.GetPtr<TraitNone>()->X);
    }

    [Fact]
    private void DynamicInheritDenseInherited()
    {
        using World world = World.Create();

        world.Component<TraitNone>().Add(Ecs.OnInstantiate, Ecs.Inherit);

        Entity @base = world.Prefab().Set(new TraitNone(10, 20));
        Entity inst = world.Entity().IsA(@base);

        TraitNone* p = inst.GetPtr<TraitNone>();
        Assert.True(p != null);
        Assert.Equal(10, p->X);
        Assert.Equal(20, p->Y);

        Assert.True(inst.GetMutPtr<TraitNone>() == null);
    }

    [Fact]
    private void StaticInheritDenseOwned()
    {
        using World world = World.Create();

        Component<TraitOnInstantiateInherit> c =
            world.Component<TraitOnInstantiateInherit>().Add(Ecs.OnInstantiate, Ecs.Inherit);
        Assert.True(c.Has(Ecs.OnInstantiate, Ecs.Inherit));

        Entity e = world.Entity().Set(new TraitOnInstantiateInherit(10, 20));

        TraitOnInstantiateInherit* p = e.GetPtr<TraitOnInstantiateInherit>();
        Assert.True(p != null);
        Assert.Equal(10, p->X);
        Assert.Equal(20, p->Y);

        TraitOnInstantiateInherit* mp = e.GetMutPtr<TraitOnInstantiateInherit>();
        Assert.True(mp != null);
        mp->X = 30;
        Assert.Equal(30, e.GetPtr<TraitOnInstantiateInherit>()->X);
    }

    [Fact]
    private void StaticInheritDenseInherited()
    {
        using World world = World.Create();

        world.Component<TraitOnInstantiateInherit>().Add(Ecs.OnInstantiate, Ecs.Inherit);

        Entity @base = world.Prefab().Set(new TraitOnInstantiateInherit(10, 20));
        Entity inst = world.Entity().IsA(@base);

        TraitOnInstantiateInherit* p = inst.GetPtr<TraitOnInstantiateInherit>();
        Assert.True(p != null);
        Assert.Equal(10, p->X);
        Assert.Equal(20, p->Y);

        Assert.True(inst.GetMutPtr<TraitOnInstantiateInherit>() == null);
    }

    [Fact]
    private void StaticInheritSparseOwned()
    {
        using World world = World.Create();

        Component<TraitSparseInherit> c = world.Component<TraitSparseInherit>()
            .Add(Ecs.Sparse)
            .Add(Ecs.OnInstantiate, Ecs.Inherit);
        Assert.True(c.Has(Ecs.Sparse));
        Assert.True(c.Has(Ecs.OnInstantiate, Ecs.Inherit));

        Entity e = world.Entity().Set(new TraitSparseInherit(10, 20));

        TraitSparseInherit* p = e.GetPtr<TraitSparseInherit>();
        Assert.True(p != null);
        Assert.Equal(10, p->X);
        Assert.Equal(20, p->Y);

        TraitSparseInherit* mp = e.GetMutPtr<TraitSparseInherit>();
        Assert.True(mp != null);
        mp->X = 30;
        Assert.Equal(30, e.GetPtr<TraitSparseInherit>()->X);
    }

    [Fact]
    private void StaticInheritSparseInherited()
    {
        using World world = World.Create();

        world.Component<TraitSparseInherit>()
            .Add(Ecs.Sparse)
            .Add(Ecs.OnInstantiate, Ecs.Inherit);

        Entity @base = world.Prefab().Set(new TraitSparseInherit(10, 20));
        Entity inst = world.Entity().IsA(@base);

        TraitSparseInherit* p = inst.GetPtr<TraitSparseInherit>();
        Assert.True(p != null);
        Assert.Equal(10, p->X);
        Assert.Equal(20, p->Y);

        Assert.True(inst.GetMutPtr<TraitSparseInherit>() == null);
    }

    [Fact]
    private void StaticInheritDontFragmentOwned()
    {
        using World world = World.Create();

        Component<TraitDontFragmentInherit> c = world.Component<TraitDontFragmentInherit>()
            .Add(Ecs.DontFragment)
            .Add(Ecs.OnInstantiate, Ecs.Inherit);
        Assert.True(c.Has(Ecs.DontFragment));
        Assert.True(c.Has(Ecs.OnInstantiate, Ecs.Inherit));

        Entity e = world.Entity().Set(new TraitDontFragmentInherit(10, 20));

        TraitDontFragmentInherit* p = e.GetPtr<TraitDontFragmentInherit>();
        Assert.True(p != null);
        Assert.Equal(10, p->X);
        Assert.Equal(20, p->Y);

        TraitDontFragmentInherit* mp = e.GetMutPtr<TraitDontFragmentInherit>();
        Assert.True(mp != null);
        mp->X = 30;
        Assert.Equal(30, e.GetPtr<TraitDontFragmentInherit>()->X);
    }

    [Fact]
    private void StaticInheritDontFragmentInherited()
    {
        using World world = World.Create();

        world.Component<TraitDontFragmentInherit>()
            .Add(Ecs.DontFragment)
            .Add(Ecs.OnInstantiate, Ecs.Inherit);

        Entity @base = world.Prefab().Set(new TraitDontFragmentInherit(10, 20));
        Entity inst = world.Entity().IsA(@base);

        TraitDontFragmentInherit* p = inst.GetPtr<TraitDontFragmentInherit>();
        Assert.True(p != null);
        Assert.Equal(10, p->X);
        Assert.Equal(20, p->Y);

        Assert.True(inst.GetMutPtr<TraitDontFragmentInherit>() == null);
    }
}
