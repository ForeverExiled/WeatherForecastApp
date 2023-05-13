using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherForecastApp.Api;
using WeatherForecastApp.Database;

namespace WeatherForecastApp
{
    public partial class MainForm : Form
    {
        WeatherDBContext dbContext = new WeatherDBContext();

        public MainForm()
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
                deserializedObject.DateTime = DateTime.Now;
            }
        }

        void GetWeatherForecast(string cityName)
        {
            HttpResponseMessage response = HttpData.Client.GetAsync($"/data/2.5/forecast?q={cityName}&units=metric&lang=ru&appid={HttpData.apiKey}").Result;
            if (response.IsSuccessStatusCode)
            {
                var responseAsString = response.Content.ReadAsStringAsync().Result;
                var deserializedObject = JsonConvert.DeserializeObject<WeatherResponseWrapper>(responseAsString);
                foreach (var forecast in deserializedObject.Forecasts) forecast.DateTime = forecast.DateTime.AddSeconds(deserializedObject.City.Timezone);
            }
        }
    }
}
