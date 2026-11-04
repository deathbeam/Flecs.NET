using System.Collections.Generic;
using System.Linq;
using Flecs.NET.Codegen.Helpers;

namespace Flecs.NET.Codegen.Generators;

public class SparseQuery : GeneratorBase
{
    public override void Generate()
    {
        for (int i = 0; i < Generator.GenericCount; i++)
            AddSource($"T{i + 1}.g.cs", GenerateSparseQuery(i));
    }

    private static string GenerateSparseQuery(int i)
    {
        string typeIds = string.Join(Separator.Comma,
            Enumerable.Range(0, i + 1).Select(f => $"Type<T{f}>.Id(WorldPtr)"));

        string refArguments = string.Join(Separator.Comma,
            Enumerable.Range(0, i + 1).Select(f => $"ref Managed.GetTypeRef<T{f}>(ptrs[{f}])"));

        IEnumerable<string> asserts = Enumerable.Range(0, i + 1).Select(f => $$"""
                Ecs.Assert(ecs_has_id(world, Type<T{{f}}>.Id(world), Ecs.DontFragment), "Sparse query component must have the DontFragment trait.");
                Ecs.Assert(ecs_get_target(world, Type<T{{f}}>.Id(world), Ecs.OnInstantiate, 0) != Ecs.Inherit, "Sparse query component cannot have the OnInstantiate Inherit trait.");
        """);

        IEnumerable<string> eachs = new[]
        {
            $$"""
                /// <summary>
                ///     Iterates the query using the provided callback.
                /// </summary>
                /// <param name="callback">The callback.</param>
                public void Each({{Generator.EachRefCallbackDelegate[i]}} callback)
                {
                    ulong* ids = stackalloc ulong[] { {{typeIds}} };
                    SparseQuery.Each(WorldPtr, ids, {{i + 1}}, &callback, &EachRefCallbackDelegate);
                }

                /// <summary>
                ///     Iterates the query using the provided callback.
                /// </summary>
                /// <param name="callback">The callback.</param>
                public void Each({{Generator.EachEntityRefCallbackDelegate[i]}} callback)
                {
                    ulong* ids = stackalloc ulong[] { {{typeIds}} };
                    SparseQuery.Each(WorldPtr, ids, {{i + 1}}, &callback, &EachEntityRefCallbackDelegate);
                }

                /// <summary>
                ///     Iterates the query using the provided callback.
                /// </summary>
                /// <param name="callback">The callback.</param>
                public void Each({{Generator.EachRefCallbackPointer[i]}} callback)
                {
                    ulong* ids = stackalloc ulong[] { {{typeIds}} };
                    SparseQuery.Each(WorldPtr, ids, {{i + 1}}, callback, &EachRefCallbackPointer);
                }

                /// <summary>
                ///     Iterates the query using the provided callback.
                /// </summary>
                /// <param name="callback">The callback.</param>
                public void Each({{Generator.EachEntityRefCallbackPointer[i]}} callback)
                {
                    ulong* ids = stackalloc ulong[] { {{typeIds}} };
                    SparseQuery.Each(WorldPtr, ids, {{i + 1}}, callback, &EachEntityRefCallbackPointer);
                }

                private static void EachRefCallbackDelegate(void* context, ecs_world_t* world, ulong entity, void** ptrs)
                {
                    Unsafe.AsRef<{{Generator.EachRefCallbackDelegate[i]}}>(context)({{refArguments}});
                }

                private static void EachEntityRefCallbackDelegate(void* context, ecs_world_t* world, ulong entity, void** ptrs)
                {
                    Unsafe.AsRef<{{Generator.EachEntityRefCallbackDelegate[i]}}>(context)(new Entity(world, entity), {{refArguments}});
                }

                private static void EachRefCallbackPointer(void* context, ecs_world_t* world, ulong entity, void** ptrs)
                {
                    (({{Generator.EachRefCallbackPointer[i]}})context)({{refArguments}});
                }

                private static void EachEntityRefCallbackPointer(void* context, ecs_world_t* world, ulong entity, void** ptrs)
                {
                    (({{Generator.EachEntityRefCallbackPointer[i]}})context)(new Entity(world, entity), {{refArguments}});
                }
            """
        };

        return $$"""
            #nullable enable

            using System;
            using System.Runtime.CompilerServices;
            using Flecs.NET.Utilities;

            using static Flecs.NET.Bindings.flecs;

            namespace Flecs.NET.Core;

            /// <summary>
            ///     A query that iterates sparse component storages directly and takes {{i + 1}} type arguments.
            /// </summary>
            /// {{Generator.XmlTypeParameters[i]}}
            public unsafe partial struct {{Generator.GetTypeName(Type.SparseQuery, i)}}
            {
                private ecs_world_t* _world;

                /// <summary>
                ///     The world pointer.
                /// </summary>
                internal ecs_world_t* WorldPtr => _world;

                /// <summary>
                ///     Returns the world.
                /// </summary>
                /// <returns>The world.</returns>
                public World World()
                {
                    return new World(_world);
                }

                /// <summary>
                ///     Creates a sparse query from the provided world.
                /// </summary>
                /// <param name="world">The world.</param>
                public {{Generator.GetTypeName(Type.SparseQuery)}}(ecs_world_t* world)
                {
                    _world = ecs_get_world(world);

            {{string.Join(Separator.NewLine, asserts)}}
                }

            {{string.Join(Separator.DoubleNewLine, eachs)}}

                /// <summary>
                ///     Returns the number of entities matched by the query.
                /// </summary>
                /// <returns>The number of matched entities.</returns>
                public int Count()
                {
                    ulong* ids = stackalloc ulong[] { {{typeIds}} };
                    return SparseQuery.Each(WorldPtr, ids, {{i + 1}}, null, null);
                }

                /// <summary>
                ///     Converts the sparse query to a regular query for the same components.
                /// </summary>
                /// <returns>The query.</returns>
                public {{Generator.GetTypeName(Type.Query, i)}} ToQuery()
                {
                    return new {{Generator.GetTypeName(Type.QueryBuilder, i)}}(WorldPtr).Build();
                }
            }
            """;
    }
}
