using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherForecastApp.Api
{
    public class CityInfo
    {
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("lat")]
        public double Latitide;
        [JsonProperty("lon")]
        public double Longitude;
        [JsonProperty("timezone")]
        public int Timezone;
    }
}
