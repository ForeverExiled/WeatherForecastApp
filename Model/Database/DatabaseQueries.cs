using System;
using System.Collections.Generic;
using System.Linq;
using WeatherForecastApp.Api;
using WeatherForecastApp.Database;

namespace WeatherForecastApp.Model.Database
{
    public static class DatabaseQueries
    {
        private static WeatherDBContext dbContext = new WeatherDBContext();
        public static event EventHandler NewCityAdded;

        public static void InsertForecastData(WeatherForecastResponse deserializedResponse)
        {
            DateTime requestTime = DateTime.Now;
            var city = GetCity(deserializedResponse.City);
            foreach (var forecast in deserializedResponse.Forecasts)
            {
                var dbForecast = new Forecast()
                {
                    Temperature = (int)Math.Round(forecast.Main.Temperature),
                    FeelsLike = (int)Math.Round(forecast.Main.FeelsLike),
                    Pressure = forecast.Main.Pressure,
                    Humidity = forecast.Main.Humidity,
                    WindSpeed = (int)Math.Round(forecast.Wind.WindSpeed),
                    WindDegree = forecast.Wind.WindDegree,
                    Weather_Description = forecast.Weather[0].Description,
                    Weather_Icon = forecast.Weather[0].Icon,
                    FkCity = city.Id,
                    Timestamp = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(forecast.Timestamp),
                    RequestTime = requestTime
                };
                dbContext.Forecasts.Add(dbForecast);
            }
            dbContext.SaveChanges();
        }

        public static City GetCity(CityData cityData)
        {
            var city = (City)dbContext.Find(typeof(City), cityData.Id);
            if (city == null) city = InsertCityData(cityData);
            return city;
        }

        private static City InsertCityData(CityData cityData)
        {
            var city = new City()
            {
                Id = cityData.Id,
                Name = cityData.Name,
                Latitude = cityData.Coordinates.Latitide,
                Longitude = cityData.Coordinates.Longitude,
                Timezone = cityData.Timezone
            };
            dbContext.Cities.Add(city);
            dbContext.SaveChanges();
            NewCityAdded?.Invoke(null, EventArgs.Empty);
            return city;
        }

        public static List<City> GetCityList()
        {
            List<City> list = dbContext.Cities.OrderBy(city => city.Name).ToList();
            return list;
        }

        public static void RemoveOldForecastData(string cityId)
        {
            List<Forecast> entries = GetForecastList(cityId);
            foreach (var forecast in entries) dbContext.Forecasts.Remove(forecast);
            dbContext.SaveChanges();
        }

        public static List<Forecast> GetForecastList(string cityId)
        {
            List<Forecast> list = dbContext.Forecasts
                .Where(forecast => forecast.FkCity == int.Parse(cityId))
                .OrderBy(Forecast => Forecast.Timestamp)
                .ToList();
            return list;
        }

        public static bool IsForecastDataRelevant(string cityId)
        {
            var entry = dbContext.Forecasts.Where(forecast => forecast.FkCity == int.Parse(cityId)).FirstOrDefault();    
            return !(entry == null || (DateTime.Now - entry.RequestTime.Value).Days > 0);
        }
    }
}
