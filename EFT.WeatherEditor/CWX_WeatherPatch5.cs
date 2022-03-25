using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Reflection.Utils;
using CWX_WeatherPatcher;
using EFT;

namespace CWX_WeatherPatch
{
    public class CWX_WeatherPatch5 : ModulePatch
    {
        protected override MethodBase GetTargetMethod()
        {
            var result = typeof(MainApplication).GetMethod("method_41", PatchConstants.PrivateFlags);

            return result;
        }

        [PatchPostfix]
        private static void PatchPostFix()
        {
            Plugin.Fix();
        }
    }
}