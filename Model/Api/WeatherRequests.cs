using Newtonsoft.Json;
using System.Net.Http;
using WeatherForecastApp.Api;

namespace WeatherForecastApp.Model.Api
{
    public static class WeatherRequests
    {
        public static WeatherResponse GetCurrentWeatherData(string cityName)
        {
            return JsonConvert.DeserializeObject<WeatherResponse>(ProcessApiGetRequest($"/data/2.5/weather?q={cityName}&units=metric&lang=ru&appid={HttpData.apiKey}"));
        }

        public static WeatherResponseWrapper GetWeatherForecast(string cityName)
        {
            return JsonConvert.DeserializeObject<WeatherResponseWrapper>(ProcessApiGetRequest($"/data/2.5/forecast?q={cityName}&units=metric&lang=ru&appid={HttpData.apiKey}"));
        }

        private static string ProcessApiGetRequest(string request)
        {
            HttpResponseMessage response = HttpData.Client.GetAsync(request).Result;
            if (response.IsSuccessStatusCode) return response.Content.ReadAsStringAsync().Result;
            else return null;
        }
    }
}
