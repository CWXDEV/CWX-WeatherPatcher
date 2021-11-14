using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Common;
using EFT.Weather;

namespace EFT.SnowEnabler
{
    class SnowEnablerPatch1 : Patch  // MAKES CHANGES TO WEATHERDEBUG
    {

        public SnowEnablerPatch1() : base(T: typeof(SnowEnablerPatch1), postfix: nameof(PostFixPatch))
        {
        }

        protected override MethodBase GetTargetMethod()
        {
            return typeof(GClass697).GetMethod("Awake", BindingFlags.Public | BindingFlags.Instance);
        }


        private static void PostFixPatch(ref GClass697)
        {
          
            Log.Info("TURNED ON CUSTOM DEBUG SETTINGS!");

        }
    }
}
