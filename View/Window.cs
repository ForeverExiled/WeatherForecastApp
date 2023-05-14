using System.Drawing;
using System.Windows.Forms;
using WeatherForecastApp.Model;

namespace WeatherForecastApp
{
    public partial class Window : Form
    {
        private Controller.Controller Controller;
        private string cityName;

        public Window()
        {
            InitializeComponent();
            Controller = new Controller.Controller(this);

            comboBoxLocationList.SelectedIndex = 0;
            cityName = comboBoxLocationList.SelectedItem.ToString();
            //GetWeatherForecast(cityName);
        }

        void GetWeatherForecast(string cityName)
        {
            var data = Controller.RequestApiForecastGetCall(cityName);
        }

        private void buttonGetCurrentWeather_Click(object sender, System.EventArgs e)
        {
            var data = Controller.RequestApiCurrentGetCall(cityName);
            pictureBoxWeatherConditionIcon.Image = new Bitmap(WeatherConditions.GetIconPath(data.Weather[0].Icon));
        }
    }
}
