using Newtonsoft.Json;

namespace WeatherForecastApp.Api
{
    public class WeatherInfo
    {
        [JsonProperty("description")]
        public string Description;
        [JsonProperty("icon")]
        public string Icon;
    }
}
