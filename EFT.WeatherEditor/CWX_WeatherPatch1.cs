using Aki.Reflection.Patching;
using System.Reflection;
using Newtonsoft.Json;
using CWX_WeatherPatch;
using System.IO;

namespace CWX_WeatherPatcher
{
    class CWX_WeatherPatch1 : ModulePatch  // MAKES CHANGES TO GClass1694 SMETHOD_0
    {
        protected override MethodBase GetTargetMethod()
        {   
            return typeof(GClass1694).GetMethod("smethod_0", BindingFlags.NonPublic | BindingFlags.Static);
        }

        [PatchPostfix]
        private static void PatchPostfix(ref GClass1694 __result)
        {
            string json = File.ReadAllText("C:/AKI PROJECT/2.2.3 build - client 16909/user/mods/CWX_WeatherPatcher 2.1.5/config.json");
            var x = JsonConvert.DeserializeObject<JSONClass>(json.ToString());

            __result.Cloudness = x.Cloudness;
            __result.WindDirection = x.WindDirection;
            __result.Wind = x.Wind;
            __result.Rain = x.Rain;
            __result.RainRandomness = x.RainRandomness;
            __result.ScaterringFogDensity = 0;
            __result.GlobalFogDensity = 0;
            __result.GlobalFogHeight = 0;

            Logger.LogInfo("MADE CHANGES TO GClass1694 SMETHOD_0!");
        }
    }
}
