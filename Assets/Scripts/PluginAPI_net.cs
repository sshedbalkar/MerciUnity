using fts;

[PluginAttr("libnet")]
public class PluginAPI_net
{
    [PluginFunctionAttr("initLib")]
    public static InitLib initLib = null;
    public delegate void InitLib();

    [PluginFunctionAttr("closeLib")]
    public static CloseLib closeLib = null;
    public delegate void CloseLib();

    [PluginFunctionAttr("add")]
    public static Add add = null;
    public delegate int Add(int a, int b);
}
