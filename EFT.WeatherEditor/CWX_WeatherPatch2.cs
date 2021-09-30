using System;
using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common;
using EFT.Weather;
using UnityEngine;

namespace EFT.WeatherEditor
{
    class CWX_WeatherPatch2 : Patch  // MAKES CHANGES TO GCLASS 1414
    {

        public CWX_WeatherPatch2() : base(T: typeof(CWX_WeatherPatch2), postfix: nameof(PostFixPatch))
        {
        }

        protected override MethodBase GetTargetMethod()
        {
            return typeof(GClass1414).GetMethod("smethod_0", BindingFlags.NonPublic | BindingFlags.Static);
        }


        private static void PostFixPatch(ref GClass1414 __result)
        {
            Log.Info("OLD GlobalFogHeight:" + __result.GlobalFogHeight.ToString());
            Log.Info("OLD Cloudness:" + __result.Cloudness.ToString());
            Log.Info("OLD Wind:" + __result.Wind.ToString());
            Log.Info("OLD Rain:" + __result.Rain.ToString());
            Log.Info("OLD RainRandomness:" + __result.RainRandomness.ToString());
            Log.Info("OLD ScaterringFogDensity:" + __result.ScaterringFogDensity.ToString());
            Log.Info("OLD ScaterringFogHeight:" + __result.ScaterringFogHeight.ToString());
            Log.Info("OLD GlobalFogDensity:" + __result.GlobalFogDensity.ToString());
            Log.Info("------------------------");
            __result.GlobalFogHeight = 0f;
            __result.Cloudness = -1f;
            __result.Wind = 0f;
            __result.Rain = 0f;
            __result.RainRandomness = 0f;
            __result.ScaterringFogDensity = 0.000f;
            __result.ScaterringFogHeight = 0f;
            __result.GlobalFogDensity = 0.000f;
            Log.Info("NEW GlobalFogHeight:" + __result.GlobalFogHeight.ToString());
            Log.Info("NEW Cloudness:" + __result.Cloudness.ToString());
            Log.Info("NEW Wind:" + __result.Wind.ToString());
            Log.Info("NEW Rain:" + __result.Rain.ToString());
            Log.Info("NEW RainRandomness:" + __result.RainRandomness.ToString());
            Log.Info("NEW ScaterringFogDensity:" + __result.ScaterringFogDensity.ToString());
            Log.Info("NEW ScaterringFogHeight:" + __result.ScaterringFogHeight.ToString());
            Log.Info("NEW GlobalFogDensity:" + __result.GlobalFogDensity.ToString());
            Log.Info("-----------------------------------------------------------------");
        }
    }
}
