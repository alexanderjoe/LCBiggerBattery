using HarmonyLib;

namespace BiggerBattery.Patches
{
    [HarmonyPatch(typeof(PatcherTool))]
    internal class PatcherToolPatch
    {
        [HarmonyPatch("ItemActivate")]
        [HarmonyPrefix]
        private static void ModifyPatcherToolBatteryUsage(ref PatcherTool __instance)
        {
            __instance.itemProperties.batteryUsage = ConfigSettings.PatcherToolBatteryUsage.Value;
        }
    }
}