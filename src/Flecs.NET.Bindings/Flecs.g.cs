#nullable enable
#pragma warning disable CS8981
namespace Flecs.NET.Bindings
{
    public static unsafe partial class flecs
    {
        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_abort_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_abort_(int error_code, byte* file, int line, byte* fmt);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_add_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_add_id(ecs_world_t* world, ulong entity, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_add_path_w_sep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_add_path_w_sep(ecs_world_t* world, ulong entity, ulong parent, byte* path, byte* sep, byte* prefix);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_alert_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_alert_init(ecs_world_t* world, ecs_alert_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_app_run", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_app_run(ecs_world_t* world, ecs_app_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_app_run_frame", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_app_run_frame(ecs_world_t* world, ecs_app_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_app_set_frame_action", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_app_set_frame_action(System.IntPtr callback);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_app_set_run_action", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_app_set_run_action(System.IntPtr callback);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_array_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_array_init(ecs_world_t* world, ecs_array_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_array_to_json", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_array_to_json(ecs_world_t* world, ulong type, void* data, int count);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_array_to_json_buf", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_array_to_json_buf(ecs_world_t* world, ulong type, void* data, int count, ecs_strbuf_t* buf_out);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_assert_log_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_assert_log_(int error_code, byte* condition_str, byte* file, int line, byte* fmt);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_atfini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_atfini(ecs_world_t* world, System.IntPtr action, void* ctx);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_auto_override_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_auto_override_id(ecs_world_t* world, ulong entity, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_bitmask_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_bitmask_init(ecs_world_t* world, ecs_bitmask_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_bulk_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong* ecs_bulk_init(ecs_world_t* world, ecs_bulk_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_bulk_new_w_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong* ecs_bulk_new_w_id(ecs_world_t* world, ulong id, int count);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_children", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_iter_t ecs_children(ecs_world_t* world, ulong parent);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_children_next", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_children_next(ecs_iter_t* it);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_clear(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_clone", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_clone(ecs_world_t* world, ulong dst, ulong src, byte copy_value);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_commit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_commit(ecs_world_t* world, ulong entity, ecs_record_t* record, ecs_table_t* table, ecs_type_t* added, ecs_type_t* removed);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_component_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_component_init(ecs_world_t* world, ecs_component_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_count_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_count_id(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_cpp_component_register", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_cpp_component_register(ecs_world_t* world, ulong id, byte* name, byte* symbol, int size, int alignment, byte implicit_name, byte* existing_out);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_cpp_component_register_explicit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_cpp_component_register_explicit(ecs_world_t* world, ulong s_id, ulong id, byte* name, byte* type_name, byte* symbol, System.IntPtr size, System.IntPtr alignment, byte is_component, byte* existing_out);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_cpp_component_validate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_cpp_component_validate(ecs_world_t* world, ulong id, byte* name, byte* symbol, System.IntPtr size, System.IntPtr alignment, byte implicit_name);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_cpp_enum_constant_register", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_cpp_enum_constant_register(ecs_world_t* world, ulong parent, ulong id, byte* name, int value);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_cpp_enum_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_cpp_enum_init(ecs_world_t* world, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_cpp_get_constant_name", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_cpp_get_constant_name(byte* constant_name, byte* func_name, System.IntPtr len, System.IntPtr back_len);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_cpp_get_symbol_name", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_cpp_get_symbol_name(byte* symbol_name, byte* type_name, System.IntPtr len);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_cpp_get_type_name", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_cpp_get_type_name(byte* type_name, byte* func_name, System.IntPtr len, System.IntPtr front_len);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_cpp_last_member", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_member_t* ecs_cpp_last_member(ecs_world_t* world, ulong type);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_cpp_reset_count_get", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_cpp_reset_count_get();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_cpp_reset_count_inc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_cpp_reset_count_inc();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_cpp_trim_module", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_cpp_trim_module(ecs_world_t* world, byte* type_name);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_defer_begin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_defer_begin(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_defer_end", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_defer_end(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_defer_resume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_defer_resume(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_defer_suspend", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_defer_suspend(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_delete", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_delete(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_delete_empty_tables", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_delete_empty_tables(ecs_world_t* world, ulong id, ushort clear_generation, ushort delete_generation, int min_id_count, double time_budget_seconds);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_delete_with", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_delete_with(ecs_world_t* world, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_deprecated_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_deprecated_(byte* file, int line, byte* msg);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_dim", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_dim(ecs_world_t* world, int entity_count);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_doc_get_brief", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_doc_get_brief(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_doc_get_color", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_doc_get_color(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_doc_get_detail", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_doc_get_detail(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_doc_get_link", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_doc_get_link(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_doc_get_name", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_doc_get_name(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_doc_get_uuid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_doc_get_uuid(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_doc_set_brief", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_doc_set_brief(ecs_world_t* world, ulong entity, byte* description);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_doc_set_color", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_doc_set_color(ecs_world_t* world, ulong entity, byte* color);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_doc_set_detail", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_doc_set_detail(ecs_world_t* world, ulong entity, byte* description);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_doc_set_link", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_doc_set_link(ecs_world_t* world, ulong entity, byte* link);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_doc_set_name", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_doc_set_name(ecs_world_t* world, ulong entity, byte* name);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_doc_set_uuid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_doc_set_uuid(ecs_world_t* world, ulong entity, byte* uuid);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_each_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_iter_t ecs_each_id(ecs_world_t* world, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_each_next", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_each_next(ecs_iter_t* it);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_emit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_emit(ecs_world_t* world, ecs_event_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_emplace_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_emplace_id(ecs_world_t* world, ulong entity, ulong id, byte* is_new);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_enable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_enable(ecs_world_t* world, ulong entity, byte enabled);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_enable_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_enable_id(ecs_world_t* world, ulong entity, ulong id, byte enable);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_enable_range_check", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_enable_range_check(ecs_world_t* world, byte enable);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_enqueue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_enqueue(ecs_world_t* world, ecs_event_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_ensure_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_ensure_id(ecs_world_t* world, ulong entity, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_ensure_modified_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_ensure_modified_id(ecs_world_t* world, ulong entity, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_entity_from_json", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_entity_from_json(ecs_world_t* world, ulong entity, byte* json, ecs_from_json_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_entity_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_entity_init(ecs_world_t* world, ecs_entity_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_entity_str", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_entity_str(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_entity_to_json", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_entity_to_json(ecs_world_t* world, ulong entity, ecs_entity_to_json_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_entity_to_json_buf", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_entity_to_json_buf(ecs_world_t* world, ulong entity, ecs_strbuf_t* buf_out, ecs_entity_to_json_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_enum_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_enum_init(ecs_world_t* world, ecs_enum_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_exists", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_exists(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_field_at_w_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_field_at_w_size(ecs_iter_t* it, System.IntPtr size, byte index, int row);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_field_column", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_field_column(ecs_iter_t* it, byte index);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_field_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_field_id(ecs_iter_t* it, byte index);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_field_is_readonly", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_field_is_readonly(ecs_iter_t* it, byte index);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_field_is_self", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_field_is_self(ecs_iter_t* it, byte index);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_field_is_set", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_field_is_set(ecs_iter_t* it, byte index);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_field_is_writeonly", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_field_is_writeonly(ecs_iter_t* it, byte index);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_field_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern System.IntPtr ecs_field_size(ecs_iter_t* it, byte index);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_field_src", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_field_src(ecs_iter_t* it, byte index);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_field_w_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_field_w_size(ecs_iter_t* it, System.IntPtr size, byte index);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_fini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_fini(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_frame_begin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern float ecs_frame_begin(ecs_world_t* world, float delta_time);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_frame_end", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_frame_end(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_alert", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_get_alert(ecs_world_t* world, ulong entity, ulong alert);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_alert_count", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_get_alert_count(ecs_world_t* world, ulong entity, ulong alert);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_alive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_get_alive(ecs_world_t* world, ulong e);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_binding_ctx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_get_binding_ctx(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_build_info", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_build_info_t* ecs_get_build_info();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_ctx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_get_ctx(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_depth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_get_depth(ecs_world_t* world, ulong entity, ulong rel);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_entities", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_entities_t ecs_get_entities(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_entity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_get_entity(void* poly);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_hooks_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_type_hooks_t* ecs_get_hooks_id(ecs_world_t* world, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_get_id(ecs_world_t* world, ulong entity, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_interval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern float ecs_get_interval(ecs_world_t* world, ulong tick_source);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_lookup_path", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong* ecs_get_lookup_path(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_max_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_get_max_id(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_mut_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_get_mut_id(ecs_world_t* world, ulong entity, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_name", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_get_name(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_parent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_get_parent(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_path_w_sep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_get_path_w_sep(ecs_world_t* world, ulong parent, ulong child, byte* sep, byte* prefix);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_path_w_sep_buf", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_get_path_w_sep_buf(ecs_world_t* world, ulong parent, ulong child, byte* sep, byte* prefix, ecs_strbuf_t* buf, byte escape);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_pipeline", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_get_pipeline(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_scope", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_get_scope(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_stage", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_world_t* ecs_get_stage(ecs_world_t* world, int stage_id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_stage_count", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_get_stage_count(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_symbol", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_get_symbol(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_table", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_table_t* ecs_get_table(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_target", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_get_target(ecs_world_t* world, ulong entity, ulong rel, int index);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_target_for_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_get_target_for_id(ecs_world_t* world, ulong entity, ulong rel, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_timeout", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern float ecs_get_timeout(ecs_world_t* world, ulong tick_source);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_type", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_type_t* ecs_get_type(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_type_info", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_type_info_t* ecs_get_type_info(ecs_world_t* world, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_typeid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_get_typeid(ecs_world_t* world, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_with", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_get_with(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_world", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_world_t* ecs_get_world(void* poly);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_get_world_info", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_world_info_t* ecs_get_world_info(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_has_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_has_id(ecs_world_t* world, ulong entity, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_http_get_header", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_http_get_header(ecs_http_request_t* req, byte* name);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_http_get_param", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_http_get_param(ecs_http_request_t* req, byte* name);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_http_server_ctx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_http_server_ctx(ecs_http_server_t* srv);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_http_server_dequeue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_http_server_dequeue(ecs_http_server_t* server, float delta_time);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_http_server_fini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_http_server_fini(ecs_http_server_t* server);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_http_server_http_request", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_http_server_http_request(ecs_http_server_t* srv, byte* req, int len, ecs_http_reply_t* reply_out);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_http_server_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_http_server_t* ecs_http_server_init(ecs_http_server_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_http_server_request", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_http_server_request(ecs_http_server_t* srv, byte* method, byte* req, ecs_http_reply_t* reply_out);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_http_server_start", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_http_server_start(ecs_http_server_t* server);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_http_server_stop", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_http_server_stop(ecs_http_server_t* server);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_id_flag_str", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_id_flag_str(ulong id_flags);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_id_from_str", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_id_from_str(ecs_world_t* world, byte* expr);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_id_get_flags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern uint ecs_id_get_flags(ecs_world_t* world, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_id_in_use", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_id_in_use(ecs_world_t* world, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_id_is_pair", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_id_is_pair(ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_id_is_tag", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_id_is_tag(ecs_world_t* world, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_id_is_valid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_id_is_valid(ecs_world_t* world, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_id_is_wildcard", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_id_is_wildcard(ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_id_match", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_id_match(ulong id, ulong pattern);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_id_str", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_id_str(ecs_world_t* world, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_id_str_buf", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_id_str_buf(ecs_world_t* world, ulong id, ecs_strbuf_t* buf);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_import", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_import(ecs_world_t* world, System.IntPtr module, byte* module_name);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_import_c", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_import_c(ecs_world_t* world, System.IntPtr module, byte* module_name_c);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_import_from_library", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_import_from_library(ecs_world_t* world, byte* library_name, byte* module_name);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_world_t* ecs_init();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_init_w_args", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_world_t* ecs_init_w_args(int argc, byte** argv);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_is_alive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_is_alive(ecs_world_t* world, ulong e);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_is_deferred", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_is_deferred(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_is_enabled_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_is_enabled_id(ecs_world_t* world, ulong entity, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_is_fini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_is_fini(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_is_valid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_is_valid(ecs_world_t* world, ulong e);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_iter_changed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_iter_changed(ecs_iter_t* it);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_iter_count", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_iter_count(ecs_iter_t* it);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_iter_fini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_iter_fini(ecs_iter_t* it);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_iter_first", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_iter_first(ecs_iter_t* it);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_iter_get_var", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_iter_get_var(ecs_iter_t* it, int var_id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_iter_get_var_as_range", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_table_range_t ecs_iter_get_var_as_range(ecs_iter_t* it, int var_id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_iter_get_var_as_table", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_table_t* ecs_iter_get_var_as_table(ecs_iter_t* it, int var_id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_iter_is_true", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_iter_is_true(ecs_iter_t* it);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_iter_next", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_iter_next(ecs_iter_t* it);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_iter_set_group", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_iter_set_group(ecs_iter_t* it, ulong group_id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_iter_set_var", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_iter_set_var(ecs_iter_t* it, int var_id, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_iter_set_var_as_range", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_iter_set_var_as_range(ecs_iter_t* it, int var_id, ecs_table_range_t* range);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_iter_set_var_as_table", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_iter_set_var_as_table(ecs_iter_t* it, int var_id, ecs_table_t* table);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_iter_skip", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_iter_skip(ecs_iter_t* it);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_iter_str", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_iter_str(ecs_iter_t* it);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_iter_to_json", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_iter_to_json(ecs_iter_t* iter, ecs_iter_to_json_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_iter_to_json_buf", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_iter_to_json_buf(ecs_iter_t* iter, ecs_strbuf_t* buf_out, ecs_iter_to_json_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_iter_var_is_constrained", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_iter_var_is_constrained(ecs_iter_t* it, int var_id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_log_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_log_(int level, byte* file, int line, byte* fmt);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_log_enable_colors", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_log_enable_colors(byte enabled);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_log_enable_timedelta", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_log_enable_timedelta(byte enabled);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_log_enable_timestamp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_log_enable_timestamp(byte enabled);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_log_get_level", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_log_get_level();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_log_last_error", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_log_last_error();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_log_pop_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_log_pop_(int level);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_log_push_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_log_push_(int level);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_log_set_level", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_log_set_level(int level);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_logv_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_logv_(int level, byte* file, int line, byte* fmt, void* args);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_lookup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_lookup(ecs_world_t* world, byte* path);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_lookup_child", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_lookup_child(ecs_world_t* world, ulong parent, byte* name);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_lookup_path_w_sep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_lookup_path_w_sep(ecs_world_t* world, ulong parent, byte* path, byte* sep, byte* prefix, byte recursive);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_lookup_symbol", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_lookup_symbol(ecs_world_t* world, byte* symbol, byte lookup_as_path, byte recursive);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_make_alive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_make_alive(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_make_alive_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_make_alive_id(ecs_world_t* world, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_make_pair", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_make_pair(ulong first, ulong second);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_map_clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_map_clear(ecs_map_t* map);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_map_copy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_map_copy(ecs_map_t* dst, ecs_map_t* src);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_map_ensure", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong* ecs_map_ensure(ecs_map_t* map, ulong key);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_map_ensure_alloc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_map_ensure_alloc(ecs_map_t* map, int elem_size, ulong key);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_map_fini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_map_fini(ecs_map_t* map);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_map_get", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong* ecs_map_get(ecs_map_t* map, ulong key);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_map_get_deref_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_map_get_deref_(ecs_map_t* map, ulong key);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_map_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_map_init(ecs_map_t* map, ecs_allocator_t* allocator);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_map_init_if", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_map_init_if(ecs_map_t* map, ecs_allocator_t* allocator);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_map_init_w_params", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_map_init_w_params(ecs_map_t* map, ecs_map_params_t* @params);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_map_init_w_params_if", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_map_init_w_params_if(ecs_map_t* result, ecs_map_params_t* @params);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_map_insert", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_map_insert(ecs_map_t* map, ulong key, ulong value);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_map_insert_alloc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_map_insert_alloc(ecs_map_t* map, int elem_size, ulong key);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_map_iter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_map_iter_t ecs_map_iter(ecs_map_t* map);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_map_next", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_map_next(ecs_map_iter_t* iter);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_map_params_fini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_map_params_fini(ecs_map_params_t* @params);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_map_params_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_map_params_init(ecs_map_params_t* @params, ecs_allocator_t* allocator);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_map_remove", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_map_remove(ecs_map_t* map, ulong key);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_map_remove_free", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_map_remove_free(ecs_map_t* map, ulong key);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_measure_frame_time", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_measure_frame_time(ecs_world_t* world, byte enable);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_measure_system_time", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_measure_system_time(ecs_world_t* world, byte enable);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_merge", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_merge(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_cursor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_meta_cursor_t ecs_meta_cursor(ecs_world_t* world, ulong type, void* ptr);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_dotmember", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_meta_dotmember(ecs_meta_cursor_t* cursor, byte* name);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_elem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_meta_elem(ecs_meta_cursor_t* cursor, int elem);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_from_desc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_meta_from_desc(ecs_world_t* world, ulong component, ecs_type_kind_t kind, byte* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_get_bool", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_meta_get_bool(ecs_meta_cursor_t* cursor);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_get_char", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_meta_get_char(ecs_meta_cursor_t* cursor);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_get_entity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_meta_get_entity(ecs_meta_cursor_t* cursor);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_get_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern double ecs_meta_get_float(ecs_meta_cursor_t* cursor);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_get_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_meta_get_id(ecs_meta_cursor_t* cursor);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_get_int", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern long ecs_meta_get_int(ecs_meta_cursor_t* cursor);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_get_member", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_meta_get_member(ecs_meta_cursor_t* cursor);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_get_member_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_meta_get_member_id(ecs_meta_cursor_t* cursor);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_get_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_meta_get_ptr(ecs_meta_cursor_t* cursor);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_get_string", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_meta_get_string(ecs_meta_cursor_t* cursor);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_get_type", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_meta_get_type(ecs_meta_cursor_t* cursor);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_get_uint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_meta_get_uint(ecs_meta_cursor_t* cursor);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_get_unit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_meta_get_unit(ecs_meta_cursor_t* cursor);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_is_collection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_meta_is_collection(ecs_meta_cursor_t* cursor);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_member", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_meta_member(ecs_meta_cursor_t* cursor, byte* name);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_next", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_meta_next(ecs_meta_cursor_t* cursor);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_pop", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_meta_pop(ecs_meta_cursor_t* cursor);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_ptr_to_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern double ecs_meta_ptr_to_float(ecs_primitive_kind_t type_kind, void* ptr);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_push", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_meta_push(ecs_meta_cursor_t* cursor);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_set_bool", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_meta_set_bool(ecs_meta_cursor_t* cursor, byte value);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_set_char", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_meta_set_char(ecs_meta_cursor_t* cursor, byte value);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_set_entity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_meta_set_entity(ecs_meta_cursor_t* cursor, ulong value);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_set_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_meta_set_float(ecs_meta_cursor_t* cursor, double value);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_set_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_meta_set_id(ecs_meta_cursor_t* cursor, ulong value);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_set_int", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_meta_set_int(ecs_meta_cursor_t* cursor, long value);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_set_null", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_meta_set_null(ecs_meta_cursor_t* cursor);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_set_string", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_meta_set_string(ecs_meta_cursor_t* cursor, byte* value);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_set_string_literal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_meta_set_string_literal(ecs_meta_cursor_t* cursor, byte* value);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_set_uint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_meta_set_uint(ecs_meta_cursor_t* cursor, ulong value);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_meta_set_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_meta_set_value(ecs_meta_cursor_t* cursor, ecs_value_t* value);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_metric_copy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_metric_copy(ecs_metric_t* m, int dst, int src);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_metric_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_metric_init(ecs_world_t* world, ecs_metric_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_metric_reduce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_metric_reduce(ecs_metric_t* dst, ecs_metric_t* src, int t_dst, int t_src);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_metric_reduce_last", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_metric_reduce_last(ecs_metric_t* m, int t, int count);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_mini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_world_t* ecs_mini();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_modified_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_modified_id(ecs_world_t* world, ulong entity, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_module_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_module_init(ecs_world_t* world, byte* c_name, ecs_component_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_new", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_new(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_new_from_path_w_sep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_new_from_path_w_sep(ecs_world_t* world, ulong parent, byte* path, byte* sep, byte* prefix);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_new_low_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_new_low_id(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_new_w_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_new_w_id(ecs_world_t* world, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_new_w_table", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_new_w_table(ecs_world_t* world, ecs_table_t* table);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_observer_get", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_observer_t* ecs_observer_get(ecs_world_t* world, ulong observer);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_observer_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_observer_init(ecs_world_t* world, ecs_observer_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_opaque_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_opaque_init(ecs_world_t* world, ecs_opaque_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_dbg", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_os_dbg(byte* file, int line, byte* msg);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_err", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_os_err(byte* file, int line, byte* msg);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_fatal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_os_fatal(byte* file, int line, byte* msg);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_fini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_os_fini();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_get_api", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_os_api_t ecs_os_get_api();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_has_dl", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_os_has_dl();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_has_heap", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_os_has_heap();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_has_logging", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_os_has_logging();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_has_modules", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_os_has_modules();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_has_task_support", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_os_has_task_support();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_has_threading", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_os_has_threading();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_has_time", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_os_has_time();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_os_init();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_memdup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_os_memdup(void* src, int size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_perf_trace_pop_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_os_perf_trace_pop_(byte* file, System.IntPtr line, byte* name);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_perf_trace_push_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_os_perf_trace_push_(byte* file, System.IntPtr line, byte* name);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_set_api", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_os_set_api(ecs_os_api_t* os_api);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_set_api_defaults", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_os_set_api_defaults();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_strerror", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_os_strerror(int err);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_strset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_os_strset(byte** str, byte* value);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_trace", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_os_trace(byte* file, int line, byte* msg);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_warn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_os_warn(byte* file, int line, byte* msg);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_owns_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_owns_id(ecs_world_t* world, ulong entity, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_page_iter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_iter_t ecs_page_iter(ecs_iter_t* it, int offset, int limit);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_page_next", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_page_next(ecs_iter_t* it);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_parser_error_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_parser_error_(byte* name, byte* expr, long column, byte* fmt);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_parser_errorv_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_parser_errorv_(byte* name, byte* expr, long column, byte* fmt, void* args);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_pipeline_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_pipeline_init(ecs_world_t* world, ecs_pipeline_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_pipeline_stats_copy_last", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_pipeline_stats_copy_last(ecs_pipeline_stats_t* dst, ecs_pipeline_stats_t* src);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_pipeline_stats_fini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_pipeline_stats_fini(ecs_pipeline_stats_t* stats);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_pipeline_stats_get", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_pipeline_stats_get(ecs_world_t* world, ulong pipeline, ecs_pipeline_stats_t* stats);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_pipeline_stats_reduce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_pipeline_stats_reduce(ecs_pipeline_stats_t* dst, ecs_pipeline_stats_t* src);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_pipeline_stats_reduce_last", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_pipeline_stats_reduce_last(ecs_pipeline_stats_t* stats, ecs_pipeline_stats_t* old, int count);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_pipeline_stats_repeat_last", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_pipeline_stats_repeat_last(ecs_pipeline_stats_t* stats);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_primitive_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_primitive_init(ecs_world_t* world, ecs_primitive_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_print_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_print_(int level, byte* file, int line, byte* fmt);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_printv_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_printv_(int level, byte* file, int line, byte* fmt, void* args);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_progress", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_progress(ecs_world_t* world, float delta_time);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_ptr_from_json", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_ptr_from_json(ecs_world_t* world, ulong type, void* ptr, byte* json, ecs_from_json_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_ptr_to_expr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_ptr_to_expr(ecs_world_t* world, ulong type, void* data);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_ptr_to_expr_buf", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_ptr_to_expr_buf(ecs_world_t* world, ulong type, void* data, ecs_strbuf_t* buf);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_ptr_to_json", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_ptr_to_json(ecs_world_t* world, ulong type, void* data);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_ptr_to_json_buf", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_ptr_to_json_buf(ecs_world_t* world, ulong type, void* data, ecs_strbuf_t* buf_out);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_ptr_to_str", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_ptr_to_str(ecs_world_t* world, ulong type, void* data);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_ptr_to_str_buf", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_ptr_to_str_buf(ecs_world_t* world, ulong type, void* data, ecs_strbuf_t* buf);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_quantity_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_quantity_init(ecs_world_t* world, ecs_entity_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_args_parse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_query_args_parse(ecs_query_t* query, ecs_iter_t* it, byte* expr);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_cache_stats_copy_last", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_query_cache_stats_copy_last(ecs_query_stats_t* dst, ecs_query_stats_t* src);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_cache_stats_reduce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_query_cache_stats_reduce(ecs_query_stats_t* dst, ecs_query_stats_t* src);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_cache_stats_reduce_last", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_query_cache_stats_reduce_last(ecs_query_stats_t* stats, ecs_query_stats_t* old, int count);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_cache_stats_repeat_last", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_query_cache_stats_repeat_last(ecs_query_stats_t* stats);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_changed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_query_changed(ecs_query_t* query);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_count", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_query_count_t ecs_query_count(ecs_query_t* query);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_find_var", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_query_find_var(ecs_query_t* query, byte* name);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_fini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_query_fini(ecs_query_t* query);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_get_cache_query", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_query_t* ecs_query_get_cache_query(ecs_query_t* query);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_get_group_ctx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_query_get_group_ctx(ecs_query_t* query, ulong group_id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_get_group_info", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_query_group_info_t* ecs_query_get_group_info(ecs_query_t* query, ulong group_id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_has", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_query_has(ecs_query_t* query, ulong entity, ecs_iter_t* it);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_has_range", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_query_has_range(ecs_query_t* query, ecs_table_range_t* range, ecs_iter_t* it);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_has_table", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_query_has_table(ecs_query_t* query, ecs_table_t* table, ecs_iter_t* it);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_query_t* ecs_query_init(ecs_world_t* world, ecs_query_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_is_true", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_query_is_true(ecs_query_t* query);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_iter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_iter_t ecs_query_iter(ecs_world_t* world, ecs_query_t* query);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_match_count", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_query_match_count(ecs_query_t* query);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_next", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_query_next(ecs_iter_t* it);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_plan", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_query_plan(ecs_query_t* query);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_plan_w_profile", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_query_plan_w_profile(ecs_query_t* query, ecs_iter_t* it);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_stats_get", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_query_stats_get(ecs_world_t* world, ecs_query_t* query, ecs_query_stats_t* stats);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_str", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_query_str(ecs_query_t* query);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_var_is_entity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_query_var_is_entity(ecs_query_t* query, int var_id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_query_var_name", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_query_var_name(ecs_query_t* query, int var_id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_quit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_quit(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_randomize_timers", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_randomize_timers(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_read_begin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_record_t* ecs_read_begin(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_read_end", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_read_end(ecs_record_t* record);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_readonly_begin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_readonly_begin(ecs_world_t* world, byte multi_threaded);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_readonly_end", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_readonly_end(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_record_ensure_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_record_ensure_id(ecs_world_t* world, ecs_record_t* record, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_record_find", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_record_t* ecs_record_find(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_record_get_by_column", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_record_get_by_column(ecs_record_t* record, int column, System.IntPtr size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_record_get_entity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_record_get_entity(ecs_record_t* record);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_record_get_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_record_get_id(ecs_world_t* world, ecs_record_t* record, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_record_has_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_record_has_id(ecs_world_t* world, ecs_record_t* record, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_ref_get_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_ref_get_id(ecs_world_t* world, ecs_ref_t* @ref, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_ref_init_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_ref_t ecs_ref_init_id(ecs_world_t* world, ulong entity, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_ref_update", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_ref_update(ecs_world_t* world, ecs_ref_t* @ref);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_remove_all", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_remove_all(ecs_world_t* world, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_remove_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_remove_id(ecs_world_t* world, ulong entity, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_reset_clock", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_reset_clock(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_reset_timer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_reset_timer(ecs_world_t* world, ulong tick_source);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_rest_server_fini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_rest_server_fini(ecs_http_server_t* srv);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_rest_server_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_http_server_t* ecs_rest_server_init(ecs_world_t* world, ecs_http_server_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_run", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_run(ecs_world_t* world, ulong system, float delta_time, void* param);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_run_aperiodic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_run_aperiodic(ecs_world_t* world, uint flags);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_run_pipeline", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_run_pipeline(ecs_world_t* world, ulong pipeline, float delta_time);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_run_post_frame", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_run_post_frame(ecs_world_t* world, System.IntPtr action, void* ctx);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_run_worker", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_run_worker(ecs_world_t* world, ulong system, int stage_current, int stage_count, float delta_time, void* param);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_script_ast_to_buf", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_script_ast_to_buf(ecs_script_t* script, ecs_strbuf_t* buf);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_script_ast_to_str", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_script_ast_to_str(ecs_script_t* script);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_script_clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_script_clear(ecs_world_t* world, ulong script, ulong instance);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_script_eval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_script_eval(ecs_script_t* script);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_script_expr_run", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_script_expr_run(ecs_world_t* world, byte* ptr, ecs_value_t* value, ecs_script_expr_run_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_script_free", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_script_free(ecs_script_t* script);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_script_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_script_init(ecs_world_t* world, ecs_script_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_script_parse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_script_t* ecs_script_parse(ecs_world_t* world, byte* name, byte* code);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_script_run", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_script_run(ecs_world_t* world, byte* name, byte* code);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_script_run_file", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_script_run_file(ecs_world_t* world, byte* filename);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_script_string_interpolate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_script_string_interpolate(ecs_world_t* world, byte* str, ecs_script_vars_t* vars);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_script_update", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_script_update(ecs_world_t* world, ulong script, ulong instance, byte* code);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_script_vars_declare", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_script_var_t* ecs_script_vars_declare(ecs_script_vars_t* vars, byte* name);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_script_vars_define_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_script_var_t* ecs_script_vars_define_id(ecs_script_vars_t* vars, byte* name, ulong type);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_script_vars_fini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_script_vars_fini(ecs_script_vars_t* vars);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_script_vars_from_iter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_script_vars_from_iter(ecs_iter_t* it, ecs_script_vars_t* vars, int offset);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_script_vars_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_script_vars_t* ecs_script_vars_init(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_script_vars_lookup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_script_var_t* ecs_script_vars_lookup(ecs_script_vars_t* vars, byte* name);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_script_vars_pop", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_script_vars_t* ecs_script_vars_pop(ecs_script_vars_t* vars);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_script_vars_push", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_script_vars_t* ecs_script_vars_push(ecs_script_vars_t* parent);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_search", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_search(ecs_world_t* world, ecs_table_t* table, ulong id, ulong* id_out);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_search_offset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_search_offset(ecs_world_t* world, ecs_table_t* table, int offset, ulong id, ulong* id_out);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_search_relation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_search_relation(ecs_world_t* world, ecs_table_t* table, int offset, ulong id, ulong rel, ulong flags, ulong* subject_out, ulong* id_out, ecs_table_record_t** tr_out);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_alias", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_set_alias(ecs_world_t* world, ulong entity, byte* alias);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_binding_ctx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_set_binding_ctx(ecs_world_t* world, void* ctx, System.IntPtr ctx_free);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_ctx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_set_ctx(ecs_world_t* world, void* ctx, System.IntPtr ctx_free);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_default_query_flags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_set_default_query_flags(ecs_world_t* world, uint flags);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_entity_range", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_set_entity_range(ecs_world_t* world, ulong id_start, ulong id_end);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_hooks_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_set_hooks_id(ecs_world_t* world, ulong id, ecs_type_hooks_t* hooks);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_set_id(ecs_world_t* world, ulong entity, ulong id, System.IntPtr size, void* ptr);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_interval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_set_interval(ecs_world_t* world, ulong tick_source, float interval);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_lookup_path", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong* ecs_set_lookup_path(ecs_world_t* world, ulong* lookup_path);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_name", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_set_name(ecs_world_t* world, ulong entity, byte* name);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_name_prefix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_set_name_prefix(ecs_world_t* world, byte* prefix);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_os_api_impl", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_set_os_api_impl();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_pipeline", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_set_pipeline(ecs_world_t* world, ulong pipeline);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_rate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_set_rate(ecs_world_t* world, ulong tick_source, int rate, ulong source);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_scope", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_set_scope(ecs_world_t* world, ulong scope);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_stage_count", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_set_stage_count(ecs_world_t* world, int stages);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_symbol", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_set_symbol(ecs_world_t* world, ulong entity, byte* symbol);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_target_fps", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_set_target_fps(ecs_world_t* world, float fps);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_task_threads", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_set_task_threads(ecs_world_t* world, int task_threads);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_threads", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_set_threads(ecs_world_t* world, int threads);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_tick_source", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_set_tick_source(ecs_world_t* world, ulong system, ulong tick_source);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_time_scale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_set_time_scale(ecs_world_t* world, float scale);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_timeout", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_set_timeout(ecs_world_t* world, ulong tick_source, float timeout);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_version", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_set_version(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_set_with", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_set_with(ecs_world_t* world, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_should_log", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_should_log(int level);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_should_quit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_should_quit(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_sleepf", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_sleepf(double t);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_sparse_add", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_sparse_add(ecs_sparse_t* sparse, int elem_size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_sparse_count", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_sparse_count(ecs_sparse_t* sparse);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_sparse_get", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_sparse_get(ecs_sparse_t* sparse, int elem_size, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_sparse_get_dense", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_sparse_get_dense(ecs_sparse_t* sparse, int elem_size, int index);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_sparse_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_sparse_init(ecs_sparse_t* sparse, int elem_size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_sparse_last_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_sparse_last_id(ecs_sparse_t* sparse);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_stage_free", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_stage_free(ecs_world_t* stage);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_stage_get_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_stage_get_id(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_stage_is_readonly", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_stage_is_readonly(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_stage_new", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_world_t* ecs_stage_new(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_start_timer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_start_timer(ecs_world_t* world, ulong tick_source);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_stop_timer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_stop_timer(ecs_world_t* world, ulong tick_source);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strbuf_append", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_strbuf_append(ecs_strbuf_t* buffer, byte* fmt);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strbuf_appendbool", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_strbuf_appendbool(ecs_strbuf_t* buffer, byte v);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strbuf_appendch", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_strbuf_appendch(ecs_strbuf_t* buffer, byte ch);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strbuf_appendflt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_strbuf_appendflt(ecs_strbuf_t* buffer, double v, byte nan_delim);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strbuf_appendint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_strbuf_appendint(ecs_strbuf_t* buffer, long v);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strbuf_appendstr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_strbuf_appendstr(ecs_strbuf_t* buffer, byte* str);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strbuf_appendstrn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_strbuf_appendstrn(ecs_strbuf_t* buffer, byte* str, int n);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strbuf_get", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_strbuf_get(ecs_strbuf_t* buffer);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strbuf_get_small", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_strbuf_get_small(ecs_strbuf_t* buffer);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strbuf_list_append", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_strbuf_list_append(ecs_strbuf_t* buffer, byte* fmt);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strbuf_list_appendch", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_strbuf_list_appendch(ecs_strbuf_t* buffer, byte ch);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strbuf_list_appendstr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_strbuf_list_appendstr(ecs_strbuf_t* buffer, byte* str);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strbuf_list_appendstrn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_strbuf_list_appendstrn(ecs_strbuf_t* buffer, byte* str, int n);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strbuf_list_next", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_strbuf_list_next(ecs_strbuf_t* buffer);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strbuf_list_pop", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_strbuf_list_pop(ecs_strbuf_t* buffer, byte* list_close);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strbuf_list_push", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_strbuf_list_push(ecs_strbuf_t* buffer, byte* list_open, byte* separator);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strbuf_mergebuff", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_strbuf_mergebuff(ecs_strbuf_t* dst_buffer, ecs_strbuf_t* src_buffer);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strbuf_reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_strbuf_reset(ecs_strbuf_t* buffer);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strbuf_vappend", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_strbuf_vappend(ecs_strbuf_t* buffer, byte* fmt, void* args);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strbuf_written", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_strbuf_written(ecs_strbuf_t* buffer);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strerror", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_strerror(int error_code);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_strip_generation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_strip_generation(ulong e);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_struct_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_struct_init(ecs_world_t* world, ecs_struct_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_system_get", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_system_t* ecs_system_get(ecs_world_t* world, ulong system);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_system_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_system_init(ecs_world_t* world, ecs_system_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_system_stats_copy_last", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_system_stats_copy_last(ecs_system_stats_t* dst, ecs_system_stats_t* src);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_system_stats_get", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_system_stats_get(ecs_world_t* world, ulong system, ecs_system_stats_t* stats);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_system_stats_reduce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_system_stats_reduce(ecs_system_stats_t* dst, ecs_system_stats_t* src);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_system_stats_reduce_last", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_system_stats_reduce_last(ecs_system_stats_t* stats, ecs_system_stats_t* old, int count);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_system_stats_repeat_last", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_system_stats_repeat_last(ecs_system_stats_t* stats);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_add_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_table_t* ecs_table_add_id(ecs_world_t* world, ecs_table_t* table, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_clear_entities", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_table_clear_entities(ecs_world_t* world, ecs_table_t* table);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_column_count", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_table_column_count(ecs_table_t* table);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_column_to_type_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_table_column_to_type_index(ecs_table_t* table, int index);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_count", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_table_count(ecs_table_t* table);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_entities", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong* ecs_table_entities(ecs_table_t* table);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_find", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_table_t* ecs_table_find(ecs_world_t* world, ulong* ids, int id_count);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_get_column", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_table_get_column(ecs_table_t* table, int index, int offset);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_get_column_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_table_get_column_index(ecs_world_t* world, ecs_table_t* table, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_get_column_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern System.IntPtr ecs_table_get_column_size(ecs_table_t* table, int index);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_get_depth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_table_get_depth(ecs_world_t* world, ecs_table_t* table, ulong rel);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_get_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_table_get_id(ecs_world_t* world, ecs_table_t* table, ulong id, int offset);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_get_type", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_type_t* ecs_table_get_type(ecs_table_t* table);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_get_type_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_table_get_type_index(ecs_world_t* world, ecs_table_t* table, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_has_flags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_table_has_flags(ecs_table_t* table, uint flags);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_has_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_table_has_id(ecs_world_t* world, ecs_table_t* table, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_lock", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_table_lock(ecs_world_t* world, ecs_table_t* table);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_remove_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_table_t* ecs_table_remove_id(ecs_world_t* world, ecs_table_t* table, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_table_size(ecs_table_t* table);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_str", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_table_str(ecs_world_t* world, ecs_table_t* table);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_swap_rows", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_table_swap_rows(ecs_world_t* world, ecs_table_t* table, int row_1, int row_2);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_type_to_column_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_table_type_to_column_index(ecs_table_t* table, int index);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_table_unlock", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_table_unlock(ecs_world_t* world, ecs_table_t* table);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_term_is_initialized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_term_is_initialized(ecs_term_t* term);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_term_match_0", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_term_match_0(ecs_term_t* term);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_term_match_this", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_term_match_this(ecs_term_t* term);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_term_ref_is_set", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_term_ref_is_set(ecs_term_ref_t* id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_term_str", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_term_str(ecs_world_t* world, ecs_term_t* term);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_time_measure", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern double ecs_time_measure(ecs_time_t* start);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_time_sub", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_time_t ecs_time_sub(ecs_time_t t1, ecs_time_t t2);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_time_to_double", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern double ecs_time_to_double(ecs_time_t t);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_type_info_to_json", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_type_info_to_json(ecs_world_t* world, ulong type);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_type_info_to_json_buf", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_type_info_to_json_buf(ecs_world_t* world, ulong type, ecs_strbuf_t* buf_out);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_type_str", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_type_str(ecs_world_t* world, ecs_type_t* type);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_unit_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_unit_init(ecs_world_t* world, ecs_unit_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_unit_prefix_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_unit_prefix_init(ecs_world_t* world, ecs_unit_prefix_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_using_task_threads", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_using_task_threads(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_value_copy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_value_copy(ecs_world_t* world, ulong type, void* dst, void* src);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_value_copy_w_type_info", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_value_copy_w_type_info(ecs_world_t* world, ecs_type_info_t* ti, void* dst, void* src);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_value_fini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_value_fini(ecs_world_t* world, ulong type, void* ptr);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_value_fini_w_type_info", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_value_fini_w_type_info(ecs_world_t* world, ecs_type_info_t* ti, void* ptr);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_value_free", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_value_free(ecs_world_t* world, ulong type, void* ptr);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_value_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_value_init(ecs_world_t* world, ulong type, void* ptr);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_value_init_w_type_info", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_value_init_w_type_info(ecs_world_t* world, ecs_type_info_t* ti, void* ptr);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_value_move", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_value_move(ecs_world_t* world, ulong type, void* dst, void* src);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_value_move_ctor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_value_move_ctor(ecs_world_t* world, ulong type, void* dst, void* src);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_value_move_ctor_w_type_info", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_value_move_ctor_w_type_info(ecs_world_t* world, ecs_type_info_t* ti, void* dst, void* src);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_value_move_w_type_info", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_value_move_w_type_info(ecs_world_t* world, ecs_type_info_t* ti, void* dst, void* src);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_value_new", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_value_new(ecs_world_t* world, ulong type);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_value_new_w_type_info", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_value_new_w_type_info(ecs_world_t* world, ecs_type_info_t* ti);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_append", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_vec_append(ecs_allocator_t* allocator, ecs_vec_t* vec, int size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_vec_clear(ecs_vec_t* vec);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_copy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_vec_t ecs_vec_copy(ecs_allocator_t* allocator, ecs_vec_t* vec, int size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_copy_shrink", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_vec_t ecs_vec_copy_shrink(ecs_allocator_t* allocator, ecs_vec_t* vec, int size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_count", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_vec_count(ecs_vec_t* vec);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_fini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_vec_fini(ecs_allocator_t* allocator, ecs_vec_t* vec, int size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_first", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_vec_first(ecs_vec_t* vec);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_get", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_vec_get(ecs_vec_t* vec, int size, int index);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_grow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_vec_grow(ecs_allocator_t* allocator, ecs_vec_t* vec, int size, int elem_count);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_vec_init(ecs_allocator_t* allocator, ecs_vec_t* vec, int size, int elem_count);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_init_if", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_vec_init_if(ecs_vec_t* vec, int size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_last", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* ecs_vec_last(ecs_vec_t* vec, int size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_reclaim", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_vec_reclaim(ecs_allocator_t* allocator, ecs_vec_t* vec, int size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_remove", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_vec_remove(ecs_vec_t* vec, int size, int elem);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_remove_last", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_vec_remove_last(ecs_vec_t* vec);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_vec_t* ecs_vec_reset(ecs_allocator_t* allocator, ecs_vec_t* vec, int size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_set_count", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_vec_set_count(ecs_allocator_t* allocator, ecs_vec_t* vec, int size, int elem_count);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_set_min_count", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_vec_set_min_count(ecs_allocator_t* allocator, ecs_vec_t* vec, int size, int elem_count);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_set_min_count_zeromem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_vec_set_min_count_zeromem(ecs_allocator_t* allocator, ecs_vec_t* vec, int size, int elem_count);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_set_min_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_vec_set_min_size(ecs_allocator_t* allocator, ecs_vec_t* vec, int size, int elem_count);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_set_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_vec_set_size(ecs_allocator_t* allocator, ecs_vec_t* vec, int size, int elem_count);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vec_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_vec_size(ecs_vec_t* vec);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_vector_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong ecs_vector_init(ecs_world_t* world, ecs_vector_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_worker_iter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_iter_t ecs_worker_iter(ecs_iter_t* it, int index, int count);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_worker_next", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte ecs_worker_next(ecs_iter_t* it);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_world_from_json", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_world_from_json(ecs_world_t* world, byte* json, ecs_from_json_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_world_from_json_file", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_world_from_json_file(ecs_world_t* world, byte* filename, ecs_from_json_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_world_get_flags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern uint ecs_world_get_flags(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_world_stats_copy_last", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_world_stats_copy_last(ecs_world_stats_t* dst, ecs_world_stats_t* src);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_world_stats_get", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_world_stats_get(ecs_world_t* world, ecs_world_stats_t* stats);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_world_stats_log", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_world_stats_log(ecs_world_t* world, ecs_world_stats_t* stats);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_world_stats_reduce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_world_stats_reduce(ecs_world_stats_t* dst, ecs_world_stats_t* src);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_world_stats_reduce_last", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_world_stats_reduce_last(ecs_world_stats_t* stats, ecs_world_stats_t* old, int count);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_world_stats_repeat_last", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_world_stats_repeat_last(ecs_world_stats_t* stats);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_world_to_json", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* ecs_world_to_json(ecs_world_t* world, ecs_world_to_json_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_world_to_json_buf", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int ecs_world_to_json_buf(ecs_world_t* world, ecs_strbuf_t* buf_out, ecs_world_to_json_desc_t* desc);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_write_begin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_record_t* ecs_write_begin(ecs_world_t* world, ulong entity);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_write_end", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void ecs_write_end(ecs_record_t* record);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_allocator_fini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_allocator_fini(ecs_allocator_t* a);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_allocator_get", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_block_allocator_t* flecs_allocator_get(ecs_allocator_t* a, int size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_allocator_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_allocator_init(ecs_allocator_t* a);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_asprintf", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* flecs_asprintf(byte* fmt);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_astresc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* flecs_astresc(byte delimiter, byte* @in);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_balloc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* flecs_balloc(ecs_block_allocator_t* allocator);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_ballocator_fini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_ballocator_fini(ecs_block_allocator_t* ba);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_ballocator_free", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_ballocator_free(ecs_block_allocator_t* ba);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_ballocator_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_ballocator_init(ecs_block_allocator_t* ba, int size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_ballocator_new", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_block_allocator_t* flecs_ballocator_new(int size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_bcalloc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* flecs_bcalloc(ecs_block_allocator_t* allocator);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_bdup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* flecs_bdup(ecs_block_allocator_t* ba, void* memory);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_bfree", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_bfree(ecs_block_allocator_t* allocator, void* memory);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_bfree_w_dbg_info", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_bfree_w_dbg_info(ecs_block_allocator_t* allocator, void* memory, byte* type_name);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_brealloc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* flecs_brealloc(ecs_block_allocator_t* dst, ecs_block_allocator_t* src, void* memory);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_chresc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* flecs_chresc(byte* @out, byte @in, byte delimiter);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_chrparse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* flecs_chrparse(byte* @in, byte* @out);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_default_ctor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_default_ctor(void* ptr, int count, ecs_type_info_t* ctx);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_dump_backtrace", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_dump_backtrace(void* stream);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_dup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* flecs_dup(ecs_allocator_t* a, int size, void* src);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_hashmap_copy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_hashmap_copy(ecs_hashmap_t* dst, ecs_hashmap_t* src);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_hashmap_ensure_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern flecs_hashmap_result_t flecs_hashmap_ensure_(ecs_hashmap_t* map, int key_size, void* key, int value_size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_hashmap_fini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_hashmap_fini(ecs_hashmap_t* map);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_hashmap_get_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* flecs_hashmap_get_(ecs_hashmap_t* map, int key_size, void* key, int value_size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_hashmap_get_bucket", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_hm_bucket_t* flecs_hashmap_get_bucket(ecs_hashmap_t* map, ulong hash);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_hashmap_init_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_hashmap_init_(ecs_hashmap_t* hm, int key_size, int value_size, System.IntPtr hash, System.IntPtr compare, ecs_allocator_t* allocator);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_hashmap_iter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern flecs_hashmap_iter_t flecs_hashmap_iter(ecs_hashmap_t* map);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_hashmap_next_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* flecs_hashmap_next_(flecs_hashmap_iter_t* it, int key_size, void* key_out, int value_size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_hashmap_remove_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_hashmap_remove_(ecs_hashmap_t* map, int key_size, void* key, int value_size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_hashmap_remove_w_hash_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_hashmap_remove_w_hash_(ecs_hashmap_t* map, int key_size, void* key, int value_size, ulong hash);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_hashmap_set_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_hashmap_set_(ecs_hashmap_t* map, int key_size, void* key, int value_size, void* value);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_hm_bucket_remove", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_hm_bucket_remove(ecs_hashmap_t* map, ecs_hm_bucket_t* bucket, ulong hash, int index);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_identifier_is_0", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte flecs_identifier_is_0(byte* id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_module_path_from_c", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* flecs_module_path_from_c(byte* c_name);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_parse_digit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* flecs_parse_digit(byte* ptr, byte* token);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_parse_ws_eol", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* flecs_parse_ws_eol(byte* ptr);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_poly_claim_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int flecs_poly_claim_(void* poly);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_poly_is_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte flecs_poly_is_(void* @object, int type);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_poly_refcount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int flecs_poly_refcount(void* poly);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_poly_release_", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int flecs_poly_release_(void* poly);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_resume_readonly", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_resume_readonly(ecs_world_t* world, ecs_suspend_readonly_state_t* state);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_sparse_add", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* flecs_sparse_add(ecs_sparse_t* sparse, int elem_size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_sparse_clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_sparse_clear(ecs_sparse_t* sparse);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_sparse_count", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int flecs_sparse_count(ecs_sparse_t* sparse);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_sparse_ensure", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* flecs_sparse_ensure(ecs_sparse_t* sparse, int elem_size, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_sparse_ensure_fast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* flecs_sparse_ensure_fast(ecs_sparse_t* sparse, int elem_size, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_sparse_fini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_sparse_fini(ecs_sparse_t* sparse);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_sparse_get", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* flecs_sparse_get(ecs_sparse_t* sparse, int elem_size, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_sparse_get_any", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* flecs_sparse_get_any(ecs_sparse_t* sparse, int elem_size, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_sparse_get_dense", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* flecs_sparse_get_dense(ecs_sparse_t* sparse, int elem_size, int index);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_sparse_ids", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong* flecs_sparse_ids(ecs_sparse_t* sparse);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_sparse_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_sparse_init(ecs_sparse_t* result, ecs_allocator_t* allocator, ecs_block_allocator_t* page_allocator, int size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_sparse_is_alive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte flecs_sparse_is_alive(ecs_sparse_t* sparse, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_sparse_last_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong flecs_sparse_last_id(ecs_sparse_t* sparse);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_sparse_new_id", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong flecs_sparse_new_id(ecs_sparse_t* sparse);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_sparse_remove", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_sparse_remove(ecs_sparse_t* sparse, int elem_size, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_sparse_remove_fast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* flecs_sparse_remove_fast(ecs_sparse_t* sparse, int size, ulong index);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_sparse_try", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* flecs_sparse_try(ecs_sparse_t* sparse, int elem_size, ulong id);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_stack_alloc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* flecs_stack_alloc(ecs_stack_t* stack, int size, int align);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_stack_calloc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* flecs_stack_calloc(ecs_stack_t* stack, int size, int align);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_stack_fini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_stack_fini(ecs_stack_t* stack);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_stack_free", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_stack_free(void* ptr, int size);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_stack_get_cursor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_stack_cursor_t* flecs_stack_get_cursor(ecs_stack_t* stack);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_stack_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_stack_init(ecs_stack_t* stack);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_stack_reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_stack_reset(ecs_stack_t* stack);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_stack_restore_cursor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_stack_restore_cursor(ecs_stack_t* stack, ecs_stack_cursor_t* cursor);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_strdup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* flecs_strdup(ecs_allocator_t* a, byte* str);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_stresc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int flecs_stresc(byte* @out, int size, byte delimiter, byte* @in);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_strfree", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_strfree(ecs_allocator_t* a, byte* str);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_suspend_readonly", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_world_t* flecs_suspend_readonly(ecs_world_t* world, ecs_suspend_readonly_state_t* state);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_switch_fini", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_switch_fini(ecs_switch_t* sw);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_switch_first", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern uint flecs_switch_first(ecs_switch_t* sw, ulong value);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_switch_get", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ulong flecs_switch_get(ecs_switch_t* sw, uint element);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_switch_init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void flecs_switch_init(ecs_switch_t* sw, ecs_allocator_t* allocator);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_switch_next", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern uint flecs_switch_next(ecs_switch_t* sw, uint previous);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_switch_reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte flecs_switch_reset(ecs_switch_t* sw, uint element);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_switch_set", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte flecs_switch_set(ecs_switch_t* sw, uint element, ulong value);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_switch_targets", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ecs_map_iter_t flecs_switch_targets(ecs_switch_t* sw);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_table_observed_count", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int flecs_table_observed_count(ecs_table_t* table);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_to_snake_case", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* flecs_to_snake_case(byte* str);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "flecs_vasprintf", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern byte* flecs_vasprintf(byte* fmt, void* args);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FlecsAlertsImport", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void FlecsAlertsImport(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FlecsDocImport", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void FlecsDocImport(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FlecsMetaImport", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void FlecsMetaImport(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FlecsMetricsImport", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void FlecsMetricsImport(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FlecsPipelineImport", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void FlecsPipelineImport(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FlecsRestImport", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void FlecsRestImport(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FlecsScriptImport", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void FlecsScriptImport(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FlecsStatsImport", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void FlecsStatsImport(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FlecsSystemImport", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void FlecsSystemImport(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FlecsTimerImport", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void FlecsTimerImport(ecs_world_t* world);

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FlecsUnitsImport", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void FlecsUnitsImport(ecs_world_t* world);

        public partial struct ecs_alert_desc_t : System.IEquatable<ecs_alert_desc_t>
        {
            public int _canary;

            public ulong entity;

            public ecs_query_desc_t query;

            public byte* message;

            public byte* doc_name;

            public byte* brief;

            public ulong severity;

            public severity_filters_FixedBuffer severity_filters;

            public float retain_period;

            public ulong member;

            public ulong id;

            public byte* var;

            public partial struct severity_filters_FixedBuffer : System.IEquatable<severity_filters_FixedBuffer>
            {
                public ecs_alert_severity_filter_t Item0;

                public ecs_alert_severity_filter_t Item1;

                public ecs_alert_severity_filter_t Item2;

                public ecs_alert_severity_filter_t Item3;

                public ref ecs_alert_severity_filter_t this[int index] => ref AsSpan()[index];

                [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public System.Span<ecs_alert_severity_filter_t> AsSpan() => System.Runtime.InteropServices.MemoryMarshal.CreateSpan(ref Item0, 4);

                public bool Equals(severity_filters_FixedBuffer other)
                {
                    fixed (severity_filters_FixedBuffer* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(severity_filters_FixedBuffer)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(severity_filters_FixedBuffer)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is severity_filters_FixedBuffer other && Equals(other);
                }

                public static bool operator ==(severity_filters_FixedBuffer left, severity_filters_FixedBuffer right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(severity_filters_FixedBuffer left, severity_filters_FixedBuffer right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (severity_filters_FixedBuffer* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(severity_filters_FixedBuffer)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public bool Equals(ecs_alert_desc_t other)
            {
                fixed (ecs_alert_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_alert_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_alert_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_alert_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_alert_desc_t left, ecs_alert_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_alert_desc_t left, ecs_alert_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_alert_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_alert_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_alert_severity_filter_t : System.IEquatable<ecs_alert_severity_filter_t>
        {
            public ulong severity;

            public ulong with;

            public byte* var;

            public int _var_index;

            public bool Equals(ecs_alert_severity_filter_t other)
            {
                fixed (ecs_alert_severity_filter_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_alert_severity_filter_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_alert_severity_filter_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_alert_severity_filter_t other && Equals(other);
            }

            public static bool operator ==(ecs_alert_severity_filter_t left, ecs_alert_severity_filter_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_alert_severity_filter_t left, ecs_alert_severity_filter_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_alert_severity_filter_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_alert_severity_filter_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_allocator_t : System.IEquatable<ecs_allocator_t>
        {
            public ecs_block_allocator_t chunks;

            public ecs_sparse_t sizes;

            public bool Equals(ecs_allocator_t other)
            {
                fixed (ecs_allocator_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_allocator_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_allocator_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_allocator_t other && Equals(other);
            }

            public static bool operator ==(ecs_allocator_t left, ecs_allocator_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_allocator_t left, ecs_allocator_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_allocator_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_allocator_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_app_desc_t : System.IEquatable<ecs_app_desc_t>
        {
            public float target_fps;

            public float delta_time;

            public int threads;

            public int frames;

            public byte enable_rest;

            public byte enable_stats;

            public ushort port;

            public System.IntPtr init; // delegate* unmanaged<ecs_world_t*, int>

            public void* ctx;

            public bool Equals(ecs_app_desc_t other)
            {
                fixed (ecs_app_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_app_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_app_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_app_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_app_desc_t left, ecs_app_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_app_desc_t left, ecs_app_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_app_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_app_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_array_desc_t : System.IEquatable<ecs_array_desc_t>
        {
            public ulong entity;

            public ulong type;

            public int count;

            public bool Equals(ecs_array_desc_t other)
            {
                fixed (ecs_array_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_array_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_array_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_array_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_array_desc_t left, ecs_array_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_array_desc_t left, ecs_array_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_array_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_array_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_bitmask_constant_t : System.IEquatable<ecs_bitmask_constant_t>
        {
            public byte* name;

            public uint value;

            public ulong constant;

            public bool Equals(ecs_bitmask_constant_t other)
            {
                fixed (ecs_bitmask_constant_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_bitmask_constant_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_bitmask_constant_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_bitmask_constant_t other && Equals(other);
            }

            public static bool operator ==(ecs_bitmask_constant_t left, ecs_bitmask_constant_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_bitmask_constant_t left, ecs_bitmask_constant_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_bitmask_constant_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_bitmask_constant_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_bitmask_desc_t : System.IEquatable<ecs_bitmask_desc_t>
        {
            public ulong entity;

            public constants_FixedBuffer constants;

            public partial struct constants_FixedBuffer : System.IEquatable<constants_FixedBuffer>
            {
                public ecs_bitmask_constant_t Item0;

                public ecs_bitmask_constant_t Item1;

                public ecs_bitmask_constant_t Item2;

                public ecs_bitmask_constant_t Item3;

                public ecs_bitmask_constant_t Item4;

                public ecs_bitmask_constant_t Item5;

                public ecs_bitmask_constant_t Item6;

                public ecs_bitmask_constant_t Item7;

                public ecs_bitmask_constant_t Item8;

                public ecs_bitmask_constant_t Item9;

                public ecs_bitmask_constant_t Item10;

                public ecs_bitmask_constant_t Item11;

                public ecs_bitmask_constant_t Item12;

                public ecs_bitmask_constant_t Item13;

                public ecs_bitmask_constant_t Item14;

                public ecs_bitmask_constant_t Item15;

                public ecs_bitmask_constant_t Item16;

                public ecs_bitmask_constant_t Item17;

                public ecs_bitmask_constant_t Item18;

                public ecs_bitmask_constant_t Item19;

                public ecs_bitmask_constant_t Item20;

                public ecs_bitmask_constant_t Item21;

                public ecs_bitmask_constant_t Item22;

                public ecs_bitmask_constant_t Item23;

                public ecs_bitmask_constant_t Item24;

                public ecs_bitmask_constant_t Item25;

                public ecs_bitmask_constant_t Item26;

                public ecs_bitmask_constant_t Item27;

                public ecs_bitmask_constant_t Item28;

                public ecs_bitmask_constant_t Item29;

                public ecs_bitmask_constant_t Item30;

                public ecs_bitmask_constant_t Item31;

                public ref ecs_bitmask_constant_t this[int index] => ref AsSpan()[index];

                [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public System.Span<ecs_bitmask_constant_t> AsSpan() => System.Runtime.InteropServices.MemoryMarshal.CreateSpan(ref Item0, 32);

                public bool Equals(constants_FixedBuffer other)
                {
                    fixed (constants_FixedBuffer* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(constants_FixedBuffer)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(constants_FixedBuffer)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is constants_FixedBuffer other && Equals(other);
                }

                public static bool operator ==(constants_FixedBuffer left, constants_FixedBuffer right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(constants_FixedBuffer left, constants_FixedBuffer right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (constants_FixedBuffer* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(constants_FixedBuffer)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public bool Equals(ecs_bitmask_desc_t other)
            {
                fixed (ecs_bitmask_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_bitmask_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_bitmask_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_bitmask_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_bitmask_desc_t left, ecs_bitmask_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_bitmask_desc_t left, ecs_bitmask_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_bitmask_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_bitmask_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_block_allocator_block_t : System.IEquatable<ecs_block_allocator_block_t>
        {
            public void* memory;

            public ecs_block_allocator_block_t* next;

            public bool Equals(ecs_block_allocator_block_t other)
            {
                fixed (ecs_block_allocator_block_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_block_allocator_block_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_block_allocator_block_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_block_allocator_block_t other && Equals(other);
            }

            public static bool operator ==(ecs_block_allocator_block_t left, ecs_block_allocator_block_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_block_allocator_block_t left, ecs_block_allocator_block_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_block_allocator_block_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_block_allocator_block_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_block_allocator_chunk_header_t : System.IEquatable<ecs_block_allocator_chunk_header_t>
        {
            public ecs_block_allocator_chunk_header_t* next;

            public bool Equals(ecs_block_allocator_chunk_header_t other)
            {
                fixed (ecs_block_allocator_chunk_header_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_block_allocator_chunk_header_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_block_allocator_chunk_header_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_block_allocator_chunk_header_t other && Equals(other);
            }

            public static bool operator ==(ecs_block_allocator_chunk_header_t left, ecs_block_allocator_chunk_header_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_block_allocator_chunk_header_t left, ecs_block_allocator_chunk_header_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_block_allocator_chunk_header_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_block_allocator_chunk_header_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_block_allocator_t : System.IEquatable<ecs_block_allocator_t>
        {
            public ecs_block_allocator_chunk_header_t* head;

            public ecs_block_allocator_block_t* block_head;

            public ecs_block_allocator_block_t* block_tail;

            public int chunk_size;

            public int data_size;

            public int chunks_per_block;

            public int block_size;

            public int alloc_count;

            public bool Equals(ecs_block_allocator_t other)
            {
                fixed (ecs_block_allocator_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_block_allocator_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_block_allocator_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_block_allocator_t other && Equals(other);
            }

            public static bool operator ==(ecs_block_allocator_t left, ecs_block_allocator_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_block_allocator_t left, ecs_block_allocator_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_block_allocator_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_block_allocator_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_bucket_entry_t : System.IEquatable<ecs_bucket_entry_t>
        {
            public ulong key;

            public ulong value;

            public ecs_bucket_entry_t* next;

            public bool Equals(ecs_bucket_entry_t other)
            {
                fixed (ecs_bucket_entry_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_bucket_entry_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_bucket_entry_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_bucket_entry_t other && Equals(other);
            }

            public static bool operator ==(ecs_bucket_entry_t left, ecs_bucket_entry_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_bucket_entry_t left, ecs_bucket_entry_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_bucket_entry_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_bucket_entry_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_bucket_t : System.IEquatable<ecs_bucket_t>
        {
            public ecs_bucket_entry_t* first;

            public bool Equals(ecs_bucket_t other)
            {
                fixed (ecs_bucket_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_bucket_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_bucket_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_bucket_t other && Equals(other);
            }

            public static bool operator ==(ecs_bucket_t left, ecs_bucket_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_bucket_t left, ecs_bucket_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_bucket_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_bucket_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_build_info_t : System.IEquatable<ecs_build_info_t>
        {
            public byte* compiler;

            public byte** addons;

            public byte* version;

            public short version_major;

            public short version_minor;

            public short version_patch;

            public byte debug;

            public byte sanitize;

            public byte perf_trace;

            public bool Equals(ecs_build_info_t other)
            {
                fixed (ecs_build_info_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_build_info_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_build_info_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_build_info_t other && Equals(other);
            }

            public static bool operator ==(ecs_build_info_t left, ecs_build_info_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_build_info_t left, ecs_build_info_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_build_info_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_build_info_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_bulk_desc_t : System.IEquatable<ecs_bulk_desc_t>
        {
            public int _canary;

            public ulong* entities;

            public int count;

            public fixed ulong ids[32];

            public void** data;

            public ecs_table_t* table;

            public bool Equals(ecs_bulk_desc_t other)
            {
                fixed (ecs_bulk_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_bulk_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_bulk_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_bulk_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_bulk_desc_t left, ecs_bulk_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_bulk_desc_t left, ecs_bulk_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_bulk_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_bulk_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_component_desc_t : System.IEquatable<ecs_component_desc_t>
        {
            public int _canary;

            public ulong entity;

            public ecs_type_info_t type;

            public bool Equals(ecs_component_desc_t other)
            {
                fixed (ecs_component_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_component_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_component_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_component_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_component_desc_t left, ecs_component_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_component_desc_t left, ecs_component_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_component_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_component_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_counter_t : System.IEquatable<ecs_counter_t>
        {
            public ecs_gauge_t rate;

            public fixed double value[60];

            public bool Equals(ecs_counter_t other)
            {
                fixed (ecs_counter_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_counter_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_counter_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_counter_t other && Equals(other);
            }

            public static bool operator ==(ecs_counter_t left, ecs_counter_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_counter_t left, ecs_counter_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_counter_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_counter_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_data_t : System.IEquatable<ecs_data_t>
        {
            public bool Equals(ecs_data_t other)
            {
                fixed (ecs_data_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_data_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_data_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_data_t other && Equals(other);
            }

            public static bool operator ==(ecs_data_t left, ecs_data_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_data_t left, ecs_data_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_data_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_data_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_each_iter_t : System.IEquatable<ecs_each_iter_t>
        {
            public ecs_table_cache_iter_t it;

            public ulong ids;

            public ulong sources;

            public int sizes;

            public int columns;

            public ecs_table_record_t* trs;

            public bool Equals(ecs_each_iter_t other)
            {
                fixed (ecs_each_iter_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_each_iter_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_each_iter_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_each_iter_t other && Equals(other);
            }

            public static bool operator ==(ecs_each_iter_t left, ecs_each_iter_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_each_iter_t left, ecs_each_iter_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_each_iter_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_each_iter_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_entities_t : System.IEquatable<ecs_entities_t>
        {
            public ulong* ids;

            public int count;

            public int alive_count;

            public bool Equals(ecs_entities_t other)
            {
                fixed (ecs_entities_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_entities_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_entities_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_entities_t other && Equals(other);
            }

            public static bool operator ==(ecs_entities_t left, ecs_entities_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_entities_t left, ecs_entities_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_entities_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_entities_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_entity_desc_t : System.IEquatable<ecs_entity_desc_t>
        {
            public int _canary;

            public ulong id;

            public ulong parent;

            public byte* name;

            public byte* sep;

            public byte* root_sep;

            public byte* symbol;

            public byte use_low_id;

            public ulong* add;

            public ecs_value_t* set;

            public byte* add_expr;

            public bool Equals(ecs_entity_desc_t other)
            {
                fixed (ecs_entity_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_entity_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_entity_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_entity_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_entity_desc_t left, ecs_entity_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_entity_desc_t left, ecs_entity_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_entity_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_entity_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_entity_to_json_desc_t : System.IEquatable<ecs_entity_to_json_desc_t>
        {
            public byte serialize_entity_id;

            public byte serialize_doc;

            public byte serialize_full_paths;

            public byte serialize_inherited;

            public byte serialize_values;

            public byte serialize_builtin;

            public byte serialize_type_info;

            public byte serialize_alerts;

            public ulong serialize_refs;

            public byte serialize_matches;

            public bool Equals(ecs_entity_to_json_desc_t other)
            {
                fixed (ecs_entity_to_json_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_entity_to_json_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_entity_to_json_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_entity_to_json_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_entity_to_json_desc_t left, ecs_entity_to_json_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_entity_to_json_desc_t left, ecs_entity_to_json_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_entity_to_json_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_entity_to_json_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_enum_constant_t : System.IEquatable<ecs_enum_constant_t>
        {
            public byte* name;

            public int value;

            public ulong constant;

            public bool Equals(ecs_enum_constant_t other)
            {
                fixed (ecs_enum_constant_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_enum_constant_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_enum_constant_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_enum_constant_t other && Equals(other);
            }

            public static bool operator ==(ecs_enum_constant_t left, ecs_enum_constant_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_enum_constant_t left, ecs_enum_constant_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_enum_constant_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_enum_constant_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_enum_desc_t : System.IEquatable<ecs_enum_desc_t>
        {
            public ulong entity;

            public constants_FixedBuffer constants;

            public partial struct constants_FixedBuffer : System.IEquatable<constants_FixedBuffer>
            {
                public ecs_enum_constant_t Item0;

                public ecs_enum_constant_t Item1;

                public ecs_enum_constant_t Item2;

                public ecs_enum_constant_t Item3;

                public ecs_enum_constant_t Item4;

                public ecs_enum_constant_t Item5;

                public ecs_enum_constant_t Item6;

                public ecs_enum_constant_t Item7;

                public ecs_enum_constant_t Item8;

                public ecs_enum_constant_t Item9;

                public ecs_enum_constant_t Item10;

                public ecs_enum_constant_t Item11;

                public ecs_enum_constant_t Item12;

                public ecs_enum_constant_t Item13;

                public ecs_enum_constant_t Item14;

                public ecs_enum_constant_t Item15;

                public ecs_enum_constant_t Item16;

                public ecs_enum_constant_t Item17;

                public ecs_enum_constant_t Item18;

                public ecs_enum_constant_t Item19;

                public ecs_enum_constant_t Item20;

                public ecs_enum_constant_t Item21;

                public ecs_enum_constant_t Item22;

                public ecs_enum_constant_t Item23;

                public ecs_enum_constant_t Item24;

                public ecs_enum_constant_t Item25;

                public ecs_enum_constant_t Item26;

                public ecs_enum_constant_t Item27;

                public ecs_enum_constant_t Item28;

                public ecs_enum_constant_t Item29;

                public ecs_enum_constant_t Item30;

                public ecs_enum_constant_t Item31;

                public ref ecs_enum_constant_t this[int index] => ref AsSpan()[index];

                [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public System.Span<ecs_enum_constant_t> AsSpan() => System.Runtime.InteropServices.MemoryMarshal.CreateSpan(ref Item0, 32);

                public bool Equals(constants_FixedBuffer other)
                {
                    fixed (constants_FixedBuffer* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(constants_FixedBuffer)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(constants_FixedBuffer)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is constants_FixedBuffer other && Equals(other);
                }

                public static bool operator ==(constants_FixedBuffer left, constants_FixedBuffer right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(constants_FixedBuffer left, constants_FixedBuffer right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (constants_FixedBuffer* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(constants_FixedBuffer)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public bool Equals(ecs_enum_desc_t other)
            {
                fixed (ecs_enum_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_enum_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_enum_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_enum_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_enum_desc_t left, ecs_enum_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_enum_desc_t left, ecs_enum_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_enum_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_enum_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_event_desc_t : System.IEquatable<ecs_event_desc_t>
        {
            public ulong @event;

            public ecs_type_t* ids;

            public ecs_table_t* table;

            public ecs_table_t* other_table;

            public int offset;

            public int count;

            public ulong entity;

            public void* param;

            public void* const_param;

            public void* observable;

            public uint flags;

            public bool Equals(ecs_event_desc_t other)
            {
                fixed (ecs_event_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_event_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_event_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_event_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_event_desc_t left, ecs_event_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_event_desc_t left, ecs_event_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_event_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_event_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_event_record_t : System.IEquatable<ecs_event_record_t>
        {
            public ecs_event_id_record_t* any;

            public ecs_event_id_record_t* wildcard;

            public ecs_event_id_record_t* wildcard_pair;

            public ecs_map_t event_ids;

            public ulong @event;

            public partial struct ecs_event_id_record_t : System.IEquatable<ecs_event_id_record_t>
            {
                public bool Equals(ecs_event_id_record_t other)
                {
                    fixed (ecs_event_id_record_t* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_event_id_record_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_event_id_record_t)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is ecs_event_id_record_t other && Equals(other);
                }

                public static bool operator ==(ecs_event_id_record_t left, ecs_event_id_record_t right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(ecs_event_id_record_t left, ecs_event_id_record_t right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (ecs_event_id_record_t* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_event_id_record_t)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public bool Equals(ecs_event_record_t other)
            {
                fixed (ecs_event_record_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_event_record_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_event_record_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_event_record_t other && Equals(other);
            }

            public static bool operator ==(ecs_event_record_t left, ecs_event_record_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_event_record_t left, ecs_event_record_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_event_record_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_event_record_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_from_json_desc_t : System.IEquatable<ecs_from_json_desc_t>
        {
            public byte* name;

            public byte* expr;

            public System.IntPtr lookup_action; // delegate* unmanaged<ecs_world_t*, byte*, void*, ulong>

            public void* lookup_ctx;

            public byte strict;

            public bool Equals(ecs_from_json_desc_t other)
            {
                fixed (ecs_from_json_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_from_json_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_from_json_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_from_json_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_from_json_desc_t left, ecs_from_json_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_from_json_desc_t left, ecs_from_json_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_from_json_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_from_json_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_gauge_t : System.IEquatable<ecs_gauge_t>
        {
            public fixed float avg[60];

            public fixed float min[60];

            public fixed float max[60];

            public bool Equals(ecs_gauge_t other)
            {
                fixed (ecs_gauge_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_gauge_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_gauge_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_gauge_t other && Equals(other);
            }

            public static bool operator ==(ecs_gauge_t left, ecs_gauge_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_gauge_t left, ecs_gauge_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_gauge_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_gauge_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_hashmap_t : System.IEquatable<ecs_hashmap_t>
        {
            public System.IntPtr hash; // delegate* unmanaged<void*, ulong>

            public System.IntPtr compare; // delegate* unmanaged<void*, void*, int>

            public int key_size;

            public int value_size;

            public ecs_block_allocator_t* hashmap_allocator;

            public ecs_block_allocator_t bucket_allocator;

            public ecs_map_t impl;

            public bool Equals(ecs_hashmap_t other)
            {
                fixed (ecs_hashmap_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_hashmap_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_hashmap_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_hashmap_t other && Equals(other);
            }

            public static bool operator ==(ecs_hashmap_t left, ecs_hashmap_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_hashmap_t left, ecs_hashmap_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_hashmap_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_hashmap_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_header_t : System.IEquatable<ecs_header_t>
        {
            public int magic;

            public int type;

            public int refcount;

            public ecs_mixins_t* mixins;

            public bool Equals(ecs_header_t other)
            {
                fixed (ecs_header_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_header_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_header_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_header_t other && Equals(other);
            }

            public static bool operator ==(ecs_header_t left, ecs_header_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_header_t left, ecs_header_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_header_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_header_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_hm_bucket_t : System.IEquatable<ecs_hm_bucket_t>
        {
            public ecs_vec_t keys;

            public ecs_vec_t values;

            public bool Equals(ecs_hm_bucket_t other)
            {
                fixed (ecs_hm_bucket_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_hm_bucket_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_hm_bucket_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_hm_bucket_t other && Equals(other);
            }

            public static bool operator ==(ecs_hm_bucket_t left, ecs_hm_bucket_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_hm_bucket_t left, ecs_hm_bucket_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_hm_bucket_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_hm_bucket_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_http_connection_t : System.IEquatable<ecs_http_connection_t>
        {
            public ulong id;

            public ecs_http_server_t* server;

            public fixed byte host[128];

            public fixed byte port[16];

            public bool Equals(ecs_http_connection_t other)
            {
                fixed (ecs_http_connection_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_http_connection_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_http_connection_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_http_connection_t other && Equals(other);
            }

            public static bool operator ==(ecs_http_connection_t left, ecs_http_connection_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_http_connection_t left, ecs_http_connection_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_http_connection_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_http_connection_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_http_key_value_t : System.IEquatable<ecs_http_key_value_t>
        {
            public byte* key;

            public byte* value;

            public bool Equals(ecs_http_key_value_t other)
            {
                fixed (ecs_http_key_value_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_http_key_value_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_http_key_value_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_http_key_value_t other && Equals(other);
            }

            public static bool operator ==(ecs_http_key_value_t left, ecs_http_key_value_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_http_key_value_t left, ecs_http_key_value_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_http_key_value_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_http_key_value_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_http_reply_t : System.IEquatable<ecs_http_reply_t>
        {
            public int code;

            public ecs_strbuf_t body;

            public byte* status;

            public byte* content_type;

            public ecs_strbuf_t headers;

            public bool Equals(ecs_http_reply_t other)
            {
                fixed (ecs_http_reply_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_http_reply_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_http_reply_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_http_reply_t other && Equals(other);
            }

            public static bool operator ==(ecs_http_reply_t left, ecs_http_reply_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_http_reply_t left, ecs_http_reply_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_http_reply_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_http_reply_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_http_request_t : System.IEquatable<ecs_http_request_t>
        {
            public ulong id;

            public ecs_http_method_t method;

            public byte* path;

            public byte* body;

            public headers_FixedBuffer headers;

            public @params_FixedBuffer @params;

            public int header_count;

            public int param_count;

            public ecs_http_connection_t* conn;

            public partial struct headers_FixedBuffer : System.IEquatable<headers_FixedBuffer>
            {
                public ecs_http_key_value_t Item0;

                public ecs_http_key_value_t Item1;

                public ecs_http_key_value_t Item2;

                public ecs_http_key_value_t Item3;

                public ecs_http_key_value_t Item4;

                public ecs_http_key_value_t Item5;

                public ecs_http_key_value_t Item6;

                public ecs_http_key_value_t Item7;

                public ecs_http_key_value_t Item8;

                public ecs_http_key_value_t Item9;

                public ecs_http_key_value_t Item10;

                public ecs_http_key_value_t Item11;

                public ecs_http_key_value_t Item12;

                public ecs_http_key_value_t Item13;

                public ecs_http_key_value_t Item14;

                public ecs_http_key_value_t Item15;

                public ecs_http_key_value_t Item16;

                public ecs_http_key_value_t Item17;

                public ecs_http_key_value_t Item18;

                public ecs_http_key_value_t Item19;

                public ecs_http_key_value_t Item20;

                public ecs_http_key_value_t Item21;

                public ecs_http_key_value_t Item22;

                public ecs_http_key_value_t Item23;

                public ecs_http_key_value_t Item24;

                public ecs_http_key_value_t Item25;

                public ecs_http_key_value_t Item26;

                public ecs_http_key_value_t Item27;

                public ecs_http_key_value_t Item28;

                public ecs_http_key_value_t Item29;

                public ecs_http_key_value_t Item30;

                public ecs_http_key_value_t Item31;

                public ref ecs_http_key_value_t this[int index] => ref AsSpan()[index];

                [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public System.Span<ecs_http_key_value_t> AsSpan() => System.Runtime.InteropServices.MemoryMarshal.CreateSpan(ref Item0, 32);

                public bool Equals(headers_FixedBuffer other)
                {
                    fixed (headers_FixedBuffer* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(headers_FixedBuffer)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(headers_FixedBuffer)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is headers_FixedBuffer other && Equals(other);
                }

                public static bool operator ==(headers_FixedBuffer left, headers_FixedBuffer right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(headers_FixedBuffer left, headers_FixedBuffer right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (headers_FixedBuffer* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(headers_FixedBuffer)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public partial struct @params_FixedBuffer : System.IEquatable<@params_FixedBuffer>
            {
                public ecs_http_key_value_t Item0;

                public ecs_http_key_value_t Item1;

                public ecs_http_key_value_t Item2;

                public ecs_http_key_value_t Item3;

                public ecs_http_key_value_t Item4;

                public ecs_http_key_value_t Item5;

                public ecs_http_key_value_t Item6;

                public ecs_http_key_value_t Item7;

                public ecs_http_key_value_t Item8;

                public ecs_http_key_value_t Item9;

                public ecs_http_key_value_t Item10;

                public ecs_http_key_value_t Item11;

                public ecs_http_key_value_t Item12;

                public ecs_http_key_value_t Item13;

                public ecs_http_key_value_t Item14;

                public ecs_http_key_value_t Item15;

                public ecs_http_key_value_t Item16;

                public ecs_http_key_value_t Item17;

                public ecs_http_key_value_t Item18;

                public ecs_http_key_value_t Item19;

                public ecs_http_key_value_t Item20;

                public ecs_http_key_value_t Item21;

                public ecs_http_key_value_t Item22;

                public ecs_http_key_value_t Item23;

                public ecs_http_key_value_t Item24;

                public ecs_http_key_value_t Item25;

                public ecs_http_key_value_t Item26;

                public ecs_http_key_value_t Item27;

                public ecs_http_key_value_t Item28;

                public ecs_http_key_value_t Item29;

                public ecs_http_key_value_t Item30;

                public ecs_http_key_value_t Item31;

                public ref ecs_http_key_value_t this[int index] => ref AsSpan()[index];

                [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public System.Span<ecs_http_key_value_t> AsSpan() => System.Runtime.InteropServices.MemoryMarshal.CreateSpan(ref Item0, 32);

                public bool Equals(@params_FixedBuffer other)
                {
                    fixed (@params_FixedBuffer* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(@params_FixedBuffer)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(@params_FixedBuffer)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is @params_FixedBuffer other && Equals(other);
                }

                public static bool operator ==(@params_FixedBuffer left, @params_FixedBuffer right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(@params_FixedBuffer left, @params_FixedBuffer right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (@params_FixedBuffer* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(@params_FixedBuffer)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public bool Equals(ecs_http_request_t other)
            {
                fixed (ecs_http_request_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_http_request_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_http_request_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_http_request_t other && Equals(other);
            }

            public static bool operator ==(ecs_http_request_t left, ecs_http_request_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_http_request_t left, ecs_http_request_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_http_request_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_http_request_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_http_server_desc_t : System.IEquatable<ecs_http_server_desc_t>
        {
            public System.IntPtr callback; // delegate* unmanaged<ecs_http_request_t*, ecs_http_reply_t*, void*, byte>

            public void* ctx;

            public ushort port;

            public byte* ipaddr;

            public int send_queue_wait_ms;

            public double cache_timeout;

            public double cache_purge_timeout;

            public bool Equals(ecs_http_server_desc_t other)
            {
                fixed (ecs_http_server_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_http_server_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_http_server_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_http_server_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_http_server_desc_t left, ecs_http_server_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_http_server_desc_t left, ecs_http_server_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_http_server_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_http_server_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_http_server_t : System.IEquatable<ecs_http_server_t>
        {
            public bool Equals(ecs_http_server_t other)
            {
                fixed (ecs_http_server_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_http_server_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_http_server_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_http_server_t other && Equals(other);
            }

            public static bool operator ==(ecs_http_server_t left, ecs_http_server_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_http_server_t left, ecs_http_server_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_http_server_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_http_server_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_id_record_t : System.IEquatable<ecs_id_record_t>
        {
            public bool Equals(ecs_id_record_t other)
            {
                fixed (ecs_id_record_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_id_record_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_id_record_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_id_record_t other && Equals(other);
            }

            public static bool operator ==(ecs_id_record_t left, ecs_id_record_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_id_record_t left, ecs_id_record_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_id_record_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_id_record_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_iter_cache_t : System.IEquatable<ecs_iter_cache_t>
        {
            public ecs_stack_cursor_t* stack_cursor;

            public byte used;

            public byte allocated;

            public bool Equals(ecs_iter_cache_t other)
            {
                fixed (ecs_iter_cache_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_iter_cache_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_iter_cache_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_iter_cache_t other && Equals(other);
            }

            public static bool operator ==(ecs_iter_cache_t left, ecs_iter_cache_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_iter_cache_t left, ecs_iter_cache_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_iter_cache_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_iter_cache_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_iter_private_t : System.IEquatable<ecs_iter_private_t>
        {
            public iter_AnonymousRecord iter;

            public void* entity_iter;

            public ecs_iter_cache_t cache;

            [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
            public partial struct iter_AnonymousRecord : System.IEquatable<iter_AnonymousRecord>
            {
                [System.Runtime.InteropServices.FieldOffset(0)]
                public ecs_query_iter_t query;

                [System.Runtime.InteropServices.FieldOffset(0)]
                public ecs_page_iter_t page;

                [System.Runtime.InteropServices.FieldOffset(0)]
                public ecs_worker_iter_t worker;

                [System.Runtime.InteropServices.FieldOffset(0)]
                public ecs_each_iter_t each;

                public bool Equals(iter_AnonymousRecord other)
                {
                    fixed (iter_AnonymousRecord* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(iter_AnonymousRecord)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(iter_AnonymousRecord)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is iter_AnonymousRecord other && Equals(other);
                }

                public static bool operator ==(iter_AnonymousRecord left, iter_AnonymousRecord right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(iter_AnonymousRecord left, iter_AnonymousRecord right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (iter_AnonymousRecord* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(iter_AnonymousRecord)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public bool Equals(ecs_iter_private_t other)
            {
                fixed (ecs_iter_private_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_iter_private_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_iter_private_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_iter_private_t other && Equals(other);
            }

            public static bool operator ==(ecs_iter_private_t left, ecs_iter_private_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_iter_private_t left, ecs_iter_private_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_iter_private_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_iter_private_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_iter_t : System.IEquatable<ecs_iter_t>
        {
            public ecs_world_t* world;

            public ecs_world_t* real_world;

            public ulong* entities;

            public int* sizes;

            public ecs_table_t* table;

            public ecs_table_t* other_table;

            public ulong* ids;

            public ecs_var_t* variables;

            public ecs_table_record_t** trs;

            public ulong* sources;

            public ulong constrained_vars;

            public ulong group_id;

            public uint set_fields;

            public uint ref_fields;

            public uint row_fields;

            public uint up_fields;

            public ulong system;

            public ulong @event;

            public ulong event_id;

            public int event_cur;

            public byte field_count;

            public byte term_index;

            public byte variable_count;

            public ecs_query_t* query;

            public byte** variable_names;

            public void* param;

            public void* ctx;

            public void* binding_ctx;

            public void* callback_ctx;

            public void* run_ctx;

            public float delta_time;

            public float delta_system_time;

            public int frame_offset;

            public int offset;

            public int count;

            public uint flags;

            public ulong interrupted_by;

            public ecs_iter_private_t priv_;

            public System.IntPtr next; // delegate* unmanaged<ecs_iter_t*, byte>

            public System.IntPtr callback; // delegate* unmanaged<ecs_iter_t*, void>

            public System.IntPtr fini; // delegate* unmanaged<ecs_iter_t*, void>

            public ecs_iter_t* chain_it;

            public bool Equals(ecs_iter_t other)
            {
                fixed (ecs_iter_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_iter_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_iter_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_iter_t other && Equals(other);
            }

            public static bool operator ==(ecs_iter_t left, ecs_iter_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_iter_t left, ecs_iter_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_iter_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_iter_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_iter_to_json_desc_t : System.IEquatable<ecs_iter_to_json_desc_t>
        {
            public byte serialize_entity_ids;

            public byte serialize_values;

            public byte serialize_builtin;

            public byte serialize_doc;

            public byte serialize_full_paths;

            public byte serialize_fields;

            public byte serialize_inherited;

            public byte serialize_table;

            public byte serialize_type_info;

            public byte serialize_field_info;

            public byte serialize_query_info;

            public byte serialize_query_plan;

            public byte serialize_query_profile;

            public byte dont_serialize_results;

            public byte serialize_alerts;

            public ulong serialize_refs;

            public byte serialize_matches;

            public void* query;

            public bool Equals(ecs_iter_to_json_desc_t other)
            {
                fixed (ecs_iter_to_json_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_iter_to_json_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_iter_to_json_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_iter_to_json_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_iter_to_json_desc_t left, ecs_iter_to_json_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_iter_to_json_desc_t left, ecs_iter_to_json_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_iter_to_json_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_iter_to_json_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_map_iter_t : System.IEquatable<ecs_map_iter_t>
        {
            public ecs_map_t* map;

            public ecs_bucket_t* bucket;

            public ecs_bucket_entry_t* entry;

            public ulong* res;

            public bool Equals(ecs_map_iter_t other)
            {
                fixed (ecs_map_iter_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_map_iter_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_map_iter_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_map_iter_t other && Equals(other);
            }

            public static bool operator ==(ecs_map_iter_t left, ecs_map_iter_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_map_iter_t left, ecs_map_iter_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_map_iter_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_map_iter_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_map_params_t : System.IEquatable<ecs_map_params_t>
        {
            public ecs_allocator_t* allocator;

            public ecs_block_allocator_t entry_allocator;

            public bool Equals(ecs_map_params_t other)
            {
                fixed (ecs_map_params_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_map_params_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_map_params_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_map_params_t other && Equals(other);
            }

            public static bool operator ==(ecs_map_params_t left, ecs_map_params_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_map_params_t left, ecs_map_params_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_map_params_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_map_params_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_map_t : System.IEquatable<ecs_map_t>
        {
            public byte bucket_shift;

            public byte shared_allocator;

            public ecs_bucket_t* buckets;

            public int bucket_count;

            public int count;

            public ecs_block_allocator_t* entry_allocator;

            public ecs_allocator_t* allocator;

            public bool Equals(ecs_map_t other)
            {
                fixed (ecs_map_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_map_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_map_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_map_t other && Equals(other);
            }

            public static bool operator ==(ecs_map_t left, ecs_map_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_map_t left, ecs_map_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_map_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_map_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_member_t : System.IEquatable<ecs_member_t>
        {
            public byte* name;

            public ulong type;

            public int count;

            public int offset;

            public ulong unit;

            public byte use_offset;

            public ecs_member_value_range_t range;

            public ecs_member_value_range_t error_range;

            public ecs_member_value_range_t warning_range;

            public int size;

            public ulong member;

            public bool Equals(ecs_member_t other)
            {
                fixed (ecs_member_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_member_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_member_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_member_t other && Equals(other);
            }

            public static bool operator ==(ecs_member_t left, ecs_member_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_member_t left, ecs_member_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_member_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_member_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_member_value_range_t : System.IEquatable<ecs_member_value_range_t>
        {
            public double min;

            public double max;

            public bool Equals(ecs_member_value_range_t other)
            {
                fixed (ecs_member_value_range_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_member_value_range_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_member_value_range_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_member_value_range_t other && Equals(other);
            }

            public static bool operator ==(ecs_member_value_range_t left, ecs_member_value_range_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_member_value_range_t left, ecs_member_value_range_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_member_value_range_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_member_value_range_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_meta_cursor_t : System.IEquatable<ecs_meta_cursor_t>
        {
            public ecs_world_t* world;

            public scope_FixedBuffer scope;

            public int depth;

            public byte valid;

            public byte is_primitive_scope;

            public System.IntPtr lookup_action; // delegate* unmanaged<ecs_world_t*, byte*, void*, ulong>

            public void* lookup_ctx;

            public partial struct scope_FixedBuffer : System.IEquatable<scope_FixedBuffer>
            {
                public ecs_meta_scope_t Item0;

                public ecs_meta_scope_t Item1;

                public ecs_meta_scope_t Item2;

                public ecs_meta_scope_t Item3;

                public ecs_meta_scope_t Item4;

                public ecs_meta_scope_t Item5;

                public ecs_meta_scope_t Item6;

                public ecs_meta_scope_t Item7;

                public ecs_meta_scope_t Item8;

                public ecs_meta_scope_t Item9;

                public ecs_meta_scope_t Item10;

                public ecs_meta_scope_t Item11;

                public ecs_meta_scope_t Item12;

                public ecs_meta_scope_t Item13;

                public ecs_meta_scope_t Item14;

                public ecs_meta_scope_t Item15;

                public ecs_meta_scope_t Item16;

                public ecs_meta_scope_t Item17;

                public ecs_meta_scope_t Item18;

                public ecs_meta_scope_t Item19;

                public ecs_meta_scope_t Item20;

                public ecs_meta_scope_t Item21;

                public ecs_meta_scope_t Item22;

                public ecs_meta_scope_t Item23;

                public ecs_meta_scope_t Item24;

                public ecs_meta_scope_t Item25;

                public ecs_meta_scope_t Item26;

                public ecs_meta_scope_t Item27;

                public ecs_meta_scope_t Item28;

                public ecs_meta_scope_t Item29;

                public ecs_meta_scope_t Item30;

                public ecs_meta_scope_t Item31;

                public ref ecs_meta_scope_t this[int index] => ref AsSpan()[index];

                [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public System.Span<ecs_meta_scope_t> AsSpan() => System.Runtime.InteropServices.MemoryMarshal.CreateSpan(ref Item0, 32);

                public bool Equals(scope_FixedBuffer other)
                {
                    fixed (scope_FixedBuffer* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(scope_FixedBuffer)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(scope_FixedBuffer)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is scope_FixedBuffer other && Equals(other);
                }

                public static bool operator ==(scope_FixedBuffer left, scope_FixedBuffer right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(scope_FixedBuffer left, scope_FixedBuffer right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (scope_FixedBuffer* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(scope_FixedBuffer)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public bool Equals(ecs_meta_cursor_t other)
            {
                fixed (ecs_meta_cursor_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_meta_cursor_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_meta_cursor_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_meta_cursor_t other && Equals(other);
            }

            public static bool operator ==(ecs_meta_cursor_t left, ecs_meta_cursor_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_meta_cursor_t left, ecs_meta_cursor_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_meta_cursor_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_meta_cursor_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_meta_scope_t : System.IEquatable<ecs_meta_scope_t>
        {
            public ulong type;

            public ecs_meta_type_op_t* ops;

            public int op_count;

            public int op_cur;

            public int elem_cur;

            public int prev_depth;

            public void* ptr;

            public EcsComponent* comp;

            public EcsOpaque* opaque;

            public ecs_vec_t* vector;

            public ecs_hashmap_t* members;

            public byte is_collection;

            public byte is_inline_array;

            public byte is_empty_scope;

            public bool Equals(ecs_meta_scope_t other)
            {
                fixed (ecs_meta_scope_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_meta_scope_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_meta_scope_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_meta_scope_t other && Equals(other);
            }

            public static bool operator ==(ecs_meta_scope_t left, ecs_meta_scope_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_meta_scope_t left, ecs_meta_scope_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_meta_scope_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_meta_scope_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_meta_type_op_t : System.IEquatable<ecs_meta_type_op_t>
        {
            public ecs_meta_type_op_kind_t kind;

            public int offset;

            public int count;

            public byte* name;

            public int op_count;

            public int size;

            public ulong type;

            public int member_index;

            public ecs_hashmap_t* members;

            public bool Equals(ecs_meta_type_op_t other)
            {
                fixed (ecs_meta_type_op_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_meta_type_op_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_meta_type_op_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_meta_type_op_t other && Equals(other);
            }

            public static bool operator ==(ecs_meta_type_op_t left, ecs_meta_type_op_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_meta_type_op_t left, ecs_meta_type_op_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_meta_type_op_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_meta_type_op_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_metric_desc_t : System.IEquatable<ecs_metric_desc_t>
        {
            public int _canary;

            public ulong entity;

            public ulong member;

            public byte* dotmember;

            public ulong id;

            public byte targets;

            public ulong kind;

            public byte* brief;

            public bool Equals(ecs_metric_desc_t other)
            {
                fixed (ecs_metric_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_metric_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_metric_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_metric_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_metric_desc_t left, ecs_metric_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_metric_desc_t left, ecs_metric_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_metric_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_metric_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public partial struct ecs_metric_t : System.IEquatable<ecs_metric_t>
        {
            [System.Runtime.InteropServices.FieldOffset(0)]
            public ecs_gauge_t gauge;

            [System.Runtime.InteropServices.FieldOffset(0)]
            public ecs_counter_t counter;

            public bool Equals(ecs_metric_t other)
            {
                fixed (ecs_metric_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_metric_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_metric_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_metric_t other && Equals(other);
            }

            public static bool operator ==(ecs_metric_t left, ecs_metric_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_metric_t left, ecs_metric_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_metric_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_metric_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_mixins_t : System.IEquatable<ecs_mixins_t>
        {
            public bool Equals(ecs_mixins_t other)
            {
                fixed (ecs_mixins_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_mixins_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_mixins_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_mixins_t other && Equals(other);
            }

            public static bool operator ==(ecs_mixins_t left, ecs_mixins_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_mixins_t left, ecs_mixins_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_mixins_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_mixins_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_observable_t : System.IEquatable<ecs_observable_t>
        {
            public ecs_event_record_t on_add;

            public ecs_event_record_t on_remove;

            public ecs_event_record_t on_set;

            public ecs_event_record_t on_wildcard;

            public ecs_sparse_t events;

            public bool Equals(ecs_observable_t other)
            {
                fixed (ecs_observable_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_observable_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_observable_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_observable_t other && Equals(other);
            }

            public static bool operator ==(ecs_observable_t left, ecs_observable_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_observable_t left, ecs_observable_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_observable_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_observable_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_observer_desc_t : System.IEquatable<ecs_observer_desc_t>
        {
            public int _canary;

            public ulong entity;

            public ecs_query_desc_t query;

            public fixed ulong events[8];

            public byte yield_existing;

            public System.IntPtr callback; // delegate* unmanaged<ecs_iter_t*, void>

            public System.IntPtr run; // delegate* unmanaged<ecs_iter_t*, void>

            public void* ctx;

            public System.IntPtr ctx_free; // delegate* unmanaged<void*, void>

            public void* callback_ctx;

            public System.IntPtr callback_ctx_free; // delegate* unmanaged<void*, void>

            public void* run_ctx;

            public System.IntPtr run_ctx_free; // delegate* unmanaged<void*, void>

            public void* observable;

            public int* last_event_id;

            public byte term_index_;

            public uint flags_;

            public bool Equals(ecs_observer_desc_t other)
            {
                fixed (ecs_observer_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_observer_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_observer_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_observer_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_observer_desc_t left, ecs_observer_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_observer_desc_t left, ecs_observer_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_observer_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_observer_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_observer_t : System.IEquatable<ecs_observer_t>
        {
            public ecs_header_t hdr;

            public ecs_query_t* query;

            public fixed ulong events[8];

            public int event_count;

            public System.IntPtr callback; // delegate* unmanaged<ecs_iter_t*, void>

            public System.IntPtr run; // delegate* unmanaged<ecs_iter_t*, void>

            public void* ctx;

            public void* callback_ctx;

            public void* run_ctx;

            public System.IntPtr ctx_free; // delegate* unmanaged<void*, void>

            public System.IntPtr callback_ctx_free; // delegate* unmanaged<void*, void>

            public System.IntPtr run_ctx_free; // delegate* unmanaged<void*, void>

            public ecs_observable_t* observable;

            public ecs_world_t* world;

            public ulong entity;

            public bool Equals(ecs_observer_t other)
            {
                fixed (ecs_observer_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_observer_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_observer_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_observer_t other && Equals(other);
            }

            public static bool operator ==(ecs_observer_t left, ecs_observer_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_observer_t left, ecs_observer_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_observer_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_observer_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_opaque_desc_t : System.IEquatable<ecs_opaque_desc_t>
        {
            public ulong entity;

            public EcsOpaque type;

            public bool Equals(ecs_opaque_desc_t other)
            {
                fixed (ecs_opaque_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_opaque_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_opaque_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_opaque_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_opaque_desc_t left, ecs_opaque_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_opaque_desc_t left, ecs_opaque_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_opaque_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_opaque_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_os_api_t : System.IEquatable<ecs_os_api_t>
        {
            public System.IntPtr init_; // delegate* unmanaged<void>

            public System.IntPtr fini_; // delegate* unmanaged<void>

            public System.IntPtr malloc_; // delegate* unmanaged<int, void*>

            public System.IntPtr realloc_; // delegate* unmanaged<void*, int, void*>

            public System.IntPtr calloc_; // delegate* unmanaged<int, void*>

            public System.IntPtr free_; // delegate* unmanaged<void*, void>

            public System.IntPtr strdup_; // delegate* unmanaged<byte*, byte*>

            public System.IntPtr thread_new_; // delegate* unmanaged<System.IntPtr, void*, ulong>

            public System.IntPtr thread_join_; // delegate* unmanaged<ulong, void*>

            public System.IntPtr thread_self_; // delegate* unmanaged<ulong>

            public System.IntPtr task_new_; // delegate* unmanaged<System.IntPtr, void*, ulong>

            public System.IntPtr task_join_; // delegate* unmanaged<ulong, void*>

            public System.IntPtr ainc_; // delegate* unmanaged<int*, int>

            public System.IntPtr adec_; // delegate* unmanaged<int*, int>

            public System.IntPtr lainc_; // delegate* unmanaged<long*, long>

            public System.IntPtr ladec_; // delegate* unmanaged<long*, long>

            public System.IntPtr mutex_new_; // delegate* unmanaged<ulong>

            public System.IntPtr mutex_free_; // delegate* unmanaged<ulong, void>

            public System.IntPtr mutex_lock_; // delegate* unmanaged<ulong, void>

            public System.IntPtr mutex_unlock_; // delegate* unmanaged<ulong, void>

            public System.IntPtr cond_new_; // delegate* unmanaged<ulong>

            public System.IntPtr cond_free_; // delegate* unmanaged<ulong, void>

            public System.IntPtr cond_signal_; // delegate* unmanaged<ulong, void>

            public System.IntPtr cond_broadcast_; // delegate* unmanaged<ulong, void>

            public System.IntPtr cond_wait_; // delegate* unmanaged<ulong, ulong, void>

            public System.IntPtr sleep_; // delegate* unmanaged<int, int, void>

            public System.IntPtr now_; // delegate* unmanaged<ulong>

            public System.IntPtr get_time_; // delegate* unmanaged<ecs_time_t*, void>

            public System.IntPtr log_; // delegate* unmanaged<int, byte*, int, byte*, void>

            public System.IntPtr abort_; // delegate* unmanaged<void>

            public System.IntPtr dlopen_; // delegate* unmanaged<byte*, ulong>

            public System.IntPtr dlproc_; // delegate* unmanaged<ulong, byte*, System.IntPtr>

            public System.IntPtr dlclose_; // delegate* unmanaged<ulong, void>

            public System.IntPtr module_to_dl_; // delegate* unmanaged<byte*, byte*>

            public System.IntPtr module_to_etc_; // delegate* unmanaged<byte*, byte*>

            public System.IntPtr perf_trace_push_; // delegate* unmanaged<byte*, ulong, byte*, void>

            public System.IntPtr perf_trace_pop_; // delegate* unmanaged<byte*, ulong, byte*, void>

            public int log_level_;

            public int log_indent_;

            public int log_last_error_;

            public long log_last_timestamp_;

            public uint flags_;

            public void* log_out_;

            public bool Equals(ecs_os_api_t other)
            {
                fixed (ecs_os_api_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_os_api_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_os_api_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_os_api_t other && Equals(other);
            }

            public static bool operator ==(ecs_os_api_t left, ecs_os_api_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_os_api_t left, ecs_os_api_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_os_api_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_os_api_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_page_iter_t : System.IEquatable<ecs_page_iter_t>
        {
            public int offset;

            public int limit;

            public int remaining;

            public bool Equals(ecs_page_iter_t other)
            {
                fixed (ecs_page_iter_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_page_iter_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_page_iter_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_page_iter_t other && Equals(other);
            }

            public static bool operator ==(ecs_page_iter_t left, ecs_page_iter_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_page_iter_t left, ecs_page_iter_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_page_iter_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_page_iter_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_pipeline_desc_t : System.IEquatable<ecs_pipeline_desc_t>
        {
            public ulong entity;

            public ecs_query_desc_t query;

            public bool Equals(ecs_pipeline_desc_t other)
            {
                fixed (ecs_pipeline_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_pipeline_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_pipeline_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_pipeline_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_pipeline_desc_t left, ecs_pipeline_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_pipeline_desc_t left, ecs_pipeline_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_pipeline_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_pipeline_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_pipeline_stats_t : System.IEquatable<ecs_pipeline_stats_t>
        {
            public byte canary_;

            public ecs_vec_t systems;

            public ecs_vec_t sync_points;

            public int t;

            public int system_count;

            public int active_system_count;

            public int rebuild_count;

            public bool Equals(ecs_pipeline_stats_t other)
            {
                fixed (ecs_pipeline_stats_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_pipeline_stats_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_pipeline_stats_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_pipeline_stats_t other && Equals(other);
            }

            public static bool operator ==(ecs_pipeline_stats_t left, ecs_pipeline_stats_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_pipeline_stats_t left, ecs_pipeline_stats_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_pipeline_stats_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_pipeline_stats_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_primitive_desc_t : System.IEquatable<ecs_primitive_desc_t>
        {
            public ulong entity;

            public ecs_primitive_kind_t kind;

            public bool Equals(ecs_primitive_desc_t other)
            {
                fixed (ecs_primitive_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_primitive_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_primitive_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_primitive_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_primitive_desc_t left, ecs_primitive_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_primitive_desc_t left, ecs_primitive_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_primitive_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_primitive_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_query_cache_table_match_t : System.IEquatable<ecs_query_cache_table_match_t>
        {
            public bool Equals(ecs_query_cache_table_match_t other)
            {
                fixed (ecs_query_cache_table_match_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_cache_table_match_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_query_cache_table_match_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_query_cache_table_match_t other && Equals(other);
            }

            public static bool operator ==(ecs_query_cache_table_match_t left, ecs_query_cache_table_match_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_query_cache_table_match_t left, ecs_query_cache_table_match_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_query_cache_table_match_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_cache_table_match_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_query_count_t : System.IEquatable<ecs_query_count_t>
        {
            public int results;

            public int entities;

            public int tables;

            public int empty_tables;

            public bool Equals(ecs_query_count_t other)
            {
                fixed (ecs_query_count_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_count_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_query_count_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_query_count_t other && Equals(other);
            }

            public static bool operator ==(ecs_query_count_t left, ecs_query_count_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_query_count_t left, ecs_query_count_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_query_count_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_count_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_query_desc_t : System.IEquatable<ecs_query_desc_t>
        {
            public int _canary;

            public terms_FixedBuffer terms;

            public byte* expr;

            public ecs_query_cache_kind_t cache_kind;

            public uint flags;

            public System.IntPtr order_by_callback; // delegate* unmanaged<ulong, void*, ulong, void*, int>

            public System.IntPtr order_by_table_callback; // delegate* unmanaged<ecs_world_t*, ecs_table_t*, ulong*, void*, int, int, int, System.IntPtr, void>

            public ulong order_by;

            public ulong group_by;

            public System.IntPtr group_by_callback; // delegate* unmanaged<ecs_world_t*, ecs_table_t*, ulong, void*, ulong>

            public System.IntPtr on_group_create; // delegate* unmanaged<ecs_world_t*, ulong, void*, void*>

            public System.IntPtr on_group_delete; // delegate* unmanaged<ecs_world_t*, ulong, void*, void*, void>

            public void* group_by_ctx;

            public System.IntPtr group_by_ctx_free; // delegate* unmanaged<void*, void>

            public void* ctx;

            public void* binding_ctx;

            public System.IntPtr ctx_free; // delegate* unmanaged<void*, void>

            public System.IntPtr binding_ctx_free; // delegate* unmanaged<void*, void>

            public ulong entity;

            public partial struct terms_FixedBuffer : System.IEquatable<terms_FixedBuffer>
            {
                public ecs_term_t Item0;

                public ecs_term_t Item1;

                public ecs_term_t Item2;

                public ecs_term_t Item3;

                public ecs_term_t Item4;

                public ecs_term_t Item5;

                public ecs_term_t Item6;

                public ecs_term_t Item7;

                public ecs_term_t Item8;

                public ecs_term_t Item9;

                public ecs_term_t Item10;

                public ecs_term_t Item11;

                public ecs_term_t Item12;

                public ecs_term_t Item13;

                public ecs_term_t Item14;

                public ecs_term_t Item15;

                public ecs_term_t Item16;

                public ecs_term_t Item17;

                public ecs_term_t Item18;

                public ecs_term_t Item19;

                public ecs_term_t Item20;

                public ecs_term_t Item21;

                public ecs_term_t Item22;

                public ecs_term_t Item23;

                public ecs_term_t Item24;

                public ecs_term_t Item25;

                public ecs_term_t Item26;

                public ecs_term_t Item27;

                public ecs_term_t Item28;

                public ecs_term_t Item29;

                public ecs_term_t Item30;

                public ecs_term_t Item31;

                public ref ecs_term_t this[int index] => ref AsSpan()[index];

                [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public System.Span<ecs_term_t> AsSpan() => System.Runtime.InteropServices.MemoryMarshal.CreateSpan(ref Item0, 32);

                public bool Equals(terms_FixedBuffer other)
                {
                    fixed (terms_FixedBuffer* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(terms_FixedBuffer)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(terms_FixedBuffer)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is terms_FixedBuffer other && Equals(other);
                }

                public static bool operator ==(terms_FixedBuffer left, terms_FixedBuffer right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(terms_FixedBuffer left, terms_FixedBuffer right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (terms_FixedBuffer* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(terms_FixedBuffer)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public bool Equals(ecs_query_desc_t other)
            {
                fixed (ecs_query_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_query_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_query_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_query_desc_t left, ecs_query_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_query_desc_t left, ecs_query_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_query_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_query_group_info_t : System.IEquatable<ecs_query_group_info_t>
        {
            public int match_count;

            public int table_count;

            public void* ctx;

            public bool Equals(ecs_query_group_info_t other)
            {
                fixed (ecs_query_group_info_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_group_info_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_query_group_info_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_query_group_info_t other && Equals(other);
            }

            public static bool operator ==(ecs_query_group_info_t left, ecs_query_group_info_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_query_group_info_t left, ecs_query_group_info_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_query_group_info_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_group_info_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_query_iter_t : System.IEquatable<ecs_query_iter_t>
        {
            public ecs_query_t* query;

            public ecs_var_t* vars;

            public ecs_query_var_t* query_vars;

            public ecs_query_op_t* ops;

            public ecs_query_op_ctx_t* op_ctx;

            public ecs_query_cache_table_match_t* node;

            public ecs_query_cache_table_match_t* prev;

            public ecs_query_cache_table_match_t* last;

            public ulong* written;

            public int skip_count;

            public ecs_query_op_profile_t* profile;

            public short op;

            public short sp;

            public partial struct ecs_query_var_t : System.IEquatable<ecs_query_var_t>
            {
                public bool Equals(ecs_query_var_t other)
                {
                    fixed (ecs_query_var_t* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_var_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_query_var_t)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is ecs_query_var_t other && Equals(other);
                }

                public static bool operator ==(ecs_query_var_t left, ecs_query_var_t right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(ecs_query_var_t left, ecs_query_var_t right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (ecs_query_var_t* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_var_t)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public partial struct ecs_query_op_t : System.IEquatable<ecs_query_op_t>
            {
                public bool Equals(ecs_query_op_t other)
                {
                    fixed (ecs_query_op_t* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_op_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_query_op_t)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is ecs_query_op_t other && Equals(other);
                }

                public static bool operator ==(ecs_query_op_t left, ecs_query_op_t right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(ecs_query_op_t left, ecs_query_op_t right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (ecs_query_op_t* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_op_t)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public partial struct ecs_query_op_ctx_t : System.IEquatable<ecs_query_op_ctx_t>
            {
                public bool Equals(ecs_query_op_ctx_t other)
                {
                    fixed (ecs_query_op_ctx_t* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_op_ctx_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_query_op_ctx_t)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is ecs_query_op_ctx_t other && Equals(other);
                }

                public static bool operator ==(ecs_query_op_ctx_t left, ecs_query_op_ctx_t right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(ecs_query_op_ctx_t left, ecs_query_op_ctx_t right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (ecs_query_op_ctx_t* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_op_ctx_t)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public bool Equals(ecs_query_iter_t other)
            {
                fixed (ecs_query_iter_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_iter_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_query_iter_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_query_iter_t other && Equals(other);
            }

            public static bool operator ==(ecs_query_iter_t left, ecs_query_iter_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_query_iter_t left, ecs_query_iter_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_query_iter_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_iter_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_query_op_profile_t : System.IEquatable<ecs_query_op_profile_t>
        {
            public fixed int count[2];

            public bool Equals(ecs_query_op_profile_t other)
            {
                fixed (ecs_query_op_profile_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_op_profile_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_query_op_profile_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_query_op_profile_t other && Equals(other);
            }

            public static bool operator ==(ecs_query_op_profile_t left, ecs_query_op_profile_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_query_op_profile_t left, ecs_query_op_profile_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_query_op_profile_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_op_profile_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_query_stats_t : System.IEquatable<ecs_query_stats_t>
        {
            public long first_;

            public ecs_metric_t result_count;

            public ecs_metric_t matched_table_count;

            public ecs_metric_t matched_entity_count;

            public long last_;

            public int t;

            public bool Equals(ecs_query_stats_t other)
            {
                fixed (ecs_query_stats_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_stats_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_query_stats_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_query_stats_t other && Equals(other);
            }

            public static bool operator ==(ecs_query_stats_t left, ecs_query_stats_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_query_stats_t left, ecs_query_stats_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_query_stats_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_stats_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_query_t : System.IEquatable<ecs_query_t>
        {
            public ecs_header_t hdr;

            public terms_FixedBuffer terms;

            public fixed int sizes[32];

            public fixed ulong ids[32];

            public uint flags;

            public byte var_count;

            public byte term_count;

            public byte field_count;

            public uint fixed_fields;

            public uint var_fields;

            public uint static_id_fields;

            public uint data_fields;

            public uint write_fields;

            public uint read_fields;

            public uint row_fields;

            public uint shared_readonly_fields;

            public uint set_fields;

            public ecs_query_cache_kind_t cache_kind;

            public byte** vars;

            public void* ctx;

            public void* binding_ctx;

            public ulong entity;

            public ecs_world_t* real_world;

            public ecs_world_t* world;

            public int eval_count;

            public partial struct terms_FixedBuffer : System.IEquatable<terms_FixedBuffer>
            {
                public ecs_term_t Item0;

                public ecs_term_t Item1;

                public ecs_term_t Item2;

                public ecs_term_t Item3;

                public ecs_term_t Item4;

                public ecs_term_t Item5;

                public ecs_term_t Item6;

                public ecs_term_t Item7;

                public ecs_term_t Item8;

                public ecs_term_t Item9;

                public ecs_term_t Item10;

                public ecs_term_t Item11;

                public ecs_term_t Item12;

                public ecs_term_t Item13;

                public ecs_term_t Item14;

                public ecs_term_t Item15;

                public ecs_term_t Item16;

                public ecs_term_t Item17;

                public ecs_term_t Item18;

                public ecs_term_t Item19;

                public ecs_term_t Item20;

                public ecs_term_t Item21;

                public ecs_term_t Item22;

                public ecs_term_t Item23;

                public ecs_term_t Item24;

                public ecs_term_t Item25;

                public ecs_term_t Item26;

                public ecs_term_t Item27;

                public ecs_term_t Item28;

                public ecs_term_t Item29;

                public ecs_term_t Item30;

                public ecs_term_t Item31;

                public ref ecs_term_t this[int index] => ref AsSpan()[index];

                [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public System.Span<ecs_term_t> AsSpan() => System.Runtime.InteropServices.MemoryMarshal.CreateSpan(ref Item0, 32);

                public bool Equals(terms_FixedBuffer other)
                {
                    fixed (terms_FixedBuffer* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(terms_FixedBuffer)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(terms_FixedBuffer)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is terms_FixedBuffer other && Equals(other);
                }

                public static bool operator ==(terms_FixedBuffer left, terms_FixedBuffer right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(terms_FixedBuffer left, terms_FixedBuffer right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (terms_FixedBuffer* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(terms_FixedBuffer)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public bool Equals(ecs_query_t other)
            {
                fixed (ecs_query_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_query_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_query_t other && Equals(other);
            }

            public static bool operator ==(ecs_query_t left, ecs_query_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_query_t left, ecs_query_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_query_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_query_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_record_t : System.IEquatable<ecs_record_t>
        {
            public ecs_id_record_t* idr;

            public ecs_table_t* table;

            public uint row;

            public int dense;

            public bool Equals(ecs_record_t other)
            {
                fixed (ecs_record_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_record_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_record_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_record_t other && Equals(other);
            }

            public static bool operator ==(ecs_record_t left, ecs_record_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_record_t left, ecs_record_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_record_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_record_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_ref_t : System.IEquatable<ecs_ref_t>
        {
            public ulong entity;

            public ulong id;

            public ulong table_id;

            public ecs_table_record_t* tr;

            public ecs_record_t* record;

            public bool Equals(ecs_ref_t other)
            {
                fixed (ecs_ref_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_ref_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_ref_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_ref_t other && Equals(other);
            }

            public static bool operator ==(ecs_ref_t left, ecs_ref_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_ref_t left, ecs_ref_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_ref_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_ref_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_script_desc_t : System.IEquatable<ecs_script_desc_t>
        {
            public ulong entity;

            public byte* filename;

            public byte* code;

            public bool Equals(ecs_script_desc_t other)
            {
                fixed (ecs_script_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_script_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_script_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_script_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_script_desc_t left, ecs_script_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_script_desc_t left, ecs_script_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_script_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_script_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_script_expr_run_desc_t : System.IEquatable<ecs_script_expr_run_desc_t>
        {
            public byte* name;

            public byte* expr;

            public System.IntPtr lookup_action; // delegate* unmanaged<ecs_world_t*, byte*, void*, ulong>

            public void* lookup_ctx;

            public ecs_script_vars_t* vars;

            public bool Equals(ecs_script_expr_run_desc_t other)
            {
                fixed (ecs_script_expr_run_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_script_expr_run_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_script_expr_run_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_script_expr_run_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_script_expr_run_desc_t left, ecs_script_expr_run_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_script_expr_run_desc_t left, ecs_script_expr_run_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_script_expr_run_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_script_expr_run_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_script_t : System.IEquatable<ecs_script_t>
        {
            public ecs_world_t* world;

            public byte* name;

            public byte* code;

            public bool Equals(ecs_script_t other)
            {
                fixed (ecs_script_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_script_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_script_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_script_t other && Equals(other);
            }

            public static bool operator ==(ecs_script_t left, ecs_script_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_script_t left, ecs_script_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_script_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_script_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_script_template_t : System.IEquatable<ecs_script_template_t>
        {
            public bool Equals(ecs_script_template_t other)
            {
                fixed (ecs_script_template_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_script_template_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_script_template_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_script_template_t other && Equals(other);
            }

            public static bool operator ==(ecs_script_template_t left, ecs_script_template_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_script_template_t left, ecs_script_template_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_script_template_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_script_template_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_script_var_t : System.IEquatable<ecs_script_var_t>
        {
            public byte* name;

            public ecs_value_t value;

            public ecs_type_info_t* type_info;

            public bool Equals(ecs_script_var_t other)
            {
                fixed (ecs_script_var_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_script_var_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_script_var_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_script_var_t other && Equals(other);
            }

            public static bool operator ==(ecs_script_var_t left, ecs_script_var_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_script_var_t left, ecs_script_var_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_script_var_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_script_var_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_script_vars_t : System.IEquatable<ecs_script_vars_t>
        {
            public ecs_script_vars_t* parent;

            public ecs_hashmap_t var_index;

            public ecs_vec_t vars;

            public ecs_world_t* world;

            public ecs_stack_t* stack;

            public ecs_stack_cursor_t* cursor;

            public ecs_allocator_t* allocator;

            public bool Equals(ecs_script_vars_t other)
            {
                fixed (ecs_script_vars_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_script_vars_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_script_vars_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_script_vars_t other && Equals(other);
            }

            public static bool operator ==(ecs_script_vars_t left, ecs_script_vars_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_script_vars_t left, ecs_script_vars_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_script_vars_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_script_vars_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_serializer_t : System.IEquatable<ecs_serializer_t>
        {
            public System.IntPtr value; // delegate* unmanaged<ecs_serializer_t*, ulong, void*, int>

            public System.IntPtr member; // delegate* unmanaged<ecs_serializer_t*, byte*, int>

            public ecs_world_t* world;

            public void* ctx;

            public bool Equals(ecs_serializer_t other)
            {
                fixed (ecs_serializer_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_serializer_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_serializer_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_serializer_t other && Equals(other);
            }

            public static bool operator ==(ecs_serializer_t left, ecs_serializer_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_serializer_t left, ecs_serializer_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_serializer_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_serializer_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_sparse_t : System.IEquatable<ecs_sparse_t>
        {
            public ecs_vec_t dense;

            public ecs_vec_t pages;

            public int size;

            public int count;

            public ulong max_id;

            public ecs_allocator_t* allocator;

            public ecs_block_allocator_t* page_allocator;

            public partial struct ecs_block_allocator_t : System.IEquatable<ecs_block_allocator_t>
            {
                public ecs_block_allocator_chunk_header_t* head;

                public ecs_block_allocator_block_t* block_head;

                public ecs_block_allocator_block_t* block_tail;

                public int chunk_size;

                public int data_size;

                public int chunks_per_block;

                public int block_size;

                public int alloc_count;

                public bool Equals(ecs_block_allocator_t other)
                {
                    fixed (ecs_block_allocator_t* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_block_allocator_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_block_allocator_t)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is ecs_block_allocator_t other && Equals(other);
                }

                public static bool operator ==(ecs_block_allocator_t left, ecs_block_allocator_t right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(ecs_block_allocator_t left, ecs_block_allocator_t right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (ecs_block_allocator_t* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_block_allocator_t)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public bool Equals(ecs_sparse_t other)
            {
                fixed (ecs_sparse_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_sparse_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_sparse_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_sparse_t other && Equals(other);
            }

            public static bool operator ==(ecs_sparse_t left, ecs_sparse_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_sparse_t left, ecs_sparse_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_sparse_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_sparse_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_stack_cursor_t : System.IEquatable<ecs_stack_cursor_t>
        {
            public ecs_stack_cursor_t* prev;

            public ecs_stack_page_t* page;

            public short sp;

            public byte is_free;

            public ecs_stack_t* owner;

            public partial struct ecs_stack_t : System.IEquatable<ecs_stack_t>
            {
                public ecs_stack_page_t first;

                public ecs_stack_page_t* tail_page;

                public ecs_stack_cursor_t* tail_cursor;

                public int cursor_count;

                public bool Equals(ecs_stack_t other)
                {
                    fixed (ecs_stack_t* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_stack_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_stack_t)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is ecs_stack_t other && Equals(other);
                }

                public static bool operator ==(ecs_stack_t left, ecs_stack_t right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(ecs_stack_t left, ecs_stack_t right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (ecs_stack_t* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_stack_t)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public bool Equals(ecs_stack_cursor_t other)
            {
                fixed (ecs_stack_cursor_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_stack_cursor_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_stack_cursor_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_stack_cursor_t other && Equals(other);
            }

            public static bool operator ==(ecs_stack_cursor_t left, ecs_stack_cursor_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_stack_cursor_t left, ecs_stack_cursor_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_stack_cursor_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_stack_cursor_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_stack_page_t : System.IEquatable<ecs_stack_page_t>
        {
            public void* data;

            public ecs_stack_page_t* next;

            public short sp;

            public uint id;

            public bool Equals(ecs_stack_page_t other)
            {
                fixed (ecs_stack_page_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_stack_page_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_stack_page_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_stack_page_t other && Equals(other);
            }

            public static bool operator ==(ecs_stack_page_t left, ecs_stack_page_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_stack_page_t left, ecs_stack_page_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_stack_page_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_stack_page_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_stack_t : System.IEquatable<ecs_stack_t>
        {
            public ecs_stack_page_t first;

            public ecs_stack_page_t* tail_page;

            public ecs_stack_cursor_t* tail_cursor;

            public int cursor_count;

            public bool Equals(ecs_stack_t other)
            {
                fixed (ecs_stack_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_stack_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_stack_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_stack_t other && Equals(other);
            }

            public static bool operator ==(ecs_stack_t left, ecs_stack_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_stack_t left, ecs_stack_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_stack_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_stack_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_stage_t : System.IEquatable<ecs_stage_t>
        {
            public bool Equals(ecs_stage_t other)
            {
                fixed (ecs_stage_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_stage_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_stage_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_stage_t other && Equals(other);
            }

            public static bool operator ==(ecs_stage_t left, ecs_stage_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_stage_t left, ecs_stage_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_stage_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_stage_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_strbuf_list_elem : System.IEquatable<ecs_strbuf_list_elem>
        {
            public int count;

            public byte* separator;

            public bool Equals(ecs_strbuf_list_elem other)
            {
                fixed (ecs_strbuf_list_elem* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_strbuf_list_elem)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_strbuf_list_elem)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_strbuf_list_elem other && Equals(other);
            }

            public static bool operator ==(ecs_strbuf_list_elem left, ecs_strbuf_list_elem right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_strbuf_list_elem left, ecs_strbuf_list_elem right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_strbuf_list_elem* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_strbuf_list_elem)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_strbuf_t : System.IEquatable<ecs_strbuf_t>
        {
            public byte* content;

            public int length;

            public int size;

            public list_stack_FixedBuffer list_stack;

            public int list_sp;

            public fixed byte small_string[512];

            public partial struct list_stack_FixedBuffer : System.IEquatable<list_stack_FixedBuffer>
            {
                public ecs_strbuf_list_elem Item0;

                public ecs_strbuf_list_elem Item1;

                public ecs_strbuf_list_elem Item2;

                public ecs_strbuf_list_elem Item3;

                public ecs_strbuf_list_elem Item4;

                public ecs_strbuf_list_elem Item5;

                public ecs_strbuf_list_elem Item6;

                public ecs_strbuf_list_elem Item7;

                public ecs_strbuf_list_elem Item8;

                public ecs_strbuf_list_elem Item9;

                public ecs_strbuf_list_elem Item10;

                public ecs_strbuf_list_elem Item11;

                public ecs_strbuf_list_elem Item12;

                public ecs_strbuf_list_elem Item13;

                public ecs_strbuf_list_elem Item14;

                public ecs_strbuf_list_elem Item15;

                public ecs_strbuf_list_elem Item16;

                public ecs_strbuf_list_elem Item17;

                public ecs_strbuf_list_elem Item18;

                public ecs_strbuf_list_elem Item19;

                public ecs_strbuf_list_elem Item20;

                public ecs_strbuf_list_elem Item21;

                public ecs_strbuf_list_elem Item22;

                public ecs_strbuf_list_elem Item23;

                public ecs_strbuf_list_elem Item24;

                public ecs_strbuf_list_elem Item25;

                public ecs_strbuf_list_elem Item26;

                public ecs_strbuf_list_elem Item27;

                public ecs_strbuf_list_elem Item28;

                public ecs_strbuf_list_elem Item29;

                public ecs_strbuf_list_elem Item30;

                public ecs_strbuf_list_elem Item31;

                public ref ecs_strbuf_list_elem this[int index] => ref AsSpan()[index];

                [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public System.Span<ecs_strbuf_list_elem> AsSpan() => System.Runtime.InteropServices.MemoryMarshal.CreateSpan(ref Item0, 32);

                public bool Equals(list_stack_FixedBuffer other)
                {
                    fixed (list_stack_FixedBuffer* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(list_stack_FixedBuffer)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(list_stack_FixedBuffer)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is list_stack_FixedBuffer other && Equals(other);
                }

                public static bool operator ==(list_stack_FixedBuffer left, list_stack_FixedBuffer right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(list_stack_FixedBuffer left, list_stack_FixedBuffer right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (list_stack_FixedBuffer* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(list_stack_FixedBuffer)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public bool Equals(ecs_strbuf_t other)
            {
                fixed (ecs_strbuf_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_strbuf_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_strbuf_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_strbuf_t other && Equals(other);
            }

            public static bool operator ==(ecs_strbuf_t left, ecs_strbuf_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_strbuf_t left, ecs_strbuf_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_strbuf_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_strbuf_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_struct_desc_t : System.IEquatable<ecs_struct_desc_t>
        {
            public ulong entity;

            public members_FixedBuffer members;

            public partial struct members_FixedBuffer : System.IEquatable<members_FixedBuffer>
            {
                public ecs_member_t Item0;

                public ecs_member_t Item1;

                public ecs_member_t Item2;

                public ecs_member_t Item3;

                public ecs_member_t Item4;

                public ecs_member_t Item5;

                public ecs_member_t Item6;

                public ecs_member_t Item7;

                public ecs_member_t Item8;

                public ecs_member_t Item9;

                public ecs_member_t Item10;

                public ecs_member_t Item11;

                public ecs_member_t Item12;

                public ecs_member_t Item13;

                public ecs_member_t Item14;

                public ecs_member_t Item15;

                public ecs_member_t Item16;

                public ecs_member_t Item17;

                public ecs_member_t Item18;

                public ecs_member_t Item19;

                public ecs_member_t Item20;

                public ecs_member_t Item21;

                public ecs_member_t Item22;

                public ecs_member_t Item23;

                public ecs_member_t Item24;

                public ecs_member_t Item25;

                public ecs_member_t Item26;

                public ecs_member_t Item27;

                public ecs_member_t Item28;

                public ecs_member_t Item29;

                public ecs_member_t Item30;

                public ecs_member_t Item31;

                public ref ecs_member_t this[int index] => ref AsSpan()[index];

                [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public System.Span<ecs_member_t> AsSpan() => System.Runtime.InteropServices.MemoryMarshal.CreateSpan(ref Item0, 32);

                public bool Equals(members_FixedBuffer other)
                {
                    fixed (members_FixedBuffer* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(members_FixedBuffer)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(members_FixedBuffer)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is members_FixedBuffer other && Equals(other);
                }

                public static bool operator ==(members_FixedBuffer left, members_FixedBuffer right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(members_FixedBuffer left, members_FixedBuffer right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (members_FixedBuffer* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(members_FixedBuffer)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public bool Equals(ecs_struct_desc_t other)
            {
                fixed (ecs_struct_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_struct_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_struct_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_struct_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_struct_desc_t left, ecs_struct_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_struct_desc_t left, ecs_struct_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_struct_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_struct_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_suspend_readonly_state_t : System.IEquatable<ecs_suspend_readonly_state_t>
        {
            public byte is_readonly;

            public byte is_deferred;

            public int defer_count;

            public ulong scope;

            public ulong with;

            public ecs_vec_t commands;

            public ecs_stack_t defer_stack;

            public ecs_stage_t* stage;

            public bool Equals(ecs_suspend_readonly_state_t other)
            {
                fixed (ecs_suspend_readonly_state_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_suspend_readonly_state_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_suspend_readonly_state_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_suspend_readonly_state_t other && Equals(other);
            }

            public static bool operator ==(ecs_suspend_readonly_state_t left, ecs_suspend_readonly_state_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_suspend_readonly_state_t left, ecs_suspend_readonly_state_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_suspend_readonly_state_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_suspend_readonly_state_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_switch_node_t : System.IEquatable<ecs_switch_node_t>
        {
            public uint next;

            public uint prev;

            public bool Equals(ecs_switch_node_t other)
            {
                fixed (ecs_switch_node_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_switch_node_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_switch_node_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_switch_node_t other && Equals(other);
            }

            public static bool operator ==(ecs_switch_node_t left, ecs_switch_node_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_switch_node_t left, ecs_switch_node_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_switch_node_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_switch_node_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_switch_page_t : System.IEquatable<ecs_switch_page_t>
        {
            public ecs_vec_t nodes;

            public ecs_vec_t values;

            public bool Equals(ecs_switch_page_t other)
            {
                fixed (ecs_switch_page_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_switch_page_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_switch_page_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_switch_page_t other && Equals(other);
            }

            public static bool operator ==(ecs_switch_page_t left, ecs_switch_page_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_switch_page_t left, ecs_switch_page_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_switch_page_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_switch_page_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_switch_t : System.IEquatable<ecs_switch_t>
        {
            public ecs_map_t hdrs;

            public ecs_vec_t pages;

            public bool Equals(ecs_switch_t other)
            {
                fixed (ecs_switch_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_switch_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_switch_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_switch_t other && Equals(other);
            }

            public static bool operator ==(ecs_switch_t left, ecs_switch_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_switch_t left, ecs_switch_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_switch_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_switch_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_sync_stats_t : System.IEquatable<ecs_sync_stats_t>
        {
            public long first_;

            public ecs_metric_t time_spent;

            public ecs_metric_t commands_enqueued;

            public long last_;

            public int system_count;

            public byte multi_threaded;

            public byte immediate;

            public bool Equals(ecs_sync_stats_t other)
            {
                fixed (ecs_sync_stats_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_sync_stats_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_sync_stats_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_sync_stats_t other && Equals(other);
            }

            public static bool operator ==(ecs_sync_stats_t left, ecs_sync_stats_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_sync_stats_t left, ecs_sync_stats_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_sync_stats_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_sync_stats_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_system_desc_t : System.IEquatable<ecs_system_desc_t>
        {
            public int _canary;

            public ulong entity;

            public ecs_query_desc_t query;

            public System.IntPtr callback; // delegate* unmanaged<ecs_iter_t*, void>

            public System.IntPtr run; // delegate* unmanaged<ecs_iter_t*, void>

            public void* ctx;

            public System.IntPtr ctx_free; // delegate* unmanaged<void*, void>

            public void* callback_ctx;

            public System.IntPtr callback_ctx_free; // delegate* unmanaged<void*, void>

            public void* run_ctx;

            public System.IntPtr run_ctx_free; // delegate* unmanaged<void*, void>

            public float interval;

            public int rate;

            public ulong tick_source;

            public byte multi_threaded;

            public byte immediate;

            public bool Equals(ecs_system_desc_t other)
            {
                fixed (ecs_system_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_system_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_system_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_system_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_system_desc_t left, ecs_system_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_system_desc_t left, ecs_system_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_system_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_system_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_system_stats_t : System.IEquatable<ecs_system_stats_t>
        {
            public long first_;

            public ecs_metric_t time_spent;

            public long last_;

            public byte task;

            public ecs_query_stats_t query;

            public bool Equals(ecs_system_stats_t other)
            {
                fixed (ecs_system_stats_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_system_stats_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_system_stats_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_system_stats_t other && Equals(other);
            }

            public static bool operator ==(ecs_system_stats_t left, ecs_system_stats_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_system_stats_t left, ecs_system_stats_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_system_stats_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_system_stats_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_system_t : System.IEquatable<ecs_system_t>
        {
            public ecs_header_t hdr;

            public System.IntPtr run; // delegate* unmanaged<ecs_iter_t*, void>

            public System.IntPtr action; // delegate* unmanaged<ecs_iter_t*, void>

            public ecs_query_t* query;

            public ulong query_entity;

            public ulong tick_source;

            public byte multi_threaded;

            public byte immediate;

            public byte* name;

            public void* ctx;

            public void* callback_ctx;

            public void* run_ctx;

            public System.IntPtr ctx_free; // delegate* unmanaged<void*, void>

            public System.IntPtr callback_ctx_free; // delegate* unmanaged<void*, void>

            public System.IntPtr run_ctx_free; // delegate* unmanaged<void*, void>

            public float time_spent;

            public float time_passed;

            public long last_frame;

            public ecs_world_t* world;

            public ulong entity;

            public System.IntPtr dtor; // delegate* unmanaged<void*, void>

            public bool Equals(ecs_system_t other)
            {
                fixed (ecs_system_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_system_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_system_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_system_t other && Equals(other);
            }

            public static bool operator ==(ecs_system_t left, ecs_system_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_system_t left, ecs_system_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_system_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_system_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_table_cache_hdr_t : System.IEquatable<ecs_table_cache_hdr_t>
        {
            public ecs_table_cache_t* cache;

            public ecs_table_t* table;

            public ecs_table_cache_hdr_t* prev;

            public ecs_table_cache_hdr_t* next;

            public byte empty;

            public partial struct ecs_table_cache_t : System.IEquatable<ecs_table_cache_t>
            {
                public bool Equals(ecs_table_cache_t other)
                {
                    fixed (ecs_table_cache_t* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_table_cache_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_table_cache_t)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is ecs_table_cache_t other && Equals(other);
                }

                public static bool operator ==(ecs_table_cache_t left, ecs_table_cache_t right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(ecs_table_cache_t left, ecs_table_cache_t right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (ecs_table_cache_t* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_table_cache_t)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public bool Equals(ecs_table_cache_hdr_t other)
            {
                fixed (ecs_table_cache_hdr_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_table_cache_hdr_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_table_cache_hdr_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_table_cache_hdr_t other && Equals(other);
            }

            public static bool operator ==(ecs_table_cache_hdr_t left, ecs_table_cache_hdr_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_table_cache_hdr_t left, ecs_table_cache_hdr_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_table_cache_hdr_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_table_cache_hdr_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_table_cache_iter_t : System.IEquatable<ecs_table_cache_iter_t>
        {
            public ecs_table_cache_hdr_t* cur;

            public ecs_table_cache_hdr_t* next;

            public ecs_table_cache_hdr_t* next_list;

            public bool Equals(ecs_table_cache_iter_t other)
            {
                fixed (ecs_table_cache_iter_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_table_cache_iter_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_table_cache_iter_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_table_cache_iter_t other && Equals(other);
            }

            public static bool operator ==(ecs_table_cache_iter_t left, ecs_table_cache_iter_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_table_cache_iter_t left, ecs_table_cache_iter_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_table_cache_iter_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_table_cache_iter_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_table_range_t : System.IEquatable<ecs_table_range_t>
        {
            public ecs_table_t* table;

            public int offset;

            public int count;

            public bool Equals(ecs_table_range_t other)
            {
                fixed (ecs_table_range_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_table_range_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_table_range_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_table_range_t other && Equals(other);
            }

            public static bool operator ==(ecs_table_range_t left, ecs_table_range_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_table_range_t left, ecs_table_range_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_table_range_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_table_range_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_table_record_t : System.IEquatable<ecs_table_record_t>
        {
            public ecs_table_cache_hdr_t hdr;

            public short index;

            public short count;

            public short column;

            public bool Equals(ecs_table_record_t other)
            {
                fixed (ecs_table_record_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_table_record_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_table_record_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_table_record_t other && Equals(other);
            }

            public static bool operator ==(ecs_table_record_t left, ecs_table_record_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_table_record_t left, ecs_table_record_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_table_record_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_table_record_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_table_t : System.IEquatable<ecs_table_t>
        {
            public bool Equals(ecs_table_t other)
            {
                fixed (ecs_table_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_table_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_table_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_table_t other && Equals(other);
            }

            public static bool operator ==(ecs_table_t left, ecs_table_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_table_t left, ecs_table_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_table_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_table_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_term_ref_t : System.IEquatable<ecs_term_ref_t>
        {
            public ulong id;

            public byte* name;

            public bool Equals(ecs_term_ref_t other)
            {
                fixed (ecs_term_ref_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_term_ref_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_term_ref_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_term_ref_t other && Equals(other);
            }

            public static bool operator ==(ecs_term_ref_t left, ecs_term_ref_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_term_ref_t left, ecs_term_ref_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_term_ref_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_term_ref_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_term_t : System.IEquatable<ecs_term_t>
        {
            public ulong id;

            public ecs_term_ref_t src;

            public ecs_term_ref_t first;

            public ecs_term_ref_t second;

            public ulong trav;

            public short inout;

            public short oper;

            public byte field_index;

            public ushort flags_;

            public bool Equals(ecs_term_t other)
            {
                fixed (ecs_term_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_term_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_term_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_term_t other && Equals(other);
            }

            public static bool operator ==(ecs_term_t left, ecs_term_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_term_t left, ecs_term_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_term_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_term_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_time_t : System.IEquatable<ecs_time_t>
        {
            public uint sec;

            public uint nanosec;

            public bool Equals(ecs_time_t other)
            {
                fixed (ecs_time_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_time_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_time_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_time_t other && Equals(other);
            }

            public static bool operator ==(ecs_time_t left, ecs_time_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_time_t left, ecs_time_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_time_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_time_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_type_hooks_t : System.IEquatable<ecs_type_hooks_t>
        {
            public System.IntPtr ctor; // delegate* unmanaged<void*, int, ecs_type_info_t*, void>

            public System.IntPtr dtor; // delegate* unmanaged<void*, int, ecs_type_info_t*, void>

            public System.IntPtr copy; // delegate* unmanaged<void*, void*, int, ecs_type_info_t*, void>

            public System.IntPtr move; // delegate* unmanaged<void*, void*, int, ecs_type_info_t*, void>

            public System.IntPtr copy_ctor; // delegate* unmanaged<void*, void*, int, ecs_type_info_t*, void>

            public System.IntPtr move_ctor; // delegate* unmanaged<void*, void*, int, ecs_type_info_t*, void>

            public System.IntPtr ctor_move_dtor; // delegate* unmanaged<void*, void*, int, ecs_type_info_t*, void>

            public System.IntPtr move_dtor; // delegate* unmanaged<void*, void*, int, ecs_type_info_t*, void>

            public System.IntPtr on_add; // delegate* unmanaged<ecs_iter_t*, void>

            public System.IntPtr on_set; // delegate* unmanaged<ecs_iter_t*, void>

            public System.IntPtr on_remove; // delegate* unmanaged<ecs_iter_t*, void>

            public void* ctx;

            public void* binding_ctx;

            public void* lifecycle_ctx;

            public System.IntPtr ctx_free; // delegate* unmanaged<void*, void>

            public System.IntPtr binding_ctx_free; // delegate* unmanaged<void*, void>

            public System.IntPtr lifecycle_ctx_free; // delegate* unmanaged<void*, void>

            public bool Equals(ecs_type_hooks_t other)
            {
                fixed (ecs_type_hooks_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_type_hooks_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_type_hooks_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_type_hooks_t other && Equals(other);
            }

            public static bool operator ==(ecs_type_hooks_t left, ecs_type_hooks_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_type_hooks_t left, ecs_type_hooks_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_type_hooks_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_type_hooks_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_type_info_t : System.IEquatable<ecs_type_info_t>
        {
            public int size;

            public int alignment;

            public ecs_type_hooks_t hooks;

            public ulong component;

            public byte* name;

            public bool Equals(ecs_type_info_t other)
            {
                fixed (ecs_type_info_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_type_info_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_type_info_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_type_info_t other && Equals(other);
            }

            public static bool operator ==(ecs_type_info_t left, ecs_type_info_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_type_info_t left, ecs_type_info_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_type_info_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_type_info_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_type_t : System.IEquatable<ecs_type_t>
        {
            public ulong* array;

            public int count;

            public bool Equals(ecs_type_t other)
            {
                fixed (ecs_type_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_type_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_type_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_type_t other && Equals(other);
            }

            public static bool operator ==(ecs_type_t left, ecs_type_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_type_t left, ecs_type_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_type_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_type_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_unit_desc_t : System.IEquatable<ecs_unit_desc_t>
        {
            public ulong entity;

            public byte* symbol;

            public ulong quantity;

            public ulong @base;

            public ulong over;

            public ecs_unit_translation_t translation;

            public ulong prefix;

            public bool Equals(ecs_unit_desc_t other)
            {
                fixed (ecs_unit_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_unit_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_unit_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_unit_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_unit_desc_t left, ecs_unit_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_unit_desc_t left, ecs_unit_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_unit_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_unit_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_unit_prefix_desc_t : System.IEquatable<ecs_unit_prefix_desc_t>
        {
            public ulong entity;

            public byte* symbol;

            public ecs_unit_translation_t translation;

            public bool Equals(ecs_unit_prefix_desc_t other)
            {
                fixed (ecs_unit_prefix_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_unit_prefix_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_unit_prefix_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_unit_prefix_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_unit_prefix_desc_t left, ecs_unit_prefix_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_unit_prefix_desc_t left, ecs_unit_prefix_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_unit_prefix_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_unit_prefix_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_unit_translation_t : System.IEquatable<ecs_unit_translation_t>
        {
            public int factor;

            public int power;

            public bool Equals(ecs_unit_translation_t other)
            {
                fixed (ecs_unit_translation_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_unit_translation_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_unit_translation_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_unit_translation_t other && Equals(other);
            }

            public static bool operator ==(ecs_unit_translation_t left, ecs_unit_translation_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_unit_translation_t left, ecs_unit_translation_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_unit_translation_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_unit_translation_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_value_t : System.IEquatable<ecs_value_t>
        {
            public ulong type;

            public void* ptr;

            public bool Equals(ecs_value_t other)
            {
                fixed (ecs_value_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_value_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_value_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_value_t other && Equals(other);
            }

            public static bool operator ==(ecs_value_t left, ecs_value_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_value_t left, ecs_value_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_value_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_value_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_var_t : System.IEquatable<ecs_var_t>
        {
            public ecs_table_range_t range;

            public ulong entity;

            public bool Equals(ecs_var_t other)
            {
                fixed (ecs_var_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_var_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_var_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_var_t other && Equals(other);
            }

            public static bool operator ==(ecs_var_t left, ecs_var_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_var_t left, ecs_var_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_var_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_var_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_vec_t : System.IEquatable<ecs_vec_t>
        {
            public void* array;

            public int count;

            public int size;

            public bool Equals(ecs_vec_t other)
            {
                fixed (ecs_vec_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_vec_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_vec_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_vec_t other && Equals(other);
            }

            public static bool operator ==(ecs_vec_t left, ecs_vec_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_vec_t left, ecs_vec_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_vec_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_vec_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_vector_desc_t : System.IEquatable<ecs_vector_desc_t>
        {
            public ulong entity;

            public ulong type;

            public bool Equals(ecs_vector_desc_t other)
            {
                fixed (ecs_vector_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_vector_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_vector_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_vector_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_vector_desc_t left, ecs_vector_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_vector_desc_t left, ecs_vector_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_vector_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_vector_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_worker_iter_t : System.IEquatable<ecs_worker_iter_t>
        {
            public int index;

            public int count;

            public bool Equals(ecs_worker_iter_t other)
            {
                fixed (ecs_worker_iter_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_worker_iter_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_worker_iter_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_worker_iter_t other && Equals(other);
            }

            public static bool operator ==(ecs_worker_iter_t left, ecs_worker_iter_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_worker_iter_t left, ecs_worker_iter_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_worker_iter_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_worker_iter_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_world_info_t : System.IEquatable<ecs_world_info_t>
        {
            public ulong last_component_id;

            public ulong min_id;

            public ulong max_id;

            public float delta_time_raw;

            public float delta_time;

            public float time_scale;

            public float target_fps;

            public float frame_time_total;

            public float system_time_total;

            public float emit_time_total;

            public float merge_time_total;

            public float rematch_time_total;

            public double world_time_total;

            public double world_time_total_raw;

            public long frame_count_total;

            public long merge_count_total;

            public long eval_comp_monitors_total;

            public long rematch_count_total;

            public long id_create_total;

            public long id_delete_total;

            public long table_create_total;

            public long table_delete_total;

            public long pipeline_build_count_total;

            public long systems_ran_frame;

            public long observers_ran_frame;

            public int tag_id_count;

            public int component_id_count;

            public int pair_id_count;

            public int table_count;

            public int empty_table_count;

            public cmd_AnonymousRecord cmd;

            public byte* name_prefix;

            public partial struct cmd_AnonymousRecord : System.IEquatable<cmd_AnonymousRecord>
            {
                public long add_count;

                public long remove_count;

                public long delete_count;

                public long clear_count;

                public long set_count;

                public long ensure_count;

                public long modified_count;

                public long discard_count;

                public long event_count;

                public long other_count;

                public long batched_entity_count;

                public long batched_command_count;

                public bool Equals(cmd_AnonymousRecord other)
                {
                    fixed (cmd_AnonymousRecord* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(cmd_AnonymousRecord)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(cmd_AnonymousRecord)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is cmd_AnonymousRecord other && Equals(other);
                }

                public static bool operator ==(cmd_AnonymousRecord left, cmd_AnonymousRecord right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(cmd_AnonymousRecord left, cmd_AnonymousRecord right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (cmd_AnonymousRecord* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(cmd_AnonymousRecord)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public bool Equals(ecs_world_info_t other)
            {
                fixed (ecs_world_info_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_world_info_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_world_info_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_world_info_t other && Equals(other);
            }

            public static bool operator ==(ecs_world_info_t left, ecs_world_info_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_world_info_t left, ecs_world_info_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_world_info_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_world_info_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_world_stats_t : System.IEquatable<ecs_world_stats_t>
        {
            public long first_;

            public entities_AnonymousRecord entities;

            public components_AnonymousRecord components;

            public tables_AnonymousRecord tables;

            public queries_AnonymousRecord queries;

            public commands_AnonymousRecord commands;

            public frame_AnonymousRecord frame;

            public performance_AnonymousRecord performance;

            public memory_AnonymousRecord memory;

            public http_AnonymousRecord http;

            public long last_;

            public int t;

            public partial struct entities_AnonymousRecord : System.IEquatable<entities_AnonymousRecord>
            {
                public ecs_metric_t count;

                public ecs_metric_t not_alive_count;

                public bool Equals(entities_AnonymousRecord other)
                {
                    fixed (entities_AnonymousRecord* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(entities_AnonymousRecord)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(entities_AnonymousRecord)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is entities_AnonymousRecord other && Equals(other);
                }

                public static bool operator ==(entities_AnonymousRecord left, entities_AnonymousRecord right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(entities_AnonymousRecord left, entities_AnonymousRecord right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (entities_AnonymousRecord* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(entities_AnonymousRecord)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public partial struct components_AnonymousRecord : System.IEquatable<components_AnonymousRecord>
            {
                public ecs_metric_t tag_count;

                public ecs_metric_t component_count;

                public ecs_metric_t pair_count;

                public ecs_metric_t type_count;

                public ecs_metric_t create_count;

                public ecs_metric_t delete_count;

                public bool Equals(components_AnonymousRecord other)
                {
                    fixed (components_AnonymousRecord* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(components_AnonymousRecord)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(components_AnonymousRecord)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is components_AnonymousRecord other && Equals(other);
                }

                public static bool operator ==(components_AnonymousRecord left, components_AnonymousRecord right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(components_AnonymousRecord left, components_AnonymousRecord right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (components_AnonymousRecord* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(components_AnonymousRecord)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public partial struct tables_AnonymousRecord : System.IEquatable<tables_AnonymousRecord>
            {
                public ecs_metric_t count;

                public ecs_metric_t empty_count;

                public ecs_metric_t create_count;

                public ecs_metric_t delete_count;

                public bool Equals(tables_AnonymousRecord other)
                {
                    fixed (tables_AnonymousRecord* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(tables_AnonymousRecord)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(tables_AnonymousRecord)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is tables_AnonymousRecord other && Equals(other);
                }

                public static bool operator ==(tables_AnonymousRecord left, tables_AnonymousRecord right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(tables_AnonymousRecord left, tables_AnonymousRecord right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (tables_AnonymousRecord* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(tables_AnonymousRecord)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public partial struct queries_AnonymousRecord : System.IEquatable<queries_AnonymousRecord>
            {
                public ecs_metric_t query_count;

                public ecs_metric_t observer_count;

                public ecs_metric_t system_count;

                public bool Equals(queries_AnonymousRecord other)
                {
                    fixed (queries_AnonymousRecord* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(queries_AnonymousRecord)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(queries_AnonymousRecord)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is queries_AnonymousRecord other && Equals(other);
                }

                public static bool operator ==(queries_AnonymousRecord left, queries_AnonymousRecord right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(queries_AnonymousRecord left, queries_AnonymousRecord right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (queries_AnonymousRecord* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(queries_AnonymousRecord)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public partial struct commands_AnonymousRecord : System.IEquatable<commands_AnonymousRecord>
            {
                public ecs_metric_t add_count;

                public ecs_metric_t remove_count;

                public ecs_metric_t delete_count;

                public ecs_metric_t clear_count;

                public ecs_metric_t set_count;

                public ecs_metric_t ensure_count;

                public ecs_metric_t modified_count;

                public ecs_metric_t other_count;

                public ecs_metric_t discard_count;

                public ecs_metric_t batched_entity_count;

                public ecs_metric_t batched_count;

                public bool Equals(commands_AnonymousRecord other)
                {
                    fixed (commands_AnonymousRecord* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(commands_AnonymousRecord)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(commands_AnonymousRecord)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is commands_AnonymousRecord other && Equals(other);
                }

                public static bool operator ==(commands_AnonymousRecord left, commands_AnonymousRecord right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(commands_AnonymousRecord left, commands_AnonymousRecord right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (commands_AnonymousRecord* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(commands_AnonymousRecord)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public partial struct frame_AnonymousRecord : System.IEquatable<frame_AnonymousRecord>
            {
                public ecs_metric_t frame_count;

                public ecs_metric_t merge_count;

                public ecs_metric_t rematch_count;

                public ecs_metric_t pipeline_build_count;

                public ecs_metric_t systems_ran;

                public ecs_metric_t observers_ran;

                public ecs_metric_t event_emit_count;

                public bool Equals(frame_AnonymousRecord other)
                {
                    fixed (frame_AnonymousRecord* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(frame_AnonymousRecord)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(frame_AnonymousRecord)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is frame_AnonymousRecord other && Equals(other);
                }

                public static bool operator ==(frame_AnonymousRecord left, frame_AnonymousRecord right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(frame_AnonymousRecord left, frame_AnonymousRecord right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (frame_AnonymousRecord* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(frame_AnonymousRecord)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public partial struct performance_AnonymousRecord : System.IEquatable<performance_AnonymousRecord>
            {
                public ecs_metric_t world_time_raw;

                public ecs_metric_t world_time;

                public ecs_metric_t frame_time;

                public ecs_metric_t system_time;

                public ecs_metric_t emit_time;

                public ecs_metric_t merge_time;

                public ecs_metric_t rematch_time;

                public ecs_metric_t fps;

                public ecs_metric_t delta_time;

                public bool Equals(performance_AnonymousRecord other)
                {
                    fixed (performance_AnonymousRecord* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(performance_AnonymousRecord)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(performance_AnonymousRecord)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is performance_AnonymousRecord other && Equals(other);
                }

                public static bool operator ==(performance_AnonymousRecord left, performance_AnonymousRecord right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(performance_AnonymousRecord left, performance_AnonymousRecord right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (performance_AnonymousRecord* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(performance_AnonymousRecord)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public partial struct memory_AnonymousRecord : System.IEquatable<memory_AnonymousRecord>
            {
                public ecs_metric_t alloc_count;

                public ecs_metric_t realloc_count;

                public ecs_metric_t free_count;

                public ecs_metric_t outstanding_alloc_count;

                public ecs_metric_t block_alloc_count;

                public ecs_metric_t block_free_count;

                public ecs_metric_t block_outstanding_alloc_count;

                public ecs_metric_t stack_alloc_count;

                public ecs_metric_t stack_free_count;

                public ecs_metric_t stack_outstanding_alloc_count;

                public bool Equals(memory_AnonymousRecord other)
                {
                    fixed (memory_AnonymousRecord* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(memory_AnonymousRecord)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(memory_AnonymousRecord)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is memory_AnonymousRecord other && Equals(other);
                }

                public static bool operator ==(memory_AnonymousRecord left, memory_AnonymousRecord right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(memory_AnonymousRecord left, memory_AnonymousRecord right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (memory_AnonymousRecord* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(memory_AnonymousRecord)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public partial struct http_AnonymousRecord : System.IEquatable<http_AnonymousRecord>
            {
                public ecs_metric_t request_received_count;

                public ecs_metric_t request_invalid_count;

                public ecs_metric_t request_handled_ok_count;

                public ecs_metric_t request_handled_error_count;

                public ecs_metric_t request_not_handled_count;

                public ecs_metric_t request_preflight_count;

                public ecs_metric_t send_ok_count;

                public ecs_metric_t send_error_count;

                public ecs_metric_t busy_count;

                public bool Equals(http_AnonymousRecord other)
                {
                    fixed (http_AnonymousRecord* __self = &this)
                    {
                        return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(http_AnonymousRecord)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(http_AnonymousRecord)));
                    }
                }

                public override bool Equals(object? obj)
                {
                    return obj is http_AnonymousRecord other && Equals(other);
                }

                public static bool operator ==(http_AnonymousRecord left, http_AnonymousRecord right)
                {
                    return left.Equals(right);
                }

                public static bool operator !=(http_AnonymousRecord left, http_AnonymousRecord right)
                {
                    return !(left == right);
                }

                public override int GetHashCode()
                {
                    fixed (http_AnonymousRecord* __self = &this)
                    {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(http_AnonymousRecord)));
                    return hash.ToHashCode();
#else
                        return base.GetHashCode();
#endif
                    }
                }
            }

            public bool Equals(ecs_world_stats_t other)
            {
                fixed (ecs_world_stats_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_world_stats_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_world_stats_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_world_stats_t other && Equals(other);
            }

            public static bool operator ==(ecs_world_stats_t left, ecs_world_stats_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_world_stats_t left, ecs_world_stats_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_world_stats_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_world_stats_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_world_t : System.IEquatable<ecs_world_t>
        {
            public bool Equals(ecs_world_t other)
            {
                fixed (ecs_world_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_world_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_world_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_world_t other && Equals(other);
            }

            public static bool operator ==(ecs_world_t left, ecs_world_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_world_t left, ecs_world_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_world_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_world_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct ecs_world_to_json_desc_t : System.IEquatable<ecs_world_to_json_desc_t>
        {
            public byte serialize_builtin;

            public byte serialize_modules;

            public bool Equals(ecs_world_to_json_desc_t other)
            {
                fixed (ecs_world_to_json_desc_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_world_to_json_desc_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(ecs_world_to_json_desc_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is ecs_world_to_json_desc_t other && Equals(other);
            }

            public static bool operator ==(ecs_world_to_json_desc_t left, ecs_world_to_json_desc_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ecs_world_to_json_desc_t left, ecs_world_to_json_desc_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (ecs_world_to_json_desc_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(ecs_world_to_json_desc_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsAlertInstance : System.IEquatable<EcsAlertInstance>
        {
            public byte* message;

            public bool Equals(EcsAlertInstance other)
            {
                fixed (EcsAlertInstance* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsAlertInstance)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsAlertInstance)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsAlertInstance other && Equals(other);
            }

            public static bool operator ==(EcsAlertInstance left, EcsAlertInstance right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsAlertInstance left, EcsAlertInstance right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsAlertInstance* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsAlertInstance)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsAlertsActive : System.IEquatable<EcsAlertsActive>
        {
            public int info_count;

            public int warning_count;

            public int error_count;

            public ecs_map_t alerts;

            public bool Equals(EcsAlertsActive other)
            {
                fixed (EcsAlertsActive* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsAlertsActive)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsAlertsActive)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsAlertsActive other && Equals(other);
            }

            public static bool operator ==(EcsAlertsActive left, EcsAlertsActive right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsAlertsActive left, EcsAlertsActive right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsAlertsActive* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsAlertsActive)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsArray : System.IEquatable<EcsArray>
        {
            public ulong type;

            public int count;

            public bool Equals(EcsArray other)
            {
                fixed (EcsArray* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsArray)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsArray)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsArray other && Equals(other);
            }

            public static bool operator ==(EcsArray left, EcsArray right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsArray left, EcsArray right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsArray* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsArray)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsBitmask : System.IEquatable<EcsBitmask>
        {
            public ecs_map_t constants;

            public bool Equals(EcsBitmask other)
            {
                fixed (EcsBitmask* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsBitmask)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsBitmask)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsBitmask other && Equals(other);
            }

            public static bool operator ==(EcsBitmask left, EcsBitmask right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsBitmask left, EcsBitmask right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsBitmask* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsBitmask)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsComponent : System.IEquatable<EcsComponent>
        {
            public int size;

            public int alignment;

            public bool Equals(EcsComponent other)
            {
                fixed (EcsComponent* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsComponent)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsComponent)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsComponent other && Equals(other);
            }

            public static bool operator ==(EcsComponent left, EcsComponent right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsComponent left, EcsComponent right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsComponent* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsComponent)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsDefaultChildComponent : System.IEquatable<EcsDefaultChildComponent>
        {
            public ulong component;

            public bool Equals(EcsDefaultChildComponent other)
            {
                fixed (EcsDefaultChildComponent* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsDefaultChildComponent)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsDefaultChildComponent)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsDefaultChildComponent other && Equals(other);
            }

            public static bool operator ==(EcsDefaultChildComponent left, EcsDefaultChildComponent right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsDefaultChildComponent left, EcsDefaultChildComponent right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsDefaultChildComponent* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsDefaultChildComponent)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsDocDescription : System.IEquatable<EcsDocDescription>
        {
            public byte* value;

            public bool Equals(EcsDocDescription other)
            {
                fixed (EcsDocDescription* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsDocDescription)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsDocDescription)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsDocDescription other && Equals(other);
            }

            public static bool operator ==(EcsDocDescription left, EcsDocDescription right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsDocDescription left, EcsDocDescription right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsDocDescription* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsDocDescription)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsEnum : System.IEquatable<EcsEnum>
        {
            public ecs_map_t constants;

            public bool Equals(EcsEnum other)
            {
                fixed (EcsEnum* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsEnum)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsEnum)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsEnum other && Equals(other);
            }

            public static bool operator ==(EcsEnum left, EcsEnum right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsEnum left, EcsEnum right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsEnum* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsEnum)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsIdentifier : System.IEquatable<EcsIdentifier>
        {
            public byte* value;

            public int length;

            public ulong hash;

            public ulong index_hash;

            public ecs_hashmap_t* index;

            public bool Equals(EcsIdentifier other)
            {
                fixed (EcsIdentifier* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsIdentifier)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsIdentifier)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsIdentifier other && Equals(other);
            }

            public static bool operator ==(EcsIdentifier left, EcsIdentifier right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsIdentifier left, EcsIdentifier right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsIdentifier* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsIdentifier)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsMember : System.IEquatable<EcsMember>
        {
            public ulong type;

            public int count;

            public ulong unit;

            public int offset;

            public byte use_offset;

            public bool Equals(EcsMember other)
            {
                fixed (EcsMember* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsMember)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsMember)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsMember other && Equals(other);
            }

            public static bool operator ==(EcsMember left, EcsMember right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsMember left, EcsMember right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsMember* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsMember)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsMemberRanges : System.IEquatable<EcsMemberRanges>
        {
            public ecs_member_value_range_t value;

            public ecs_member_value_range_t warning;

            public ecs_member_value_range_t error;

            public bool Equals(EcsMemberRanges other)
            {
                fixed (EcsMemberRanges* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsMemberRanges)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsMemberRanges)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsMemberRanges other && Equals(other);
            }

            public static bool operator ==(EcsMemberRanges left, EcsMemberRanges right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsMemberRanges left, EcsMemberRanges right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsMemberRanges* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsMemberRanges)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsMetricSource : System.IEquatable<EcsMetricSource>
        {
            public ulong entity;

            public bool Equals(EcsMetricSource other)
            {
                fixed (EcsMetricSource* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsMetricSource)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsMetricSource)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsMetricSource other && Equals(other);
            }

            public static bool operator ==(EcsMetricSource left, EcsMetricSource right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsMetricSource left, EcsMetricSource right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsMetricSource* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsMetricSource)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsMetricValue : System.IEquatable<EcsMetricValue>
        {
            public double value;

            public bool Equals(EcsMetricValue other)
            {
                fixed (EcsMetricValue* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsMetricValue)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsMetricValue)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsMetricValue other && Equals(other);
            }

            public static bool operator ==(EcsMetricValue left, EcsMetricValue right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsMetricValue left, EcsMetricValue right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsMetricValue* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsMetricValue)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsOpaque : System.IEquatable<EcsOpaque>
        {
            public ulong as_type;

            public System.IntPtr serialize; // delegate* unmanaged<ecs_serializer_t*, void*, int>

            public System.IntPtr assign_bool; // delegate* unmanaged<void*, byte, void>

            public System.IntPtr assign_char; // delegate* unmanaged<void*, byte, void>

            public System.IntPtr assign_int; // delegate* unmanaged<void*, long, void>

            public System.IntPtr assign_uint; // delegate* unmanaged<void*, ulong, void>

            public System.IntPtr assign_float; // delegate* unmanaged<void*, double, void>

            public System.IntPtr assign_string; // delegate* unmanaged<void*, byte*, void>

            public System.IntPtr assign_entity; // delegate* unmanaged<void*, ecs_world_t*, ulong, void>

            public System.IntPtr assign_id; // delegate* unmanaged<void*, ecs_world_t*, ulong, void>

            public System.IntPtr assign_null; // delegate* unmanaged<void*, void>

            public System.IntPtr clear; // delegate* unmanaged<void*, void>

            public System.IntPtr ensure_element; // delegate* unmanaged<void*, System.IntPtr, void*>

            public System.IntPtr ensure_member; // delegate* unmanaged<void*, byte*, void*>

            public System.IntPtr count; // delegate* unmanaged<void*, System.IntPtr>

            public System.IntPtr resize; // delegate* unmanaged<void*, System.IntPtr, void>

            public bool Equals(EcsOpaque other)
            {
                fixed (EcsOpaque* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsOpaque)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsOpaque)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsOpaque other && Equals(other);
            }

            public static bool operator ==(EcsOpaque left, EcsOpaque right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsOpaque left, EcsOpaque right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsOpaque* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsOpaque)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsPipelineStats : System.IEquatable<EcsPipelineStats>
        {
            public EcsStatsHeader hdr;

            public ecs_map_t stats;

            public bool Equals(EcsPipelineStats other)
            {
                fixed (EcsPipelineStats* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsPipelineStats)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsPipelineStats)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsPipelineStats other && Equals(other);
            }

            public static bool operator ==(EcsPipelineStats left, EcsPipelineStats right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsPipelineStats left, EcsPipelineStats right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsPipelineStats* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsPipelineStats)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsPoly : System.IEquatable<EcsPoly>
        {
            public void* poly;

            public bool Equals(EcsPoly other)
            {
                fixed (EcsPoly* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsPoly)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsPoly)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsPoly other && Equals(other);
            }

            public static bool operator ==(EcsPoly left, EcsPoly right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsPoly left, EcsPoly right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsPoly* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsPoly)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsPrimitive : System.IEquatable<EcsPrimitive>
        {
            public ecs_primitive_kind_t kind;

            public bool Equals(EcsPrimitive other)
            {
                fixed (EcsPrimitive* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsPrimitive)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsPrimitive)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsPrimitive other && Equals(other);
            }

            public static bool operator ==(EcsPrimitive left, EcsPrimitive right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsPrimitive left, EcsPrimitive right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsPrimitive* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsPrimitive)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsRateFilter : System.IEquatable<EcsRateFilter>
        {
            public ulong src;

            public int rate;

            public int tick_count;

            public float time_elapsed;

            public bool Equals(EcsRateFilter other)
            {
                fixed (EcsRateFilter* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsRateFilter)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsRateFilter)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsRateFilter other && Equals(other);
            }

            public static bool operator ==(EcsRateFilter left, EcsRateFilter right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsRateFilter left, EcsRateFilter right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsRateFilter* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsRateFilter)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsRest : System.IEquatable<EcsRest>
        {
            public ushort port;

            public byte* ipaddr;

            public void* impl;

            public bool Equals(EcsRest other)
            {
                fixed (EcsRest* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsRest)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsRest)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsRest other && Equals(other);
            }

            public static bool operator ==(EcsRest left, EcsRest right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsRest left, EcsRest right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsRest* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsRest)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsScript : System.IEquatable<EcsScript>
        {
            public ecs_script_t* script;

            public ecs_script_template_t* template_;

            public bool Equals(EcsScript other)
            {
                fixed (EcsScript* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsScript)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsScript)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsScript other && Equals(other);
            }

            public static bool operator ==(EcsScript left, EcsScript right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsScript left, EcsScript right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsScript* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsScript)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsStatsHeader : System.IEquatable<EcsStatsHeader>
        {
            public float elapsed;

            public int reduce_count;

            public bool Equals(EcsStatsHeader other)
            {
                fixed (EcsStatsHeader* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsStatsHeader)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsStatsHeader)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsStatsHeader other && Equals(other);
            }

            public static bool operator ==(EcsStatsHeader left, EcsStatsHeader right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsStatsHeader left, EcsStatsHeader right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsStatsHeader* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsStatsHeader)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsStruct : System.IEquatable<EcsStruct>
        {
            public ecs_vec_t members;

            public bool Equals(EcsStruct other)
            {
                fixed (EcsStruct* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsStruct)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsStruct)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsStruct other && Equals(other);
            }

            public static bool operator ==(EcsStruct left, EcsStruct right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsStruct left, EcsStruct right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsStruct* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsStruct)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsSystemStats : System.IEquatable<EcsSystemStats>
        {
            public EcsStatsHeader hdr;

            public ecs_map_t stats;

            public bool Equals(EcsSystemStats other)
            {
                fixed (EcsSystemStats* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsSystemStats)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsSystemStats)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsSystemStats other && Equals(other);
            }

            public static bool operator ==(EcsSystemStats left, EcsSystemStats right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsSystemStats left, EcsSystemStats right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsSystemStats* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsSystemStats)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsTickSource : System.IEquatable<EcsTickSource>
        {
            public byte tick;

            public float time_elapsed;

            public bool Equals(EcsTickSource other)
            {
                fixed (EcsTickSource* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsTickSource)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsTickSource)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsTickSource other && Equals(other);
            }

            public static bool operator ==(EcsTickSource left, EcsTickSource right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsTickSource left, EcsTickSource right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsTickSource* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsTickSource)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsTimer : System.IEquatable<EcsTimer>
        {
            public float timeout;

            public float time;

            public float overshoot;

            public int fired_count;

            public byte active;

            public byte single_shot;

            public bool Equals(EcsTimer other)
            {
                fixed (EcsTimer* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsTimer)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsTimer)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsTimer other && Equals(other);
            }

            public static bool operator ==(EcsTimer left, EcsTimer right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsTimer left, EcsTimer right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsTimer* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsTimer)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsType : System.IEquatable<EcsType>
        {
            public ecs_type_kind_t kind;

            public byte existing;

            public byte partial;

            public bool Equals(EcsType other)
            {
                fixed (EcsType* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsType)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsType)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsType other && Equals(other);
            }

            public static bool operator ==(EcsType left, EcsType right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsType left, EcsType right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsType* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsType)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsTypeSerializer : System.IEquatable<EcsTypeSerializer>
        {
            public ecs_vec_t ops;

            public bool Equals(EcsTypeSerializer other)
            {
                fixed (EcsTypeSerializer* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsTypeSerializer)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsTypeSerializer)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsTypeSerializer other && Equals(other);
            }

            public static bool operator ==(EcsTypeSerializer left, EcsTypeSerializer right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsTypeSerializer left, EcsTypeSerializer right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsTypeSerializer* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsTypeSerializer)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsUnit : System.IEquatable<EcsUnit>
        {
            public byte* symbol;

            public ulong prefix;

            public ulong @base;

            public ulong over;

            public ecs_unit_translation_t translation;

            public bool Equals(EcsUnit other)
            {
                fixed (EcsUnit* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsUnit)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsUnit)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsUnit other && Equals(other);
            }

            public static bool operator ==(EcsUnit left, EcsUnit right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsUnit left, EcsUnit right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsUnit* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsUnit)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsUnitPrefix : System.IEquatable<EcsUnitPrefix>
        {
            public byte* symbol;

            public ecs_unit_translation_t translation;

            public bool Equals(EcsUnitPrefix other)
            {
                fixed (EcsUnitPrefix* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsUnitPrefix)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsUnitPrefix)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsUnitPrefix other && Equals(other);
            }

            public static bool operator ==(EcsUnitPrefix left, EcsUnitPrefix right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsUnitPrefix left, EcsUnitPrefix right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsUnitPrefix* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsUnitPrefix)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsVector : System.IEquatable<EcsVector>
        {
            public ulong type;

            public bool Equals(EcsVector other)
            {
                fixed (EcsVector* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsVector)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsVector)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsVector other && Equals(other);
            }

            public static bool operator ==(EcsVector left, EcsVector right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsVector left, EcsVector right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsVector* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsVector)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsWorldStats : System.IEquatable<EcsWorldStats>
        {
            public EcsStatsHeader hdr;

            public ecs_world_stats_t stats;

            public bool Equals(EcsWorldStats other)
            {
                fixed (EcsWorldStats* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsWorldStats)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsWorldStats)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsWorldStats other && Equals(other);
            }

            public static bool operator ==(EcsWorldStats left, EcsWorldStats right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsWorldStats left, EcsWorldStats right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsWorldStats* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsWorldStats)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct EcsWorldSummary : System.IEquatable<EcsWorldSummary>
        {
            public double target_fps;

            public double time_scale;

            public double frame_time_total;

            public double system_time_total;

            public double merge_time_total;

            public double frame_time_last;

            public double system_time_last;

            public double merge_time_last;

            public long frame_count;

            public long command_count;

            public ecs_build_info_t build_info;

            public bool Equals(EcsWorldSummary other)
            {
                fixed (EcsWorldSummary* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsWorldSummary)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(EcsWorldSummary)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is EcsWorldSummary other && Equals(other);
            }

            public static bool operator ==(EcsWorldSummary left, EcsWorldSummary right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EcsWorldSummary left, EcsWorldSummary right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (EcsWorldSummary* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(EcsWorldSummary)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct flecs_hashmap_iter_t : System.IEquatable<flecs_hashmap_iter_t>
        {
            public ecs_map_iter_t it;

            public ecs_hm_bucket_t* bucket;

            public int index;

            public bool Equals(flecs_hashmap_iter_t other)
            {
                fixed (flecs_hashmap_iter_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(flecs_hashmap_iter_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(flecs_hashmap_iter_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is flecs_hashmap_iter_t other && Equals(other);
            }

            public static bool operator ==(flecs_hashmap_iter_t left, flecs_hashmap_iter_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(flecs_hashmap_iter_t left, flecs_hashmap_iter_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (flecs_hashmap_iter_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(flecs_hashmap_iter_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public partial struct flecs_hashmap_result_t : System.IEquatable<flecs_hashmap_result_t>
        {
            public void* key;

            public void* value;

            public ulong hash;

            public bool Equals(flecs_hashmap_result_t other)
            {
                fixed (flecs_hashmap_result_t* __self = &this)
                {
                    return System.MemoryExtensions.SequenceEqual(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(flecs_hashmap_result_t)), new System.ReadOnlySpan<byte>((byte*)&other, sizeof(flecs_hashmap_result_t)));
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is flecs_hashmap_result_t other && Equals(other);
            }

            public static bool operator ==(flecs_hashmap_result_t left, flecs_hashmap_result_t right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(flecs_hashmap_result_t left, flecs_hashmap_result_t right)
            {
                return !(left == right);
            }

            public override int GetHashCode()
            {
                fixed (flecs_hashmap_result_t* __self = &this)
                {
#if NET6_0_OR_GREATER
                    System.HashCode hash = new System.HashCode();
                    hash.AddBytes(new System.ReadOnlySpan<byte>((byte*)__self, sizeof(flecs_hashmap_result_t)));
                    return hash.ToHashCode();
#else
                    return base.GetHashCode();
#endif
                }
            }
        }

        public enum ecs_http_method_t : uint
        {
            EcsHttpGet = 0,
            EcsHttpPost = 1,
            EcsHttpPut = 2,
            EcsHttpDelete = 3,
            EcsHttpOptions = 4,
            EcsHttpMethodUnsupported = 5
        }

        public enum ecs_inout_kind_t : uint
        {
            EcsInOutDefault = 0,
            EcsInOutNone = 1,
            EcsInOutFilter = 2,
            EcsInOut = 3,
            EcsIn = 4,
            EcsOut = 5
        }

        public enum ecs_meta_type_op_kind_t : uint
        {
            EcsOpArray = 0,
            EcsOpVector = 1,
            EcsOpOpaque = 2,
            EcsOpPush = 3,
            EcsOpPop = 4,
            EcsOpScope = 5,
            EcsOpEnum = 6,
            EcsOpBitmask = 7,
            EcsOpPrimitive = 8,
            EcsOpBool = 9,
            EcsOpChar = 10,
            EcsOpByte = 11,
            EcsOpU8 = 12,
            EcsOpU16 = 13,
            EcsOpU32 = 14,
            EcsOpU64 = 15,
            EcsOpI8 = 16,
            EcsOpI16 = 17,
            EcsOpI32 = 18,
            EcsOpI64 = 19,
            EcsOpF32 = 20,
            EcsOpF64 = 21,
            EcsOpUPtr = 22,
            EcsOpIPtr = 23,
            EcsOpString = 24,
            EcsOpEntity = 25,
            EcsOpId = 26,
            EcsMetaTypeOpKindLast = 26
        }

        public enum ecs_oper_kind_t : uint
        {
            EcsAnd = 0,
            EcsOr = 1,
            EcsNot = 2,
            EcsOptional = 3,
            EcsAndFrom = 4,
            EcsOrFrom = 5,
            EcsNotFrom = 6
        }

        public enum ecs_primitive_kind_t : uint
        {
            EcsBool = 1,
            EcsChar = 2,
            EcsByte = 3,
            EcsU8 = 4,
            EcsU16 = 5,
            EcsU32 = 6,
            EcsU64 = 7,
            EcsI8 = 8,
            EcsI16 = 9,
            EcsI32 = 10,
            EcsI64 = 11,
            EcsF32 = 12,
            EcsF64 = 13,
            EcsUPtr = 14,
            EcsIPtr = 15,
            EcsString = 16,
            EcsEntity = 17,
            EcsId = 18,
            EcsPrimitiveKindLast = 18
        }

        public enum ecs_query_cache_kind_t : uint
        {
            EcsQueryCacheDefault = 0,
            EcsQueryCacheAuto = 1,
            EcsQueryCacheAll = 2,
            EcsQueryCacheNone = 3
        }

        public enum ecs_type_kind_t : uint
        {
            EcsPrimitiveType = 0,
            EcsBitmaskType = 1,
            EcsEnumType = 2,
            EcsStructType = 3,
            EcsArrayType = 4,
            EcsVectorType = 5,
            EcsOpaqueType = 6,
            EcsTypeKindLast = 6
        }

        public const ecs_http_method_t EcsHttpGet = ecs_http_method_t.EcsHttpGet;

        public const ecs_http_method_t EcsHttpPost = ecs_http_method_t.EcsHttpPost;

        public const ecs_http_method_t EcsHttpPut = ecs_http_method_t.EcsHttpPut;

        public const ecs_http_method_t EcsHttpDelete = ecs_http_method_t.EcsHttpDelete;

        public const ecs_http_method_t EcsHttpOptions = ecs_http_method_t.EcsHttpOptions;

        public const ecs_http_method_t EcsHttpMethodUnsupported = ecs_http_method_t.EcsHttpMethodUnsupported;

        public const ecs_inout_kind_t EcsInOutDefault = ecs_inout_kind_t.EcsInOutDefault;

        public const ecs_inout_kind_t EcsInOutNone = ecs_inout_kind_t.EcsInOutNone;

        public const ecs_inout_kind_t EcsInOutFilter = ecs_inout_kind_t.EcsInOutFilter;

        public const ecs_inout_kind_t EcsInOut = ecs_inout_kind_t.EcsInOut;

        public const ecs_inout_kind_t EcsIn = ecs_inout_kind_t.EcsIn;

        public const ecs_inout_kind_t EcsOut = ecs_inout_kind_t.EcsOut;

        public const ecs_meta_type_op_kind_t EcsOpArray = ecs_meta_type_op_kind_t.EcsOpArray;

        public const ecs_meta_type_op_kind_t EcsOpVector = ecs_meta_type_op_kind_t.EcsOpVector;

        public const ecs_meta_type_op_kind_t EcsOpOpaque = ecs_meta_type_op_kind_t.EcsOpOpaque;

        public const ecs_meta_type_op_kind_t EcsOpPush = ecs_meta_type_op_kind_t.EcsOpPush;

        public const ecs_meta_type_op_kind_t EcsOpPop = ecs_meta_type_op_kind_t.EcsOpPop;

        public const ecs_meta_type_op_kind_t EcsOpScope = ecs_meta_type_op_kind_t.EcsOpScope;

        public const ecs_meta_type_op_kind_t EcsOpEnum = ecs_meta_type_op_kind_t.EcsOpEnum;

        public const ecs_meta_type_op_kind_t EcsOpBitmask = ecs_meta_type_op_kind_t.EcsOpBitmask;

        public const ecs_meta_type_op_kind_t EcsOpPrimitive = ecs_meta_type_op_kind_t.EcsOpPrimitive;

        public const ecs_meta_type_op_kind_t EcsOpBool = ecs_meta_type_op_kind_t.EcsOpBool;

        public const ecs_meta_type_op_kind_t EcsOpChar = ecs_meta_type_op_kind_t.EcsOpChar;

        public const ecs_meta_type_op_kind_t EcsOpByte = ecs_meta_type_op_kind_t.EcsOpByte;

        public const ecs_meta_type_op_kind_t EcsOpU8 = ecs_meta_type_op_kind_t.EcsOpU8;

        public const ecs_meta_type_op_kind_t EcsOpU16 = ecs_meta_type_op_kind_t.EcsOpU16;

        public const ecs_meta_type_op_kind_t EcsOpU32 = ecs_meta_type_op_kind_t.EcsOpU32;

        public const ecs_meta_type_op_kind_t EcsOpU64 = ecs_meta_type_op_kind_t.EcsOpU64;

        public const ecs_meta_type_op_kind_t EcsOpI8 = ecs_meta_type_op_kind_t.EcsOpI8;

        public const ecs_meta_type_op_kind_t EcsOpI16 = ecs_meta_type_op_kind_t.EcsOpI16;

        public const ecs_meta_type_op_kind_t EcsOpI32 = ecs_meta_type_op_kind_t.EcsOpI32;

        public const ecs_meta_type_op_kind_t EcsOpI64 = ecs_meta_type_op_kind_t.EcsOpI64;

        public const ecs_meta_type_op_kind_t EcsOpF32 = ecs_meta_type_op_kind_t.EcsOpF32;

        public const ecs_meta_type_op_kind_t EcsOpF64 = ecs_meta_type_op_kind_t.EcsOpF64;

        public const ecs_meta_type_op_kind_t EcsOpUPtr = ecs_meta_type_op_kind_t.EcsOpUPtr;

        public const ecs_meta_type_op_kind_t EcsOpIPtr = ecs_meta_type_op_kind_t.EcsOpIPtr;

        public const ecs_meta_type_op_kind_t EcsOpString = ecs_meta_type_op_kind_t.EcsOpString;

        public const ecs_meta_type_op_kind_t EcsOpEntity = ecs_meta_type_op_kind_t.EcsOpEntity;

        public const ecs_meta_type_op_kind_t EcsOpId = ecs_meta_type_op_kind_t.EcsOpId;

        public const ecs_meta_type_op_kind_t EcsMetaTypeOpKindLast = ecs_meta_type_op_kind_t.EcsMetaTypeOpKindLast;

        public const ecs_oper_kind_t EcsAnd = ecs_oper_kind_t.EcsAnd;

        public const ecs_oper_kind_t EcsOr = ecs_oper_kind_t.EcsOr;

        public const ecs_oper_kind_t EcsNot = ecs_oper_kind_t.EcsNot;

        public const ecs_oper_kind_t EcsOptional = ecs_oper_kind_t.EcsOptional;

        public const ecs_oper_kind_t EcsAndFrom = ecs_oper_kind_t.EcsAndFrom;

        public const ecs_oper_kind_t EcsOrFrom = ecs_oper_kind_t.EcsOrFrom;

        public const ecs_oper_kind_t EcsNotFrom = ecs_oper_kind_t.EcsNotFrom;

        public const ecs_primitive_kind_t EcsBool = ecs_primitive_kind_t.EcsBool;

        public const ecs_primitive_kind_t EcsChar = ecs_primitive_kind_t.EcsChar;

        public const ecs_primitive_kind_t EcsByte = ecs_primitive_kind_t.EcsByte;

        public const ecs_primitive_kind_t EcsU8 = ecs_primitive_kind_t.EcsU8;

        public const ecs_primitive_kind_t EcsU16 = ecs_primitive_kind_t.EcsU16;

        public const ecs_primitive_kind_t EcsU32 = ecs_primitive_kind_t.EcsU32;

        public const ecs_primitive_kind_t EcsU64 = ecs_primitive_kind_t.EcsU64;

        public const ecs_primitive_kind_t EcsI8 = ecs_primitive_kind_t.EcsI8;

        public const ecs_primitive_kind_t EcsI16 = ecs_primitive_kind_t.EcsI16;

        public const ecs_primitive_kind_t EcsI32 = ecs_primitive_kind_t.EcsI32;

        public const ecs_primitive_kind_t EcsI64 = ecs_primitive_kind_t.EcsI64;

        public const ecs_primitive_kind_t EcsF32 = ecs_primitive_kind_t.EcsF32;

        public const ecs_primitive_kind_t EcsF64 = ecs_primitive_kind_t.EcsF64;

        public const ecs_primitive_kind_t EcsUPtr = ecs_primitive_kind_t.EcsUPtr;

        public const ecs_primitive_kind_t EcsIPtr = ecs_primitive_kind_t.EcsIPtr;

        public const ecs_primitive_kind_t EcsString = ecs_primitive_kind_t.EcsString;

        public const ecs_primitive_kind_t EcsEntity = ecs_primitive_kind_t.EcsEntity;

        public const ecs_primitive_kind_t EcsId = ecs_primitive_kind_t.EcsId;

        public const ecs_primitive_kind_t EcsPrimitiveKindLast = ecs_primitive_kind_t.EcsPrimitiveKindLast;

        public const ecs_query_cache_kind_t EcsQueryCacheDefault = ecs_query_cache_kind_t.EcsQueryCacheDefault;

        public const ecs_query_cache_kind_t EcsQueryCacheAuto = ecs_query_cache_kind_t.EcsQueryCacheAuto;

        public const ecs_query_cache_kind_t EcsQueryCacheAll = ecs_query_cache_kind_t.EcsQueryCacheAll;

        public const ecs_query_cache_kind_t EcsQueryCacheNone = ecs_query_cache_kind_t.EcsQueryCacheNone;

        public const ecs_type_kind_t EcsPrimitiveType = ecs_type_kind_t.EcsPrimitiveType;

        public const ecs_type_kind_t EcsBitmaskType = ecs_type_kind_t.EcsBitmaskType;

        public const ecs_type_kind_t EcsEnumType = ecs_type_kind_t.EcsEnumType;

        public const ecs_type_kind_t EcsStructType = ecs_type_kind_t.EcsStructType;

        public const ecs_type_kind_t EcsArrayType = ecs_type_kind_t.EcsArrayType;

        public const ecs_type_kind_t EcsVectorType = ecs_type_kind_t.EcsVectorType;

        public const ecs_type_kind_t EcsOpaqueType = ecs_type_kind_t.EcsOpaqueType;

        public const ecs_type_kind_t EcsTypeKindLast = ecs_type_kind_t.EcsTypeKindLast;

        public const int ECS_ACCESS_VIOLATION = 40;

        public const int ECS_ALERT_MAX_SEVERITY_FILTERS = 4;

        public const int ECS_ALREADY_DEFINED = 8;

        public const int ECS_ALREADY_IN_USE = 30;

        public const string ECS_BLACK = "[1;30m";

        public const string ECS_BLUE = "[0;34m";

        public const string ECS_BOLD = "[1;49m";

        public const int ECS_CLANG_VERSION = 16;

        public const int ECS_COLUMN_INDEX_OUT_OF_RANGE = 41;

        public const int ECS_COLUMN_IS_NOT_SHARED = 42;

        public const int ECS_COLUMN_IS_SHARED = 43;

        public const int ECS_COLUMN_TYPE_MISMATCH = 45;

        public const ulong ECS_COMPONENT_MASK = 1152921504606846975;

        public const int ECS_COMPONENT_NOT_REGISTERED = 25;

        public const int ECS_CONSTRAINT_VIOLATED = 3;

        public const string ECS_CYAN = "[0;36m";

        public const int ECS_CYCLE_DETECTED = 13;

        public const int ECS_DOUBLE_FREE = 15;

        public const ulong ECS_ENTITY_MASK = 4294967295;

        public const ulong ECS_GENERATION_MASK = 281470681743360;

        public const string ECS_GREEN = "[0;32m";

        public const string ECS_GREY = "[0;37m";

        public const int ECS_HTTP_HEADER_COUNT_MAX = 32;

        public const int ECS_HTTP_QUERY_PARAM_COUNT_MAX = 32;

        public const ulong ECS_ID_FLAGS_MASK = 17293822569102704640;

        public const int ECS_ID_IN_USE = 12;

        public const int ECS_INCONSISTENT_COMPONENT_ACTION = 27;

        public const int ECS_INCONSISTENT_COMPONENT_ID = 26;

        public const int ECS_INCONSISTENT_NAME = 20;

        public const int ECS_INTERNAL_ERROR = 7;

        public const int ECS_INVALID_COMPONENT_ALIGNMENT = 24;

        public const int ECS_INVALID_COMPONENT_SIZE = 23;

        public const int ECS_INVALID_CONVERSION = 11;

        public const int ECS_INVALID_FROM_WORKER = 72;

        public const int ECS_INVALID_OPERATION = 1;

        public const int ECS_INVALID_PARAMETER = 2;

        public const int ECS_INVALID_WHILE_READONLY = 70;

        public const int ECS_LEAK_DETECTED = 14;

        public const int ECS_LOCKED_STORAGE = 71;

        public const string ECS_MAGENTA = "[0;35m";

        public const uint ECS_MAX_COMPONENT_ID = 268435455;

        public const int ECS_MAX_RECURSION = 512;

        public const int ECS_MAX_TOKEN_SIZE = 256;

        public const int ECS_MEMBER_DESC_CACHE_SIZE = 32;

        public const int ECS_META_MAX_SCOPE_DEPTH = 32;

        public const int ECS_MISSING_OS_API = 9;

        public const int ECS_MISSING_SYMBOL = 29;

        public const int ECS_MODULE_UNDEFINED = 28;

        public const int ECS_NAME_IN_USE = 21;

        public const string ECS_NORMAL = "[0;49m";

        public const int ECS_NOT_A_COMPONENT = 22;

        public const int ecs_observer_t_magic = 1701016418;

        public const int ECS_OPERATION_FAILED = 10;

        public const int ECS_OUT_OF_MEMORY = 4;

        public const int ECS_OUT_OF_RANGE = 5;

        public const int ecs_query_t_magic = 1701016437;

        public const string ECS_RED = "[0;31m";

        public const int ECS_REST_DEFAULT_PORT = 27750;

        public const uint ECS_ROW_FLAGS_MASK = 4026531840;

        public const uint ECS_ROW_MASK = 268435455;

        public const int ECS_STACK_PAGE_SIZE = 4096;

        public const int ecs_stage_t_magic = 1701016435;

        public const int ECS_STAT_WINDOW = 60;

        public const int ECS_STRBUF_MAX_LIST_DEPTH = 32;

        public const int ECS_STRBUF_SMALL_STRING_SIZE = 512;

        public const int ECS_UNSUPPORTED = 6;

        public const string ECS_WHITE = "[1;37m";

        public const int ecs_world_t_magic = 1701016439;

        public const string ECS_YELLOW = "[0;33m";

        public const uint EcsAperiodicComponentMonitors = 4;

        public const uint EcsAperiodicEmptyQueries = 16;

        public const uint EcsAperiodicEmptyTables = 2;

        public const ulong EcsCascade = 1152921504606846976;

        public const ulong EcsDesc = 576460752303423488;

        public const uint EcsEntityIsId = 2147483648;

        public const uint EcsEntityIsTarget = 1073741824;

        public const uint EcsEntityIsTraversable = 536870912;

        public const uint EcsEventNoOnSet = 65536;

        public const uint EcsEventTableOnly = 1048576;

        public const int EcsFirstUserComponentId = 8;

        public const int EcsFirstUserEntityId = 384;

        public const uint EcsIdCanToggle = 8192;

        public const uint EcsIdEventMask = 33488896;

        public const uint EcsIdExclusive = 512;

        public const uint EcsIdHasOnAdd = 65536;

        public const uint EcsIdHasOnRemove = 131072;

        public const uint EcsIdHasOnSet = 262144;

        public const uint EcsIdHasOnTableCreate = 2097152;

        public const uint EcsIdHasOnTableDelete = 4194304;

        public const uint EcsIdHasOnTableEmpty = 1048576;

        public const uint EcsIdHasOnTableFill = 524288;

        public const uint EcsIdIsSparse = 8388608;

        public const uint EcsIdIsTransitive = 16384;

        public const uint EcsIdIsUnion = 16777216;

        public const uint EcsIdMarkedForDelete = 1073741824;

        public const uint EcsIdOnDeleteDelete = 2;

        public const uint EcsIdOnDeleteMask = 7;

        public const uint EcsIdOnDeleteObjectDelete = 16;

        public const uint EcsIdOnDeleteObjectMask = 56;

        public const uint EcsIdOnDeleteObjectPanic = 32;

        public const uint EcsIdOnDeleteObjectRemove = 8;

        public const uint EcsIdOnDeletePanic = 4;

        public const uint EcsIdOnDeleteRemove = 1;

        public const uint EcsIdOnInstantiateDontInherit = 256;

        public const uint EcsIdOnInstantiateInherit = 128;

        public const uint EcsIdOnInstantiateMask = 448;

        public const uint EcsIdOnInstantiateOverride = 64;

        public const uint EcsIdTag = 2048;

        public const uint EcsIdTraversable = 1024;

        public const uint EcsIdWith = 4096;

        public const ulong EcsIsEntity = 144115188075855872;

        public const ulong EcsIsName = 72057594037927936;

        public const ulong EcsIsVariable = 288230376151711744;

        public const uint EcsIterCacheSearch = 32768;

        public const uint EcsIterCppEach = 524288;

        public const uint EcsIterFixedInChangeComputed = 65536;

        public const uint EcsIterFixedInChanged = 131072;

        public const uint EcsIterHasCondSet = 64;

        public const uint EcsIterIgnoreThis = 16;

        public const uint EcsIterIsValid = 1;

        public const int EcsIterNext = 1;

        public const int EcsIterNextYield = 0;

        public const uint EcsIterNoData = 2;

        public const uint EcsIterNoResults = 8;

        public const uint EcsIterProfile = 128;

        public const uint EcsIterSkip = 262144;

        public const uint EcsIterTableOnly = 1048576;

        public const uint EcsIterTrivialCached = 16384;

        public const uint EcsIterTrivialSearch = 256;

        public const uint EcsIterTrivialTest = 2048;

        public const int EcsIterYield = -1;

        public const uint EcsObserverBypassQuery = 32;

        public const uint EcsObserverIsDisabled = 8;

        public const uint EcsObserverIsMonitor = 4;

        public const uint EcsObserverIsMulti = 2;

        public const uint EcsObserverIsParentDisabled = 16;

        public const uint EcsObserverYieldOnCreate = 64;

        public const uint EcsObserverYieldOnDelete = 128;

        public const uint EcsOsApiHighResolutionTimer = 1;

        public const uint EcsOsApiLogWithColors = 2;

        public const uint EcsOsApiLogWithTimeDelta = 8;

        public const uint EcsOsApiLogWithTimeStamp = 4;

        public const uint EcsQueryAllowUnresolvedByName = 64;

        public const uint EcsQueryCacheYieldEmptyTables = 134217728;

        public const uint EcsQueryHasCacheable = 16777216;

        public const uint EcsQueryHasCondSet = 65536;

        public const uint EcsQueryHasMonitor = 4194304;

        public const uint EcsQueryHasNonThisOutTerms = 2097152;

        public const uint EcsQueryHasOutTerms = 1048576;

        public const uint EcsQueryHasPred = 131072;

        public const uint EcsQueryHasRefs = 524288;

        public const uint EcsQueryHasScopes = 262144;

        public const uint EcsQueryHasTableThisVar = 67108864;

        public const uint EcsQueryIsCacheable = 33554432;

        public const uint EcsQueryIsTrivial = 8388608;

        public const uint EcsQueryMatchDisabled = 4;

        public const uint EcsQueryMatchEmptyTables = 8;

        public const uint EcsQueryMatchNothing = 32768;

        public const uint EcsQueryMatchOnlySelf = 8192;

        public const uint EcsQueryMatchOnlyThis = 4096;

        public const uint EcsQueryMatchPrefab = 2;

        public const uint EcsQueryMatchThis = 2048;

        public const uint EcsQueryMatchWildcards = 16384;

        public const uint EcsQueryNested = 268435456;

        public const uint EcsQueryTableOnly = 128;

        public const ulong EcsSelf = 9223372036854775808;

        public const uint EcsTableAddEdgeFlags = 25231360;

        public const uint EcsTableEdgeFlags = 25362432;

        public const uint EcsTableHasAddActions = 328712;

        public const uint EcsTableHasBuiltins = 2;

        public const uint EcsTableHasChildOf = 16;

        public const uint EcsTableHasCopy = 4096;

        public const uint EcsTableHasCtors = 1024;

        public const uint EcsTableHasDtors = 2048;

        public const uint EcsTableHasIsA = 8;

        public const uint EcsTableHasLifecycle = 3072;

        public const uint EcsTableHasModule = 128;

        public const uint EcsTableHasMove = 8192;

        public const uint EcsTableHasName = 32;

        public const uint EcsTableHasOnAdd = 65536;

        public const uint EcsTableHasOnRemove = 131072;

        public const uint EcsTableHasOnSet = 262144;

        public const uint EcsTableHasOnTableCreate = 2097152;

        public const uint EcsTableHasOnTableDelete = 4194304;

        public const uint EcsTableHasOnTableEmpty = 1048576;

        public const uint EcsTableHasOnTableFill = 524288;

        public const uint EcsTableHasOverrides = 32768;

        public const uint EcsTableHasPairs = 64;

        public const uint EcsTableHasRemoveActions = 133128;

        public const uint EcsTableHasSparse = 8388608;

        public const uint EcsTableHasToggle = 16384;

        public const uint EcsTableHasTraversable = 67108864;

        public const uint EcsTableHasUnion = 16777216;

        public const uint EcsTableIsComplex = 8408064;

        public const uint EcsTableIsDisabled = 256;

        public const uint EcsTableIsPrefab = 4;

        public const uint EcsTableMarkedForDelete = 1073741824;

        public const uint EcsTableNotQueryable = 512;

        public const uint EcsTableRemoveEdgeFlags = 25296896;

        public const uint EcsTermIdInherited = 16;

        public const uint EcsTermIsCacheable = 128;

        public const uint EcsTermIsMember = 512;

        public const uint EcsTermIsOr = 16384;

        public const uint EcsTermIsScope = 256;

        public const uint EcsTermIsSparse = 4096;

        public const uint EcsTermIsToggle = 1024;

        public const uint EcsTermIsTrivial = 32;

        public const uint EcsTermIsUnion = 8192;

        public const uint EcsTermKeepAlive = 2048;

        public const uint EcsTermMatchAny = 1;

        public const uint EcsTermMatchAnySrc = 2;

        public const ulong EcsTermRefFlags = 18374686479671623680;

        public const uint EcsTermReflexive = 8;

        public const uint EcsTermTransitive = 4;

        public const ulong EcsTrav = 2305843009213693952;

        public const ulong EcsTraverseFlags = 17870283321406128128;

        public const ulong EcsUp = 4611686018427387904;

        public const uint EcsWorldFini = 16;

        public const uint EcsWorldFrameInProgress = 256;

        public const uint EcsWorldInit = 4;

        public const uint EcsWorldMeasureFrameTime = 32;

        public const uint EcsWorldMeasureSystemTime = 64;

        public const uint EcsWorldMultiThreaded = 128;

        public const uint EcsWorldQuit = 8;

        public const uint EcsWorldQuitWorkers = 1;

        public const uint EcsWorldReadonly = 2;

        public const int FLECS_ENTITY_PAGE_BITS = 12;

        public const int FLECS_EVENT_DESC_MAX = 8;

        public const int FLECS_HI_COMPONENT_ID = 256;

        public const int FLECS_HI_ID_RECORD_ID = 1024;

        public const int FLECS_ID_DESC_MAX = 32;

        public const int flecs_iter_cache_all = 255;

        public const uint flecs_iter_cache_ids = 1;

        public const uint flecs_iter_cache_ptrs = 8;

        public const uint flecs_iter_cache_sources = 4;

        public const uint flecs_iter_cache_trs = 2;

        public const uint flecs_iter_cache_variables = 16;

        public const int FLECS_QUERY_SCOPE_NESTING_MAX = 8;

        public const int FLECS_QUERY_VARIABLE_COUNT_MAX = 64;

        public const int FLECS_SPARSE_PAGE_BITS = 12;

        public const int FLECS_SPARSE_PAGE_SIZE = 4096;

        public const int FLECS_TERM_ARG_COUNT_MAX = 16;

        public const int FLECS_TERM_COUNT_MAX = 32;

        public const int FLECS_VARIABLE_COUNT_MAX = 64;

        public const string FLECS_VERSION = "4.0.3";

        public const int FLECS_VERSION_MAJOR = 4;

        public const int FLECS_VERSION_MINOR = 0;

        public const int FLECS_VERSION_PATCH = 3;

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ECS_AUTO_OVERRIDE_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ECS_AUTO_OVERRIDE_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_block_allocator_alloc_count_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ecs_block_allocator_alloc_count_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_block_allocator_free_count_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ecs_block_allocator_free_count_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_http_busy_count_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ecs_http_busy_count_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_http_request_handled_error_count_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ecs_http_request_handled_error_count_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_http_request_handled_ok_count_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ecs_http_request_handled_ok_count_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_http_request_invalid_count_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ecs_http_request_invalid_count_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_http_request_not_handled_count_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ecs_http_request_not_handled_count_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_http_request_preflight_count_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ecs_http_request_preflight_count_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_http_request_received_count_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ecs_http_request_received_count_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_http_send_error_count_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ecs_http_send_error_count_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_http_send_ok_count_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ecs_http_send_ok_count_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_api_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ecs_os_api_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_api_calloc_count_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ecs_os_api_calloc_count_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_api_free_count_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ecs_os_api_free_count_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_api_malloc_count_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ecs_os_api_malloc_count_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_os_api_realloc_count_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ecs_os_api_realloc_count_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ECS_PAIR_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ECS_PAIR_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_stack_allocator_alloc_count_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ecs_stack_allocator_alloc_count_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ecs_stack_allocator_free_count_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ecs_stack_allocator_free_count_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "ECS_TOGGLE_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* ECS_TOGGLE_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsAcceleration_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsAcceleration_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsAcyclic_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsAcyclic_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsAlertCritical_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsAlertCritical_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsAlertError_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsAlertError_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsAlertInfo_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsAlertInfo_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsAlertWarning_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsAlertWarning_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsAlias_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsAlias_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsAmount_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsAmount_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsAmpere_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsAmpere_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsAngle_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsAngle_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsAny_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsAny_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsAtto_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsAtto_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsBar_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsBar_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsBel_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsBel_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsBits_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsBits_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsBitsPerSecond_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsBitsPerSecond_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsBytes_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsBytes_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsBytesPerSecond_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsBytesPerSecond_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsCandela_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsCandela_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsCanToggle_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsCanToggle_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsCelsius_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsCelsius_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsCenti_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsCenti_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsCentiMeters_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsCentiMeters_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsChildOf_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsChildOf_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsColor_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsColor_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsColorCss_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsColorCss_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsColorHsl_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsColorHsl_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsColorRgb_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsColorRgb_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsConstant_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsConstant_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsCounter_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsCounter_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsCounterId_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsCounterId_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsCounterIncrement_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsCounterIncrement_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsData_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsData_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsDataRate_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsDataRate_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsDate_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsDate_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsDays_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsDays_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsDeca_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsDeca_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsDeci_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsDeci_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsDeciBel_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsDeciBel_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsDegrees_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsDegrees_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsDelete_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsDelete_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsDependsOn_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsDependsOn_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsDisabled_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsDisabled_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsDocBrief_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsDocBrief_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsDocColor_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsDocColor_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsDocDetail_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsDocDetail_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsDocLink_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsDocLink_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsDocUuid_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsDocUuid_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsDontInherit_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsDontInherit_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsDuration_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsDuration_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsElectricCurrent_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsElectricCurrent_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsEmpty_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsEmpty_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsExa_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsExa_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsExbi_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsExbi_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsExclusive_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsExclusive_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsFahrenheit_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsFahrenheit_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsFemto_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsFemto_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsFinal_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsFinal_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsFlecs_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsFlecs_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsFlecsCore_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsFlecsCore_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsForce_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsForce_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsFrequency_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsFrequency_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsGauge_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsGauge_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsGibi_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsGibi_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsGibiBytes_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsGibiBytes_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsGiga_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsGiga_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsGigaBits_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsGigaBits_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsGigaBitsPerSecond_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsGigaBitsPerSecond_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsGigaBytes_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsGigaBytes_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsGigaBytesPerSecond_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsGigaBytesPerSecond_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsGigaHertz_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsGigaHertz_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsGrams_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsGrams_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsHecto_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsHecto_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsHertz_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsHertz_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsHours_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsHours_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsInherit_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsInherit_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsIsA_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsIsA_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsKelvin_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsKelvin_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsKibi_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsKibi_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsKibiBytes_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsKibiBytes_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsKilo_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsKilo_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsKiloBits_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsKiloBits_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsKiloBitsPerSecond_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsKiloBitsPerSecond_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsKiloBytes_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsKiloBytes_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsKiloBytesPerSecond_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsKiloBytesPerSecond_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsKiloGrams_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsKiloGrams_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsKiloHertz_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsKiloHertz_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsKiloMeters_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsKiloMeters_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsKiloMetersPerHour_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsKiloMetersPerHour_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsKiloMetersPerSecond_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsKiloMetersPerSecond_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsLength_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsLength_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsLuminousIntensity_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsLuminousIntensity_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMass_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMass_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMebi_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMebi_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMebiBytes_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMebiBytes_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMega_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMega_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMegaBits_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMegaBits_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMegaBitsPerSecond_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMegaBitsPerSecond_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMegaBytes_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMegaBytes_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMegaBytesPerSecond_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMegaBytesPerSecond_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMegaHertz_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMegaHertz_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMeters_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMeters_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMetersPerSecond_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMetersPerSecond_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMetric_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMetric_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMetricInstance_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMetricInstance_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMicro_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMicro_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMicroMeters_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMicroMeters_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMicroSeconds_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMicroSeconds_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMiles_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMiles_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMilesPerHour_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMilesPerHour_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMilli_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMilli_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMilliMeters_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMilliMeters_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMilliSeconds_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMilliSeconds_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMinutes_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMinutes_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsModule_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsModule_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMole_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMole_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsMonitor_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsMonitor_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsName_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsName_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsNano_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsNano_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsNanoMeters_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsNanoMeters_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsNanoSeconds_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsNanoSeconds_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsNewton_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsNewton_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsNotQueryable_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsNotQueryable_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsObserver_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsObserver_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsOnAdd_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsOnAdd_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsOnDelete_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsOnDelete_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsOnDeleteTarget_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsOnDeleteTarget_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsOneOf_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsOneOf_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsOnInstantiate_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsOnInstantiate_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsOnLoad_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsOnLoad_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsOnRemove_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsOnRemove_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsOnSet_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsOnSet_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsOnStart_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsOnStart_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsOnStore_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsOnStore_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsOnTableCreate_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsOnTableCreate_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsOnTableDelete_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsOnTableDelete_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsOnTableEmpty_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsOnTableEmpty_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsOnTableFill_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsOnTableFill_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsOnUpdate_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsOnUpdate_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsOnValidate_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsOnValidate_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsOverride_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsOverride_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPairIsTag_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPairIsTag_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPanic_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPanic_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPascal_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPascal_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPebi_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPebi_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPercentage_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPercentage_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPeriod1d_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPeriod1d_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPeriod1h_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPeriod1h_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPeriod1m_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPeriod1m_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPeriod1s_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPeriod1s_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPeriod1w_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPeriod1w_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPeta_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPeta_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPhase_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPhase_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPico_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPico_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPicoMeters_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPicoMeters_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPicoSeconds_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPicoSeconds_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPixels_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPixels_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPostFrame_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPostFrame_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPostLoad_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPostLoad_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPostUpdate_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPostUpdate_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPredEq_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPredEq_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPredLookup_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPredLookup_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPredMatch_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPredMatch_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPrefab_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPrefab_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPreFrame_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPreFrame_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPressure_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPressure_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPreStore_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPreStore_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPreUpdate_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPreUpdate_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsPrivate_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsPrivate_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsQuantity_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsQuantity_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsQuery_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsQuery_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsRadians_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsRadians_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsReflexive_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsReflexive_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsRelationship_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsRelationship_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsRemove_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsRemove_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsScopeClose_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsScopeClose_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsScopeOpen_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsScopeOpen_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsSeconds_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsSeconds_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsSlotOf_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsSlotOf_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsSparse_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsSparse_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsSpeed_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsSpeed_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsSymbol_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsSymbol_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsSymmetric_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsSymmetric_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsSystem_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsSystem_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsTarget_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsTarget_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsTebi_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsTebi_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsTemperature_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsTemperature_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsTera_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsTera_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsThis_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsThis_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsTime_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsTime_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsTrait_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsTrait_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsTransitive_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsTransitive_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsTraversable_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsTraversable_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsUnion_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsUnion_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsUnitPrefixes_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsUnitPrefixes_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsUri_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsUri_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsUriFile_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsUriFile_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsUriHyperlink_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsUriHyperlink_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsUriImage_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsUriImage_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsVariable_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsVariable_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsWildcard_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsWildcard_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsWith_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsWith_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsWorld_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsWorld_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsYobi_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsYobi_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsYocto_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsYocto_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsYotta_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsYotta_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsZebi_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsZebi_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsZepto_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsZepto_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "EcsZetta_BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* EcsZetta_BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDecs_bool_tID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDecs_bool_tID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDecs_byte_tID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDecs_byte_tID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDecs_char_tID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDecs_char_tID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDecs_entity_tID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDecs_entity_tID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDecs_f32_tID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDecs_f32_tID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDecs_f64_tID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDecs_f64_tID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDecs_i16_tID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDecs_i16_tID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDecs_i32_tID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDecs_i32_tID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDecs_i64_tID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDecs_i64_tID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDecs_i8_tID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDecs_i8_tID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDecs_id_tID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDecs_id_tID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDecs_iptr_tID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDecs_iptr_tID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDecs_string_tID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDecs_string_tID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDecs_u16_tID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDecs_u16_tID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDecs_u32_tID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDecs_u32_tID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDecs_u64_tID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDecs_u64_tID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDecs_u8_tID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDecs_u8_tID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDecs_uptr_tID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDecs_uptr_tID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsAlertCriticalID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsAlertCriticalID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsAlertErrorID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsAlertErrorID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsAlertID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsAlertID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsAlertInfoID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsAlertInfoID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsAlertInstanceID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsAlertInstanceID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsAlertsActiveID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsAlertsActiveID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsAlertTimeoutID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsAlertTimeoutID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsAlertWarningID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsAlertWarningID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsArrayID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsArrayID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsBitmaskID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsBitmaskID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsComponentID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsComponentID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsCounterID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsCounterID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsCounterIdID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsCounterIdID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsCounterIncrementID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsCounterIncrementID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsDefaultChildComponentID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsDefaultChildComponentID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsDocDescriptionID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsDocDescriptionID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsEnumID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsEnumID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsGaugeID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsGaugeID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsIdentifierID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsIdentifierID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsMemberID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsMemberID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsMemberRangesID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsMemberRangesID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsMetricID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsMetricID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsMetricInstanceID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsMetricInstanceID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsMetricSourceID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsMetricSourceID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsMetricValueID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsMetricValueID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsOpaqueID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsOpaqueID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsPipelineID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsPipelineID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsPipelineStatsID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsPipelineStatsID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsPolyID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsPolyID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsPrimitiveID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsPrimitiveID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsRateFilterID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsRateFilterID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsRestID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsRestID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsScriptID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsScriptID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsStructID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsStructID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsSystemStatsID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsSystemStatsID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsTickSourceID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsTickSourceID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsTimerID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsTimerID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsTypeID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsTypeID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsTypeSerializerID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsTypeSerializerID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsUnitID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsUnitID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsUnitPrefixID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsUnitPrefixID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsVectorID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsVectorID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsWorldStatsID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsWorldStatsID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDEcsWorldSummaryID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDEcsWorldSummaryID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDFlecsAlertsID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDFlecsAlertsID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDFlecsMetricsID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDFlecsMetricsID__BindgenGetExtern();

        [System.Runtime.InteropServices.DllImport(BindgenInternal.DllImportPath, EntryPoint = "FLECS_IDFlecsStatsID__BindgenGetExtern", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* FLECS_IDFlecsStatsID__BindgenGetExtern();

        private static void* ECS_AUTO_OVERRIDE_Ptr;

        private static void* ecs_block_allocator_alloc_count_Ptr;

        private static void* ecs_block_allocator_free_count_Ptr;

        private static void* ecs_http_busy_count_Ptr;

        private static void* ecs_http_request_handled_error_count_Ptr;

        private static void* ecs_http_request_handled_ok_count_Ptr;

        private static void* ecs_http_request_invalid_count_Ptr;

        private static void* ecs_http_request_not_handled_count_Ptr;

        private static void* ecs_http_request_preflight_count_Ptr;

        private static void* ecs_http_request_received_count_Ptr;

        private static void* ecs_http_send_error_count_Ptr;

        private static void* ecs_http_send_ok_count_Ptr;

        private static void* ecs_os_api_Ptr;

        private static void* ecs_os_api_calloc_count_Ptr;

        private static void* ecs_os_api_free_count_Ptr;

        private static void* ecs_os_api_malloc_count_Ptr;

        private static void* ecs_os_api_realloc_count_Ptr;

        private static void* ECS_PAIR_Ptr;

        private static void* ecs_stack_allocator_alloc_count_Ptr;

        private static void* ecs_stack_allocator_free_count_Ptr;

        private static void* ECS_TOGGLE_Ptr;

        private static void* EcsAcceleration_Ptr;

        private static void* EcsAcyclic_Ptr;

        private static void* EcsAlertCritical_Ptr;

        private static void* EcsAlertError_Ptr;

        private static void* EcsAlertInfo_Ptr;

        private static void* EcsAlertWarning_Ptr;

        private static void* EcsAlias_Ptr;

        private static void* EcsAmount_Ptr;

        private static void* EcsAmpere_Ptr;

        private static void* EcsAngle_Ptr;

        private static void* EcsAny_Ptr;

        private static void* EcsAtto_Ptr;

        private static void* EcsBar_Ptr;

        private static void* EcsBel_Ptr;

        private static void* EcsBits_Ptr;

        private static void* EcsBitsPerSecond_Ptr;

        private static void* EcsBytes_Ptr;

        private static void* EcsBytesPerSecond_Ptr;

        private static void* EcsCandela_Ptr;

        private static void* EcsCanToggle_Ptr;

        private static void* EcsCelsius_Ptr;

        private static void* EcsCenti_Ptr;

        private static void* EcsCentiMeters_Ptr;

        private static void* EcsChildOf_Ptr;

        private static void* EcsColor_Ptr;

        private static void* EcsColorCss_Ptr;

        private static void* EcsColorHsl_Ptr;

        private static void* EcsColorRgb_Ptr;

        private static void* EcsConstant_Ptr;

        private static void* EcsCounter_Ptr;

        private static void* EcsCounterId_Ptr;

        private static void* EcsCounterIncrement_Ptr;

        private static void* EcsData_Ptr;

        private static void* EcsDataRate_Ptr;

        private static void* EcsDate_Ptr;

        private static void* EcsDays_Ptr;

        private static void* EcsDeca_Ptr;

        private static void* EcsDeci_Ptr;

        private static void* EcsDeciBel_Ptr;

        private static void* EcsDegrees_Ptr;

        private static void* EcsDelete_Ptr;

        private static void* EcsDependsOn_Ptr;

        private static void* EcsDisabled_Ptr;

        private static void* EcsDocBrief_Ptr;

        private static void* EcsDocColor_Ptr;

        private static void* EcsDocDetail_Ptr;

        private static void* EcsDocLink_Ptr;

        private static void* EcsDocUuid_Ptr;

        private static void* EcsDontInherit_Ptr;

        private static void* EcsDuration_Ptr;

        private static void* EcsElectricCurrent_Ptr;

        private static void* EcsEmpty_Ptr;

        private static void* EcsExa_Ptr;

        private static void* EcsExbi_Ptr;

        private static void* EcsExclusive_Ptr;

        private static void* EcsFahrenheit_Ptr;

        private static void* EcsFemto_Ptr;

        private static void* EcsFinal_Ptr;

        private static void* EcsFlecs_Ptr;

        private static void* EcsFlecsCore_Ptr;

        private static void* EcsForce_Ptr;

        private static void* EcsFrequency_Ptr;

        private static void* EcsGauge_Ptr;

        private static void* EcsGibi_Ptr;

        private static void* EcsGibiBytes_Ptr;

        private static void* EcsGiga_Ptr;

        private static void* EcsGigaBits_Ptr;

        private static void* EcsGigaBitsPerSecond_Ptr;

        private static void* EcsGigaBytes_Ptr;

        private static void* EcsGigaBytesPerSecond_Ptr;

        private static void* EcsGigaHertz_Ptr;

        private static void* EcsGrams_Ptr;

        private static void* EcsHecto_Ptr;

        private static void* EcsHertz_Ptr;

        private static void* EcsHours_Ptr;

        private static void* EcsInherit_Ptr;

        private static void* EcsIsA_Ptr;

        private static void* EcsKelvin_Ptr;

        private static void* EcsKibi_Ptr;

        private static void* EcsKibiBytes_Ptr;

        private static void* EcsKilo_Ptr;

        private static void* EcsKiloBits_Ptr;

        private static void* EcsKiloBitsPerSecond_Ptr;

        private static void* EcsKiloBytes_Ptr;

        private static void* EcsKiloBytesPerSecond_Ptr;

        private static void* EcsKiloGrams_Ptr;

        private static void* EcsKiloHertz_Ptr;

        private static void* EcsKiloMeters_Ptr;

        private static void* EcsKiloMetersPerHour_Ptr;

        private static void* EcsKiloMetersPerSecond_Ptr;

        private static void* EcsLength_Ptr;

        private static void* EcsLuminousIntensity_Ptr;

        private static void* EcsMass_Ptr;

        private static void* EcsMebi_Ptr;

        private static void* EcsMebiBytes_Ptr;

        private static void* EcsMega_Ptr;

        private static void* EcsMegaBits_Ptr;

        private static void* EcsMegaBitsPerSecond_Ptr;

        private static void* EcsMegaBytes_Ptr;

        private static void* EcsMegaBytesPerSecond_Ptr;

        private static void* EcsMegaHertz_Ptr;

        private static void* EcsMeters_Ptr;

        private static void* EcsMetersPerSecond_Ptr;

        private static void* EcsMetric_Ptr;

        private static void* EcsMetricInstance_Ptr;

        private static void* EcsMicro_Ptr;

        private static void* EcsMicroMeters_Ptr;

        private static void* EcsMicroSeconds_Ptr;

        private static void* EcsMiles_Ptr;

        private static void* EcsMilesPerHour_Ptr;

        private static void* EcsMilli_Ptr;

        private static void* EcsMilliMeters_Ptr;

        private static void* EcsMilliSeconds_Ptr;

        private static void* EcsMinutes_Ptr;

        private static void* EcsModule_Ptr;

        private static void* EcsMole_Ptr;

        private static void* EcsMonitor_Ptr;

        private static void* EcsName_Ptr;

        private static void* EcsNano_Ptr;

        private static void* EcsNanoMeters_Ptr;

        private static void* EcsNanoSeconds_Ptr;

        private static void* EcsNewton_Ptr;

        private static void* EcsNotQueryable_Ptr;

        private static void* EcsObserver_Ptr;

        private static void* EcsOnAdd_Ptr;

        private static void* EcsOnDelete_Ptr;

        private static void* EcsOnDeleteTarget_Ptr;

        private static void* EcsOneOf_Ptr;

        private static void* EcsOnInstantiate_Ptr;

        private static void* EcsOnLoad_Ptr;

        private static void* EcsOnRemove_Ptr;

        private static void* EcsOnSet_Ptr;

        private static void* EcsOnStart_Ptr;

        private static void* EcsOnStore_Ptr;

        private static void* EcsOnTableCreate_Ptr;

        private static void* EcsOnTableDelete_Ptr;

        private static void* EcsOnTableEmpty_Ptr;

        private static void* EcsOnTableFill_Ptr;

        private static void* EcsOnUpdate_Ptr;

        private static void* EcsOnValidate_Ptr;

        private static void* EcsOverride_Ptr;

        private static void* EcsPairIsTag_Ptr;

        private static void* EcsPanic_Ptr;

        private static void* EcsPascal_Ptr;

        private static void* EcsPebi_Ptr;

        private static void* EcsPercentage_Ptr;

        private static void* EcsPeriod1d_Ptr;

        private static void* EcsPeriod1h_Ptr;

        private static void* EcsPeriod1m_Ptr;

        private static void* EcsPeriod1s_Ptr;

        private static void* EcsPeriod1w_Ptr;

        private static void* EcsPeta_Ptr;

        private static void* EcsPhase_Ptr;

        private static void* EcsPico_Ptr;

        private static void* EcsPicoMeters_Ptr;

        private static void* EcsPicoSeconds_Ptr;

        private static void* EcsPixels_Ptr;

        private static void* EcsPostFrame_Ptr;

        private static void* EcsPostLoad_Ptr;

        private static void* EcsPostUpdate_Ptr;

        private static void* EcsPredEq_Ptr;

        private static void* EcsPredLookup_Ptr;

        private static void* EcsPredMatch_Ptr;

        private static void* EcsPrefab_Ptr;

        private static void* EcsPreFrame_Ptr;

        private static void* EcsPressure_Ptr;

        private static void* EcsPreStore_Ptr;

        private static void* EcsPreUpdate_Ptr;

        private static void* EcsPrivate_Ptr;

        private static void* EcsQuantity_Ptr;

        private static void* EcsQuery_Ptr;

        private static void* EcsRadians_Ptr;

        private static void* EcsReflexive_Ptr;

        private static void* EcsRelationship_Ptr;

        private static void* EcsRemove_Ptr;

        private static void* EcsScopeClose_Ptr;

        private static void* EcsScopeOpen_Ptr;

        private static void* EcsSeconds_Ptr;

        private static void* EcsSlotOf_Ptr;

        private static void* EcsSparse_Ptr;

        private static void* EcsSpeed_Ptr;

        private static void* EcsSymbol_Ptr;

        private static void* EcsSymmetric_Ptr;

        private static void* EcsSystem_Ptr;

        private static void* EcsTarget_Ptr;

        private static void* EcsTebi_Ptr;

        private static void* EcsTemperature_Ptr;

        private static void* EcsTera_Ptr;

        private static void* EcsThis_Ptr;

        private static void* EcsTime_Ptr;

        private static void* EcsTrait_Ptr;

        private static void* EcsTransitive_Ptr;

        private static void* EcsTraversable_Ptr;

        private static void* EcsUnion_Ptr;

        private static void* EcsUnitPrefixes_Ptr;

        private static void* EcsUri_Ptr;

        private static void* EcsUriFile_Ptr;

        private static void* EcsUriHyperlink_Ptr;

        private static void* EcsUriImage_Ptr;

        private static void* EcsVariable_Ptr;

        private static void* EcsWildcard_Ptr;

        private static void* EcsWith_Ptr;

        private static void* EcsWorld_Ptr;

        private static void* EcsYobi_Ptr;

        private static void* EcsYocto_Ptr;

        private static void* EcsYotta_Ptr;

        private static void* EcsZebi_Ptr;

        private static void* EcsZepto_Ptr;

        private static void* EcsZetta_Ptr;

        private static void* FLECS_IDecs_bool_tID__Ptr;

        private static void* FLECS_IDecs_byte_tID__Ptr;

        private static void* FLECS_IDecs_char_tID__Ptr;

        private static void* FLECS_IDecs_entity_tID__Ptr;

        private static void* FLECS_IDecs_f32_tID__Ptr;

        private static void* FLECS_IDecs_f64_tID__Ptr;

        private static void* FLECS_IDecs_i16_tID__Ptr;

        private static void* FLECS_IDecs_i32_tID__Ptr;

        private static void* FLECS_IDecs_i64_tID__Ptr;

        private static void* FLECS_IDecs_i8_tID__Ptr;

        private static void* FLECS_IDecs_id_tID__Ptr;

        private static void* FLECS_IDecs_iptr_tID__Ptr;

        private static void* FLECS_IDecs_string_tID__Ptr;

        private static void* FLECS_IDecs_u16_tID__Ptr;

        private static void* FLECS_IDecs_u32_tID__Ptr;

        private static void* FLECS_IDecs_u64_tID__Ptr;

        private static void* FLECS_IDecs_u8_tID__Ptr;

        private static void* FLECS_IDecs_uptr_tID__Ptr;

        private static void* FLECS_IDEcsAlertCriticalID__Ptr;

        private static void* FLECS_IDEcsAlertErrorID__Ptr;

        private static void* FLECS_IDEcsAlertID__Ptr;

        private static void* FLECS_IDEcsAlertInfoID__Ptr;

        private static void* FLECS_IDEcsAlertInstanceID__Ptr;

        private static void* FLECS_IDEcsAlertsActiveID__Ptr;

        private static void* FLECS_IDEcsAlertTimeoutID__Ptr;

        private static void* FLECS_IDEcsAlertWarningID__Ptr;

        private static void* FLECS_IDEcsArrayID__Ptr;

        private static void* FLECS_IDEcsBitmaskID__Ptr;

        private static void* FLECS_IDEcsComponentID__Ptr;

        private static void* FLECS_IDEcsCounterID__Ptr;

        private static void* FLECS_IDEcsCounterIdID__Ptr;

        private static void* FLECS_IDEcsCounterIncrementID__Ptr;

        private static void* FLECS_IDEcsDefaultChildComponentID__Ptr;

        private static void* FLECS_IDEcsDocDescriptionID__Ptr;

        private static void* FLECS_IDEcsEnumID__Ptr;

        private static void* FLECS_IDEcsGaugeID__Ptr;

        private static void* FLECS_IDEcsIdentifierID__Ptr;

        private static void* FLECS_IDEcsMemberID__Ptr;

        private static void* FLECS_IDEcsMemberRangesID__Ptr;

        private static void* FLECS_IDEcsMetricID__Ptr;

        private static void* FLECS_IDEcsMetricInstanceID__Ptr;

        private static void* FLECS_IDEcsMetricSourceID__Ptr;

        private static void* FLECS_IDEcsMetricValueID__Ptr;

        private static void* FLECS_IDEcsOpaqueID__Ptr;

        private static void* FLECS_IDEcsPipelineID__Ptr;

        private static void* FLECS_IDEcsPipelineStatsID__Ptr;

        private static void* FLECS_IDEcsPolyID__Ptr;

        private static void* FLECS_IDEcsPrimitiveID__Ptr;

        private static void* FLECS_IDEcsRateFilterID__Ptr;

        private static void* FLECS_IDEcsRestID__Ptr;

        private static void* FLECS_IDEcsScriptID__Ptr;

        private static void* FLECS_IDEcsStructID__Ptr;

        private static void* FLECS_IDEcsSystemStatsID__Ptr;

        private static void* FLECS_IDEcsTickSourceID__Ptr;

        private static void* FLECS_IDEcsTimerID__Ptr;

        private static void* FLECS_IDEcsTypeID__Ptr;

        private static void* FLECS_IDEcsTypeSerializerID__Ptr;

        private static void* FLECS_IDEcsUnitID__Ptr;

        private static void* FLECS_IDEcsUnitPrefixID__Ptr;

        private static void* FLECS_IDEcsVectorID__Ptr;

        private static void* FLECS_IDEcsWorldStatsID__Ptr;

        private static void* FLECS_IDEcsWorldSummaryID__Ptr;

        private static void* FLECS_IDFlecsAlertsID__Ptr;

        private static void* FLECS_IDFlecsMetricsID__Ptr;

        private static void* FLECS_IDFlecsStatsID__Ptr;

        public static ref ulong ECS_AUTO_OVERRIDE => ref *(ulong*)(ECS_AUTO_OVERRIDE_Ptr == null ? ECS_AUTO_OVERRIDE_Ptr = ECS_AUTO_OVERRIDE_BindgenGetExtern() : ECS_AUTO_OVERRIDE_Ptr);

        public static ref long ecs_block_allocator_alloc_count => ref *(long*)(ecs_block_allocator_alloc_count_Ptr == null ? ecs_block_allocator_alloc_count_Ptr = ecs_block_allocator_alloc_count_BindgenGetExtern() : ecs_block_allocator_alloc_count_Ptr);

        public static ref long ecs_block_allocator_free_count => ref *(long*)(ecs_block_allocator_free_count_Ptr == null ? ecs_block_allocator_free_count_Ptr = ecs_block_allocator_free_count_BindgenGetExtern() : ecs_block_allocator_free_count_Ptr);

        public static ref long ecs_http_busy_count => ref *(long*)(ecs_http_busy_count_Ptr == null ? ecs_http_busy_count_Ptr = ecs_http_busy_count_BindgenGetExtern() : ecs_http_busy_count_Ptr);

        public static ref long ecs_http_request_handled_error_count => ref *(long*)(ecs_http_request_handled_error_count_Ptr == null ? ecs_http_request_handled_error_count_Ptr = ecs_http_request_handled_error_count_BindgenGetExtern() : ecs_http_request_handled_error_count_Ptr);

        public static ref long ecs_http_request_handled_ok_count => ref *(long*)(ecs_http_request_handled_ok_count_Ptr == null ? ecs_http_request_handled_ok_count_Ptr = ecs_http_request_handled_ok_count_BindgenGetExtern() : ecs_http_request_handled_ok_count_Ptr);

        public static ref long ecs_http_request_invalid_count => ref *(long*)(ecs_http_request_invalid_count_Ptr == null ? ecs_http_request_invalid_count_Ptr = ecs_http_request_invalid_count_BindgenGetExtern() : ecs_http_request_invalid_count_Ptr);

        public static ref long ecs_http_request_not_handled_count => ref *(long*)(ecs_http_request_not_handled_count_Ptr == null ? ecs_http_request_not_handled_count_Ptr = ecs_http_request_not_handled_count_BindgenGetExtern() : ecs_http_request_not_handled_count_Ptr);

        public static ref long ecs_http_request_preflight_count => ref *(long*)(ecs_http_request_preflight_count_Ptr == null ? ecs_http_request_preflight_count_Ptr = ecs_http_request_preflight_count_BindgenGetExtern() : ecs_http_request_preflight_count_Ptr);

        public static ref long ecs_http_request_received_count => ref *(long*)(ecs_http_request_received_count_Ptr == null ? ecs_http_request_received_count_Ptr = ecs_http_request_received_count_BindgenGetExtern() : ecs_http_request_received_count_Ptr);

        public static ref long ecs_http_send_error_count => ref *(long*)(ecs_http_send_error_count_Ptr == null ? ecs_http_send_error_count_Ptr = ecs_http_send_error_count_BindgenGetExtern() : ecs_http_send_error_count_Ptr);

        public static ref long ecs_http_send_ok_count => ref *(long*)(ecs_http_send_ok_count_Ptr == null ? ecs_http_send_ok_count_Ptr = ecs_http_send_ok_count_BindgenGetExtern() : ecs_http_send_ok_count_Ptr);

        public static ref ecs_os_api_t ecs_os_api => ref *(ecs_os_api_t*)(ecs_os_api_Ptr == null ? ecs_os_api_Ptr = ecs_os_api_BindgenGetExtern() : ecs_os_api_Ptr);

        public static ref long ecs_os_api_calloc_count => ref *(long*)(ecs_os_api_calloc_count_Ptr == null ? ecs_os_api_calloc_count_Ptr = ecs_os_api_calloc_count_BindgenGetExtern() : ecs_os_api_calloc_count_Ptr);

        public static ref long ecs_os_api_free_count => ref *(long*)(ecs_os_api_free_count_Ptr == null ? ecs_os_api_free_count_Ptr = ecs_os_api_free_count_BindgenGetExtern() : ecs_os_api_free_count_Ptr);

        public static ref long ecs_os_api_malloc_count => ref *(long*)(ecs_os_api_malloc_count_Ptr == null ? ecs_os_api_malloc_count_Ptr = ecs_os_api_malloc_count_BindgenGetExtern() : ecs_os_api_malloc_count_Ptr);

        public static ref long ecs_os_api_realloc_count => ref *(long*)(ecs_os_api_realloc_count_Ptr == null ? ecs_os_api_realloc_count_Ptr = ecs_os_api_realloc_count_BindgenGetExtern() : ecs_os_api_realloc_count_Ptr);

        public static ref ulong ECS_PAIR => ref *(ulong*)(ECS_PAIR_Ptr == null ? ECS_PAIR_Ptr = ECS_PAIR_BindgenGetExtern() : ECS_PAIR_Ptr);

        public static ref long ecs_stack_allocator_alloc_count => ref *(long*)(ecs_stack_allocator_alloc_count_Ptr == null ? ecs_stack_allocator_alloc_count_Ptr = ecs_stack_allocator_alloc_count_BindgenGetExtern() : ecs_stack_allocator_alloc_count_Ptr);

        public static ref long ecs_stack_allocator_free_count => ref *(long*)(ecs_stack_allocator_free_count_Ptr == null ? ecs_stack_allocator_free_count_Ptr = ecs_stack_allocator_free_count_BindgenGetExtern() : ecs_stack_allocator_free_count_Ptr);

        public static ref ulong ECS_TOGGLE => ref *(ulong*)(ECS_TOGGLE_Ptr == null ? ECS_TOGGLE_Ptr = ECS_TOGGLE_BindgenGetExtern() : ECS_TOGGLE_Ptr);

        public static ref ulong EcsAcceleration => ref *(ulong*)(EcsAcceleration_Ptr == null ? EcsAcceleration_Ptr = EcsAcceleration_BindgenGetExtern() : EcsAcceleration_Ptr);

        public static ref ulong EcsAcyclic => ref *(ulong*)(EcsAcyclic_Ptr == null ? EcsAcyclic_Ptr = EcsAcyclic_BindgenGetExtern() : EcsAcyclic_Ptr);

        public static ref ulong EcsAlertCritical => ref *(ulong*)(EcsAlertCritical_Ptr == null ? EcsAlertCritical_Ptr = EcsAlertCritical_BindgenGetExtern() : EcsAlertCritical_Ptr);

        public static ref ulong EcsAlertError => ref *(ulong*)(EcsAlertError_Ptr == null ? EcsAlertError_Ptr = EcsAlertError_BindgenGetExtern() : EcsAlertError_Ptr);

        public static ref ulong EcsAlertInfo => ref *(ulong*)(EcsAlertInfo_Ptr == null ? EcsAlertInfo_Ptr = EcsAlertInfo_BindgenGetExtern() : EcsAlertInfo_Ptr);

        public static ref ulong EcsAlertWarning => ref *(ulong*)(EcsAlertWarning_Ptr == null ? EcsAlertWarning_Ptr = EcsAlertWarning_BindgenGetExtern() : EcsAlertWarning_Ptr);

        public static ref ulong EcsAlias => ref *(ulong*)(EcsAlias_Ptr == null ? EcsAlias_Ptr = EcsAlias_BindgenGetExtern() : EcsAlias_Ptr);

        public static ref ulong EcsAmount => ref *(ulong*)(EcsAmount_Ptr == null ? EcsAmount_Ptr = EcsAmount_BindgenGetExtern() : EcsAmount_Ptr);

        public static ref ulong EcsAmpere => ref *(ulong*)(EcsAmpere_Ptr == null ? EcsAmpere_Ptr = EcsAmpere_BindgenGetExtern() : EcsAmpere_Ptr);

        public static ref ulong EcsAngle => ref *(ulong*)(EcsAngle_Ptr == null ? EcsAngle_Ptr = EcsAngle_BindgenGetExtern() : EcsAngle_Ptr);

        public static ref ulong EcsAny => ref *(ulong*)(EcsAny_Ptr == null ? EcsAny_Ptr = EcsAny_BindgenGetExtern() : EcsAny_Ptr);

        public static ref ulong EcsAtto => ref *(ulong*)(EcsAtto_Ptr == null ? EcsAtto_Ptr = EcsAtto_BindgenGetExtern() : EcsAtto_Ptr);

        public static ref ulong EcsBar => ref *(ulong*)(EcsBar_Ptr == null ? EcsBar_Ptr = EcsBar_BindgenGetExtern() : EcsBar_Ptr);

        public static ref ulong EcsBel => ref *(ulong*)(EcsBel_Ptr == null ? EcsBel_Ptr = EcsBel_BindgenGetExtern() : EcsBel_Ptr);

        public static ref ulong EcsBits => ref *(ulong*)(EcsBits_Ptr == null ? EcsBits_Ptr = EcsBits_BindgenGetExtern() : EcsBits_Ptr);

        public static ref ulong EcsBitsPerSecond => ref *(ulong*)(EcsBitsPerSecond_Ptr == null ? EcsBitsPerSecond_Ptr = EcsBitsPerSecond_BindgenGetExtern() : EcsBitsPerSecond_Ptr);

        public static ref ulong EcsBytes => ref *(ulong*)(EcsBytes_Ptr == null ? EcsBytes_Ptr = EcsBytes_BindgenGetExtern() : EcsBytes_Ptr);

        public static ref ulong EcsBytesPerSecond => ref *(ulong*)(EcsBytesPerSecond_Ptr == null ? EcsBytesPerSecond_Ptr = EcsBytesPerSecond_BindgenGetExtern() : EcsBytesPerSecond_Ptr);

        public static ref ulong EcsCandela => ref *(ulong*)(EcsCandela_Ptr == null ? EcsCandela_Ptr = EcsCandela_BindgenGetExtern() : EcsCandela_Ptr);

        public static ref ulong EcsCanToggle => ref *(ulong*)(EcsCanToggle_Ptr == null ? EcsCanToggle_Ptr = EcsCanToggle_BindgenGetExtern() : EcsCanToggle_Ptr);

        public static ref ulong EcsCelsius => ref *(ulong*)(EcsCelsius_Ptr == null ? EcsCelsius_Ptr = EcsCelsius_BindgenGetExtern() : EcsCelsius_Ptr);

        public static ref ulong EcsCenti => ref *(ulong*)(EcsCenti_Ptr == null ? EcsCenti_Ptr = EcsCenti_BindgenGetExtern() : EcsCenti_Ptr);

        public static ref ulong EcsCentiMeters => ref *(ulong*)(EcsCentiMeters_Ptr == null ? EcsCentiMeters_Ptr = EcsCentiMeters_BindgenGetExtern() : EcsCentiMeters_Ptr);

        public static ref ulong EcsChildOf => ref *(ulong*)(EcsChildOf_Ptr == null ? EcsChildOf_Ptr = EcsChildOf_BindgenGetExtern() : EcsChildOf_Ptr);

        public static ref ulong EcsColor => ref *(ulong*)(EcsColor_Ptr == null ? EcsColor_Ptr = EcsColor_BindgenGetExtern() : EcsColor_Ptr);

        public static ref ulong EcsColorCss => ref *(ulong*)(EcsColorCss_Ptr == null ? EcsColorCss_Ptr = EcsColorCss_BindgenGetExtern() : EcsColorCss_Ptr);

        public static ref ulong EcsColorHsl => ref *(ulong*)(EcsColorHsl_Ptr == null ? EcsColorHsl_Ptr = EcsColorHsl_BindgenGetExtern() : EcsColorHsl_Ptr);

        public static ref ulong EcsColorRgb => ref *(ulong*)(EcsColorRgb_Ptr == null ? EcsColorRgb_Ptr = EcsColorRgb_BindgenGetExtern() : EcsColorRgb_Ptr);

        public static ref ulong EcsConstant => ref *(ulong*)(EcsConstant_Ptr == null ? EcsConstant_Ptr = EcsConstant_BindgenGetExtern() : EcsConstant_Ptr);

        public static ref ulong EcsCounter => ref *(ulong*)(EcsCounter_Ptr == null ? EcsCounter_Ptr = EcsCounter_BindgenGetExtern() : EcsCounter_Ptr);

        public static ref ulong EcsCounterId => ref *(ulong*)(EcsCounterId_Ptr == null ? EcsCounterId_Ptr = EcsCounterId_BindgenGetExtern() : EcsCounterId_Ptr);

        public static ref ulong EcsCounterIncrement => ref *(ulong*)(EcsCounterIncrement_Ptr == null ? EcsCounterIncrement_Ptr = EcsCounterIncrement_BindgenGetExtern() : EcsCounterIncrement_Ptr);

        public static ref ulong EcsData => ref *(ulong*)(EcsData_Ptr == null ? EcsData_Ptr = EcsData_BindgenGetExtern() : EcsData_Ptr);

        public static ref ulong EcsDataRate => ref *(ulong*)(EcsDataRate_Ptr == null ? EcsDataRate_Ptr = EcsDataRate_BindgenGetExtern() : EcsDataRate_Ptr);

        public static ref ulong EcsDate => ref *(ulong*)(EcsDate_Ptr == null ? EcsDate_Ptr = EcsDate_BindgenGetExtern() : EcsDate_Ptr);

        public static ref ulong EcsDays => ref *(ulong*)(EcsDays_Ptr == null ? EcsDays_Ptr = EcsDays_BindgenGetExtern() : EcsDays_Ptr);

        public static ref ulong EcsDeca => ref *(ulong*)(EcsDeca_Ptr == null ? EcsDeca_Ptr = EcsDeca_BindgenGetExtern() : EcsDeca_Ptr);

        public static ref ulong EcsDeci => ref *(ulong*)(EcsDeci_Ptr == null ? EcsDeci_Ptr = EcsDeci_BindgenGetExtern() : EcsDeci_Ptr);

        public static ref ulong EcsDeciBel => ref *(ulong*)(EcsDeciBel_Ptr == null ? EcsDeciBel_Ptr = EcsDeciBel_BindgenGetExtern() : EcsDeciBel_Ptr);

        public static ref ulong EcsDegrees => ref *(ulong*)(EcsDegrees_Ptr == null ? EcsDegrees_Ptr = EcsDegrees_BindgenGetExtern() : EcsDegrees_Ptr);

        public static ref ulong EcsDelete => ref *(ulong*)(EcsDelete_Ptr == null ? EcsDelete_Ptr = EcsDelete_BindgenGetExtern() : EcsDelete_Ptr);

        public static ref ulong EcsDependsOn => ref *(ulong*)(EcsDependsOn_Ptr == null ? EcsDependsOn_Ptr = EcsDependsOn_BindgenGetExtern() : EcsDependsOn_Ptr);

        public static ref ulong EcsDisabled => ref *(ulong*)(EcsDisabled_Ptr == null ? EcsDisabled_Ptr = EcsDisabled_BindgenGetExtern() : EcsDisabled_Ptr);

        public static ref ulong EcsDocBrief => ref *(ulong*)(EcsDocBrief_Ptr == null ? EcsDocBrief_Ptr = EcsDocBrief_BindgenGetExtern() : EcsDocBrief_Ptr);

        public static ref ulong EcsDocColor => ref *(ulong*)(EcsDocColor_Ptr == null ? EcsDocColor_Ptr = EcsDocColor_BindgenGetExtern() : EcsDocColor_Ptr);

        public static ref ulong EcsDocDetail => ref *(ulong*)(EcsDocDetail_Ptr == null ? EcsDocDetail_Ptr = EcsDocDetail_BindgenGetExtern() : EcsDocDetail_Ptr);

        public static ref ulong EcsDocLink => ref *(ulong*)(EcsDocLink_Ptr == null ? EcsDocLink_Ptr = EcsDocLink_BindgenGetExtern() : EcsDocLink_Ptr);

        public static ref ulong EcsDocUuid => ref *(ulong*)(EcsDocUuid_Ptr == null ? EcsDocUuid_Ptr = EcsDocUuid_BindgenGetExtern() : EcsDocUuid_Ptr);

        public static ref ulong EcsDontInherit => ref *(ulong*)(EcsDontInherit_Ptr == null ? EcsDontInherit_Ptr = EcsDontInherit_BindgenGetExtern() : EcsDontInherit_Ptr);

        public static ref ulong EcsDuration => ref *(ulong*)(EcsDuration_Ptr == null ? EcsDuration_Ptr = EcsDuration_BindgenGetExtern() : EcsDuration_Ptr);

        public static ref ulong EcsElectricCurrent => ref *(ulong*)(EcsElectricCurrent_Ptr == null ? EcsElectricCurrent_Ptr = EcsElectricCurrent_BindgenGetExtern() : EcsElectricCurrent_Ptr);

        public static ref ulong EcsEmpty => ref *(ulong*)(EcsEmpty_Ptr == null ? EcsEmpty_Ptr = EcsEmpty_BindgenGetExtern() : EcsEmpty_Ptr);

        public static ref ulong EcsExa => ref *(ulong*)(EcsExa_Ptr == null ? EcsExa_Ptr = EcsExa_BindgenGetExtern() : EcsExa_Ptr);

        public static ref ulong EcsExbi => ref *(ulong*)(EcsExbi_Ptr == null ? EcsExbi_Ptr = EcsExbi_BindgenGetExtern() : EcsExbi_Ptr);

        public static ref ulong EcsExclusive => ref *(ulong*)(EcsExclusive_Ptr == null ? EcsExclusive_Ptr = EcsExclusive_BindgenGetExtern() : EcsExclusive_Ptr);

        public static ref ulong EcsFahrenheit => ref *(ulong*)(EcsFahrenheit_Ptr == null ? EcsFahrenheit_Ptr = EcsFahrenheit_BindgenGetExtern() : EcsFahrenheit_Ptr);

        public static ref ulong EcsFemto => ref *(ulong*)(EcsFemto_Ptr == null ? EcsFemto_Ptr = EcsFemto_BindgenGetExtern() : EcsFemto_Ptr);

        public static ref ulong EcsFinal => ref *(ulong*)(EcsFinal_Ptr == null ? EcsFinal_Ptr = EcsFinal_BindgenGetExtern() : EcsFinal_Ptr);

        public static ref ulong EcsFlecs => ref *(ulong*)(EcsFlecs_Ptr == null ? EcsFlecs_Ptr = EcsFlecs_BindgenGetExtern() : EcsFlecs_Ptr);

        public static ref ulong EcsFlecsCore => ref *(ulong*)(EcsFlecsCore_Ptr == null ? EcsFlecsCore_Ptr = EcsFlecsCore_BindgenGetExtern() : EcsFlecsCore_Ptr);

        public static ref ulong EcsForce => ref *(ulong*)(EcsForce_Ptr == null ? EcsForce_Ptr = EcsForce_BindgenGetExtern() : EcsForce_Ptr);

        public static ref ulong EcsFrequency => ref *(ulong*)(EcsFrequency_Ptr == null ? EcsFrequency_Ptr = EcsFrequency_BindgenGetExtern() : EcsFrequency_Ptr);

        public static ref ulong EcsGauge => ref *(ulong*)(EcsGauge_Ptr == null ? EcsGauge_Ptr = EcsGauge_BindgenGetExtern() : EcsGauge_Ptr);

        public static ref ulong EcsGibi => ref *(ulong*)(EcsGibi_Ptr == null ? EcsGibi_Ptr = EcsGibi_BindgenGetExtern() : EcsGibi_Ptr);

        public static ref ulong EcsGibiBytes => ref *(ulong*)(EcsGibiBytes_Ptr == null ? EcsGibiBytes_Ptr = EcsGibiBytes_BindgenGetExtern() : EcsGibiBytes_Ptr);

        public static ref ulong EcsGiga => ref *(ulong*)(EcsGiga_Ptr == null ? EcsGiga_Ptr = EcsGiga_BindgenGetExtern() : EcsGiga_Ptr);

        public static ref ulong EcsGigaBits => ref *(ulong*)(EcsGigaBits_Ptr == null ? EcsGigaBits_Ptr = EcsGigaBits_BindgenGetExtern() : EcsGigaBits_Ptr);

        public static ref ulong EcsGigaBitsPerSecond => ref *(ulong*)(EcsGigaBitsPerSecond_Ptr == null ? EcsGigaBitsPerSecond_Ptr = EcsGigaBitsPerSecond_BindgenGetExtern() : EcsGigaBitsPerSecond_Ptr);

        public static ref ulong EcsGigaBytes => ref *(ulong*)(EcsGigaBytes_Ptr == null ? EcsGigaBytes_Ptr = EcsGigaBytes_BindgenGetExtern() : EcsGigaBytes_Ptr);

        public static ref ulong EcsGigaBytesPerSecond => ref *(ulong*)(EcsGigaBytesPerSecond_Ptr == null ? EcsGigaBytesPerSecond_Ptr = EcsGigaBytesPerSecond_BindgenGetExtern() : EcsGigaBytesPerSecond_Ptr);

        public static ref ulong EcsGigaHertz => ref *(ulong*)(EcsGigaHertz_Ptr == null ? EcsGigaHertz_Ptr = EcsGigaHertz_BindgenGetExtern() : EcsGigaHertz_Ptr);

        public static ref ulong EcsGrams => ref *(ulong*)(EcsGrams_Ptr == null ? EcsGrams_Ptr = EcsGrams_BindgenGetExtern() : EcsGrams_Ptr);

        public static ref ulong EcsHecto => ref *(ulong*)(EcsHecto_Ptr == null ? EcsHecto_Ptr = EcsHecto_BindgenGetExtern() : EcsHecto_Ptr);

        public static ref ulong EcsHertz => ref *(ulong*)(EcsHertz_Ptr == null ? EcsHertz_Ptr = EcsHertz_BindgenGetExtern() : EcsHertz_Ptr);

        public static ref ulong EcsHours => ref *(ulong*)(EcsHours_Ptr == null ? EcsHours_Ptr = EcsHours_BindgenGetExtern() : EcsHours_Ptr);

        public static ref ulong EcsInherit => ref *(ulong*)(EcsInherit_Ptr == null ? EcsInherit_Ptr = EcsInherit_BindgenGetExtern() : EcsInherit_Ptr);

        public static ref ulong EcsIsA => ref *(ulong*)(EcsIsA_Ptr == null ? EcsIsA_Ptr = EcsIsA_BindgenGetExtern() : EcsIsA_Ptr);

        public static ref ulong EcsKelvin => ref *(ulong*)(EcsKelvin_Ptr == null ? EcsKelvin_Ptr = EcsKelvin_BindgenGetExtern() : EcsKelvin_Ptr);

        public static ref ulong EcsKibi => ref *(ulong*)(EcsKibi_Ptr == null ? EcsKibi_Ptr = EcsKibi_BindgenGetExtern() : EcsKibi_Ptr);

        public static ref ulong EcsKibiBytes => ref *(ulong*)(EcsKibiBytes_Ptr == null ? EcsKibiBytes_Ptr = EcsKibiBytes_BindgenGetExtern() : EcsKibiBytes_Ptr);

        public static ref ulong EcsKilo => ref *(ulong*)(EcsKilo_Ptr == null ? EcsKilo_Ptr = EcsKilo_BindgenGetExtern() : EcsKilo_Ptr);

        public static ref ulong EcsKiloBits => ref *(ulong*)(EcsKiloBits_Ptr == null ? EcsKiloBits_Ptr = EcsKiloBits_BindgenGetExtern() : EcsKiloBits_Ptr);

        public static ref ulong EcsKiloBitsPerSecond => ref *(ulong*)(EcsKiloBitsPerSecond_Ptr == null ? EcsKiloBitsPerSecond_Ptr = EcsKiloBitsPerSecond_BindgenGetExtern() : EcsKiloBitsPerSecond_Ptr);

        public static ref ulong EcsKiloBytes => ref *(ulong*)(EcsKiloBytes_Ptr == null ? EcsKiloBytes_Ptr = EcsKiloBytes_BindgenGetExtern() : EcsKiloBytes_Ptr);

        public static ref ulong EcsKiloBytesPerSecond => ref *(ulong*)(EcsKiloBytesPerSecond_Ptr == null ? EcsKiloBytesPerSecond_Ptr = EcsKiloBytesPerSecond_BindgenGetExtern() : EcsKiloBytesPerSecond_Ptr);

        public static ref ulong EcsKiloGrams => ref *(ulong*)(EcsKiloGrams_Ptr == null ? EcsKiloGrams_Ptr = EcsKiloGrams_BindgenGetExtern() : EcsKiloGrams_Ptr);

        public static ref ulong EcsKiloHertz => ref *(ulong*)(EcsKiloHertz_Ptr == null ? EcsKiloHertz_Ptr = EcsKiloHertz_BindgenGetExtern() : EcsKiloHertz_Ptr);

        public static ref ulong EcsKiloMeters => ref *(ulong*)(EcsKiloMeters_Ptr == null ? EcsKiloMeters_Ptr = EcsKiloMeters_BindgenGetExtern() : EcsKiloMeters_Ptr);

        public static ref ulong EcsKiloMetersPerHour => ref *(ulong*)(EcsKiloMetersPerHour_Ptr == null ? EcsKiloMetersPerHour_Ptr = EcsKiloMetersPerHour_BindgenGetExtern() : EcsKiloMetersPerHour_Ptr);

        public static ref ulong EcsKiloMetersPerSecond => ref *(ulong*)(EcsKiloMetersPerSecond_Ptr == null ? EcsKiloMetersPerSecond_Ptr = EcsKiloMetersPerSecond_BindgenGetExtern() : EcsKiloMetersPerSecond_Ptr);

        public static ref ulong EcsLength => ref *(ulong*)(EcsLength_Ptr == null ? EcsLength_Ptr = EcsLength_BindgenGetExtern() : EcsLength_Ptr);

        public static ref ulong EcsLuminousIntensity => ref *(ulong*)(EcsLuminousIntensity_Ptr == null ? EcsLuminousIntensity_Ptr = EcsLuminousIntensity_BindgenGetExtern() : EcsLuminousIntensity_Ptr);

        public static ref ulong EcsMass => ref *(ulong*)(EcsMass_Ptr == null ? EcsMass_Ptr = EcsMass_BindgenGetExtern() : EcsMass_Ptr);

        public static ref ulong EcsMebi => ref *(ulong*)(EcsMebi_Ptr == null ? EcsMebi_Ptr = EcsMebi_BindgenGetExtern() : EcsMebi_Ptr);

        public static ref ulong EcsMebiBytes => ref *(ulong*)(EcsMebiBytes_Ptr == null ? EcsMebiBytes_Ptr = EcsMebiBytes_BindgenGetExtern() : EcsMebiBytes_Ptr);

        public static ref ulong EcsMega => ref *(ulong*)(EcsMega_Ptr == null ? EcsMega_Ptr = EcsMega_BindgenGetExtern() : EcsMega_Ptr);

        public static ref ulong EcsMegaBits => ref *(ulong*)(EcsMegaBits_Ptr == null ? EcsMegaBits_Ptr = EcsMegaBits_BindgenGetExtern() : EcsMegaBits_Ptr);

        public static ref ulong EcsMegaBitsPerSecond => ref *(ulong*)(EcsMegaBitsPerSecond_Ptr == null ? EcsMegaBitsPerSecond_Ptr = EcsMegaBitsPerSecond_BindgenGetExtern() : EcsMegaBitsPerSecond_Ptr);

        public static ref ulong EcsMegaBytes => ref *(ulong*)(EcsMegaBytes_Ptr == null ? EcsMegaBytes_Ptr = EcsMegaBytes_BindgenGetExtern() : EcsMegaBytes_Ptr);

        public static ref ulong EcsMegaBytesPerSecond => ref *(ulong*)(EcsMegaBytesPerSecond_Ptr == null ? EcsMegaBytesPerSecond_Ptr = EcsMegaBytesPerSecond_BindgenGetExtern() : EcsMegaBytesPerSecond_Ptr);

        public static ref ulong EcsMegaHertz => ref *(ulong*)(EcsMegaHertz_Ptr == null ? EcsMegaHertz_Ptr = EcsMegaHertz_BindgenGetExtern() : EcsMegaHertz_Ptr);

        public static ref ulong EcsMeters => ref *(ulong*)(EcsMeters_Ptr == null ? EcsMeters_Ptr = EcsMeters_BindgenGetExtern() : EcsMeters_Ptr);

        public static ref ulong EcsMetersPerSecond => ref *(ulong*)(EcsMetersPerSecond_Ptr == null ? EcsMetersPerSecond_Ptr = EcsMetersPerSecond_BindgenGetExtern() : EcsMetersPerSecond_Ptr);

        public static ref ulong EcsMetric => ref *(ulong*)(EcsMetric_Ptr == null ? EcsMetric_Ptr = EcsMetric_BindgenGetExtern() : EcsMetric_Ptr);

        public static ref ulong EcsMetricInstance => ref *(ulong*)(EcsMetricInstance_Ptr == null ? EcsMetricInstance_Ptr = EcsMetricInstance_BindgenGetExtern() : EcsMetricInstance_Ptr);

        public static ref ulong EcsMicro => ref *(ulong*)(EcsMicro_Ptr == null ? EcsMicro_Ptr = EcsMicro_BindgenGetExtern() : EcsMicro_Ptr);

        public static ref ulong EcsMicroMeters => ref *(ulong*)(EcsMicroMeters_Ptr == null ? EcsMicroMeters_Ptr = EcsMicroMeters_BindgenGetExtern() : EcsMicroMeters_Ptr);

        public static ref ulong EcsMicroSeconds => ref *(ulong*)(EcsMicroSeconds_Ptr == null ? EcsMicroSeconds_Ptr = EcsMicroSeconds_BindgenGetExtern() : EcsMicroSeconds_Ptr);

        public static ref ulong EcsMiles => ref *(ulong*)(EcsMiles_Ptr == null ? EcsMiles_Ptr = EcsMiles_BindgenGetExtern() : EcsMiles_Ptr);

        public static ref ulong EcsMilesPerHour => ref *(ulong*)(EcsMilesPerHour_Ptr == null ? EcsMilesPerHour_Ptr = EcsMilesPerHour_BindgenGetExtern() : EcsMilesPerHour_Ptr);

        public static ref ulong EcsMilli => ref *(ulong*)(EcsMilli_Ptr == null ? EcsMilli_Ptr = EcsMilli_BindgenGetExtern() : EcsMilli_Ptr);

        public static ref ulong EcsMilliMeters => ref *(ulong*)(EcsMilliMeters_Ptr == null ? EcsMilliMeters_Ptr = EcsMilliMeters_BindgenGetExtern() : EcsMilliMeters_Ptr);

        public static ref ulong EcsMilliSeconds => ref *(ulong*)(EcsMilliSeconds_Ptr == null ? EcsMilliSeconds_Ptr = EcsMilliSeconds_BindgenGetExtern() : EcsMilliSeconds_Ptr);

        public static ref ulong EcsMinutes => ref *(ulong*)(EcsMinutes_Ptr == null ? EcsMinutes_Ptr = EcsMinutes_BindgenGetExtern() : EcsMinutes_Ptr);

        public static ref ulong EcsModule => ref *(ulong*)(EcsModule_Ptr == null ? EcsModule_Ptr = EcsModule_BindgenGetExtern() : EcsModule_Ptr);

        public static ref ulong EcsMole => ref *(ulong*)(EcsMole_Ptr == null ? EcsMole_Ptr = EcsMole_BindgenGetExtern() : EcsMole_Ptr);

        public static ref ulong EcsMonitor => ref *(ulong*)(EcsMonitor_Ptr == null ? EcsMonitor_Ptr = EcsMonitor_BindgenGetExtern() : EcsMonitor_Ptr);

        public static ref ulong EcsName => ref *(ulong*)(EcsName_Ptr == null ? EcsName_Ptr = EcsName_BindgenGetExtern() : EcsName_Ptr);

        public static ref ulong EcsNano => ref *(ulong*)(EcsNano_Ptr == null ? EcsNano_Ptr = EcsNano_BindgenGetExtern() : EcsNano_Ptr);

        public static ref ulong EcsNanoMeters => ref *(ulong*)(EcsNanoMeters_Ptr == null ? EcsNanoMeters_Ptr = EcsNanoMeters_BindgenGetExtern() : EcsNanoMeters_Ptr);

        public static ref ulong EcsNanoSeconds => ref *(ulong*)(EcsNanoSeconds_Ptr == null ? EcsNanoSeconds_Ptr = EcsNanoSeconds_BindgenGetExtern() : EcsNanoSeconds_Ptr);

        public static ref ulong EcsNewton => ref *(ulong*)(EcsNewton_Ptr == null ? EcsNewton_Ptr = EcsNewton_BindgenGetExtern() : EcsNewton_Ptr);

        public static ref ulong EcsNotQueryable => ref *(ulong*)(EcsNotQueryable_Ptr == null ? EcsNotQueryable_Ptr = EcsNotQueryable_BindgenGetExtern() : EcsNotQueryable_Ptr);

        public static ref ulong EcsObserver => ref *(ulong*)(EcsObserver_Ptr == null ? EcsObserver_Ptr = EcsObserver_BindgenGetExtern() : EcsObserver_Ptr);

        public static ref ulong EcsOnAdd => ref *(ulong*)(EcsOnAdd_Ptr == null ? EcsOnAdd_Ptr = EcsOnAdd_BindgenGetExtern() : EcsOnAdd_Ptr);

        public static ref ulong EcsOnDelete => ref *(ulong*)(EcsOnDelete_Ptr == null ? EcsOnDelete_Ptr = EcsOnDelete_BindgenGetExtern() : EcsOnDelete_Ptr);

        public static ref ulong EcsOnDeleteTarget => ref *(ulong*)(EcsOnDeleteTarget_Ptr == null ? EcsOnDeleteTarget_Ptr = EcsOnDeleteTarget_BindgenGetExtern() : EcsOnDeleteTarget_Ptr);

        public static ref ulong EcsOneOf => ref *(ulong*)(EcsOneOf_Ptr == null ? EcsOneOf_Ptr = EcsOneOf_BindgenGetExtern() : EcsOneOf_Ptr);

        public static ref ulong EcsOnInstantiate => ref *(ulong*)(EcsOnInstantiate_Ptr == null ? EcsOnInstantiate_Ptr = EcsOnInstantiate_BindgenGetExtern() : EcsOnInstantiate_Ptr);

        public static ref ulong EcsOnLoad => ref *(ulong*)(EcsOnLoad_Ptr == null ? EcsOnLoad_Ptr = EcsOnLoad_BindgenGetExtern() : EcsOnLoad_Ptr);

        public static ref ulong EcsOnRemove => ref *(ulong*)(EcsOnRemove_Ptr == null ? EcsOnRemove_Ptr = EcsOnRemove_BindgenGetExtern() : EcsOnRemove_Ptr);

        public static ref ulong EcsOnSet => ref *(ulong*)(EcsOnSet_Ptr == null ? EcsOnSet_Ptr = EcsOnSet_BindgenGetExtern() : EcsOnSet_Ptr);

        public static ref ulong EcsOnStart => ref *(ulong*)(EcsOnStart_Ptr == null ? EcsOnStart_Ptr = EcsOnStart_BindgenGetExtern() : EcsOnStart_Ptr);

        public static ref ulong EcsOnStore => ref *(ulong*)(EcsOnStore_Ptr == null ? EcsOnStore_Ptr = EcsOnStore_BindgenGetExtern() : EcsOnStore_Ptr);

        public static ref ulong EcsOnTableCreate => ref *(ulong*)(EcsOnTableCreate_Ptr == null ? EcsOnTableCreate_Ptr = EcsOnTableCreate_BindgenGetExtern() : EcsOnTableCreate_Ptr);

        public static ref ulong EcsOnTableDelete => ref *(ulong*)(EcsOnTableDelete_Ptr == null ? EcsOnTableDelete_Ptr = EcsOnTableDelete_BindgenGetExtern() : EcsOnTableDelete_Ptr);

        public static ref ulong EcsOnTableEmpty => ref *(ulong*)(EcsOnTableEmpty_Ptr == null ? EcsOnTableEmpty_Ptr = EcsOnTableEmpty_BindgenGetExtern() : EcsOnTableEmpty_Ptr);

        public static ref ulong EcsOnTableFill => ref *(ulong*)(EcsOnTableFill_Ptr == null ? EcsOnTableFill_Ptr = EcsOnTableFill_BindgenGetExtern() : EcsOnTableFill_Ptr);

        public static ref ulong EcsOnUpdate => ref *(ulong*)(EcsOnUpdate_Ptr == null ? EcsOnUpdate_Ptr = EcsOnUpdate_BindgenGetExtern() : EcsOnUpdate_Ptr);

        public static ref ulong EcsOnValidate => ref *(ulong*)(EcsOnValidate_Ptr == null ? EcsOnValidate_Ptr = EcsOnValidate_BindgenGetExtern() : EcsOnValidate_Ptr);

        public static ref ulong EcsOverride => ref *(ulong*)(EcsOverride_Ptr == null ? EcsOverride_Ptr = EcsOverride_BindgenGetExtern() : EcsOverride_Ptr);

        public static ref ulong EcsPairIsTag => ref *(ulong*)(EcsPairIsTag_Ptr == null ? EcsPairIsTag_Ptr = EcsPairIsTag_BindgenGetExtern() : EcsPairIsTag_Ptr);

        public static ref ulong EcsPanic => ref *(ulong*)(EcsPanic_Ptr == null ? EcsPanic_Ptr = EcsPanic_BindgenGetExtern() : EcsPanic_Ptr);

        public static ref ulong EcsPascal => ref *(ulong*)(EcsPascal_Ptr == null ? EcsPascal_Ptr = EcsPascal_BindgenGetExtern() : EcsPascal_Ptr);

        public static ref ulong EcsPebi => ref *(ulong*)(EcsPebi_Ptr == null ? EcsPebi_Ptr = EcsPebi_BindgenGetExtern() : EcsPebi_Ptr);

        public static ref ulong EcsPercentage => ref *(ulong*)(EcsPercentage_Ptr == null ? EcsPercentage_Ptr = EcsPercentage_BindgenGetExtern() : EcsPercentage_Ptr);

        public static ref ulong EcsPeriod1d => ref *(ulong*)(EcsPeriod1d_Ptr == null ? EcsPeriod1d_Ptr = EcsPeriod1d_BindgenGetExtern() : EcsPeriod1d_Ptr);

        public static ref ulong EcsPeriod1h => ref *(ulong*)(EcsPeriod1h_Ptr == null ? EcsPeriod1h_Ptr = EcsPeriod1h_BindgenGetExtern() : EcsPeriod1h_Ptr);

        public static ref ulong EcsPeriod1m => ref *(ulong*)(EcsPeriod1m_Ptr == null ? EcsPeriod1m_Ptr = EcsPeriod1m_BindgenGetExtern() : EcsPeriod1m_Ptr);

        public static ref ulong EcsPeriod1s => ref *(ulong*)(EcsPeriod1s_Ptr == null ? EcsPeriod1s_Ptr = EcsPeriod1s_BindgenGetExtern() : EcsPeriod1s_Ptr);

        public static ref ulong EcsPeriod1w => ref *(ulong*)(EcsPeriod1w_Ptr == null ? EcsPeriod1w_Ptr = EcsPeriod1w_BindgenGetExtern() : EcsPeriod1w_Ptr);

        public static ref ulong EcsPeta => ref *(ulong*)(EcsPeta_Ptr == null ? EcsPeta_Ptr = EcsPeta_BindgenGetExtern() : EcsPeta_Ptr);

        public static ref ulong EcsPhase => ref *(ulong*)(EcsPhase_Ptr == null ? EcsPhase_Ptr = EcsPhase_BindgenGetExtern() : EcsPhase_Ptr);

        public static ref ulong EcsPico => ref *(ulong*)(EcsPico_Ptr == null ? EcsPico_Ptr = EcsPico_BindgenGetExtern() : EcsPico_Ptr);

        public static ref ulong EcsPicoMeters => ref *(ulong*)(EcsPicoMeters_Ptr == null ? EcsPicoMeters_Ptr = EcsPicoMeters_BindgenGetExtern() : EcsPicoMeters_Ptr);

        public static ref ulong EcsPicoSeconds => ref *(ulong*)(EcsPicoSeconds_Ptr == null ? EcsPicoSeconds_Ptr = EcsPicoSeconds_BindgenGetExtern() : EcsPicoSeconds_Ptr);

        public static ref ulong EcsPixels => ref *(ulong*)(EcsPixels_Ptr == null ? EcsPixels_Ptr = EcsPixels_BindgenGetExtern() : EcsPixels_Ptr);

        public static ref ulong EcsPostFrame => ref *(ulong*)(EcsPostFrame_Ptr == null ? EcsPostFrame_Ptr = EcsPostFrame_BindgenGetExtern() : EcsPostFrame_Ptr);

        public static ref ulong EcsPostLoad => ref *(ulong*)(EcsPostLoad_Ptr == null ? EcsPostLoad_Ptr = EcsPostLoad_BindgenGetExtern() : EcsPostLoad_Ptr);

        public static ref ulong EcsPostUpdate => ref *(ulong*)(EcsPostUpdate_Ptr == null ? EcsPostUpdate_Ptr = EcsPostUpdate_BindgenGetExtern() : EcsPostUpdate_Ptr);

        public static ref ulong EcsPredEq => ref *(ulong*)(EcsPredEq_Ptr == null ? EcsPredEq_Ptr = EcsPredEq_BindgenGetExtern() : EcsPredEq_Ptr);

        public static ref ulong EcsPredLookup => ref *(ulong*)(EcsPredLookup_Ptr == null ? EcsPredLookup_Ptr = EcsPredLookup_BindgenGetExtern() : EcsPredLookup_Ptr);

        public static ref ulong EcsPredMatch => ref *(ulong*)(EcsPredMatch_Ptr == null ? EcsPredMatch_Ptr = EcsPredMatch_BindgenGetExtern() : EcsPredMatch_Ptr);

        public static ref ulong EcsPrefab => ref *(ulong*)(EcsPrefab_Ptr == null ? EcsPrefab_Ptr = EcsPrefab_BindgenGetExtern() : EcsPrefab_Ptr);

        public static ref ulong EcsPreFrame => ref *(ulong*)(EcsPreFrame_Ptr == null ? EcsPreFrame_Ptr = EcsPreFrame_BindgenGetExtern() : EcsPreFrame_Ptr);

        public static ref ulong EcsPressure => ref *(ulong*)(EcsPressure_Ptr == null ? EcsPressure_Ptr = EcsPressure_BindgenGetExtern() : EcsPressure_Ptr);

        public static ref ulong EcsPreStore => ref *(ulong*)(EcsPreStore_Ptr == null ? EcsPreStore_Ptr = EcsPreStore_BindgenGetExtern() : EcsPreStore_Ptr);

        public static ref ulong EcsPreUpdate => ref *(ulong*)(EcsPreUpdate_Ptr == null ? EcsPreUpdate_Ptr = EcsPreUpdate_BindgenGetExtern() : EcsPreUpdate_Ptr);

        public static ref ulong EcsPrivate => ref *(ulong*)(EcsPrivate_Ptr == null ? EcsPrivate_Ptr = EcsPrivate_BindgenGetExtern() : EcsPrivate_Ptr);

        public static ref ulong EcsQuantity => ref *(ulong*)(EcsQuantity_Ptr == null ? EcsQuantity_Ptr = EcsQuantity_BindgenGetExtern() : EcsQuantity_Ptr);

        public static ref ulong EcsQuery => ref *(ulong*)(EcsQuery_Ptr == null ? EcsQuery_Ptr = EcsQuery_BindgenGetExtern() : EcsQuery_Ptr);

        public static ref ulong EcsRadians => ref *(ulong*)(EcsRadians_Ptr == null ? EcsRadians_Ptr = EcsRadians_BindgenGetExtern() : EcsRadians_Ptr);

        public static ref ulong EcsReflexive => ref *(ulong*)(EcsReflexive_Ptr == null ? EcsReflexive_Ptr = EcsReflexive_BindgenGetExtern() : EcsReflexive_Ptr);

        public static ref ulong EcsRelationship => ref *(ulong*)(EcsRelationship_Ptr == null ? EcsRelationship_Ptr = EcsRelationship_BindgenGetExtern() : EcsRelationship_Ptr);

        public static ref ulong EcsRemove => ref *(ulong*)(EcsRemove_Ptr == null ? EcsRemove_Ptr = EcsRemove_BindgenGetExtern() : EcsRemove_Ptr);

        public static ref ulong EcsScopeClose => ref *(ulong*)(EcsScopeClose_Ptr == null ? EcsScopeClose_Ptr = EcsScopeClose_BindgenGetExtern() : EcsScopeClose_Ptr);

        public static ref ulong EcsScopeOpen => ref *(ulong*)(EcsScopeOpen_Ptr == null ? EcsScopeOpen_Ptr = EcsScopeOpen_BindgenGetExtern() : EcsScopeOpen_Ptr);

        public static ref ulong EcsSeconds => ref *(ulong*)(EcsSeconds_Ptr == null ? EcsSeconds_Ptr = EcsSeconds_BindgenGetExtern() : EcsSeconds_Ptr);

        public static ref ulong EcsSlotOf => ref *(ulong*)(EcsSlotOf_Ptr == null ? EcsSlotOf_Ptr = EcsSlotOf_BindgenGetExtern() : EcsSlotOf_Ptr);

        public static ref ulong EcsSparse => ref *(ulong*)(EcsSparse_Ptr == null ? EcsSparse_Ptr = EcsSparse_BindgenGetExtern() : EcsSparse_Ptr);

        public static ref ulong EcsSpeed => ref *(ulong*)(EcsSpeed_Ptr == null ? EcsSpeed_Ptr = EcsSpeed_BindgenGetExtern() : EcsSpeed_Ptr);

        public static ref ulong EcsSymbol => ref *(ulong*)(EcsSymbol_Ptr == null ? EcsSymbol_Ptr = EcsSymbol_BindgenGetExtern() : EcsSymbol_Ptr);

        public static ref ulong EcsSymmetric => ref *(ulong*)(EcsSymmetric_Ptr == null ? EcsSymmetric_Ptr = EcsSymmetric_BindgenGetExtern() : EcsSymmetric_Ptr);

        public static ref ulong EcsSystem => ref *(ulong*)(EcsSystem_Ptr == null ? EcsSystem_Ptr = EcsSystem_BindgenGetExtern() : EcsSystem_Ptr);

        public static ref ulong EcsTarget => ref *(ulong*)(EcsTarget_Ptr == null ? EcsTarget_Ptr = EcsTarget_BindgenGetExtern() : EcsTarget_Ptr);

        public static ref ulong EcsTebi => ref *(ulong*)(EcsTebi_Ptr == null ? EcsTebi_Ptr = EcsTebi_BindgenGetExtern() : EcsTebi_Ptr);

        public static ref ulong EcsTemperature => ref *(ulong*)(EcsTemperature_Ptr == null ? EcsTemperature_Ptr = EcsTemperature_BindgenGetExtern() : EcsTemperature_Ptr);

        public static ref ulong EcsTera => ref *(ulong*)(EcsTera_Ptr == null ? EcsTera_Ptr = EcsTera_BindgenGetExtern() : EcsTera_Ptr);

        public static ref ulong EcsThis => ref *(ulong*)(EcsThis_Ptr == null ? EcsThis_Ptr = EcsThis_BindgenGetExtern() : EcsThis_Ptr);

        public static ref ulong EcsTime => ref *(ulong*)(EcsTime_Ptr == null ? EcsTime_Ptr = EcsTime_BindgenGetExtern() : EcsTime_Ptr);

        public static ref ulong EcsTrait => ref *(ulong*)(EcsTrait_Ptr == null ? EcsTrait_Ptr = EcsTrait_BindgenGetExtern() : EcsTrait_Ptr);

        public static ref ulong EcsTransitive => ref *(ulong*)(EcsTransitive_Ptr == null ? EcsTransitive_Ptr = EcsTransitive_BindgenGetExtern() : EcsTransitive_Ptr);

        public static ref ulong EcsTraversable => ref *(ulong*)(EcsTraversable_Ptr == null ? EcsTraversable_Ptr = EcsTraversable_BindgenGetExtern() : EcsTraversable_Ptr);

        public static ref ulong EcsUnion => ref *(ulong*)(EcsUnion_Ptr == null ? EcsUnion_Ptr = EcsUnion_BindgenGetExtern() : EcsUnion_Ptr);

        public static ref ulong EcsUnitPrefixes => ref *(ulong*)(EcsUnitPrefixes_Ptr == null ? EcsUnitPrefixes_Ptr = EcsUnitPrefixes_BindgenGetExtern() : EcsUnitPrefixes_Ptr);

        public static ref ulong EcsUri => ref *(ulong*)(EcsUri_Ptr == null ? EcsUri_Ptr = EcsUri_BindgenGetExtern() : EcsUri_Ptr);

        public static ref ulong EcsUriFile => ref *(ulong*)(EcsUriFile_Ptr == null ? EcsUriFile_Ptr = EcsUriFile_BindgenGetExtern() : EcsUriFile_Ptr);

        public static ref ulong EcsUriHyperlink => ref *(ulong*)(EcsUriHyperlink_Ptr == null ? EcsUriHyperlink_Ptr = EcsUriHyperlink_BindgenGetExtern() : EcsUriHyperlink_Ptr);

        public static ref ulong EcsUriImage => ref *(ulong*)(EcsUriImage_Ptr == null ? EcsUriImage_Ptr = EcsUriImage_BindgenGetExtern() : EcsUriImage_Ptr);

        public static ref ulong EcsVariable => ref *(ulong*)(EcsVariable_Ptr == null ? EcsVariable_Ptr = EcsVariable_BindgenGetExtern() : EcsVariable_Ptr);

        public static ref ulong EcsWildcard => ref *(ulong*)(EcsWildcard_Ptr == null ? EcsWildcard_Ptr = EcsWildcard_BindgenGetExtern() : EcsWildcard_Ptr);

        public static ref ulong EcsWith => ref *(ulong*)(EcsWith_Ptr == null ? EcsWith_Ptr = EcsWith_BindgenGetExtern() : EcsWith_Ptr);

        public static ref ulong EcsWorld => ref *(ulong*)(EcsWorld_Ptr == null ? EcsWorld_Ptr = EcsWorld_BindgenGetExtern() : EcsWorld_Ptr);

        public static ref ulong EcsYobi => ref *(ulong*)(EcsYobi_Ptr == null ? EcsYobi_Ptr = EcsYobi_BindgenGetExtern() : EcsYobi_Ptr);

        public static ref ulong EcsYocto => ref *(ulong*)(EcsYocto_Ptr == null ? EcsYocto_Ptr = EcsYocto_BindgenGetExtern() : EcsYocto_Ptr);

        public static ref ulong EcsYotta => ref *(ulong*)(EcsYotta_Ptr == null ? EcsYotta_Ptr = EcsYotta_BindgenGetExtern() : EcsYotta_Ptr);

        public static ref ulong EcsZebi => ref *(ulong*)(EcsZebi_Ptr == null ? EcsZebi_Ptr = EcsZebi_BindgenGetExtern() : EcsZebi_Ptr);

        public static ref ulong EcsZepto => ref *(ulong*)(EcsZepto_Ptr == null ? EcsZepto_Ptr = EcsZepto_BindgenGetExtern() : EcsZepto_Ptr);

        public static ref ulong EcsZetta => ref *(ulong*)(EcsZetta_Ptr == null ? EcsZetta_Ptr = EcsZetta_BindgenGetExtern() : EcsZetta_Ptr);

        public static ref ulong FLECS_IDecs_bool_tID_ => ref *(ulong*)(FLECS_IDecs_bool_tID__Ptr == null ? FLECS_IDecs_bool_tID__Ptr = FLECS_IDecs_bool_tID__BindgenGetExtern() : FLECS_IDecs_bool_tID__Ptr);

        public static ref ulong FLECS_IDecs_byte_tID_ => ref *(ulong*)(FLECS_IDecs_byte_tID__Ptr == null ? FLECS_IDecs_byte_tID__Ptr = FLECS_IDecs_byte_tID__BindgenGetExtern() : FLECS_IDecs_byte_tID__Ptr);

        public static ref ulong FLECS_IDecs_char_tID_ => ref *(ulong*)(FLECS_IDecs_char_tID__Ptr == null ? FLECS_IDecs_char_tID__Ptr = FLECS_IDecs_char_tID__BindgenGetExtern() : FLECS_IDecs_char_tID__Ptr);

        public static ref ulong FLECS_IDecs_entity_tID_ => ref *(ulong*)(FLECS_IDecs_entity_tID__Ptr == null ? FLECS_IDecs_entity_tID__Ptr = FLECS_IDecs_entity_tID__BindgenGetExtern() : FLECS_IDecs_entity_tID__Ptr);

        public static ref ulong FLECS_IDecs_f32_tID_ => ref *(ulong*)(FLECS_IDecs_f32_tID__Ptr == null ? FLECS_IDecs_f32_tID__Ptr = FLECS_IDecs_f32_tID__BindgenGetExtern() : FLECS_IDecs_f32_tID__Ptr);

        public static ref ulong FLECS_IDecs_f64_tID_ => ref *(ulong*)(FLECS_IDecs_f64_tID__Ptr == null ? FLECS_IDecs_f64_tID__Ptr = FLECS_IDecs_f64_tID__BindgenGetExtern() : FLECS_IDecs_f64_tID__Ptr);

        public static ref ulong FLECS_IDecs_i16_tID_ => ref *(ulong*)(FLECS_IDecs_i16_tID__Ptr == null ? FLECS_IDecs_i16_tID__Ptr = FLECS_IDecs_i16_tID__BindgenGetExtern() : FLECS_IDecs_i16_tID__Ptr);

        public static ref ulong FLECS_IDecs_i32_tID_ => ref *(ulong*)(FLECS_IDecs_i32_tID__Ptr == null ? FLECS_IDecs_i32_tID__Ptr = FLECS_IDecs_i32_tID__BindgenGetExtern() : FLECS_IDecs_i32_tID__Ptr);

        public static ref ulong FLECS_IDecs_i64_tID_ => ref *(ulong*)(FLECS_IDecs_i64_tID__Ptr == null ? FLECS_IDecs_i64_tID__Ptr = FLECS_IDecs_i64_tID__BindgenGetExtern() : FLECS_IDecs_i64_tID__Ptr);

        public static ref ulong FLECS_IDecs_i8_tID_ => ref *(ulong*)(FLECS_IDecs_i8_tID__Ptr == null ? FLECS_IDecs_i8_tID__Ptr = FLECS_IDecs_i8_tID__BindgenGetExtern() : FLECS_IDecs_i8_tID__Ptr);

        public static ref ulong FLECS_IDecs_id_tID_ => ref *(ulong*)(FLECS_IDecs_id_tID__Ptr == null ? FLECS_IDecs_id_tID__Ptr = FLECS_IDecs_id_tID__BindgenGetExtern() : FLECS_IDecs_id_tID__Ptr);

        public static ref ulong FLECS_IDecs_iptr_tID_ => ref *(ulong*)(FLECS_IDecs_iptr_tID__Ptr == null ? FLECS_IDecs_iptr_tID__Ptr = FLECS_IDecs_iptr_tID__BindgenGetExtern() : FLECS_IDecs_iptr_tID__Ptr);

        public static ref ulong FLECS_IDecs_string_tID_ => ref *(ulong*)(FLECS_IDecs_string_tID__Ptr == null ? FLECS_IDecs_string_tID__Ptr = FLECS_IDecs_string_tID__BindgenGetExtern() : FLECS_IDecs_string_tID__Ptr);

        public static ref ulong FLECS_IDecs_u16_tID_ => ref *(ulong*)(FLECS_IDecs_u16_tID__Ptr == null ? FLECS_IDecs_u16_tID__Ptr = FLECS_IDecs_u16_tID__BindgenGetExtern() : FLECS_IDecs_u16_tID__Ptr);

        public static ref ulong FLECS_IDecs_u32_tID_ => ref *(ulong*)(FLECS_IDecs_u32_tID__Ptr == null ? FLECS_IDecs_u32_tID__Ptr = FLECS_IDecs_u32_tID__BindgenGetExtern() : FLECS_IDecs_u32_tID__Ptr);

        public static ref ulong FLECS_IDecs_u64_tID_ => ref *(ulong*)(FLECS_IDecs_u64_tID__Ptr == null ? FLECS_IDecs_u64_tID__Ptr = FLECS_IDecs_u64_tID__BindgenGetExtern() : FLECS_IDecs_u64_tID__Ptr);

        public static ref ulong FLECS_IDecs_u8_tID_ => ref *(ulong*)(FLECS_IDecs_u8_tID__Ptr == null ? FLECS_IDecs_u8_tID__Ptr = FLECS_IDecs_u8_tID__BindgenGetExtern() : FLECS_IDecs_u8_tID__Ptr);

        public static ref ulong FLECS_IDecs_uptr_tID_ => ref *(ulong*)(FLECS_IDecs_uptr_tID__Ptr == null ? FLECS_IDecs_uptr_tID__Ptr = FLECS_IDecs_uptr_tID__BindgenGetExtern() : FLECS_IDecs_uptr_tID__Ptr);

        public static ref ulong FLECS_IDEcsAlertCriticalID_ => ref *(ulong*)(FLECS_IDEcsAlertCriticalID__Ptr == null ? FLECS_IDEcsAlertCriticalID__Ptr = FLECS_IDEcsAlertCriticalID__BindgenGetExtern() : FLECS_IDEcsAlertCriticalID__Ptr);

        public static ref ulong FLECS_IDEcsAlertErrorID_ => ref *(ulong*)(FLECS_IDEcsAlertErrorID__Ptr == null ? FLECS_IDEcsAlertErrorID__Ptr = FLECS_IDEcsAlertErrorID__BindgenGetExtern() : FLECS_IDEcsAlertErrorID__Ptr);

        public static ref ulong FLECS_IDEcsAlertID_ => ref *(ulong*)(FLECS_IDEcsAlertID__Ptr == null ? FLECS_IDEcsAlertID__Ptr = FLECS_IDEcsAlertID__BindgenGetExtern() : FLECS_IDEcsAlertID__Ptr);

        public static ref ulong FLECS_IDEcsAlertInfoID_ => ref *(ulong*)(FLECS_IDEcsAlertInfoID__Ptr == null ? FLECS_IDEcsAlertInfoID__Ptr = FLECS_IDEcsAlertInfoID__BindgenGetExtern() : FLECS_IDEcsAlertInfoID__Ptr);

        public static ref ulong FLECS_IDEcsAlertInstanceID_ => ref *(ulong*)(FLECS_IDEcsAlertInstanceID__Ptr == null ? FLECS_IDEcsAlertInstanceID__Ptr = FLECS_IDEcsAlertInstanceID__BindgenGetExtern() : FLECS_IDEcsAlertInstanceID__Ptr);

        public static ref ulong FLECS_IDEcsAlertsActiveID_ => ref *(ulong*)(FLECS_IDEcsAlertsActiveID__Ptr == null ? FLECS_IDEcsAlertsActiveID__Ptr = FLECS_IDEcsAlertsActiveID__BindgenGetExtern() : FLECS_IDEcsAlertsActiveID__Ptr);

        public static ref ulong FLECS_IDEcsAlertTimeoutID_ => ref *(ulong*)(FLECS_IDEcsAlertTimeoutID__Ptr == null ? FLECS_IDEcsAlertTimeoutID__Ptr = FLECS_IDEcsAlertTimeoutID__BindgenGetExtern() : FLECS_IDEcsAlertTimeoutID__Ptr);

        public static ref ulong FLECS_IDEcsAlertWarningID_ => ref *(ulong*)(FLECS_IDEcsAlertWarningID__Ptr == null ? FLECS_IDEcsAlertWarningID__Ptr = FLECS_IDEcsAlertWarningID__BindgenGetExtern() : FLECS_IDEcsAlertWarningID__Ptr);

        public static ref ulong FLECS_IDEcsArrayID_ => ref *(ulong*)(FLECS_IDEcsArrayID__Ptr == null ? FLECS_IDEcsArrayID__Ptr = FLECS_IDEcsArrayID__BindgenGetExtern() : FLECS_IDEcsArrayID__Ptr);

        public static ref ulong FLECS_IDEcsBitmaskID_ => ref *(ulong*)(FLECS_IDEcsBitmaskID__Ptr == null ? FLECS_IDEcsBitmaskID__Ptr = FLECS_IDEcsBitmaskID__BindgenGetExtern() : FLECS_IDEcsBitmaskID__Ptr);

        public static ref ulong FLECS_IDEcsComponentID_ => ref *(ulong*)(FLECS_IDEcsComponentID__Ptr == null ? FLECS_IDEcsComponentID__Ptr = FLECS_IDEcsComponentID__BindgenGetExtern() : FLECS_IDEcsComponentID__Ptr);

        public static ref ulong FLECS_IDEcsCounterID_ => ref *(ulong*)(FLECS_IDEcsCounterID__Ptr == null ? FLECS_IDEcsCounterID__Ptr = FLECS_IDEcsCounterID__BindgenGetExtern() : FLECS_IDEcsCounterID__Ptr);

        public static ref ulong FLECS_IDEcsCounterIdID_ => ref *(ulong*)(FLECS_IDEcsCounterIdID__Ptr == null ? FLECS_IDEcsCounterIdID__Ptr = FLECS_IDEcsCounterIdID__BindgenGetExtern() : FLECS_IDEcsCounterIdID__Ptr);

        public static ref ulong FLECS_IDEcsCounterIncrementID_ => ref *(ulong*)(FLECS_IDEcsCounterIncrementID__Ptr == null ? FLECS_IDEcsCounterIncrementID__Ptr = FLECS_IDEcsCounterIncrementID__BindgenGetExtern() : FLECS_IDEcsCounterIncrementID__Ptr);

        public static ref ulong FLECS_IDEcsDefaultChildComponentID_ => ref *(ulong*)(FLECS_IDEcsDefaultChildComponentID__Ptr == null ? FLECS_IDEcsDefaultChildComponentID__Ptr = FLECS_IDEcsDefaultChildComponentID__BindgenGetExtern() : FLECS_IDEcsDefaultChildComponentID__Ptr);

        public static ref ulong FLECS_IDEcsDocDescriptionID_ => ref *(ulong*)(FLECS_IDEcsDocDescriptionID__Ptr == null ? FLECS_IDEcsDocDescriptionID__Ptr = FLECS_IDEcsDocDescriptionID__BindgenGetExtern() : FLECS_IDEcsDocDescriptionID__Ptr);

        public static ref ulong FLECS_IDEcsEnumID_ => ref *(ulong*)(FLECS_IDEcsEnumID__Ptr == null ? FLECS_IDEcsEnumID__Ptr = FLECS_IDEcsEnumID__BindgenGetExtern() : FLECS_IDEcsEnumID__Ptr);

        public static ref ulong FLECS_IDEcsGaugeID_ => ref *(ulong*)(FLECS_IDEcsGaugeID__Ptr == null ? FLECS_IDEcsGaugeID__Ptr = FLECS_IDEcsGaugeID__BindgenGetExtern() : FLECS_IDEcsGaugeID__Ptr);

        public static ref ulong FLECS_IDEcsIdentifierID_ => ref *(ulong*)(FLECS_IDEcsIdentifierID__Ptr == null ? FLECS_IDEcsIdentifierID__Ptr = FLECS_IDEcsIdentifierID__BindgenGetExtern() : FLECS_IDEcsIdentifierID__Ptr);

        public static ref ulong FLECS_IDEcsMemberID_ => ref *(ulong*)(FLECS_IDEcsMemberID__Ptr == null ? FLECS_IDEcsMemberID__Ptr = FLECS_IDEcsMemberID__BindgenGetExtern() : FLECS_IDEcsMemberID__Ptr);

        public static ref ulong FLECS_IDEcsMemberRangesID_ => ref *(ulong*)(FLECS_IDEcsMemberRangesID__Ptr == null ? FLECS_IDEcsMemberRangesID__Ptr = FLECS_IDEcsMemberRangesID__BindgenGetExtern() : FLECS_IDEcsMemberRangesID__Ptr);

        public static ref ulong FLECS_IDEcsMetricID_ => ref *(ulong*)(FLECS_IDEcsMetricID__Ptr == null ? FLECS_IDEcsMetricID__Ptr = FLECS_IDEcsMetricID__BindgenGetExtern() : FLECS_IDEcsMetricID__Ptr);

        public static ref ulong FLECS_IDEcsMetricInstanceID_ => ref *(ulong*)(FLECS_IDEcsMetricInstanceID__Ptr == null ? FLECS_IDEcsMetricInstanceID__Ptr = FLECS_IDEcsMetricInstanceID__BindgenGetExtern() : FLECS_IDEcsMetricInstanceID__Ptr);

        public static ref ulong FLECS_IDEcsMetricSourceID_ => ref *(ulong*)(FLECS_IDEcsMetricSourceID__Ptr == null ? FLECS_IDEcsMetricSourceID__Ptr = FLECS_IDEcsMetricSourceID__BindgenGetExtern() : FLECS_IDEcsMetricSourceID__Ptr);

        public static ref ulong FLECS_IDEcsMetricValueID_ => ref *(ulong*)(FLECS_IDEcsMetricValueID__Ptr == null ? FLECS_IDEcsMetricValueID__Ptr = FLECS_IDEcsMetricValueID__BindgenGetExtern() : FLECS_IDEcsMetricValueID__Ptr);

        public static ref ulong FLECS_IDEcsOpaqueID_ => ref *(ulong*)(FLECS_IDEcsOpaqueID__Ptr == null ? FLECS_IDEcsOpaqueID__Ptr = FLECS_IDEcsOpaqueID__BindgenGetExtern() : FLECS_IDEcsOpaqueID__Ptr);

        public static ref ulong FLECS_IDEcsPipelineID_ => ref *(ulong*)(FLECS_IDEcsPipelineID__Ptr == null ? FLECS_IDEcsPipelineID__Ptr = FLECS_IDEcsPipelineID__BindgenGetExtern() : FLECS_IDEcsPipelineID__Ptr);

        public static ref ulong FLECS_IDEcsPipelineStatsID_ => ref *(ulong*)(FLECS_IDEcsPipelineStatsID__Ptr == null ? FLECS_IDEcsPipelineStatsID__Ptr = FLECS_IDEcsPipelineStatsID__BindgenGetExtern() : FLECS_IDEcsPipelineStatsID__Ptr);

        public static ref ulong FLECS_IDEcsPolyID_ => ref *(ulong*)(FLECS_IDEcsPolyID__Ptr == null ? FLECS_IDEcsPolyID__Ptr = FLECS_IDEcsPolyID__BindgenGetExtern() : FLECS_IDEcsPolyID__Ptr);

        public static ref ulong FLECS_IDEcsPrimitiveID_ => ref *(ulong*)(FLECS_IDEcsPrimitiveID__Ptr == null ? FLECS_IDEcsPrimitiveID__Ptr = FLECS_IDEcsPrimitiveID__BindgenGetExtern() : FLECS_IDEcsPrimitiveID__Ptr);

        public static ref ulong FLECS_IDEcsRateFilterID_ => ref *(ulong*)(FLECS_IDEcsRateFilterID__Ptr == null ? FLECS_IDEcsRateFilterID__Ptr = FLECS_IDEcsRateFilterID__BindgenGetExtern() : FLECS_IDEcsRateFilterID__Ptr);

        public static ref ulong FLECS_IDEcsRestID_ => ref *(ulong*)(FLECS_IDEcsRestID__Ptr == null ? FLECS_IDEcsRestID__Ptr = FLECS_IDEcsRestID__BindgenGetExtern() : FLECS_IDEcsRestID__Ptr);

        public static ref ulong FLECS_IDEcsScriptID_ => ref *(ulong*)(FLECS_IDEcsScriptID__Ptr == null ? FLECS_IDEcsScriptID__Ptr = FLECS_IDEcsScriptID__BindgenGetExtern() : FLECS_IDEcsScriptID__Ptr);

        public static ref ulong FLECS_IDEcsStructID_ => ref *(ulong*)(FLECS_IDEcsStructID__Ptr == null ? FLECS_IDEcsStructID__Ptr = FLECS_IDEcsStructID__BindgenGetExtern() : FLECS_IDEcsStructID__Ptr);

        public static ref ulong FLECS_IDEcsSystemStatsID_ => ref *(ulong*)(FLECS_IDEcsSystemStatsID__Ptr == null ? FLECS_IDEcsSystemStatsID__Ptr = FLECS_IDEcsSystemStatsID__BindgenGetExtern() : FLECS_IDEcsSystemStatsID__Ptr);

        public static ref ulong FLECS_IDEcsTickSourceID_ => ref *(ulong*)(FLECS_IDEcsTickSourceID__Ptr == null ? FLECS_IDEcsTickSourceID__Ptr = FLECS_IDEcsTickSourceID__BindgenGetExtern() : FLECS_IDEcsTickSourceID__Ptr);

        public static ref ulong FLECS_IDEcsTimerID_ => ref *(ulong*)(FLECS_IDEcsTimerID__Ptr == null ? FLECS_IDEcsTimerID__Ptr = FLECS_IDEcsTimerID__BindgenGetExtern() : FLECS_IDEcsTimerID__Ptr);

        public static ref ulong FLECS_IDEcsTypeID_ => ref *(ulong*)(FLECS_IDEcsTypeID__Ptr == null ? FLECS_IDEcsTypeID__Ptr = FLECS_IDEcsTypeID__BindgenGetExtern() : FLECS_IDEcsTypeID__Ptr);

        public static ref ulong FLECS_IDEcsTypeSerializerID_ => ref *(ulong*)(FLECS_IDEcsTypeSerializerID__Ptr == null ? FLECS_IDEcsTypeSerializerID__Ptr = FLECS_IDEcsTypeSerializerID__BindgenGetExtern() : FLECS_IDEcsTypeSerializerID__Ptr);

        public static ref ulong FLECS_IDEcsUnitID_ => ref *(ulong*)(FLECS_IDEcsUnitID__Ptr == null ? FLECS_IDEcsUnitID__Ptr = FLECS_IDEcsUnitID__BindgenGetExtern() : FLECS_IDEcsUnitID__Ptr);

        public static ref ulong FLECS_IDEcsUnitPrefixID_ => ref *(ulong*)(FLECS_IDEcsUnitPrefixID__Ptr == null ? FLECS_IDEcsUnitPrefixID__Ptr = FLECS_IDEcsUnitPrefixID__BindgenGetExtern() : FLECS_IDEcsUnitPrefixID__Ptr);

        public static ref ulong FLECS_IDEcsVectorID_ => ref *(ulong*)(FLECS_IDEcsVectorID__Ptr == null ? FLECS_IDEcsVectorID__Ptr = FLECS_IDEcsVectorID__BindgenGetExtern() : FLECS_IDEcsVectorID__Ptr);

        public static ref ulong FLECS_IDEcsWorldStatsID_ => ref *(ulong*)(FLECS_IDEcsWorldStatsID__Ptr == null ? FLECS_IDEcsWorldStatsID__Ptr = FLECS_IDEcsWorldStatsID__BindgenGetExtern() : FLECS_IDEcsWorldStatsID__Ptr);

        public static ref ulong FLECS_IDEcsWorldSummaryID_ => ref *(ulong*)(FLECS_IDEcsWorldSummaryID__Ptr == null ? FLECS_IDEcsWorldSummaryID__Ptr = FLECS_IDEcsWorldSummaryID__BindgenGetExtern() : FLECS_IDEcsWorldSummaryID__Ptr);

        public static ref ulong FLECS_IDFlecsAlertsID_ => ref *(ulong*)(FLECS_IDFlecsAlertsID__Ptr == null ? FLECS_IDFlecsAlertsID__Ptr = FLECS_IDFlecsAlertsID__BindgenGetExtern() : FLECS_IDFlecsAlertsID__Ptr);

        public static ref ulong FLECS_IDFlecsMetricsID_ => ref *(ulong*)(FLECS_IDFlecsMetricsID__Ptr == null ? FLECS_IDFlecsMetricsID__Ptr = FLECS_IDFlecsMetricsID__BindgenGetExtern() : FLECS_IDFlecsMetricsID__Ptr);

        public static ref ulong FLECS_IDFlecsStatsID_ => ref *(ulong*)(FLECS_IDFlecsStatsID__Ptr == null ? FLECS_IDFlecsStatsID__Ptr = FLECS_IDFlecsStatsID__BindgenGetExtern() : FLECS_IDFlecsStatsID__Ptr);

        public partial class BindgenInternal
        {
            public const string DllImportPath = @"flecs";
        }
    }
}
#pragma warning restore CS8981
#nullable disable
