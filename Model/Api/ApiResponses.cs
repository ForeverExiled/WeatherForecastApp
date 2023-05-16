using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using WeatherForecastApp.Model.Api;

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
    }

    public class WeatherForecastResponse
    {
        [JsonProperty("list")]
        public List<TimestampInfo> Forecasts;
        [JsonProperty("city")]
        public CityInfo City;
    }
}
