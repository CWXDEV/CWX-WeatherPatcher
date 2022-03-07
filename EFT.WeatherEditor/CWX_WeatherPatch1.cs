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
            return typeof(GClass1694).GetMethod("smethod_0", BindingFlags.NonPublic | BindingFlags.Static);
        }

        [PatchPostfix]
        private static void PatchPostfix(ref GClass1694 __result)
        {
            //string json = File.ReadAllText("C:/AKI PROJECT/2.2.3 build - client 16909/user/mods/CWX_WeatherPatcher 2.1.5/config.json");
            //var x = JsonConvert.DeserializeObject<JSONClass>(json.ToString());

            //__result.Cloudness = x.Cloudness;
            //__result.WindDirection = x.WindDirection;
            //__result.Wind = x.Wind;
            //__result.Rain = x.Rain;
            //__result.RainRandomness = x.RainRandomness;

            __result.Cloudness = -1;
            __result.WindDirection = 8;
            __result.Wind = 0;
            __result.Rain = 0;
            __result.RainRandomness = 0;
            __result.ScaterringFogDensity = 0;
            __result.GlobalFogDensity = 0;
            __result.GlobalFogHeight = 0;


            Log.Info("MADE CHANGES TO GClass1694 SMETHOD_0!");

        }
    }
}
