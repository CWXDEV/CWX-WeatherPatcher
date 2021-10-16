using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common;
using EFT.Weather;

namespace EFT.WeatherEditor
{
    class CWX_WeatherPatch5 : Patch  // TOD_scattering fog changes
    {

        public CWX_WeatherPatch5() : base(T: typeof(CWX_WeatherPatch5), postfix: nameof(PostFixPatch))
        {
        }

        protected override MethodBase GetTargetMethod()
        {
            return typeof(TOD_Scattering).GetMethod("Start", BindingFlags.NonPublic | BindingFlags.Instance);
        }


        private static void PostFixPatch(ref TOD_Scattering __instance)
        {
            __instance.GlobalDensity = 0f;
            __instance.HeightFalloff = 0f;
            Log.Info("CHANGED TOD_SCATTERING SETTINGS!");
        }
    }
}
