using System;
using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common;
using EFT.Weather;
using UnityEngine;
using BehaviourMachine;

//namespace EFT.WeatherEditor
//{
//    class CWX_WeatherPatch3 : Patch
//    {

//        public CWX_WeatherPatch3() : base(T: typeof(CWX_WeatherPatch3), postfix: nameof(PostFixPatch))
//        {
//        }

//        protected override MethodBase GetTargetMethod()
//        {
//            return typeof(SetFog).GetMethod("SetFog", BindingFlags.Public | BindingFlags.Instance);
//        }


//        private static void PostFixPatch(ref SetFog __result)
//        {

//            Log.Info("OLD GlobalFogStart:" + __result.FogStart.ToString());
//            Log.Info("---------------------------");
//            __result.linearFogStart = 400f;
//            Log.Info("NEW GlobalFogStart:" + __result.FogStart.ToString());
//            Log.Info("-----------------------------------------------------------------");
//        }
//    }
//}
