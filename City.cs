using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherInfo
{
    public class City
    {
        public readonly string name;
        public readonly double latitide;
        public readonly double longitude;
        public readonly List<Forecast> forecaststs;
    }
}
