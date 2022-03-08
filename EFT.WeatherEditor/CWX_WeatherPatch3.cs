using Aki.Reflection.Patching;
using System.Reflection;

namespace CWX_WeatherPatcher
{
    class CWX_WeatherPatch3 : ModulePatch  // MAKES CHANGES TO LEVELSETTINGS
    {
        protected override MethodBase GetTargetMethod()
        {
            return typeof(LevelSettings).GetMethod("ApplySettings", BindingFlags.Public | BindingFlags.Instance);
        }

        [PatchPostfix]
        private static void PostFixPatch(ref LevelSettings __instance)
        {
            __instance.fog = false;
            __instance.fogEndDistance = 0f;
            Logger.LogMessage("MADE CHANGES TO LEVELSETTINGS!");
        }
    }
}
