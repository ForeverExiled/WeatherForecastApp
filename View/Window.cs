using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using WeatherForecastApp.Model;

namespace WeatherForecastApp
{
    public partial class Window : Form
    {
        private Controller.Controller Controller;
        private string CityName;

        public Window()
        {
            InitializeComponent();
            Controller = new Controller.Controller(this);

            comboBoxLocationList.SelectedIndex = 0;
            CityName = comboBoxLocationList.SelectedItem.ToString();
            //GetWeatherForecast(cityName);
        }

        void GetWeatherForecast(string cityName)
        {
            var data = Controller.RequestApiForecastGetCall(cityName);
        }

        private void buttonGetCurrentWeather_Click(object sender, System.EventArgs e)
        {
            var data = Controller.RequestApiCurrentGetCall(CityName);
            pictureBoxWeatherConditionIcon.Image = new Bitmap(WeatherConditions.GetIconPath(data.Weather[0].Icon));
            var dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(data.Timestamp + data.Timezone);
            labelCurrentWeatherDateTime.Text = dt.ToString("t", new CultureInfo("ru-RU")) + "\n"
                + dt.ToString("dddd", new CultureInfo("ru-RU")) + "\n"
                + dt.ToString("M", new CultureInfo("ru-RU"));
            labelFeelsLike.Text = Math.Round(data.Main.FeelsLike).ToString() + " °C";
            labelTemperature.Text = Math.Round(data.Main.Temperature).ToString() + " °C";
            labelHumidity.Text = data.Main.Humidity.ToString() + " %";
            labelPressure.Text = data.Main.Pressure.ToString() + " hPa";
            labelWeatherDescription.Text = data.Weather[0].Description;
            labelWindInfo.Text = Math.Round(data.Wind.WindSpeed).ToString() + " м/с, " + WindDirections.GetDirectionNameByDegree(data.Wind.WindDegree);
        }
    }
}
