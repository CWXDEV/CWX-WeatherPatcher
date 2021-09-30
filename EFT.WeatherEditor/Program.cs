using Aki.Common;
using Aki.Reflection.Patching;

namespace EFT.WeatherPatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Log.Info("Loading: CWX WeatherPatcher");
            new PatchManager().RunPatches();
        }
    }
}
