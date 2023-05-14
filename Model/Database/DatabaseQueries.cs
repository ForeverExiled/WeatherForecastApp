using System;
using WeatherForecastApp.Api;
using WeatherForecastApp.Database;

namespace WeatherForecastApp.Model.Database
{
    public static class DatabaseQueries
    {
        private static WeatherDBContext dbContext = new WeatherDBContext();

        public static void InsertIntoDatabase(WeatherResponseWrapper deserializedResponse, DateTime requestTime)
        {
            var city = (City)dbContext.Find(typeof(City), deserializedResponse.City.Id);
            if (city is null)
            {
                city = new City()
                {
                    Id = deserializedResponse.City.Id,
                    Name = deserializedResponse.City.Name,
                    Latitude = deserializedResponse.City.Coordinates.Latitide,
                    Longitude = deserializedResponse.City.Coordinates.Longitude,
                    Timezone = deserializedResponse.City.Timezone
                };
                dbContext.Cities.Add(city);
            }
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
                    Timestamp = forecast.Timestamp,
                    RequestTime = requestTime
                };
                dbContext.Forecasts.Add(dbForecast);
            }
            dbContext.SaveChanges();
        }
    }
}
