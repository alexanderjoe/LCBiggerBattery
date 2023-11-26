using HarmonyLib;

namespace BiggerBattery.Patches
{
    [HarmonyPatch(typeof(BoomboxItem))]
    internal class BoomboxItemPatch
    {
        [HarmonyPatch("ItemActivate")]
        [HarmonyPrefix]
        private static void ModifyBoomboxItemBatteryUsage(ref BoomboxItem __instance)
        {
            __instance.itemProperties.batteryUsage = ConfigSettings.BoomboxItemBatteryUsage.Value;
        }
    }
}