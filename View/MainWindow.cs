using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using WeatherForecastApp.Api;
using WeatherForecastApp.View;

namespace WeatherForecastApp
{
    public partial class MainWindow : Form
    {
        private Controller.Controller Controller = new Controller.Controller();
        SettingsWindow SettingsWindow = new SettingsWindow();

        public MainWindow()
        {
            InitializeComponent();
            buttonGetCurrentWeather_Click(this, EventArgs.Empty);
            if (!Controller.RequestForecastDataRelevanceCheck(SettingsWindow.GetSelectedCityId())) buttonGetForecast_Click(this, EventArgs.Empty);
        }


        private void buttonGetCurrentWeather_Click(object sender, System.EventArgs e)
        {
            var data = Controller.RequestApiCurrentGetCall(SettingsWindow.GetSelectedCityName());
            if (data != null) FillCurrentWeather(data);
            else MessageBox.Show("Ошибка при попытке получения данных.", "Данные отсутствуют", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FillCurrentWeather(CurrentWeatherResponseWrapper data)
        {
            groupBoxCurrentWeather.Text = SettingsWindow.GetSelectedCityName();
            if (data.CurrentWeatherResponse.Weather[0].Icon.Contains("d")) pictureBoxWeatherConditionIcon.BackColor = Color.LightSkyBlue;
            else pictureBoxWeatherConditionIcon.BackColor = Color.SlateBlue;
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
            SettingsWindow.ShowDialog();
            if (SettingsWindow.IsSelectedCityInTheList()) Controller.RequestOldForecastDataDeletion(SettingsWindow.GetSelectedCityId());
            var data = Controller.RequestApiForecastGetCall(SettingsWindow.GetSelectedCityName());
        }

        private void toolStripMenuItem_Settings_Click(object sender, EventArgs e)
        {
            SettingsWindow.ShowDialog();
        }
    }
}
