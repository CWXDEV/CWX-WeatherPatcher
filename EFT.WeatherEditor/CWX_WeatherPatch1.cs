using Aki.Common.Utils;
using Aki.Reflection.Patching;
using CWX_WeatherPatch;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;

namespace CWX_WeatherPatcher
{
    class CWX_WeatherPatch1 : ModulePatch  // MAKES CHANGES TO GClass1694 SMETHOD_0
    {
        protected override MethodBase GetTargetMethod()
        {   
            return typeof(GClass1691).GetMethod("smethod_0", BindingFlags.NonPublic | BindingFlags.Static);
        }

        [PatchPostfix]
        private static void PatchPostfix(ref GClass1691 __result)
        {
            __result.Cloudness = -1;
            __result.WindDirection = 8;
            __result.Wind = 0;
            __result.Rain = 0;
            __result.RainRandomness = 0;
            __result.ScaterringFogDensity = 0;
            __result.GlobalFogDensity = 0;
            __result.GlobalFogHeight = 0;


            Logger.LogMessage("MADE CHANGES TO GClass1694 SMETHOD_0!");

        }
    }
}
