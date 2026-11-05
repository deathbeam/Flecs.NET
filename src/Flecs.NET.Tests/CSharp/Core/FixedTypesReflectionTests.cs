using System;
using Flecs.NET.Core;
using Xunit;

namespace Flecs.NET.Tests.CSharp.Core
{
    public unsafe class FixedTypesReflectionTests
    {
        [Fact]
        private void SetAndGet()
        {
            using World world = World.Create();

            Entity entity = world.Entity("e1").Set(CreatePlayer("hello", 42, 1, 2, 3));

            FixedPlayer player = entity.Get<FixedPlayer>();

            Assert.Equal("hello", player.Name.ToString());
            Assert.Equal(42, player.Score);
            Assert.Equal(3, player.Items.Count);
            Assert.Equal(1, player.Items[0]);
            Assert.Equal(3, player.Items[2]);
        }

        [Fact]
        private void CloneCopiesValues()
        {
            using World world = World.Create();

            Entity entity = world.Entity("e1").Set(CreatePlayer("hello", 42, 1, 2, 3));
            Entity clone = entity.Clone();

            FixedPlayer cloned = clone.Get<FixedPlayer>();
            cloned.Name.TryCopyFrom("changed");
            cloned.Items.RemoveAt(0);
            cloned.Score = 7;
            clone.Set(cloned);

            FixedPlayer original = entity.Get<FixedPlayer>();

            Assert.Equal("hello", original.Name.ToString());
            Assert.Equal(42, original.Score);
            Assert.Equal(3, original.Items.Count);
            Assert.Equal(1, original.Items[0]);

            FixedPlayer updated = clone.Get<FixedPlayer>();
            Assert.Equal("changed", updated.Name.ToString());
            Assert.Equal(7, updated.Score);
            Assert.Equal(2, updated.Items.Count);
        }

        [Fact]
        private void PrefabInstantiateCopiesValues()
        {
            using World world = World.Create();

            Entity prefab = world.Prefab("p1").Set(CreatePlayer("prefab", 42, 1, 2, 3));
            Entity instance = world.Entity("e1").IsA(prefab);

            FixedPlayer player = instance.Get<FixedPlayer>();

            Assert.Equal("prefab", player.Name.ToString());
            Assert.Equal(42, player.Score);
            Assert.Equal(3, player.Items.Count);
        }

        [Fact]
        private void TableMovePreservesValues()
        {
            using World world = World.Create();

            Entity entity = world.Entity("e1").Set(CreatePlayer("hello", 42, 1, 2, 3));
            entity.Add<Tag>();

            FixedPlayer player = entity.Get<FixedPlayer>();

            Assert.Equal("hello", player.Name.ToString());
            Assert.Equal(42, player.Score);
            Assert.Equal(3, player.Items.Count);
        }

        [Fact]
        private void DeleteDoesNotCrash()
        {
            using World world = World.Create();

            Entity entity = world.Entity("e1").Set(CreatePlayer("hello", 42, 1, 2, 3));
            entity.Destruct();

            Assert.False(entity.IsAlive());
        }

        [Fact]
        private void JsonRoundTrip()
        {
            using World world = World.Create();

            Entity entity = world.Entity("e1").Set(CreatePlayer("hello", 42, 1, 2, 3));
            string json = entity.ToJson();

            Assert.Contains("hello", json);
            Assert.Contains("[1, 2, 3]", json);
            Assert.Contains("42", json);

            Entity deserialized = world.Entity("e2").SetJson<FixedPlayer>("""
                {"Name": "world", "Items": [7, 8], "Score": 1}
                """);

            FixedPlayer player = deserialized.Get<FixedPlayer>();

            Assert.Equal("world", player.Name.ToString());
            Assert.Equal(1, player.Score);
            Assert.Equal(2, player.Items.Count);
            Assert.Equal(7, player.Items[0]);
            Assert.Equal(8, player.Items[1]);
        }

        [Fact]
        private void JsonTruncatesOverlongStringAndClampsArray()
        {
            using World world = World.Create();

            Entity entity = world.Entity("e1").SetJson<FixedPlayer>("""
                {"Name": "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "Items": [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]}
                """);

            FixedPlayer player = entity.Get<FixedPlayer>();

            // FlecsString64 stores at most 62 bytes, the array keeps the first elements and the
            // last parsed value in the final slot.
            Assert.Equal(FlecsString64.Capacity, player.Name.Length);
            Assert.Equal(FlecsArray8<int>.Capacity, player.Items.Count);
            Assert.Equal(1, player.Items[0]);
            Assert.Equal(8, player.Items[FlecsArray8<int>.Capacity - 1]);
        }

        [Fact]
        private void ScriptAssignsValues()
        {
            using World world = World.Create();

            Entity entity = world.Entity("e1").Set(default(FixedPlayer));

            world.ScriptRun("fixed_types", """
                e1 { FixedPlayer: { Name: "script", Items: [1, 2, 3], Score: 5 } }
                """);

            FixedPlayer player = entity.Get<FixedPlayer>();

            Assert.Equal("script", player.Name.ToString());
            Assert.Equal(5, player.Score);
            Assert.Equal(3, player.Items.Count);
            Assert.Equal(1, player.Items[0]);
            Assert.Equal(3, player.Items[2]);
        }

        [Fact]
        private void ScriptTruncatesOverlongString()
        {
            using World world = World.Create();

            Entity entity = world.Entity("e1").Set(default(FixedPlayer));

            world.ScriptRun("fixed_types_truncate", """
                e1 { FixedPlayer: { Name: "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" } }
                """);

            FixedPlayer player = entity.Get<FixedPlayer>();

            // FlecsString64 stores at most 62 bytes.
            Assert.Equal(FlecsString64.Capacity, player.Name.Length);
            Assert.Equal(new string('a', FlecsString64.Capacity), player.Name.ToString());
        }

        [Fact]
        private void ScriptClampsOverCapacityArray()
        {
            using World world = World.Create();

            Entity entity = world.Entity("e1").Set(default(FixedPlayer));

            world.ScriptRun("fixed_types_clamp", """
                e1 { FixedPlayer: { Items: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] } }
                """);

            FixedPlayer player = entity.Get<FixedPlayer>();

            // The array keeps the first elements and the last parsed value in the final slot.
            Assert.Equal(FlecsArray8<int>.Capacity, player.Items.Count);
            Assert.Equal(1, player.Items[0]);
            Assert.Equal(8, player.Items[FlecsArray8<int>.Capacity - 1]);
        }

        [Fact]
        private void JsonSerializesNestedArrays()
        {
            using World world = World.Create();

            Entity entity = world.Entity("e1").Set(new FixedStrings { Names = ["a", "b"] });
            string json = entity.ToJson();

            Assert.Contains("[\"a\", \"b\"]", json);
        }

        [Fact]
        private void DirectComponents()
        {
            using World world = World.Create();

            Entity name = world.Entity("e1").Set(new FlecsString64("hello"));
            FlecsArray8<int> array = [1, 2, 3];
            Entity items = world.Entity("e2").Set(array);

            Assert.Contains("\"hello\"", name.ToJson());
            Assert.Contains("[1, 2, 3]", items.ToJson());

            Assert.Equal("hello", name.Get<FlecsString64>().ToString());
            Assert.Equal(3, items.Get<FlecsArray8<int>>().Count);

            Assert.True(world.FromJson(Type<FlecsString64>.Id(world), name.GetMutPtr<FlecsString64>(), "\"world\""));
            Assert.Equal("world", name.Get<FlecsString64>().ToString());

            Assert.True(world.FromJson(Type<FlecsArray8<int>>.Id(world), items.GetMutPtr<FlecsArray8<int>>(), "[7, 8]"));
            Assert.Equal(2, items.Get<FlecsArray8<int>>().Count);
            Assert.Equal(7, items.Get<FlecsArray8<int>>()[0]);
        }

        private static FixedPlayer CreatePlayer(string name, int score, params int[] items)
        {
            FixedPlayer player = default;
            player.Name.TryCopyFrom(name);
            player.Score = score;

            foreach (int item in items)
                player.Items.Add(item);

            return player;
        }
    }
}

internal struct FixedPlayer : IFlecsStruct
{
    public FlecsString64 Name;
    public FlecsArray8<int> Items;
    public int Score;
}

internal struct FixedStrings : IFlecsStruct
{
    public FlecsArray4<FlecsString32> Names;
}
