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
        private SettingsWindow SettingsWindow = new SettingsWindow();
        private WeatherForecastResponse CachedWeatherData = null;
        private int currentIndex;
        private int minIndex;
        private int maxIndex;
        private GroupBox currentDay;

        public MainWindow()
        {
            InitializeComponent();
            buttonGetCurrentWeather_Click(this, EventArgs.Empty);
            if (!Controller.RequestForecastDataRelevanceCheck(SettingsWindow.GetSelectedCityId())) buttonGetForecast_Click(this, EventArgs.Empty);
            CachedWeatherData = Controller.RequestForecastData(SettingsWindow.GetSelectedCityId());
            FillForecastData();
        }


        private void buttonGetCurrentWeather_Click(object sender, EventArgs e)
        {
            buttonNextTimestamp.Enabled = false;
            buttonNextTimestamp.Text = "нет\nданных";
            buttonPreviousTimestamp.Enabled = false;
            buttonPreviousTimestamp.Text = "нет\nданных";
            var data = Controller.RequestApiCurrentGetCall(SettingsWindow.GetSelectedCityName());
            if (data != null) FillCurrentWeather(data);
            else MessageBox.Show("Ошибка при попытке получения данных о текущей погоде.", "Данные отсутствуют", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FillCurrentWeather(CurrentWeatherResponseWrapper data)
        {
            groupBoxCity.Text = SettingsWindow.GetSelectedCityName();
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
            if (SettingsWindow.IsSelectedCityInTheList()) Controller.RequestOldForecastDataDeletion(SettingsWindow.GetSelectedCityId());
            CachedWeatherData = Controller.RequestApiForecastGetCall(SettingsWindow.GetSelectedCityName());
            if (CachedWeatherData != null) FillForecastData();
            else MessageBox.Show("Ошибка при попытке получения данных о прогнозе.", "Данные отсутствуют", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FillForecastData()
        {
            groupBoxCity.Text = SettingsWindow.GetSelectedCityName();
            FillForecastTemperatureData();
            FillWeatherConditionIcons();
            FIllDateData();
        }

        private void FIllDateData()
        {
            var dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    .AddSeconds(CachedWeatherData.Forecasts[0].Timestamp + CachedWeatherData.City.Timezone);
            groupBoxDay1.Text = $"Сегодня, {dt.ToString("M", new CultureInfo("ru-RU"))}";
            dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    .AddSeconds(CachedWeatherData.Forecasts[8].Timestamp + CachedWeatherData.City.Timezone);
            groupBoxDay2.Text = $"Завтра, {dt.ToString("M", new CultureInfo("ru-RU"))}";
            dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    .AddSeconds(CachedWeatherData.Forecasts[16].Timestamp + CachedWeatherData.City.Timezone);
            groupBoxDay3.Text = $"{dt.ToString("dddd", new CultureInfo("ru-RU"))}, {dt.ToString("M", new CultureInfo("ru-RU"))}";
            dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    .AddSeconds(CachedWeatherData.Forecasts[24].Timestamp + CachedWeatherData.City.Timezone);
            groupBoxDay4.Text = $"{dt.ToString("dddd", new CultureInfo("ru-RU"))}, {dt.ToString("M", new CultureInfo("ru-RU"))}";
            dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    .AddSeconds(CachedWeatherData.Forecasts[32].Timestamp + CachedWeatherData.City.Timezone);
            groupBoxDay5.Text = $"{dt.ToString("dddd", new CultureInfo("ru-RU"))}, {dt.ToString("M", new CultureInfo("ru-RU"))}";
        }

        private void FillWeatherConditionIcons()
        {
            pictureBoxDay1.Image = new Bitmap(FindDayIcon(0, 8));
            pictureBoxDay2.Image = new Bitmap(FindDayIcon(8, 16));
            pictureBoxDay3.Image = new Bitmap(FindDayIcon(16, 24));
            pictureBoxDay4.Image = new Bitmap(FindDayIcon(24, 32));
            pictureBoxDay5.Image = new Bitmap(FindDayIcon(32, 40));
            pictureBoxNight1.Image = new Bitmap(FindNightIcon(0, 8));
            pictureBoxNight2.Image = new Bitmap(FindNightIcon(8, 16));
            pictureBoxNight3.Image = new Bitmap(FindNightIcon(16, 24));
            pictureBoxNight4.Image = new Bitmap(FindNightIcon(24, 32));
            pictureBoxNight5.Image = new Bitmap(FindNightIcon(32, 40));
        }

        private string FindDayIcon(int startIndex, int endIndex)
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                if (new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    .AddSeconds(CachedWeatherData.Forecasts[i].Timestamp + CachedWeatherData.City.Timezone).Hour >= 12)
                    return Controller.RequestIconPath(CachedWeatherData.Forecasts[i].Weather[0].Icon);
            }
            return null;
        }
        private string FindNightIcon(int startIndex, int endIndex)
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                if (new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    .AddSeconds(CachedWeatherData.Forecasts[i].Timestamp + CachedWeatherData.City.Timezone).Hour >= 21)
                    return Controller.RequestIconPath(CachedWeatherData.Forecasts[i].Weather[0].Icon);
            }
            return null;
        }

        private void FillForecastTemperatureData()
        {
            Tuple<int, int> minMax1 = FindMinAndMaxTemperature(0, 8);
            labelDay1.Text = $"От {minMax1.Item1} до {minMax1.Item2}.";
            Tuple<int, int> minMax2 = FindMinAndMaxTemperature(8, 16);
            labelDay2.Text = $"От {minMax2.Item1} до {minMax2.Item2}.";
            Tuple<int, int> minMax3 = FindMinAndMaxTemperature(16, 24);
            labelDay3.Text = $"От {minMax3.Item1} до {minMax3.Item2}.";
            Tuple<int, int> minMax4 = FindMinAndMaxTemperature(24, 32);
            labelDay4.Text = $"От {minMax4.Item1} до {minMax4.Item2}.";
            Tuple<int, int> minMax5 = FindMinAndMaxTemperature(32, 40);
            labelDay5.Text = $"От {minMax5.Item1} до {minMax5.Item2}.";
        }

        private Tuple<int, int> FindMinAndMaxTemperature(int startIndex, int endIndex)
        {
            if (CachedWeatherData != null)
            {
                int min = int.MaxValue;
                int max = int.MinValue;
                for (int i = startIndex; i < endIndex; i++)
                {
                    if (CachedWeatherData.Forecasts[i].Main.Temperature < min) min = (int)Math.Round(CachedWeatherData.Forecasts[i].Main.Temperature);
                    if (CachedWeatherData.Forecasts[i].Main.Temperature > max) max = (int)Math.Round(CachedWeatherData.Forecasts[i].Main.Temperature);
                }
                return Tuple.Create(min, max);
            }
            return null;
        }

        private void toolStripMenuItem_Settings_Click(object sender, EventArgs e)
        {
            SettingsWindow.ShowDialog();
        }

        private void FillCurrentWithForecastDay(int index, GroupBox box)
        {
            if (CachedWeatherData != null)
            {
                groupBoxCurrentWeather.Text = box.Text;
                if (CachedWeatherData.Forecasts[index].Weather[0].Icon.Contains("d")) pictureBoxWeatherConditionIcon.BackColor = Color.LightSkyBlue;
                else pictureBoxWeatherConditionIcon.BackColor = Color.SlateBlue;
                pictureBoxWeatherConditionIcon.Image = new Bitmap(Controller.RequestIconPath(CachedWeatherData.Forecasts[index].Weather[0].Icon));
                var dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    .AddSeconds(CachedWeatherData.Forecasts[index].Timestamp + CachedWeatherData.City.Timezone);
                labelCurrentWeatherDateTime.Text = dt.ToString("t", new CultureInfo("ru-RU")) + "\n"
                    + dt.ToString("ddd", new CultureInfo("ru-RU")) + ", "
                    + dt.ToString("M", new CultureInfo("ru-RU"));
                labelFeelsLike.Text = Math.Round(CachedWeatherData.Forecasts[index].Main.FeelsLike).ToString() + " °C";
                labelTemperature.Text = Math.Round(CachedWeatherData.Forecasts[index].Main.Temperature).ToString() + " °C";
                labelHumidity.Text = CachedWeatherData.Forecasts[index].Main.Humidity.ToString() + " %";
                labelPressure.Text = CachedWeatherData.Forecasts[index].Main.Pressure.ToString() + " hPa";
                labelWeatherDescription.Text = string.Join("\n", CachedWeatherData.Forecasts[index].Weather[0].Description.Split());
                labelWindInfo.Text = Math.Round(CachedWeatherData.Forecasts[index].Wind.WindSpeed).ToString() + " м/с, "
                    + Controller.RequestWindDirection(CachedWeatherData.Forecasts[index].Wind.WindDegree);
                FillButtonsWithText(index, dt);
            }
        }

        private void FillButtonsWithText(int index, DateTime dt)
        {
            if (index != minIndex)
            {
                buttonPreviousTimestamp.Enabled = true;
                buttonPreviousTimestamp.Text = "->\n" + dt.AddSeconds(-10800).ToString("t", new CultureInfo("ru-RU"));
            }
            else
            {
                buttonPreviousTimestamp.Enabled = false;
                buttonPreviousTimestamp.Text = "нет\nданных";
            }
            if (index != maxIndex)
            {
                buttonNextTimestamp.Enabled = true;
                buttonNextTimestamp.Text = "->\n" + dt.AddSeconds(10800).ToString("t", new CultureInfo("ru-RU"));
            }
            else
            {
                buttonNextTimestamp.Enabled = false;
                buttonNextTimestamp.Text = "нет\nданных";
            }
        }

        private void buttonDay1_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            minIndex = 0;
            maxIndex = 7;
            currentDay = groupBoxDay1;
            FillCurrentWithForecastDay(0, groupBoxDay1);
        }

        private void buttonDay2_Click(object sender, EventArgs e)
        {
            currentIndex = 8;
            minIndex = 8;
            maxIndex = 15;
            currentDay = groupBoxDay2;
            FillCurrentWithForecastDay(8, groupBoxDay2);
        }

        private void buttonDay3_Click(object sender, EventArgs e)
        {
            currentIndex = 16;
            minIndex = 16;
            maxIndex = 23;
            currentDay = groupBoxDay3;
            FillCurrentWithForecastDay(16, groupBoxDay3);
        }

        private void buttonDay4_Click(object sender, EventArgs e)
        {
            currentIndex = 24;
            minIndex = 24;
            maxIndex = 31;
            currentDay = groupBoxDay4;
            FillCurrentWithForecastDay(24, groupBoxDay4);
        }

        private void buttonDay5_Click(object sender, EventArgs e)
        {
            currentIndex = 32;
            minIndex = 32;
            maxIndex = 39;
            currentDay = groupBoxDay5;
            FillCurrentWithForecastDay(32, groupBoxDay5);
        }

        private void buttonPreviousTimestamp_Click(object sender, EventArgs e)
        {
            FillCurrentWithForecastDay(--currentIndex, currentDay);
        }

        private void buttonNextTimestamp_Click(object sender, EventArgs e)
        {
            FillCurrentWithForecastDay(++currentIndex, currentDay);
        }
    }
}
