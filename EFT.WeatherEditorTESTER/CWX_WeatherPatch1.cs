﻿using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common;
using EFT.Weather;

namespace EFT.WeatherEditor
{
    class CWX_WeatherPatch1 : Patch  // MAKES CHANGES TO WEATHERDEBUG
    {

        public CWX_WeatherPatch1() : base(T: typeof(CWX_WeatherPatch1), postfix: nameof(PostFixPatch))
        {
        }

        protected override MethodBase GetTargetMethod()
        {
            return typeof(WeatherDebug).GetMethod("method_0", BindingFlags.NonPublic | BindingFlags.Instance);
        }


        private static void PostFixPatch(ref WeatherDebug __result)
        {
            __result.IsDynamicSunWeatherDebug = false;
            __result.Enabled = true;
            __result.WindMagnitude = 0f;
            __result.WindDirection = 0f;
            __result.CloudDensity = -1f;
            __result.Fog = 0f;
            __result.Rain = 0f;
            __result.LightningThunderProbability = 0f;
            Log.Info("TURNED ON CUSTOM DEBUG SETTINGS!");

        }
    }
}
