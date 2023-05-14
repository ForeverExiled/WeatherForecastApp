using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherForecastApp.Model
{
    public static class WeatherConditions
    {
        private static readonly Dictionary<string, string> Conditions;

        static WeatherConditions()
        {
            Conditions = new Dictionary<string, string>();
            Conditions["01d"] = "Resources/Icons/01d@2x.png";
            Conditions["02d"] = "Resources/Icons/02d@2x.png";
            Conditions["03d"] = "Resources/Icons/03d@2x.png";
            Conditions["04d"] = "Resources/Icons/04d@2x.png";
            Conditions["09d"] = "Resources/Icons/09d@2x.png";
            Conditions["10d"] = "Resources/Icons/10d@2x.png";
            Conditions["11d"] = "Resources/Icons/11d@2x.png";
            Conditions["13d"] = "Resources/Icons/13d@2x.png";
            Conditions["50d"] = "Resources/Icons/50d@2x.png";
            Conditions["01n"] = "Resources/Icons/01n@2x.png";
            Conditions["02n"] = "Resources/Icons/02n@2x.png";
            Conditions["03n"] = "Resources/Icons/03n@2x.png";
            Conditions["04n"] = "Resources/Icons/04n@2x.png";
            Conditions["09n"] = "Resources/Icons/09n@2x.png";
            Conditions["10n"] = "Resources/Icons/10n@2x.png";
            Conditions["11n"] = "Resources/Icons/11n@2x.png";
            Conditions["13n"] = "Resources/Icons/13n@2x.png";
            Conditions["50n"] = "Resources/Icons/50n@2x.png";
        }
        
        public static string GetIconPath(string iconCode)
        {
            return Conditions[iconCode];
        }
    }
}
