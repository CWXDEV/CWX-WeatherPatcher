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
            return typeof(WeatherDebug).GetMethod("method_0", BindingFlags.Public);
        }


        private static void PostFixPatch(ref WeatherDebug __result)
        {
            __result.Enabled = true;
            __result.LightningThunderProbability = 0f;
            __result.Fog = 0f;
        }
    }
}
