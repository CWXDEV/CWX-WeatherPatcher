using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common;


namespace EFT.SnowEnabler
{
    //class SnowEnablerPatch2 : Patch  // MAKES CHANGES TO GCLASS 1414
    //{

    //    public SnowEnablerPatch2() : base(T: typeof(SnowEnablerPatch2), postfix: nameof(PostFixPatch))
    //    {
    //    }

    //    protected override MethodBase GetTargetMethod()
    //    {
    //        return typeof(GClass1624).GetMethod("smethod_0", BindingFlags.NonPublic | BindingFlags.Static);
    //    }


    //    private static void PostFixPatch(ref GClass1624 __result)
    //    {
    //        __result.GlobalFogHeight = 0f;
    //        __result.Cloudness = -1f;
    //        __result.Wind = 0f;
    //        __result.Rain = 0f;
    //        __result.RainRandomness = 0f;
    //        __result.ScaterringFogDensity = 0.000f;
    //        __result.ScaterringFogHeight = 0f;
    //        __result.GlobalFogDensity = 0.000f;
    //        __result.LyingWater = 0f;
    //        __result.Turbulence = 0f;
    //        Log.Info("TURNED ON ALWAYS SUNNY!");
    //    }
    //}
}
