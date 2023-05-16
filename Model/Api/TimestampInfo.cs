using Newtonsoft.Json;
using System.Collections.Generic;
using WeatherForecastApp.Api;

namespace WeatherForecastApp.Model.Api
{
    public class TimestampInfo
    {
        [JsonProperty("dt")]
        public ulong Timestamp;
        [JsonProperty("main")]
        public MainInfo Main;
        [JsonProperty("weather")]
        public List<WeatherInfo> Weather;
        [JsonProperty("wind")]
        public WindInfo Wind;
    }
}
