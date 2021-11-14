using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common;
using EFT.Weather;

namespace EFT.SnowEnabler
{
    //class SnowEnablerPatch5 : Patch  // TOD_scattering fog changes
    //{

    //    public SnowEnablerPatch5() : base(T: typeof(SnowEnablerPatch5), postfix: nameof(PostFixPatch))
    //    {
    //    }

    //    protected override MethodBase GetTargetMethod()
    //    {
    //        return typeof(TOD_Scattering).GetMethod("Start", BindingFlags.NonPublic | BindingFlags.Instance);
    //    }


    //    private static void PostFixPatch(ref TOD_Scattering __instance)
    //    {
    //        __instance.GlobalDensity = 0f;
    //        __instance.HeightFalloff = 0f;
    //        Log.Info("CHANGED TOD_SCATTERING SETTINGS!");
    //    }
    //}
}
