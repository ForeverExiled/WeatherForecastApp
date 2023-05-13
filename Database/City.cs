using System;
using System.Collections.Generic;

#nullable disable

namespace WeatherForecastApp.Database
{
    public partial class City
    {
        public City()
        {
            Forecasts = new HashSet<Forecast>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public virtual ICollection<Forecast> Forecasts { get; set; }
    }
}
