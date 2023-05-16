using Newtonsoft.Json;

namespace WeatherForecastApp.Api
{
    public class MainData
    {
        [JsonProperty("temp")]
        public double Temperature;
        [JsonProperty("feels_like")]
        public double FeelsLike;
        [JsonProperty("pressure")]
        public int Pressure;
        [JsonProperty("humidity")]
        public int Humidity;
    }
}
