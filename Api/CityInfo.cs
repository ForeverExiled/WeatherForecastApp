using Newtonsoft.Json;

namespace WeatherForecastApp.Api
{
    public class CityInfo
    {
        [JsonProperty("id")]
        public int Id;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("coord")]
        public CoordinatesInfo Coordinates;
        [JsonProperty("timezone")]
        public int Timezone;
    }
}
