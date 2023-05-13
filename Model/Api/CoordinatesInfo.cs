using Newtonsoft.Json;

namespace WeatherForecastApp.Api
{
    public class CoordinatesInfo
    {
        [JsonProperty("lat")]
        public double Latitide;
        [JsonProperty("lon")]
        public double Longitude;
    }
}
