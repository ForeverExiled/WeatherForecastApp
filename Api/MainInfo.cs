using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherForecastApp.Api
{
    internal class MainInfo
    {
        [JsonProperty("temp")]
        public double Temperature;
        [JsonProperty("feels_like")]
        public double FeelsLike;
        [JsonProperty("pressure")]
        public int Pressure;
        [JsonProperty("humidity")]
        public int Humidity;
    }
}
