using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common.Utils;

namespace EFT.WeatherEditor
{
    class CWX_WeatherPatch4 : ModulePatch  // MAKES CHANGES TO LEVELSETTINGS
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
            Log.Info("MADE CHANGES TO LEVELSETTINGS!");
        }
    }
}
