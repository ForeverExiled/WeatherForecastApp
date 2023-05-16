using System;
using System.Drawing;
using System.Globalization;
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
            comboBoxLocationList.DisplayMember = "Name";
            comboBoxLocationList.ValueMember = "Id";
            Model.Database.DatabaseQueries.NewCityAdded += LoadCities;
            LoadCities(null, EventArgs.Empty);
            comboBoxLocationList.SelectedIndex = Properties.Settings.Default.ComboboxCityIndex;
            buttonGetCurrentWeather_Click(this, EventArgs.Empty);
            if (!Controller.RequestForecastDataRelevanceCheck(comboBoxLocationList.SelectedValue.ToString())) buttonGetForecast_Click(this, EventArgs.Empty);
        }

        private void LoadCities(object sender, EventArgs e)
        {
            var cityList = Controller.RequestCityList();
            comboBoxLocationList.DataSource = cityList;
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

        private void Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ComboboxCityIndex = comboBoxLocationList.SelectedIndex;
            Properties.Settings.Default.Save();
        }
    }
}
