using Newtonsoft.Json;
using System.Collections.Generic;
using WeatherForecastApp.Api;

namespace WeatherForecastApp.Model.Api
{
    public class TimestampData
    {
        [JsonProperty("dt")]
        public ulong Timestamp;
        [JsonProperty("main")]
        public MainData Main;
        [JsonProperty("weather")]
        public List<WeatherData> Weather;
        [JsonProperty("wind")]
        public WindData Wind;
    }
}
