using fts;

[PluginAttr("libdebug")]
public class PluginAPI_debug
{
    public delegate void UnityDebugCallback(string message);

    [PluginFunctionAttr("registerUnityDbgCallback")]
    public static RegisterUnityDbgCallback registerUnityDbgCallback = null;
    public delegate void RegisterUnityDbgCallback(UnityDebugCallback callback);
}
