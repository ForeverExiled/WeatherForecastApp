namespace WeatherForecastApp.Model
{
    public static class WindDirections
    {
        public static string GetDirectionNameByDegree(int degree)
        {
            if (degree >= 0 && degree <= 23 || degree >= 337 && degree <= 360) return "С ↑";
            else if (degree >= 24 && degree <= 68) return "СВ ↗";
            else if (degree >= 69 && degree <= 113) return "В →";
            else if (degree >= 114 && degree <= 158) return "ЮВ ↘";
            else if (degree >= 159 && degree <= 203) return "Ю ↓";
            else if (degree >= 204 && degree <= 248) return "ЮЗ ↙";
            else if (degree >= 249 && degree <= 293) return "З ←";
            else if (degree >= 294 && degree <= 336) return "СЗ ↖";
            else return "неопределено";
        }
    }
}
