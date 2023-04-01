using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherInfo
{
    public class Forecast
    {
        public readonly DateTime moment;
        public readonly int temperature;
        public readonly int feelingTemperature;
        public readonly Weather weather;
        public readonly int windSpeed;
        public readonly int pressure;
        public readonly int precipation;
    }

    public enum Weather
    {

    }
}
