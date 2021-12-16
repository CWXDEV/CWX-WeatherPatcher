using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common;

namespace EFT.WeatherEditor
{
    class CWX_WeatherPatch10 : Patch  // testing winterscript stuff
    {

        public CWX_WeatherPatch10() : base(T: typeof(CWX_WeatherPatch10), postfix: nameof(PostFixPatch))
        {
        }

        protected override MethodBase GetTargetMethod()
        {
            return typeof(WinterScript).GetMethod("Start", BindingFlags.NonPublic | BindingFlags.Instance);
        }


        private static void PostFixPatch(ref WinterScript __instance)
        {
            Log.Info("WINTERSCRIPT IS READ!");
        }
    }
}
