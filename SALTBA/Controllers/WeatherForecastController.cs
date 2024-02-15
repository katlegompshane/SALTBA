using Microsoft.AspNetCore.Mvc;
using SALTBA.Classes;
using SALTBA.Interfaces;
using SALTBA.Models.Countries;
using SALTBA.Models.CountryWeather;
using static System.Net.Mime.MediaTypeNames;

namespace SALTBA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IDataDispay<WeatherPerCountry> _iDataDispay;

        public WeatherForecastController(IDataDispay<WeatherPerCountry> iDataDispay)
        {
            _iDataDispay = iDataDispay;
        }

        [HttpGet(Name = "GetCountriesCuurentWeatherforcasts")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<WeatherPerCountry>))]
        public async Task<ActionResult<IList<WeatherPerCountry>>> GetCountries()
        {
            try
            {
                var result = await _iDataDispay.GetWeatherDataPerCountry();


                return Ok(result);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
            
        }

    }
}