using BepInEx;
using CWX_WeatherPatch;
using EFT.Weather;

namespace CWX_WeatherPatcher
{
    [BepInPlugin("com.CWX.WeatherPatcher", "CWX-WeatherPatcher", "3.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            Logger.LogMessage("Loading: CWX-WeatherPatcher - V3.0.0");

            new CWX_WeatherPatch1().Enable();
            new CWX_WeatherPatch2().Enable();
            new CWX_WeatherPatch3().Enable();
            new CWX_WeatherPatch4().Enable();
            new CWX_WeatherPatch5().Enable();
        }

        public static void Fix()
        {
            var instance = WeatherController.Instance;
            if (instance != null)
            {
                instance.RainController.enabled = false;
                instance.LightningController.enabled = false;

                var debug = WeatherController.Instance.WeatherDebug;
                debug.Enabled = true;
                debug.CloudDensity = -1f;
                debug.Fog = 0f;
                debug.Rain = 0f;
                debug.LightningThunderProbability = 0f;
            }
        }
    }
}
