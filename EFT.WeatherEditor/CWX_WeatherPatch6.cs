using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common;

namespace EFT.WeatherEditor
{
    class CWX_WeatherPatch6 : Patch  // MAKES CHANGES TO GClass1638 SMETHOD_2
    {

        public CWX_WeatherPatch6() : base(T: typeof(CWX_WeatherPatch6), postfix: nameof(PostFixPatch))
        {
        }

        protected override MethodBase GetTargetMethod()
        {
            return typeof(GClass1638).GetMethod("smethod_2", BindingFlags.NonPublic | BindingFlags.Static);
        }


        private static void PostFixPatch(ref GClass1638 __result)
        {
            __result.Cloudness = -1f;
            __result.WindDirection = 8;
            __result.Wind = 0f;
            __result.Rain = 0f;
            __result.RainRandomness = 0f;
            __result.ScaterringFogDensity = 0f;
            __result.GlobalFogDensity = 0f;
            __result.GlobalFogHeight = 0f;

            Log.Info("MADE CHANGES TO GCLASSS1414 SMETHOD_2!");
        }
    }
}
