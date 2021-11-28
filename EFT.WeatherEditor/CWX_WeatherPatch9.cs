using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common;
using EFT.Weather;
using System;
using UnityEngine;

namespace EFT.WeatherEditor
{
    //class CWX_WeatherPatch9 : Patch  // MAKES CHANGES TO SHARPNESS
    //{

    //    public CWX_WeatherPatch9() : base(T: typeof(CWX_WeatherPatch9), postfix: nameof(PostFixPatch))
    //    {
    //    }

    //    protected override MethodBase GetTargetMethod()
    //    {
    //        return typeof(EffectsController).GetNestedType("Class358", BindingFlags.NonPublic | BindingFlags.Instance, "UpdateAmount"), new (typeof(CWX_WeatherPatch9), nameof(PostFixPatch));
    //    }


    //    private static void PostFixPatch(ref CC_Sharpen __instance, CC_Base ___base)
    //    {
    //        Log.Info("current when called:" + __instance.strength.ToString());
    //        Log.Info("current when called:" + __instance.clamp.ToString());

    //        Log.Info("amended when called:" + __instance.strength.ToString());

    //        Log.Info("----------------------------------------------------------------");
    //    }
    //}
}
