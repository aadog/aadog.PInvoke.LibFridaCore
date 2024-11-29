using System.Runtime.InteropServices;
using aadog.PInvoke.LibFridaCore.Enums;

namespace aadog.PInvoke.LibFridaCore
{
    public unsafe partial class LibFridaCoreFunctions
    {
#if Windows
        private const string Frida_LibPrefix = "";
#else
        private const string Frida_LibPrefix = "_frida_";
#endif
        public unsafe delegate void GFunc(IntPtr data, IntPtr user_data);
        const string DllName = "FridaCore";


        /*g_bytes*/
        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_bytes_new")]
        public static unsafe partial GBytes* g_bytes_new(IntPtr data, gsize size);
        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_bytes_unref")]
        public static unsafe partial void g_bytes_unref(GBytes* bytes);

        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_bytes_get_size")]
        public static unsafe partial gsize g_bytes_get_size(GBytes* bytes);

        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_bytes_get_data")]
        public static unsafe partial IntPtr g_bytes_get_data(GBytes* bytes, gsize* size);


        [LibraryImport(DllName)]
        public static unsafe partial void frida_version(guint* major, guint* minor, guint* micro, guint* nano);
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr frida_version_string();

        [LibraryImport(DllName)]
        public static unsafe partial void frida_init();
        [LibraryImport(DllName)]
        public static unsafe partial void frida_shutdown();
        [LibraryImport(DllName)]
        public static unsafe partial void frida_deinit();
        [LibraryImport(DllName)]
        public static unsafe partial void frida_unref(IntPtr obj);

        /* DeviceManager */
        [LibraryImport(DllName)]
        public static unsafe partial FridaDeviceManager* frida_device_manager_new();
        /* DeviceManager */
        [LibraryImport(DllName)]
        public static unsafe partial void frida_device_manager_close_sync(FridaDeviceManager* self, GCancellable* cancellable, GError** error);
        /* DeviceManager */
        [LibraryImport(DllName)]
        public static unsafe partial FridaDevice* frida_device_manager_get_device_by_id_sync(FridaDeviceManager* self,[MarshalAs(UnmanagedType.LPUTF8Str)]string id, gint timeout, GCancellable* cancellable, GError ** error);
        /* DeviceManager */
        [LibraryImport(DllName)]
        public static unsafe partial FridaDevice* frida_device_manager_get_device_by_type_sync(FridaDeviceManager* self, FridaDeviceType type, gint timeout, GCancellable* cancellable, GError** error);
        /* DeviceManager */
        [LibraryImport(DllName)]
        public static unsafe partial FridaDevice* frida_device_manager_find_device_by_id_sync(FridaDeviceManager* self, [MarshalAs(UnmanagedType.LPUTF8Str)]string id, gint timeout, GCancellable* cancellable, GError ** error);

        [LibraryImport(DllName)]
        public static unsafe partial FridaDevice* frida_device_manager_find_device_by_type_sync(FridaDeviceManager* self, FridaDeviceType type, gint timeout, GCancellable* cancellable, GError** error);

        [LibraryImport(DllName)]
        public static unsafe partial FridaDeviceList* frida_device_manager_enumerate_devices_sync(FridaDeviceManager* self, GCancellable* cancellable, GError** error);

        [LibraryImport(DllName)]
        public static unsafe partial FridaDevice* frida_device_manager_add_remote_device_sync(FridaDeviceManager* self,[MarshalAs(UnmanagedType.LPUTF8Str)]string address, FridaRemoteDeviceOptions * options, GCancellable* cancellable, GError ** error);

        [LibraryImport(DllName)]
        public static unsafe partial void frida_device_manager_remove_remote_device_sync(FridaDeviceManager* self, [MarshalAs(UnmanagedType.LPUTF8Str)]string address, GCancellable * cancellable, GError** error);

        /* DeviceList */
        [LibraryImport(DllName)]
        public static unsafe partial gint frida_device_list_size(FridaDeviceList* self);
        [LibraryImport(DllName)]
        public static unsafe partial FridaDevice* frida_device_list_get(FridaDeviceList* self, gint index);

        /* Device */
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr frida_device_get_id(FridaDevice* self);
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr frida_device_get_name(FridaDevice* self);
        [LibraryImport(DllName)]
        public static unsafe partial GVariant* frida_device_get_icon(FridaDevice* self);
        [LibraryImport(DllName)]
        public static unsafe partial FridaDeviceType frida_device_get_dtype(FridaDevice* self);
        [LibraryImport(DllName)]
        public static unsafe partial FridaDeviceManager* frida_device_get_manager(FridaDevice* self);

        [LibraryImport(DllName)]
        public static unsafe partial gboolean frida_device_is_lost(FridaDevice* self);

        [LibraryImport(DllName)]
        public static unsafe partial GHashTable* frida_device_query_system_parameters_sync(FridaDevice* self, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial FridaApplication* frida_device_get_frontmost_application_sync(FridaDevice* self, FridaFrontmostQueryOptions* options, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial FridaApplicationList* frida_device_enumerate_applications_sync(FridaDevice* self, FridaApplicationQueryOptions* options, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial FridaProcess* frida_device_get_process_by_pid_sync(FridaDevice* self, guint pid, FridaProcessMatchOptions* options, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial FridaProcess* frida_device_get_process_by_name_sync(FridaDevice* self,[MarshalAs(UnmanagedType.LPUTF8Str)]string name, FridaProcessMatchOptions * options, GCancellable* cancellable, GError ** error);
        [LibraryImport(DllName)]
        public static unsafe partial FridaProcess* frida_device_find_process_by_pid_sync(FridaDevice* self, guint pid, FridaProcessMatchOptions* options, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial FridaProcess* frida_device_find_process_by_name_sync(FridaDevice* self, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, FridaProcessMatchOptions * options, GCancellable* cancellable, GError ** error);
        [LibraryImport(DllName)]
        public static unsafe partial FridaProcessList* frida_device_enumerate_processes_sync(FridaDevice* self, FridaProcessQueryOptions* options, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_device_enable_spawn_gating_sync(FridaDevice* self, GCancellable* cancellable, GError** error);

        [LibraryImport(DllName)]
        public static unsafe partial void frida_device_disable_spawn_gating_sync(FridaDevice* self, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial FridaSpawnList* frida_device_enumerate_pending_spawn_sync(FridaDevice* self, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial FridaChildList* frida_device_enumerate_pending_children_sync(FridaDevice* self, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial guint frida_device_spawn_sync(FridaDevice* self, [MarshalAs(UnmanagedType.LPUTF8Str)] string program, FridaSpawnOptions * options, GCancellable* cancellable, GError ** error);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_device_input_sync(FridaDevice* self, guint pid, GBytes* data, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_device_resume_sync(FridaDevice* self, guint pid, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_device_kill_sync(FridaDevice* self, guint pid, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial FridaSession* frida_device_attach_sync(FridaDevice* self, guint pid, FridaSessionOptions* options, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial guint frida_device_inject_library_file_sync(FridaDevice* self, guint pid, [MarshalAs(UnmanagedType.LPUTF8Str)] string path, [MarshalAs(UnmanagedType.LPUTF8Str)] string entrypoint, [MarshalAs(UnmanagedType.LPUTF8Str)] string data, GCancellable * cancellable, GError** error);

        [LibraryImport(DllName)]
        public static unsafe partial guint frida_device_inject_library_blob_sync(FridaDevice* self, guint pid, GBytes* blob, [MarshalAs(UnmanagedType.LPUTF8Str)] string entrypoint, [MarshalAs(UnmanagedType.LPUTF8Str)] string data, GCancellable * cancellable, GError** error);

        /* RemoteDeviceOptions */
        [LibraryImport(DllName)]
        public static unsafe partial FridaRemoteDeviceOptions* frida_remote_device_options_new();
        [LibraryImport(DllName)]
        public static unsafe partial GTlsCertificate* frida_remote_device_options_get_certificate(FridaRemoteDeviceOptions* self);
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr frida_remote_device_options_get_origin (FridaRemoteDeviceOptions * self);

        [LibraryImport(DllName)]
        public static unsafe partial IntPtr frida_remote_device_options_get_token (FridaRemoteDeviceOptions * self);
        [LibraryImport(DllName)]
        public static unsafe partial gint frida_remote_device_options_get_keepalive_interval(FridaRemoteDeviceOptions* self);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_remote_device_options_set_certificate(FridaRemoteDeviceOptions* self, GTlsCertificate* value);

        [LibraryImport(DllName)]
        public static unsafe partial void frida_remote_device_options_set_origin(FridaRemoteDeviceOptions* self, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

        [LibraryImport(DllName)]
        public static unsafe partial void frida_remote_device_options_set_token(FridaRemoteDeviceOptions* self, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_remote_device_options_set_keepalive_interval(FridaRemoteDeviceOptions* self, gint value);

        /* ApplicationList */
        [LibraryImport(DllName)]
        public static unsafe partial gint frida_application_list_size(FridaApplicationList* self);

        [LibraryImport(DllName)]
        public static unsafe partial FridaApplication* frida_application_list_get(FridaApplicationList* self, gint index);
        /* Application */
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr frida_application_get_identifier (FridaApplication * self);
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr frida_application_get_name (FridaApplication * self);

        [LibraryImport(DllName)]
        public static unsafe partial guint frida_application_get_pid(FridaApplication* self);
        [LibraryImport(DllName)]
        public static unsafe partial GHashTable* frida_application_get_parameters(FridaApplication* self);

        /* ProcessList */
        [LibraryImport(DllName)]
        public static unsafe partial gint frida_process_list_size(FridaProcessList* self);

        [LibraryImport(DllName)]
        public static unsafe partial FridaProcess* frida_process_list_get(FridaProcessList* self, gint index);


        /* Process */
        [LibraryImport(DllName)]
        public static unsafe partial guint frida_process_get_pid(FridaProcess* self);
        /* Process */
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr frida_process_get_name (FridaProcess * self);

        /* Process */
        [LibraryImport(DllName)]
        public static unsafe partial GHashTable* frida_process_get_parameters(FridaProcess* self);

        /* ProcessMatchOptions */
        [LibraryImport(DllName)]
        public static unsafe partial FridaProcessMatchOptions* frida_process_match_options_new();
        [LibraryImport(DllName)]
        public static unsafe partial gint frida_process_match_options_get_timeout(FridaProcessMatchOptions* self);
        [LibraryImport(DllName)]
        public static unsafe partial FridaScope frida_process_match_options_get_scope(FridaProcessMatchOptions* self);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_process_match_options_set_timeout(FridaProcessMatchOptions* self, gint value);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_process_match_options_set_scope(FridaProcessMatchOptions* self, FridaScope value);

        /* SpawnOptions */
        [LibraryImport(DllName)]
        public static unsafe partial FridaSpawnOptions* frida_spawn_options_new();
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr frida_spawn_options_get_argv(FridaSpawnOptions* self, gint* result_length);
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr frida_spawn_options_get_envp(FridaSpawnOptions* self, gint* result_length);
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr frida_spawn_options_get_env(FridaSpawnOptions* self, gint* result_length);
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr frida_spawn_options_get_cwd (FridaSpawnOptions * self);
        [LibraryImport(DllName)]
        public static unsafe partial FridaStdio frida_spawn_options_get_stdio(FridaSpawnOptions* self);

        [LibraryImport(DllName)]
        public static unsafe partial GHashTable* frida_spawn_options_get_aux(FridaSpawnOptions* self);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_spawn_options_set_argv(FridaSpawnOptions* self, IntPtr value, gint value_length);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_spawn_options_set_envp(FridaSpawnOptions* self, IntPtr value, gint value_length);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_spawn_options_set_env(FridaSpawnOptions* self, IntPtr value, gint value_length);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_spawn_options_set_cwd(FridaSpawnOptions* self, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_spawn_options_set_stdio(FridaSpawnOptions* self, FridaStdio value);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_spawn_options_set_aux(FridaSpawnOptions* self, GHashTable* value);

        /* FrontmostQueryOptions */
        [LibraryImport(DllName)]
        public static unsafe partial FridaFrontmostQueryOptions* frida_frontmost_query_options_new();
        [LibraryImport(DllName)]
        public static unsafe partial FridaScope frida_frontmost_query_options_get_scope(FridaFrontmostQueryOptions* self);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_frontmost_query_options_set_scope(FridaFrontmostQueryOptions* self, FridaScope value);
        /* ApplicationQueryOptions */
        [LibraryImport(DllName)]
        public static unsafe partial FridaApplicationQueryOptions* frida_application_query_options_new();
        [LibraryImport(DllName)]
        public static unsafe partial FridaScope frida_application_query_options_get_scope(FridaApplicationQueryOptions* self);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_application_query_options_select_identifier(FridaApplicationQueryOptions* self, [MarshalAs(UnmanagedType.LPUTF8Str)] string identifier);
        [LibraryImport(DllName)]
        public static unsafe partial gboolean frida_application_query_options_has_selected_identifiers(FridaApplicationQueryOptions* self);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_application_query_options_enumerate_selected_identifiers(FridaApplicationQueryOptions* self, GFunc func, gpointer user_data);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_application_query_options_set_scope(FridaApplicationQueryOptions* self, FridaScope value);
        /* ProcessQueryOptions */
        [LibraryImport(DllName)]
        public static unsafe partial FridaProcessQueryOptions* frida_process_query_options_new();
        [LibraryImport(DllName)]
        public static unsafe partial FridaScope frida_process_query_options_get_scope(FridaProcessQueryOptions* self);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_process_query_options_select_pid(FridaProcessQueryOptions* self, guint pid);
        [LibraryImport(DllName)]
        public static unsafe partial gboolean frida_process_query_options_has_selected_pids(FridaProcessQueryOptions* self);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_process_query_options_enumerate_selected_pids(FridaProcessQueryOptions* self, GFunc func, gpointer user_data);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_process_query_options_set_scope(FridaProcessQueryOptions* self, FridaScope value);
        /* SessionOptions */
        [LibraryImport(DllName)]
        public static unsafe partial FridaSessionOptions* frida_session_options_new();
        [LibraryImport(DllName)]
        public static unsafe partial FridaRealm frida_session_options_get_realm(FridaSessionOptions* self);
        [LibraryImport(DllName)]
        public static unsafe partial guint frida_session_options_get_persist_timeout(FridaSessionOptions* self);
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr frida_session_options_get_emulated_agent_path (FridaSessionOptions * self);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_session_options_set_realm(FridaSessionOptions* self, FridaRealm value);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_session_options_set_persist_timeout(FridaSessionOptions* self, guint value);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_session_options_set_emulated_agent_path(FridaSessionOptions* self, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);
        /* SpawnList */
        [LibraryImport(DllName)]
        public static unsafe partial gint frida_spawn_list_size(FridaSpawnList* self);
        [LibraryImport(DllName)]
        public static unsafe partial FridaSpawn* frida_spawn_list_get(FridaSpawnList* self, gint index);
        /* Spawn */
        [LibraryImport(DllName)]
        public static unsafe partial guint frida_spawn_get_pid(FridaSpawn* self);
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr frida_spawn_get_identifier (FridaSpawn * self);
        /* ChildList */
        [LibraryImport(DllName)]
        public static unsafe partial gint frida_child_list_size(FridaChildList* self);
        [LibraryImport(DllName)]
        public static unsafe partial FridaChild* frida_child_list_get(FridaChildList* self, gint index);
        /* Crash */
        [LibraryImport(DllName)]
        public static unsafe partial guint frida_crash_get_pid(FridaCrash* self);
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr frida_crash_get_process_name (FridaCrash * self);
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr frida_crash_get_summary (FridaCrash * self);
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr frida_crash_get_report (FridaCrash * self);
        [LibraryImport(DllName)]
        public static unsafe partial GHashTable* frida_crash_get_parameters(FridaCrash* self);
        /* Session */
        [LibraryImport(DllName)]
        public static unsafe partial guint frida_session_get_pid(FridaSession* self);
        [LibraryImport(DllName)]
        public static unsafe partial guint frida_session_get_persist_timeout(FridaSession* self);
        [LibraryImport(DllName)]
        public static unsafe partial FridaDevice* frida_session_get_device(FridaSession* self);
        [LibraryImport(DllName)]
        public static unsafe partial gboolean frida_session_is_detached(FridaSession* self);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_session_detach_sync(FridaSession* self, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_session_resume_sync(FridaSession* self, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_session_enable_child_gating_sync(FridaSession* self, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_session_disable_child_gating_sync(FridaSession* self, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial FridaScript* frida_session_create_script_sync(FridaSession* self, [MarshalAs(UnmanagedType.LPUTF8Str)] string source, FridaScriptOptions * options, GCancellable* cancellable, GError ** error);
        [LibraryImport(DllName)]
        public static unsafe partial FridaScript* frida_session_create_script_from_bytes_sync(FridaSession* self, GBytes* bytes, FridaScriptOptions* options, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial GBytes* frida_session_compile_script_sync(FridaSession* self, [MarshalAs(UnmanagedType.LPUTF8Str)] string source, FridaScriptOptions * options, GCancellable* cancellable, GError ** error);
        [LibraryImport(DllName)]
        public static unsafe partial GBytes* frida_session_snapshot_script_sync(FridaSession* self, [MarshalAs(UnmanagedType.LPUTF8Str)] string embed_script, FridaSnapshotOptions * options, GCancellable* cancellable, GError ** error);
        /* Script */
        [LibraryImport(DllName)]
        public static unsafe partial gboolean frida_script_is_destroyed(FridaScript* self);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_script_load_sync(FridaScript* self, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_script_unload_sync(FridaScript* self, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_script_eternalize_sync(FridaScript* self, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_script_post(FridaScript* self, [MarshalAs(UnmanagedType.LPUTF8Str)] string json, GBytes * data);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_script_enable_debugger_sync(FridaScript* self, guint16 port, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_script_disable_debugger_sync(FridaScript* self, GCancellable* cancellable, GError** error);
        /* SnapshotOptions */
        [LibraryImport(DllName)]
        public static unsafe partial FridaSnapshotOptions* frida_snapshot_options_new();
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr frida_snapshot_options_get_warmup_script (FridaSnapshotOptions * self);
        [LibraryImport(DllName)]
        public static unsafe partial FridaScriptRuntime frida_snapshot_options_get_runtime(FridaSnapshotOptions* self);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_snapshot_options_set_warmup_script(FridaSnapshotOptions* self, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_snapshot_options_set_runtime(FridaSnapshotOptions* self, FridaScriptRuntime value);
        /* ScriptOptions */
        [LibraryImport(DllName)]
        public static unsafe partial FridaScriptOptions* frida_script_options_new();
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr frida_script_options_get_name (FridaScriptOptions * self);
        [LibraryImport(DllName)]
        public static unsafe partial GBytes* frida_script_options_get_snapshot(FridaScriptOptions* self);
        [LibraryImport(DllName)]
        public static unsafe partial FridaSnapshotTransport frida_script_options_get_snapshot_transport(FridaScriptOptions* self);
        [LibraryImport(DllName)]
        public static unsafe partial FridaScriptRuntime frida_script_options_get_runtime(FridaScriptOptions* self);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_script_options_set_name(FridaScriptOptions* self, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_script_options_set_snapshot(FridaScriptOptions* self, GBytes* value);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_script_options_set_snapshot_transport(FridaScriptOptions* self, FridaSnapshotTransport value);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_script_options_set_runtime(FridaScriptOptions* self, FridaScriptRuntime value);
        /* RpcClient */
        [LibraryImport(DllName)]
        public static unsafe partial FridaRpcClient* frida_rpc_client_new(FridaRpcPeer* peer);
        // [LibraryImport(DllName)]
        // public static unsafe partial FridaRpcPeer* frida_rpc_client_get_peer(FridaRpcClient* self);
        // [LibraryImport(DllName)]
        // public static unsafe partial void frida_rpc_client_call(FridaRpcClient* self,[MarshalAs(UnmanagedType.LPUTF8Str)]string method, JsonNode ** args, gint args_length, GBytes * data, GCancellable* cancellable, GAsyncReadyCallback callback, gpointer user_data);
        // [LibraryImport(DllName)]
        // public static unsafe partial JsonNode* frida_rpc_client_call_finish(FridaRpcClient* self, GAsyncResult* result, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial gboolean frida_rpc_client_try_handle_message(FridaRpcClient* self, [MarshalAs(UnmanagedType.LPUTF8Str)] string json);


        /* Injector */
        [LibraryImport(DllName)]
        public static unsafe partial FridaInjector* frida_injector_new();
        [LibraryImport(DllName)]
        public static unsafe partial FridaInjector* frida_injector_new_inprocess();
        [LibraryImport(DllName)]
        public static unsafe partial void frida_injector_close_sync(FridaInjector* self, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial guint frida_injector_inject_library_file_sync(FridaInjector* self, guint pid, [MarshalAs(UnmanagedType.LPUTF8Str)] string path, [MarshalAs(UnmanagedType.LPUTF8Str)] string entrypoint, [MarshalAs(UnmanagedType.LPUTF8Str)] string data, GCancellable * cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial guint frida_injector_inject_library_blob_sync(FridaInjector* self, guint pid, GBytes* blob, [MarshalAs(UnmanagedType.LPUTF8Str)] string entrypoint, [MarshalAs(UnmanagedType.LPUTF8Str)] string data, GCancellable * cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_injector_demonitor_sync(FridaInjector* self, guint id, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial guint frida_injector_demonitor_and_clone_state_sync(FridaInjector* self, guint id, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)] 
        public static unsafe partial void frida_injector_recreate_thread_sync(FridaInjector* self, guint pid, guint id, GCancellable* cancellable, GError** error);

        /* FileMonitor */
        [LibraryImport(DllName)]
        public static unsafe partial FridaFileMonitor* frida_file_monitor_new([MarshalAs(UnmanagedType.LPUTF8Str)] string path);
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr frida_file_monitor_get_path (FridaFileMonitor * self);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_file_monitor_enable_sync(FridaFileMonitor* self, GCancellable* cancellable, GError** error);
        [LibraryImport(DllName)]
        public static unsafe partial void frida_file_monitor_disable_sync(FridaFileMonitor* self, GCancellable* cancellable, GError** error);


    }
}
