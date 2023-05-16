﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WeatherForecastApp.Api;
using WeatherForecastApp.Database;
using WeatherForecastApp.Model.Api;
using WeatherForecastApp.Model.Database;

namespace WeatherForecastApp.Controller
{
    public class Controller
    {
        public CurrentWeatherResponse RequestApiCurrentGetCall(string cityName)
        {
            var deserializedResponse = ApiRequests.GetCurrentWeatherData(cityName);
            return deserializedResponse;
        }

        public WeatherForecastResponse RequestApiForecastGetCall(string cityName)
        {
            WeatherForecastResponse deserializedResponse = ApiRequests.GetWeatherForecast(cityName);
            RequestForecastDataInsertion(deserializedResponse);
            return deserializedResponse;
        }

        public void RequestForecastDataInsertion(WeatherForecastResponse data)
        {
            DatabaseQueries.InsertForecastData(data);
        }

        public List<City> RequestCityList()
        {
            List<City> list = DatabaseQueries.GetCityList();
            return list;
        }
    }
}
