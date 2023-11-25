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
                // TODO: need to confirm this is laser pointer
                // case FlashlightType.LaserPointer:
                //     Plugin.Log($"LaserPointer Default Usage: {__instance.itemProperties.batteryUsage}");
                //     __instance.itemProperties.batteryUsage = ConfigSettings.LaserPointerBatteryUsage.Value;
                //     break;
                default:
                    Plugin.Log($"Unknown FlashlightType: {type}");
                    break;
            }
        }
    }
}