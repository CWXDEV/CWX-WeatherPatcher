using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common;

namespace EFT.WeatherEditor
{
    class CWX_WeatherPatch3 : Patch  // MAKES CHANGES TO CUSTOMGLOBALFOG
    {

        public CWX_WeatherPatch3() : base(T: typeof(CWX_WeatherPatch3), postfix: nameof(PostFixPatch))
        {
        }

        protected override MethodBase GetTargetMethod()
        {
            return typeof(CustomGlobalFog).GetMethod("Start", BindingFlags.NonPublic | BindingFlags.Instance);
        }


        private static void PostFixPatch(ref CustomGlobalFog __instance)
        {
            __instance.FuncStart = 0f;
            Log.Info("MADE CHANGES TO CUSTOMGLOBALFOG!");
        }
    }
}
