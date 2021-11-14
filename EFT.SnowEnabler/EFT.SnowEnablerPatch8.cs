using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common;
using EFT.Weather;
using System;

namespace EFT.SnowEnabler
{
    //class SnowEnablerPatch8 : Patch  // MAKES CHANGES TO WEATHERDEBUG - COPYPARAMS - 2ND
    //{

    //    public SnowEnablerPatch8() : base(T: typeof(SnowEnablerPatch8), postfix: nameof(PostFixPatch))
    //    {
    //    }

    //    protected override MethodBase GetTargetMethod()
    //    {
    //        return typeof(WeatherDebug).GetMethod("CopyParams", BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(IWeatherCurve)}, null);
    //    }


    //    private static void PostFixPatch(ref WeatherDebug __instance)
    //    {
    //        Log.Info("current when called:" + __instance.IsDynamicSunWeatherDebug.ToString());
    //        Log.Info("current when called:" + __instance.WindMagnitude.ToString());
    //        Log.Info("current when called:" + __instance.WindDirection.ToString());
    //        Log.Info("current when called:" + __instance.TopWindDirection.ToString());
    //        Log.Info("current when called:" + __instance.CloudDensity.ToString());
    //        Log.Info("current when called:" + __instance.Fog.ToString());
    //        Log.Info("current when called:" + __instance.Rain.ToString());
    //        Log.Info("current when called:" + __instance.LightningThunderProbability.ToString());
    //        Log.Info("current when called:" + __instance.Temperature.ToString());

    //        Log.Info("----------------------------------------------------------------");
    //    }
    //}
}
