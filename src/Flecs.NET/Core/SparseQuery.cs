using Flecs.NET.Utilities;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     Shared iteration logic for <see cref="SparseQuery{T0}"/>, which iterates sparse component storages directly.
/// </summary>
internal static unsafe class SparseQuery
{
    /// <summary>
    ///     Iterates the entities that are present in all provided sparse storages and returns the number of matched
    ///     entities. The invoker receives the pointers to the component values of each matched entity.
    /// </summary>
    internal static int Each(ecs_world_t* world, ulong* ids, int idCount, void* context,
        delegate*<void*, ecs_world_t*, ulong, void**, void> invoker)
    {
        ecs_sparse_t** sparse = stackalloc ecs_sparse_t*[idCount];

        for (int i = 0; i < idCount; i++)
        {
            sparse[i] = Storage(world, ids[i]);

            if (sparse[i] == null)
                return 0;
        }

        // Iterate the storage with the fewest elements to minimize the number of lookups.
        int lead = 0;
        for (int i = 1; i < idCount; i++)
        {
            if (sparse[i]->count < sparse[lead]->count)
                lead = i;
        }

        ulong* entities = (ulong*)sparse[lead]->dense.array + 1;
        int entityCount = sparse[lead]->count - 1;
        void** ptrs = stackalloc void*[idCount];
        int matched = 0;

        for (int i = 0; i < entityCount; i++)
        {
            ulong entity = entities[i];
            bool found = true;

            for (int f = 0; f < idCount; f++)
            {
                ptrs[f] = FieldAtSparse(sparse[f], entity, f != lead);

                if (ptrs[f] == null)
                {
                    found = false;
                    break;
                }
            }

            if (!found)
                continue;

            ecs_record_t* record = flecs_entities_get(world, entity);

            if (record == null || record->table == null)
                continue;

            if ((flecs_table_flags(record->table) &
                (EcsTableNotQueryable | EcsTableIsPrefab | EcsTableIsDisabled)) != 0)
                continue;

            if (invoker != null)
                invoker(context, world, entity, ptrs);

            matched++;
        }

        return matched;
    }

    private static ecs_sparse_t* Storage(ecs_world_t* world, ulong id)
    {
        ecs_component_record_t* record = flecs_components_get(world, id);
        return record == null ? null : flecs_component_get_sparse(record);
    }

    private static void* FieldAtSparse(ecs_sparse_t* sparse, ulong entity, bool check)
    {
        Ecs.Assert(sparse != null, nameof(ECS_INVALID_PARAMETER));

        int pageIndex = (int)((uint)entity >> FLECS_SPARSE_PAGE_BITS);

        if (check && pageIndex >= sparse->pages.count)
            return null;

        ecs_sparse_page_t* page = &((ecs_sparse_page_t*)sparse->pages.array)[pageIndex];
        int offset = (int)(entity & (FLECS_SPARSE_PAGE_SIZE - 1));

        if (check)
        {
            if (page->sparse == null)
                return null;

            int dense = page->sparse[offset];

            if (dense == 0 || dense >= sparse->count)
                return null;
        }

        return (byte*)page->data + sparse->size * offset;
    }
}
