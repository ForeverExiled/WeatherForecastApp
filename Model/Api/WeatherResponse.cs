using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WeatherForecastApp.Api
{
    public class CurrentWeatherResponse
    {
        [JsonProperty("weather")]
        public List<WeatherInfo> Weather;
        [JsonProperty("main")]
        public MainInfo Main;
        [JsonProperty("wind")]
        public WindInfo Wind;
        [JsonProperty("dt")]
        public ulong Timestamp;
        [JsonProperty("timezone")]
        public ulong Timezone;
    }

    public class WeatherForecastResponse
    {
        [JsonProperty("list")]
        public List<TimestampInfo> Forecasts;
        [JsonProperty("city")]
        public CityInfo City;

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
}
