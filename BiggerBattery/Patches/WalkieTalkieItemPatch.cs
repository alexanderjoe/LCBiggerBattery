using HarmonyLib;

namespace BiggerBattery.Patches
{
    [HarmonyPatch(typeof(WalkieTalkie))]
    internal class WalkieTalkieItemPatch
    {
        [HarmonyPatch("ItemActivate")]
        [HarmonyPostfix]
        private static void ModifyWalkieTalkieBatteryUsage(ref WalkieTalkie __instance)
        {
            __instance.itemProperties.batteryUsage = ConfigSettings.WalkieTalkieBatteryUsage.Value;
        }
    }
}