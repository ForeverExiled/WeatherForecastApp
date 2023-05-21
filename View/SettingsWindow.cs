using System;
using System.Windows.Forms;

namespace WeatherForecastApp.View
{
    public partial class SettingsWindow : Form
    {
        private Controller.Controller Controller = new Controller.Controller();
        public event EventHandler CityChanged;

        public SettingsWindow()
        {
            InitializeComponent();
            Model.Database.DatabaseQueries.NewCityAdded += LoadCities;
            comboBoxLocationList.DisplayMember = "Name";
            comboBoxLocationList.ValueMember = "Id";
            LoadCities(this, EventArgs.Empty);
            comboBoxLocationList.SelectedIndex = Properties.Settings.Default.ComboboxCityIndex;
        }

        private void LoadCities(object sender, EventArgs e)
        {
            var comboboxOldText = comboBoxLocationList.Text;
            var cityList = Controller.RequestCityList();
            comboBoxLocationList.DataSource = cityList;
            if (comboboxOldText != "") comboBoxLocationList.Text = comboboxOldText;
        }

        public string GetSelectedCityName()
        {
            return comboBoxLocationList.Text;
        }

        public string GetSelectedCityId()
        {
            return comboBoxLocationList.SelectedValue.ToString();
        }

        public bool IsSelectedCityInTheList()
        {
            return comboBoxLocationList.SelectedItem != null;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ComboboxCityIndex = comboBoxLocationList.SelectedIndex;
            Properties.Settings.Default.Save();
            CityChanged?.Invoke(this, EventArgs.Empty);
            Close();
        }
    }
}
