using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using WeatherForecastApp.Api;

namespace WeatherForecastApp
{
    public partial class Window : Form
    {
        private Controller.Controller Controller = new Controller.Controller();

        public Window()
        {
            InitializeComponent();
            Model.Database.DatabaseQueries.NewCityAdded += LoadCities;
            LoadCities(null, EventArgs.Empty);
            comboBoxLocationList.SelectedIndex = 0;
        }

        private void LoadCities(object sender, EventArgs e)
        {
            var cityList = Controller.RequestCityList();
            if (comboBoxLocationList.DataSource == null)
            {
                comboBoxLocationList.DisplayMember = "Name";
                comboBoxLocationList.ValueMember = "Id";
            }
            var item = comboBoxLocationList.SelectedItem;
            comboBoxLocationList.DataSource = cityList;
            comboBoxLocationList.SelectedItem = item;
        }

        private void buttonGetCurrentWeather_Click(object sender, System.EventArgs e)
        {
            var data = Controller.RequestApiCurrentGetCall(comboBoxLocationList.Text);
            if (data != null) FillCurrentWeather(data);
            else MessageBox.Show("Ошибка при попытке получения данных.", "Данные отсутствуют", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FillCurrentWeather(CurrentWeatherResponseWrapper data)
        {
            groupBoxCurrentWeather.Text = comboBoxLocationList.Text;
            pictureBoxWeatherConditionIcon.Image = new Bitmap(Controller.RequestIconPath(data.CurrentWeatherResponse.Weather[0].Icon));
            var dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(data.CurrentWeatherResponse.Timestamp + data.City.Timezone);
            labelCurrentWeatherDateTime.Text = dt.ToString("t", new CultureInfo("ru-RU")) + "\n"
                + dt.ToString("ddd", new CultureInfo("ru-RU")) + ", "
                + dt.ToString("M", new CultureInfo("ru-RU"));
            labelFeelsLike.Text = Math.Round(data.CurrentWeatherResponse.Main.FeelsLike).ToString() + " °C";
            labelTemperature.Text = Math.Round(data.CurrentWeatherResponse.Main.Temperature).ToString() + " °C";
            labelHumidity.Text = data.CurrentWeatherResponse.Main.Humidity.ToString() + " %";
            labelPressure.Text = data.CurrentWeatherResponse.Main.Pressure.ToString() + " hPa";
            labelWeatherDescription.Text = string.Join("\n", data.CurrentWeatherResponse.Weather[0].Description.Split());
            labelWindInfo.Text = Math.Round(data.CurrentWeatherResponse.Wind.WindSpeed).ToString() + " м/с, "
                + Controller.RequestWindDirection(data.CurrentWeatherResponse.Wind.WindDegree);
        }

        private void buttonGetForecast_Click(object sender, EventArgs e)
        {
            if (comboBoxLocationList.SelectedValue != null) Controller.RequestOldForecastDataDeletion(comboBoxLocationList.SelectedValue.ToString());
            var data = Controller.RequestApiForecastGetCall(comboBoxLocationList.Text);
        }
    }
}
