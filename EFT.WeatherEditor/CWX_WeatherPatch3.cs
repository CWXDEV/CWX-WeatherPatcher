using System;
using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common;
using EFT.Weather;
using UnityEngine;

//namespace EFT.WeatherEditor
//{
//    class CWX_WeatherPatch3 : Patch
//    {

//        public CWX_WeatherPatch3() : base(T: typeof(CWX_WeatherPatch3), prefix: nameof(PreFixPatch))
//        {
//        }

//        protected override MethodBase GetTargetMethod()
//        {
//            return typeof(CloudsController).GetMethod("Awake", BindingFlags.NonPublic | BindingFlags.Instance);
//        }


//        static bool PreFixPatch(ref CloudsController __result)
//        {
//            __result.Refresh();
//            Log.Info("OLD GlobalFogStart:" + __result.FogDensityMultyplier.ToString());
//            Log.Info("---------------------------");
//            __result.FogDensityMultyplier = 0f;
//            Log.Info("NEW GlobalFogStart:" + __result.FogDensityMultyplier.ToString());
//            Log.Info("-----------------------------------------------------------------");
//            return false;
//        }
//    }
//}
