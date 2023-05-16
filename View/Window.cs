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
        private Controller.Controller Controller = new Controller.Controller();

        public Window()
        {
            InitializeComponent();
            LoadCities();
            comboBoxLocationList.SelectedIndex = 0;
            //GetWeatherForecast();
        }

        private void LoadCities()
        {
            var cityList = Controller.RequestCityList();
            comboBoxLocationList.DisplayMember = "Name";
            comboBoxLocationList.ValueMember = "Id";
            comboBoxLocationList.DataSource = cityList;
        }

        private void buttonGetCurrentWeather_Click(object sender, System.EventArgs e)
        {
            var data = Controller.RequestApiCurrentGetCall(comboBoxLocationList.Text);
            if (data != null)
            {
                pictureBoxWeatherConditionIcon.Image = new Bitmap(WeatherConditions.GetIconPath(data.Weather[0].Icon));
                var dt = DateTime.Now;
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
            else MessageBox.Show("Ошибка при попытке получения данных.", "Данные отсутствуют", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = Controller.RequestApiForecastGetCall(comboBoxLocationList.Text);
        }
    }
}
