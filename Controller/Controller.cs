using System;
using System.Collections.Generic;
using WeatherForecastApp.Api;
using WeatherForecastApp.Database;
using WeatherForecastApp.Model;
using WeatherForecastApp.Model.Api;
using WeatherForecastApp.Model.Database;

namespace WeatherForecastApp.Controller
{
    public class Controller
    {
        public CurrentWeatherResponseWrapper RequestApiCurrentGetCall(string cityName)
        {
            var deserializedResponse = ApiRequests.GetCurrentWeatherData(cityName);
            DatabaseQueries.GetCity(deserializedResponse.City);
            return deserializedResponse;
        }


        public WeatherForecastResponse RequestApiForecastGetCall(string cityName)
        {
            WeatherForecastResponse deserializedResponse = ApiRequests.GetWeatherForecast(cityName);
            RequestForecastDataInsertion(deserializedResponse);
            return deserializedResponse;
        }

        private void RequestForecastDataInsertion(WeatherForecastResponse data)
        {
            DatabaseQueries.InsertForecastData(data);
        }

        public List<City> RequestCityList()
        {
            List<City> list = DatabaseQueries.GetCityList();
            return list;
        }

        public string RequestIconPath(string iconName)
        {
            var iconPath = WeatherConditions.GetIconPath(iconName);
            return iconPath;
        }

        public string RequestWindDirection(int degree)
        {
            var direction = WindDirections.GetDirectionNameByDegree(degree);
            return direction;
        }

        public void RequestOldForecastDataDeletion(string cityId)
        {
            DatabaseQueries.RemoveOldForecastData(cityId);
        }

        public bool RequestForecastDataRelevanceCheck(string cityId)
        {
            return DatabaseQueries.IsForecastDataRelevant(cityId);
        }

        public WeatherForecastResponse RequestForecastData(string cityId)
        {
            var forecastData = DatabaseQueries.GetForecastList(cityId);
            var city = DatabaseQueries.GetCityById(cityId);
            var forecastsList = new List<TimestampData>();
            foreach (var forecast in forecastData)
            {
                var dt = (DateTime)forecast.Timestamp;
                var tsData = new TimestampData
                {
                    Main = new MainData
                    {
                        FeelsLike = (double)forecast.FeelsLike,
                        Temperature = (double)forecast.Temperature,
                        Humidity = (int)forecast.Humidity,
                        Pressure = (int)forecast.Pressure
                    },
                    Timestamp = ((DateTimeOffset)dt.AddSeconds((long)city.Timezone)).ToUnixTimeSeconds(),
                    Weather = new List<WeatherData>(),
                    Wind = new WindData
                    {
                        WindDegree = (int)forecast.WindDegree,
                        WindSpeed = (double)forecast.WindSpeed
                    }
                };
                tsData.Weather.Add(new WeatherData
                {
                    Description = forecast.Weather_Description,
                    Icon = forecast.Weather_Icon
                });
                forecastsList.Add(tsData);
            }
            var result = new WeatherForecastResponse
            {
                City = new CityData
                {
                    Timezone = (long)city.Timezone,
                    Coordinates = new CoordinatesData
                    {
                        Latitide = (double)city.Latitude,
                        Longitude = (double)city.Longitude
                    },
                    Id = city.Id,
                    Name = city.Name
                },
                Forecasts = forecastsList
            };
            return result;
        }
    }
}
