using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common.Utils;
using Aki.Reflection.Utils;
using System.Linq;

//namespace EFT.WeatherEditor
//{
//    class CWX_WeatherPatch2 : ModulePatch  // MAKES CHANGES TO GClass1677 SMETHOD_0
//    {
//        protected override MethodBase GetTargetMethod()
//        {
//            var flags = BindingFlags.NonPublic | BindingFlags.Static;
//            var methodName = "smethod_0";

//            foreach (var matchingType in PatchConstants.EftTypes.Where(x => x.GetMethod(methodName, flags) != null))
//            {
//                foreach (var method in matchingType.GetMethods(flags))
//                {
//                    if (IsTargetMethod(method))
//                    {
//                        return matchingType.GetMethod(methodName);
//                    }
//                    Log.Error($"method: {method}");
//                }
//                Log.Error($"matchingTypes: {matchingType}");
//            }
//            Log.Error("CWX_WeatherPatch2() didnt find target method");
//            return null;


//            // return typeof(GClass1677).GetMethod("smethod_0", BindingFlags.NonPublic | BindingFlags.Static);
//        }

//        private static bool IsTargetMethod(MethodInfo mi)
//        {
//            var parameters = mi.GetParameters();
//            return parameters.Length == 1
//                && parameters[0].Name == "dateTime";
//        }

//        [PatchPostfix]
//        private static void PostFixPatch(ref GClass1677 __result)
//        {
//            __result.Cloudness = 0f;
//            __result.WindDirection = 8;
//            __result.Wind = 0f;
//            __result.Rain = 2f;
//            __result.RainRandomness = 0f;
//            __result.ScaterringFogDensity = 0f;
//            __result.GlobalFogDensity = 0f;
//            __result.GlobalFogHeight = 0f;

//            Log.Info("MADE CHANGES TO GClass1677 SMETHOD_0!");
//        }
//    }
//}
