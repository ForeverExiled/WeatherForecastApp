using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows.Forms;
using WeatherForecastApp.Api;
using WeatherForecastApp.Database;

namespace WeatherForecastApp
{
    public partial class Window : Form
    {
        WeatherDBContext dbContext = new WeatherDBContext();

        public Window()
        {
            InitializeComponent();

            
            string cityName = "Тюмень"; // в запросе можно сразу указывать название города, api поймёт. На русском тоже.
            //GetCurrentWeatherData(cityName);
            //GetWeatherForecast(cityName);
        }

        // ПРОСТО ПОКА ПОМЕСТИЛ ТУТ ДЛЯ ТЕСТА
        void GetCurrentWeatherData(string cityName)
        {
            HttpResponseMessage response = HttpData.Client.GetAsync($"/data/2.5/weather?q={cityName}&units=metric&lang=ru&appid={HttpData.apiKey}").Result;
            if (response.IsSuccessStatusCode)
            {
                var text = response.Content.ReadAsStringAsync().Result;
                var deserializedObject = JsonConvert.DeserializeObject<WeatherResponse>(text);
                deserializedObject.Timestamp = DateTime.Now;
            }
        }

        void GetWeatherForecast(string cityName)
        {
            var requestTime = DateTime.Now;
            HttpResponseMessage response = HttpData.Client.GetAsync($"/data/2.5/forecast?q={cityName}&units=metric&lang=ru&appid={HttpData.apiKey}").Result;
            if (response.IsSuccessStatusCode)
            {
                var responseAsString = response.Content.ReadAsStringAsync().Result;
                var deserializedObject = JsonConvert.DeserializeObject<WeatherResponseWrapper>(responseAsString);
                var city = (City)dbContext.Find(typeof(City), deserializedObject.City.Id);
                if (city is null)
                {
                    city = new City()
                    {
                        Id = deserializedObject.City.Id,
                        Name = deserializedObject.City.Name,
                        Latitude = deserializedObject.City.Coordinates.Latitide,
                        Longitude = deserializedObject.City.Coordinates.Longitude,
                        Timezone = deserializedObject.City.Timezone
                    };
                    dbContext.Cities.Add(city);
                }
                foreach (var forecast in deserializedObject.Forecasts)
                {
                    var dbForecast = new Forecast()
                    {
                        Temperature = (int)Math.Round(forecast.Main.Temperature),
                        FeelsLike = (int)Math.Round(forecast.Main.FeelsLike),
                        Pressure = forecast.Main.Pressure,
                        Humidity = forecast.Main.Humidity,
                        WindSpeed = (int)Math.Round(forecast.Wind.WindSpeed),
                        WindDegree = forecast.Wind.WindDegree,
                        Weather = forecast.Weather[0].Main,
                        Weather_Description = forecast.Weather[0].Description,
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
}
