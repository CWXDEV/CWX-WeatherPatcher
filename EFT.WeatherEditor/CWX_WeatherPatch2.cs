﻿using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common;

namespace EFT.WeatherEditor
{
    class CWX_WeatherPatch2 : Patch  // MAKES CHANGES TO GClass1638 SMETHOD_0
    {

        public CWX_WeatherPatch2() : base(T: typeof(CWX_WeatherPatch2), postfix: nameof(PostFixPatch))
        {
        }

        protected override MethodBase GetTargetMethod()
        {
            return typeof(GClass1676).GetMethod("smethod_0", BindingFlags.NonPublic | BindingFlags.Static);
        }


        private static void PostFixPatch(ref GClass1676 __result)
        {
            __result.Cloudness = -1f;
            __result.WindDirection = 8;
            __result.Wind = 0f;
            __result.Rain = 0f;
            __result.RainRandomness = 0f;
            __result.ScaterringFogDensity = 0f;
            __result.GlobalFogDensity = 0f;
            __result.GlobalFogHeight = 0f;

            Log.Info("MADE CHANGES TO GCLASS1414 SMETHOD_0!");
        }
    }
}
