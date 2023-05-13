using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Text;

namespace WeatherForecastApp
{
    internal static class HttpData
    {
        readonly public static string apiKey = "677b1ec4b8c2c6e55d5ed3c0617dfea0";
        readonly static string baseAddress = $"https://api.openweathermap.org";
        readonly public static HttpClient Client = new HttpClient()
        {
            BaseAddress = new Uri(baseAddress)
        };
    }
}
