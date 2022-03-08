using BepInEx;

namespace CWX_WeatherPatcher
{
    [BepInPlugin("com.CWX.WeatherPatcher", "CWX-WeatherPatcher", "3.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Start()
        {
            Logger.LogInfo("Loading: CWX-WeatherPatcher - V3.0.0");

            new CWX_WeatherPatch1().Enable();
            new CWX_WeatherPatch2().Enable();
            new CWX_WeatherPatch3().Enable();
            new CWX_WeatherPatch4().Enable();
        }
    }
}
