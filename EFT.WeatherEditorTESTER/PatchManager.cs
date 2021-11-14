using Aki.Reflection.Patching;
using EFT.WeatherEditor;

namespace EFT.WeatherPatch
{
    public class PatchManager
    {
        public PatchManager()
        {
            PatchList patchlist = new PatchList
            {
                //new CWX_WeatherPatch1(),     // WeatherDebug-method_0
                new CWX_WeatherPatch2(),     // GClass1414
                new CWX_WeatherPatch3()      // CustomGlobalFog
                //new CWX_WeatherPatch4(),     // WeatherDebug-CopyParams
                //new CWX_WeatherPatch5(),     // looking for weather update time
                //new CWX_WeatherPatch6(),     // WEATHERCONTROLLER ENABLED WEATHERDEBUG
                //new CWX_WeatherPatch7(),     // testing copyparams in weatherdebug 2nd method
                //new CWX_WeatherPatch8(),     // testing copyparams in weatherdebug 1st method
                //new CWX_WeatherPatch9()      // checking sharpness settings
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
