using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common;
using EFT.Weather;

namespace EFT.WeatherEditor
{
    class CWX_WeatherPatch6 : Patch  // WEATHERCONTROLLER ENABLED WEATHERDEBUG
    {

        public CWX_WeatherPatch6() : base(T: typeof(CWX_WeatherPatch6), postfix: nameof(PostFixPatch))
        {
        }

        protected override MethodBase GetTargetMethod()
        {
            return typeof(WeatherController).GetMethod("method_0", BindingFlags.NonPublic | BindingFlags.Instance);
        }


        private static void PostFixPatch(ref WeatherController __instance)
        {
            __instance.WeatherDebug.Enabled = true;
            Log.Info("CHANGED WEATHERDEBUG TO TRUE!");
        }
    }
}
