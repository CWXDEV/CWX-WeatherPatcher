using Aki.Common.Utils;

namespace CWX_WeatherPatcher
{
    public class Program
    {
        static void Main(string[] args)
        {
            Log.Info("Loading: CWX WEATHERPATCHER");
            new CWX_WeatherPatch1().Enable();
            new CWX_WeatherPatch2().Enable();
            new CWX_WeatherPatch3().Enable();
            new CWX_WeatherPatch4().Enable();
        }
    }
}
