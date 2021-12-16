using Aki.Reflection.Utils;
using System.Linq;
using System.Reflection;
using Patch = Aki.Reflection.Patching.Patch;
using Aki.Common;

namespace EFT.WeatherEditor
{
    class CWX_WeatherPatch9 : Patch // MAKES CHANGES TO SHARPNESS
    {
        public CWX_WeatherPatch9() : base(T: typeof(CWX_WeatherPatch9), postfix: nameof(PostFixPatch))
        {
        }

        protected override MethodBase GetTargetMethod()
        {
            return typeof(GClass873).GetMethods(Constants.PrivateFlags).FirstOrDefault(m => m.Name.Contains("method_0"));
        }

        private static void PostFixPatch(int x)
        {
            Log.Info("test test");
            
        }
    }
}
