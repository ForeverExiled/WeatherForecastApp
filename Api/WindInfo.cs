using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherForecastApp.Api
{
    internal class WindInfo
    {
        [JsonProperty("Speed")]
        public double WindSpeed;
        [JsonProperty("Deg")]
        public int WindDegree;
    }
}
