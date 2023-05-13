using System.Windows.Forms;

namespace WeatherForecastApp
{
    public partial class Window : Form
    {
        private Controller.Controller Controller;

        public Window()
        {
            InitializeComponent();
            Controller = new Controller.Controller(this);

            string cityName = "Тюмень";
            //GetCurrentWeatherData(cityName);
            //GetWeatherForecast(cityName);
        }

        void GetCurrentWeatherData(string cityName)
        {
            var data = Controller.RequestApiCurrentGetCall(cityName);
        }

        void GetWeatherForecast(string cityName)
        {
            var data = Controller.RequestApiForecastGetCall(cityName);
        }
    }
}
