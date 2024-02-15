namespace SALTBA.Models.Weather
{
    public class WeatherDetails
    {
        public Location location { get; set; }
        public Current current { get; set; }
        public Forecast forecast { get; set; }
    }
}
