using Aki.Common.Utils;
using Aki.Reflection.Patching;
using System.Reflection;

namespace EFT.WeatherEditor
{
    class CWX_WeatherPatch1 : ModulePatch  // MAKES CHANGES TO GClass1705 SMETHOD_1
    {
        protected override MethodBase GetTargetMethod()
        {
            return typeof(GClass1705).GetMethod("smethod_0", BindingFlags.NonPublic | BindingFlags.Static);
        }

        [PatchPostfix]
        private static void PostFixPatch(ref GClass1705 __result)
        {
            __result.Cloudness = -1f;
            __result.WindDirection = 8;
            __result.Wind = 0f;
            __result.Rain = 0f;
            __result.RainRandomness = 0f;
            __result.ScaterringFogDensity = 0f;
            __result.GlobalFogDensity = 0f;
            __result.GlobalFogHeight = 0f;

            Log.Info("MADE CHANGES TO GClass1703 SMETHOD_1!");

        }
    }
}
