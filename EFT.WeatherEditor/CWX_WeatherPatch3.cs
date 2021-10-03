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
//            return typeof(SetFog).GetMethod("Update", BindingFlags.Public | BindingFlags.Instance);
//        }


//        static void PostFixPatch(ref SetFog __result)
//        {
//            Aki.Common.Log.Info("OLD fog:" + __result.fog.ToString());
//            Aki.Common.Log.Info("OLD fogMode:" + __result.fogMode.ToString());
//            Aki.Common.Log.Info("OLD fogDensity:" + __result.fogDensity.ToString());
//            Aki.Common.Log.Info("OLD linearFogStart:" + __result.linearFogStart.ToString());
//            Aki.Common.Log.Info("OLD linearFogEnd:" + __result.linearFogEnd.ToString());
//            __result.fogDensity = 0f;
//            __result.linearFogStart = 700f;
//            __result.linearFogEnd = 700f;
//            Aki.Common.Log.Info("NEW fog:" + __result.fog.ToString());
//            Aki.Common.Log.Info("NEW fogMode:" + __result.fogMode.ToString());
//            Aki.Common.Log.Info("NEW fogDensity:" + __result.fogDensity.ToString());
//            Aki.Common.Log.Info("NEW linearFogStart:" + __result.linearFogStart.ToString());
//            Aki.Common.Log.Info("NEW linearFogEnd:" + __result.linearFogEnd.ToString());
//        }
//    }
//}
