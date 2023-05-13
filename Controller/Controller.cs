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

        public WeatherResponse RequestApiCurrentGetCall(string cityName)
        {
            return WeatherRequests.GetCurrentWeatherData(cityName);
        }

        public WeatherResponseWrapper RequestApiForecastGetCall(string cityName)
        {
            WeatherResponseWrapper deserializedResponse = WeatherRequests.GetWeatherForecast(cityName);
            RequestDataInsertion(deserializedResponse, DateTime.Now);
            return deserializedResponse;
        }

        public void RequestDataInsertion(WeatherResponseWrapper data, DateTime requestTime)
        {
            DatabaseQueries.InsertIntoDatabase(data, requestTime);
        }
    }
}
