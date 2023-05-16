using Newtonsoft.Json;

namespace WeatherForecastApp.Api
{
    public class WindData
    {
        [JsonProperty("speed")]
        public double WindSpeed;
        [JsonProperty("deg")]
        public int WindDegree;
    }
}
