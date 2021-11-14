using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common;

namespace EFT.SnowEnabler
{
    //class SnowEnablerPatch3 : Patch  // MAKES CHANGES TO CUSTOMGLOBALFOG
    //{

    //    public SnowEnablerPatch3() : base(T: typeof(SnowEnablerPatch3), postfix: nameof(PostFixPatch))
    //    {
    //    }

    //    protected override MethodBase GetTargetMethod()
    //    {
    //        return typeof(CustomGlobalFog).GetMethod("Start", BindingFlags.NonPublic | BindingFlags.Instance);
    //    }


    //    private static void PostFixPatch(ref CustomGlobalFog __instance)
    //    {
    //        Log.Info("TURNED OFF THE GLOBAL FOG!");
    //        __instance.FuncStart = 0f;
    //    }
    //}
}
