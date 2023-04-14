using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherForecastApp.Api
{
    internal class WeatherInfo
    {
        [JsonProperty("main")]
        string Main; // приходит только на английском. Возможно, можно использовать для создания соотвествия с картинкой.
        [JsonProperty("description")]
        string Description;
    }
}
