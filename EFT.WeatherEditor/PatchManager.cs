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
                new CWX_WeatherPatch1(),       // MAKES CHANGES TO GClass1638 SMETHOD_1
                new CWX_WeatherPatch2(),       // MAKES CHANGES TO GClass1638 SMETHOD_0
                new CWX_WeatherPatch3(),       // MAKES CHANGES TO CUSTOMGLOBALFOG
                new CWX_WeatherPatch4(),       // MAKES CHANGES TO LEVELSETTINGS
                new CWX_WeatherPatch5(),       // MAKES CHANGES TO TOD_SCATTERING FOG
                new CWX_WeatherPatch6(),       // MAKES CHANGES TO GClass1638 SMETHOD_2
                new CWX_WeatherPatch7(),       // MAKES CHANGES TO GClass1638 CREATEDEFAULT
                //new CWX_WeatherPatch8(),       // testing copyparams in weatherdebug 1st method
                //new CWX_WeatherPatch9(),       // checking sharpness settings
                //new CWX_WeatherPatch10(),        // testing winterscript stuff
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
