using BepInEx;
using HarmonyLib;

namespace TransmitPunctuation
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private readonly Harmony _harmony = new(PluginInfo.PLUGIN_GUID);
        
        private void Awake()
        {
            _harmony.PatchAll(typeof(TerminalPatch));
        }
    }
}