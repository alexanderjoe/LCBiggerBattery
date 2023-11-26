using BepInEx.Configuration;

namespace BiggerBattery
{
    public static class ConfigSettings
    {
        public static ConfigEntry<float> FlashlightBatteryUsage;
        public static ConfigEntry<float> ProFlashlightBatteryUsage;
        public static ConfigEntry<float> LaserPointerBatteryUsage;
        public static ConfigEntry<float> WalkieTalkieBatteryUsage;
        public static ConfigEntry<float> JetpackBatteryUsage;
        public static ConfigEntry<float> PatcherToolBatteryUsage;
        public static ConfigEntry<float> BoomboxItemBatteryUsage;
        
        public static void Init()
        {
            FlashlightBatteryUsage = Plugin.Instance.Config.Bind("BiggerBattery", "FlashlightBatteryUsage", 300.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: 140)");
            ProFlashlightBatteryUsage = Plugin.Instance.Config.Bind("BiggerBattery", "ProFlashlightBatteryUsage", 600.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: 300)");
            LaserPointerBatteryUsage = Plugin.Instance.Config.Bind("BiggerBattery", "LaserPointerBatteryUsage", 450.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: 300)");
            WalkieTalkieBatteryUsage = Plugin.Instance.Config.Bind("BiggerBattery", "WalkieTalkieBatteryUsage", 1500.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: 820)");
            JetpackBatteryUsage = Plugin.Instance.Config.Bind("BiggerBattery", "JetpackBatteryUsage", 140.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: 60)");
            PatcherToolBatteryUsage = Plugin.Instance.Config.Bind("BiggerBattery", "PatcherToolBatteryUsage", 66.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: 22)");
            BoomboxItemBatteryUsage = Plugin.Instance.Config.Bind("BiggerBattery", "BoomboxItemBatteryUsage", 600.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: 350)");
        }
    }
}