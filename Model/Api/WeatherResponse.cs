using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WeatherForecastApp.Api
{
    public class WeatherResponse
    {
        [JsonProperty("main")]
        public MainInfo Main;
        [JsonProperty("wind")]
        public WindInfo Wind;
        [JsonProperty("weather")]
        public List<WeatherInfo> Weather;
        [JsonProperty("dt_txt")]
        public DateTime Timestamp;
    }

    public class WeatherResponseWrapper
    {
        [JsonProperty("list")]
        public List<WeatherResponse> Forecasts;
        [JsonProperty("city")]
        public CityInfo City;
    }
}
