using Newtonsoft.Json;

namespace WeatherForecastApp.Api
{
    public class WindInfo
    {
        [JsonProperty("Speed")]
        public double WindSpeed;
        [JsonProperty("Deg")]
        public int WindDegree;
    }
}
