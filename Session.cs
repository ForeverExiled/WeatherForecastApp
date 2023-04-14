using System;
using System.Collections.Generic;
using System.Text;
using WeatherForecastApp.Api;

namespace WeatherForecastApp
{
    public class Session
    {
        public DateTime displayedMoment;
        public CityInfo displayedCity;

        public CityInfo CityRequest()
        {
            return new CityInfo();
        }

        public List<Forecast> ForecastRequest() // Если мы можем запрашивать с API прогноз на определенный день, или даже момент, то можно добавить атрибут DateTime moment 
        {
            return new List<Forecast>();
        }
    }
}
