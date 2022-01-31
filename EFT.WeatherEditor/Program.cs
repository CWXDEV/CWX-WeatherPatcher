using Aki.Common.Utils;
using EFT.WeatherEditor;

namespace EFT.WeatherPatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Log.Info("Loading: CWX WEATHERPATCHER");

            new CWX_WeatherPatch1().Enable();
            //new CWX_WeatherPatch2().Enable();
            new CWX_WeatherPatch3().Enable();
            new CWX_WeatherPatch4().Enable();
            new CWX_WeatherPatch5().Enable();
            //new CWX_WeatherPatch6().Enable();
            //new CWX_WeatherPatch7().Enable();
            //new CWX_WeatherPatch8().Enable();
            //new CWX_WeatherPatch9().Enable();
            //new CWX_WeatherPatch10().Enable();
        }
    }
}
