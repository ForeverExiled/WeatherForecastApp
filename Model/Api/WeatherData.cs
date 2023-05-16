using Newtonsoft.Json;

namespace WeatherForecastApp.Api
{
    public class WeatherData
    {
        [JsonProperty("description")]
        public string Description;
        [JsonProperty("icon")]
        public string Icon;
    }
}
