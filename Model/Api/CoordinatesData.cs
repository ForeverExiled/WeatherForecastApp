using Newtonsoft.Json;

namespace WeatherForecastApp.Api
{
    public class CoordinatesData
    {
        [JsonProperty("lat")]
        public double Latitide;
        [JsonProperty("lon")]
        public double Longitude;
    }
}
