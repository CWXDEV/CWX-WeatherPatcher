using System;
using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common;
using EFT.Weather;
using UnityEngine;

namespace EFT.WeatherEditor
{
    class CWX_WeatherPatch1 : Patch
    {

        public CWX_WeatherPatch1() : base(T: typeof(CWX_WeatherPatch1), postfix: nameof(PostFixPatch))
        {
        }

        protected override MethodBase GetTargetMethod()
        {
            return typeof(TOD_Weather).GetMethod("FadeTime", BindingFlags.Public);
        }


        private static void PostFixPatch(ref TOD_Weather __result)
        {
            __result.FadeTime = 0.1f;
        }
    }
}
