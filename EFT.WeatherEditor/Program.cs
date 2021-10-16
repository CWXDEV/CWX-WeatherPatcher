using Aki.Common;

namespace EFT.WeatherPatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Log.Info("Loading: CWX WEATHERPATCH");
            new PatchManager().RunPatches();
        }
    }
}
