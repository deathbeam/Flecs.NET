using BenchmarkDotNet.Attributes;
using Flecs.NET.Core;

namespace Flecs.NET.Benchmarks.Core
{
    /// <summary>
    ///     Measures iteration and component access overhead.
    /// </summary>
    [MemoryDiagnoser]
    public class Iteration
    {
        public const int EntityCount = 1000000;
        public const int ManagedEntityCount = 10000;

        public struct Position
        {
            public float X;
            public float Y;
        }

        public struct Velocity
        {
            public float X;
            public float Y;
        }

        public struct Position2
        {
            public float X;
            public float Y;
        }

        public struct ManagedComponent
        {
            public string Value;
        }

        public World World;
        public Query<Position> PositionQuery;
        public Query<Position2, Velocity> PositionVelocityQuery;
        public Query<ManagedComponent> ManagedQuery;
        public Entity[] ManagedEntities;

        public static float Sum;
        public static int Length;

        [GlobalSetup]
        public void Setup()
        {
            World = World.Create();

            for (int i = 0; i < EntityCount; i++)
                World.Entity().Set(new Position { X = i, Y = i });

            for (int i = 0; i < EntityCount; i++)
                World.Entity()
                    .Set(new Position2 { X = i, Y = i })
                    .Set(new Velocity { X = 1, Y = 2 });

            ManagedEntities = new Entity[ManagedEntityCount];
            for (int i = 0; i < ManagedEntityCount; i++)
                ManagedEntities[i] = World.Entity().Set(new ManagedComponent { Value = "managed" });

            PositionQuery = World.Query<Position>();
            PositionVelocityQuery = World.Query<Position2, Velocity>();
            ManagedQuery = World.Query<ManagedComponent>();
        }

        [GlobalCleanup]
        public void Cleanup()
        {
            World.Dispose();
        }

        [Benchmark]
        public void Each1()
        {
            PositionQuery.Each((ref Position p) => Sum += p.X);
        }

        [Benchmark]
        public void Each2()
        {
            PositionVelocityQuery.Each((ref Position2 p, ref Velocity v) => Sum += p.X + v.X);
        }

        [Benchmark]
        public void EachManaged()
        {
            ManagedQuery.Each((ref ManagedComponent c) => Length += c.Value.Length);
        }

        [Benchmark]
        public void IterField()
        {
            PositionVelocityQuery.Run((Iter it) =>
            {
                while (it.Next())
                {
                    Field<Position2> p = it.Field<Position2>(0);
                    Field<Velocity> v = it.Field<Velocity>(1);

                    for (int i = 0; i < it.Count(); i++)
                        p[i].X += v[i].X;
                }
            });
        }

        [Benchmark]
        public void SetManaged()
        {
            for (int i = 0; i < ManagedEntityCount; i++)
                ManagedEntities[i].Set(new ManagedComponent { Value = "managed" });
        }
    }
}
