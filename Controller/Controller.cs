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

        public List<Forecast> GetForecastList(string cityId)
        {
            return DatabaseQueries.GetForecastList(cityId);
        }
    }
}
