using Aki.Reflection.Patching;

namespace EFT.SnowEnabler
{
    public class PatchManager
    {
        public PatchManager()
        {
            PatchList patchlist = new PatchList
            {
                new SnowEnablerPatch1()     // WeatherDebug-method_0
                //new SnowEnablerPatch2(),     // GClass1414
                //new SnowEnablerPatch3(),     // CustomGlobalFog
                //new SnowEnablerPatch4(),     // WeatherDebug-CopyParams
                //new SnowEnablerPatch5(),     // looking for weather update time
                //new SnowEnablerPatch6(),     // WEATHERCONTROLLER ENABLED WEATHERDEBUG
                //new SnowEnablerPatch7(),     // testing copyparams in weatherdebug 2nd method
                //new SnowEnablerPatch8(),     // testing copyparams in weatherdebug 1st method
                //new SnowEnablerPatch9()      // checking sharpness settings
            };
            this._patches = patchlist;
        }

        public void RunPatches()
        {
            this._patches.EnableAll();
        }

        private readonly PatchList _patches;
    }
}
