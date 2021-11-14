using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common;
using EFT.Weather;
using System;
using UnityEngine;

namespace EFT.SnowEnabler
{
    //class SnowEnablerPatch9 : Patch  // MAKES CHANGES TO SHARPNESS
    //{

    //    public SnowEnablerPatch9() : base(T: typeof(SnowEnablerPatch9), postfix: nameof(PostFixPatch))
    //    {
    //    }

    //    protected override MethodBase GetTargetMethod()
    //    {
    //        return typeof(EffectsController).GetMethod("OnRenderImage", BindingFlags.NonPublic | BindingFlags.Instance);
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
