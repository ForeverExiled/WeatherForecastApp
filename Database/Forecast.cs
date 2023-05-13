using System;
using System.Collections.Generic;

#nullable disable

namespace WeatherForecastApp.Database
{
    public partial class Forecast
    {
        public int Id { get; set; }
        public int? Temperature { get; set; }
        public int? FeelsLike { get; set; }
        public int? Pressure { get; set; }
        public int? Humidity { get; set; }
        public int? WindSpeed { get; set; }
        public string Weather { get; set; }
        public int? FkCity { get; set; }
        public int? WindDegree { get; set; }
        public DateTime? Timestamp { get; set; }
        public DateTime? RequestTime { get; set; }

        public virtual City FkCityNavigation { get; set; }
    }
}
