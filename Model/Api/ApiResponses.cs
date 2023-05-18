using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using WeatherForecastApp.Model.Api;

namespace WeatherForecastApp.Api
{
    public class CurrentWeatherResponse
    {
        [JsonProperty("weather")]
        public List<WeatherData> Weather;
        [JsonProperty("main")]
        public MainData Main;
        [JsonProperty("wind")]
        public WindData Wind;
        [JsonProperty("dt")]
        public long Timestamp;
    }

    public class CurrentWeatherResponseWrapper
    {
        public CurrentWeatherResponse CurrentWeatherResponse;
        public CityData City;

        public CurrentWeatherResponseWrapper(CurrentWeatherResponse currentWeatherResponse, CityData city)
        {
            CurrentWeatherResponse = currentWeatherResponse;
            City = city;
        }
    }

    public class WeatherForecastResponse
    {
        [JsonProperty("list")]
        public List<TimestampData> Forecasts;
        [JsonProperty("city")]
        public CityData City;
    }
}
