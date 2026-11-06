#pragma warning disable CS8981

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: InternalsVisibleTo("Flecs.NET")]

namespace Flecs.NET.Bindings
{
    public static unsafe partial class flecs
    {
        // SuppressGCTransition fast variants

        [SuppressGCTransition]
        [DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_binding_ctx")]
        internal static extern void* ecs_get_binding_ctx_fast(ecs_world_t* world);

        [SuppressGCTransition]
        [DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_is_alive")]
        internal static extern bool ecs_is_alive_fast(ecs_world_t* world, ulong e);

        [SuppressGCTransition]
        [DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_has_id")]
        internal static extern bool ecs_has_id_fast(ecs_world_t* world, ulong entity, ulong component);

        [SuppressGCTransition]
        [DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_id")]
        internal static extern void* ecs_get_id_fast(ecs_world_t* world, ulong entity, ulong component);

        [SuppressGCTransition]
        [DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_world_info")]
        internal static extern ecs_world_info_t* ecs_get_world_info_fast(ecs_world_t* world);
    }
}

#pragma warning restore CS8981
