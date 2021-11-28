using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common;
using EFT.Weather;

namespace EFT.SnowEnabler
{
    //class SnowEnablerPatch4 : Patch  // EDITS COPYPARAMS IN WEATHERDEBUG
    //{

    //    public SnowEnablerPatch4() : base(T: typeof(SnowEnablerPatch4), postfix: nameof(PostFixPatch))
    //    {
    //    }

    //    protected override MethodBase GetTargetMethod()
    //    {
    //        return typeof(LevelSettings).GetMethod("ApplySettings", BindingFlags.Public | BindingFlags.Instance);
    //    }


    //    private static void PostFixPatch(ref LevelSettings __instance)
    //    {
    //        __instance.fog = false;
    //        __instance.fogEndDistance = 0f;
    //        Log.Info("CHANGED LEVELSETTINGS SETTINGS!");
    //    }
    //}
}
