﻿using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common.Utils;
using System.Diagnostics;

namespace CWX_WeatherPatcher
{
    class CWX_WeatherPatch2 : ModulePatch  // MAKES CHANGES TO CUSTOMGLOBALFOG
    {

        protected override MethodBase GetTargetMethod()
        {
            return typeof(CustomGlobalFog).GetMethod("Start", BindingFlags.NonPublic | BindingFlags.Instance);
        }

        [PatchPostfix]
        private static void PostFixPatch(ref CustomGlobalFog __instance)
        {
            __instance.FuncStart = 0f;
            Log.Info("MADE CHANGES TO CUSTOMGLOBALFOG!");
        }
    }
}
