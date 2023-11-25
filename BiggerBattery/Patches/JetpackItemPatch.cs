using HarmonyLib;

namespace BiggerBattery.Patches
{
    [HarmonyPatch(typeof(JetpackItem))]
    internal class JetpackItemPatch
    {
        [HarmonyPatch("ItemActivate")]
        [HarmonyPrefix]
        private static void ModifyJetpackBatteryUsage(ref JetpackItem __instance)
        {
            __instance.itemProperties.batteryUsage = ConfigSettings.JetpackBatteryUsage.Value;
        }
    }
}