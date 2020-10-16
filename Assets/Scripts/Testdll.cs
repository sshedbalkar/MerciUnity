using UnityEngine;
using System.Runtime.InteropServices;
using System.Diagnostics;

public class Testdll : MonoBehaviour
{
    public delegate void UnityDebugCallback(string message);

    [DllImport("libdebug")]
    private static extern void registerUnityDbgCallback(UnityDebugCallback callback);

    [DllImport("libnet")]
    public static extern void initLib();

    [DllImport("libnet")]
    public static extern void closeLib();

    [DllImport("libnet")]
    public static extern int add(int a, int b);

    private void Start()
    {
        registerUnityDbgCallback(new UnityDebugCallback(DebugMethod));
        initLib();
        UnityEngine.Debug.Log("Adding 23, 45: " + add(23, 45));
        closeLib();
    }

    private static void DebugMethod(string message)
    {
        UnityEngine.Debug.Log("libdebug: " + message);
    }
}
