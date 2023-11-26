using BepInEx;
using HarmonyLib;

namespace BiggerBattery
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private const string ModGuid = PluginInfo.PLUGIN_GUID;
        private const string ModName = PluginInfo.PLUGIN_NAME;
        private const string ModVersion = PluginInfo.PLUGIN_VERSION;

        private readonly Harmony _harmony = new Harmony(ModGuid);

        public static Plugin Instance;

        private void Awake()
        {
            Instance = this;
            _harmony.PatchAll();

            ConfigSettings.Init();

            Log($"Plugin {ModName}-{ModVersion} loaded!");
        }

        public static void Log(string message) => Instance.Logger.LogInfo(message);
    }
}