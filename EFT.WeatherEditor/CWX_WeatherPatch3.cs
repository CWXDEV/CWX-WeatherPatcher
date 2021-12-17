using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common.Utils;

namespace EFT.WeatherEditor
{
    class CWX_WeatherPatch3 : ModulePatch  // MAKES CHANGES TO CUSTOMGLOBALFOG
    {

        protected override MethodBase GetTargetMethod()
        {
            return typeof(CustomGlobalFog).GetMethod("Start", BindingFlags.NonPublic | BindingFlags.Instance);
        }

        [PatchPostfix]
        private static void PostFixPatch(ref CustomGlobalFog __instance)
        {
            __instance.FuncStart = 0f;
            Log.Info("MADE CHANGES TO CUSTOMGLOBALFOG!");
        }
    }
}
