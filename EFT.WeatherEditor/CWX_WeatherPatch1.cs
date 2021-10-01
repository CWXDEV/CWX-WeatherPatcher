using System;
using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common;
using EFT.Weather;
using UnityEngine;

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
            Log.Info("OLD Enabled:" + __result.Enabled.ToString());
            Log.Info("OLD CloudDensity:" + __result.CloudDensity.ToString());
            Log.Info("OLD Rain:" + __result.Rain.ToString());
            Log.Info("OLD WindMagnitude:" + __result.WindMagnitude.ToString());
            Log.Info("OLD LightningThunderProbability:" + __result.LightningThunderProbability.ToString());
            Log.Info("OLD Fog:" + __result.Fog.ToString());
            Log.Info("---------------------------");
            __result.Enabled = true;
            __result.CloudDensity = -1f;
            __result.Rain = 0f;
            __result.WindMagnitude = 0f;
            __result.LightningThunderProbability = 0f;
            __result.Fog = 0f;
            Log.Info("NEW Enabled:" + __result.Enabled.ToString());
            Log.Info("NEW CloudDensity:" + __result.CloudDensity.ToString());
            Log.Info("NEW Rain:" + __result.Rain.ToString());
            Log.Info("NEW WindMagnitude:" + __result.WindMagnitude.ToString());
            Log.Info("NEW LightningThunderProbability:" + __result.LightningThunderProbability.ToString());
            Log.Info("NEW Fog:" + __result.Fog.ToString());
            Log.Info("-----------------------------------------------------------------");
        }
    }
}
