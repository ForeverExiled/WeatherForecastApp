using System;
using System.Windows.Forms;
using WeatherForecastApp.Api;
using WeatherForecastApp.Model.Api;
using WeatherForecastApp.Model.Database;

namespace WeatherForecastApp.Controller
{
    public class Controller
    {
        private Form View;

        public Controller(Form view)
        {
            View = view;
        }

        public CurrentWeatherResponse RequestApiCurrentGetCall(string cityName)
        {
            return WeatherRequests.GetCurrentWeatherData(cityName);
        }

        public WeatherForecastResponse RequestApiForecastGetCall(string cityName)
        {
            WeatherForecastResponse deserializedResponse = WeatherRequests.GetWeatherForecast(cityName);
            RequestDataInsertion(deserializedResponse, DateTime.Now);
            return deserializedResponse;
        }

        public void RequestDataInsertion(WeatherForecastResponse data, DateTime requestTime)
        {
            DatabaseQueries.InsertIntoDatabase(data, requestTime);
        }
    }
}
