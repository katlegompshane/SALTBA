using SALTBA.Models.Countries;
using SALTBA.Models.Weather;

namespace SALTBA.Models.CountryWeather
{
    public class WeatherPerCountry 
    {
        public Country Country { get; set; }
        public WeatherDetails weatherDetails { get; set; }


    }
}
