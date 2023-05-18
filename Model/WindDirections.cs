namespace WeatherForecastApp.Model
{
    public static class WindDirections
    {
        public static string GetDirectionNameByDegree(int degree)
        {
            if (degree >= 337) return "С ↑";
            if (degree >= 294) return "СЗ ↖";
            if (degree >= 249) return "З ←";
            if (degree >= 204) return "ЮЗ ↙";
            if (degree >= 159) return "Ю ↓";
            if (degree >= 114) return "ЮВ ↘";
            if (degree >= 69) return "В →";
            if (degree >= 24) return "СВ ↗";
            return "С ↑";
        }
    }
}
