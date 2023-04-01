using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherInfo
{
    public class Session
    {
        public DateTime displayedMoment;
        public City displayedCity;

        public City CityRequest()
        {
            return new City();
        }

        public List<Forecast> ForecastRequest() // Если мы можем запрашивать с API прогноз на определенный день, или даже момент, то можно добавить атрибут DateTime moment 
        {
            return new List<Forecast>();
        }
    }
}
