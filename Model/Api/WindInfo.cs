using Newtonsoft.Json;

namespace WeatherForecastApp.Api
{
    public class WindInfo
    {
        [JsonProperty("speed")]
        public double WindSpeed;
        [JsonProperty("deg")]
        public int WindDegree;
    }
}
