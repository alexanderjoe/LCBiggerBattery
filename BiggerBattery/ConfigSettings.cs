using BepInEx.Configuration;

namespace BiggerBattery
{
    public static class ConfigSettings
    {
        public static ConfigEntry<float> FlashlightBatteryUsage;
        public static ConfigEntry<float> ProFlashlightBatteryUsage;
        // public static ConfigEntry<float> LaserPointerBatteryUsage;
        public static ConfigEntry<float> WalkieTalkieBatteryUsage;
        public static ConfigEntry<float> JetpackBatteryUsage;
        public static ConfigEntry<float> PatcherToolBatteryUsage;
        
        public static void Init()
        {
            FlashlightBatteryUsage = Plugin.Instance.Config.Bind<float>("BiggerBattery", "FlashlightBatteryUsage", 270.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: 140)");
            ProFlashlightBatteryUsage = Plugin.Instance.Config.Bind<float>("BiggerBattery", "ProFlashlightBatteryUsage", 500.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: 300)");
            // LaserPointerBatteryUsage = Plugin.Instance.Config.Bind<float>("BiggerBattery", "LaserPointerBatteryUsage", 60.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: TODO)");
            WalkieTalkieBatteryUsage = Plugin.Instance.Config.Bind<float>("BiggerBattery", "WalkieTalkieBatteryUsage", 1000.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: 820)");
            JetpackBatteryUsage = Plugin.Instance.Config.Bind<float>("BiggerBattery", "JetpackBatteryUsage", 120.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: 60)");
            PatcherToolBatteryUsage = Plugin.Instance.Config.Bind<float>("BiggerBattery", "PatcherToolBatteryUsage", 50.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: 22)");
        }
    }
}