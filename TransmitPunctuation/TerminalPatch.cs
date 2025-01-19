using HarmonyLib;

namespace TransmitPunctuation;

[HarmonyPatch(typeof(Terminal))]
public class TerminalPatch
{
    [HarmonyPatch("RemovePunctuation")]
    [HarmonyPrefix]
    private static bool RemovePunctuation(object[] __args, ref string __result)
    {
        __result = __args[0].ToString().ToLower();
        return false;
    }
}