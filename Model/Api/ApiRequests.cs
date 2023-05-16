using Newtonsoft.Json;
using System.Net.Http;
using WeatherForecastApp.Api;

namespace WeatherForecastApp.Model.Api
{
    public static class ApiRequests
    {
        public static CurrentWeatherResponseWrapper GetCurrentWeatherData(string cityName)
        {
            var responseAsString = ProcessApiGetRequest($"/data/2.5/weather?q={cityName}&units=metric&lang=ru&appid={HttpData.apiKey}");
            var currentWeatherData = JsonConvert.DeserializeObject<CurrentWeatherResponse>(responseAsString);
            var cityInfo = JsonConvert.DeserializeObject<CityData>(responseAsString);
            return new CurrentWeatherResponseWrapper(currentWeatherData, cityInfo);
        }

        public static WeatherForecastResponse GetWeatherForecast(string cityName)
        {
            var responseAsString = ProcessApiGetRequest($"/data/2.5/forecast?q={cityName}&units=metric&lang=ru&appid={HttpData.apiKey}");
            var forecastDate = JsonConvert.DeserializeObject<WeatherForecastResponse>(responseAsString);
            return forecastDate;
        }

        private static string ProcessApiGetRequest(string request)
        {
            HttpResponseMessage response = HttpData.Client.GetAsync(request).Result;
            string processedResponse = null;
            if (response.IsSuccessStatusCode) processedResponse = response.Content.ReadAsStringAsync().Result;
            return processedResponse;
        }
    }
}
