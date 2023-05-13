using Newtonsoft.Json;
using System;
using System.Net.Http;
using WeatherForecastApp.Api;

namespace WeatherForecastApp.Model.Api
{
    public static class WeatherRequests
    {
        public static WeatherResponse GetCurrentWeatherData(string cityName)
        {
            WeatherResponse deserializedResponse = null;
            HttpResponseMessage response = HttpData.Client.GetAsync($"/data/2.5/weather?q={cityName}&units=metric&lang=ru&appid={HttpData.apiKey}").Result;
            if (response.IsSuccessStatusCode)
            {
                var responseAsString = response.Content.ReadAsStringAsync().Result;
                deserializedResponse = JsonConvert.DeserializeObject<WeatherResponse>(responseAsString);
            }
            return deserializedResponse;
        }

        public static WeatherResponseWrapper GetWeatherForecast(string cityName)
        {
            WeatherResponseWrapper deserializedResponse = null;
            var requestTime = DateTime.Now;
            HttpResponseMessage response = HttpData.Client.GetAsync($"/data/2.5/forecast?q={cityName}&units=metric&lang=ru&appid={HttpData.apiKey}").Result;
            if (response.IsSuccessStatusCode)
            {
                var responseAsString = response.Content.ReadAsStringAsync().Result;
                deserializedResponse = JsonConvert.DeserializeObject<WeatherResponseWrapper>(responseAsString);
            }
            return deserializedResponse;
        }
    }
}
