using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherForecastApp.Api
{
    internal class WeatherResponse
    {
        [JsonProperty("main")]
        public MainInfo Main;
        [JsonProperty("wind")]
        public WindInfo Wind;
        [JsonProperty("weather")]
        public List<WeatherInfo> Weather;
        [JsonProperty("dt_txt")]
        public DateTime DateTime; // без таймзоны
    }

    internal class WeatherResponseWrapper
    {
        [JsonProperty("list")]
        public List<WeatherResponse> Forecasts;
        [JsonProperty("city")]
        public CityInfo City;
    }
}
