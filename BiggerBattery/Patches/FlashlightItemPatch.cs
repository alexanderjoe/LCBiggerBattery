using HarmonyLib;

namespace BiggerBattery.Patches
{
    [HarmonyPatch(typeof(FlashlightItem))]
    internal class FlashlightItemPatch
    {
        [HarmonyPatch("ItemActivate")]
        [HarmonyPrefix]
        private static void ModifyFlashlightBatteryUsage(ref FlashlightItem __instance)
        {
            var type = (FlashlightType)__instance.flashlightTypeID;

            switch (type)
            {
                case FlashlightType.Flashlight:
                    __instance.itemProperties.batteryUsage = ConfigSettings.FlashlightBatteryUsage.Value;
                    break;
                case FlashlightType.ProFlashlight:
                    __instance.itemProperties.batteryUsage = ConfigSettings.ProFlashlightBatteryUsage.Value;
                    break;
                case FlashlightType.LaserPointer:
                    __instance.itemProperties.batteryUsage = ConfigSettings.LaserPointerBatteryUsage.Value;
                    break;
                default:
                    Plugin.Log($"Unknown FlashlightType: {type}");
                    break;
            }
        }
    }
}