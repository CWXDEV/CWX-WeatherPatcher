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
                new CWX_WeatherPatch1(),
                new CWX_WeatherPatch2()
                //new CWX_WeatherPatch3()
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
