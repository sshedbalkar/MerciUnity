using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testdll_lazyload : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PluginAPI_debug.registerUnityDbgCallback(DebugMethod);
        PluginAPI_net.initLib();
        UnityEngine.Debug.Log("Adding 23, 45: " + PluginAPI_net.add(23, 45));
        PluginAPI_net.closeLib();
    }

    private static void DebugMethod(string message)
    {
        UnityEngine.Debug.Log("[LIBNATIVE]: " + message);
    }
}
