using Newtonsoft.Json;

namespace WeatherForecastApp.Api
{
    public class WeatherInfo
    {
        [JsonProperty("main")]
        public string Main; // приходит только на английском. Возможно, можно использовать для создания соотвествия с картинкой.
        [JsonProperty("description")]
        public string Description;
    }
}
