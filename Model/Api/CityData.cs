using Newtonsoft.Json;

namespace WeatherForecastApp.Api
{
    public class CityData
    {
        [JsonProperty("id")]
        public int Id;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("coord")]
        public CoordinatesData Coordinates;
        [JsonProperty("timezone")]
        public long Timezone;
    }
}
