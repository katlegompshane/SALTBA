using SALTBA.Interfaces;
using SALTBA.Models.Countries;
using SALTBA.Models.CountryWeather;
using SALTBA.Models.Weather;

namespace SALTBA.Classes
{
    public class DataDisplayService : IDataDispay<WeatherPerCountry>
    {
        private readonly ICountryService _iCountryService;
        private readonly IWeatherService _weatherService;
        public DataDisplayService(ICountryService iCountryService, IWeatherService weatherService)
        {
            _iCountryService = iCountryService;
            _weatherService = weatherService;
        }

        /// <summary>
        /// Implemention to get  weather forcast per countries major cities, regions etc
        /// </summary>
        /// <returns></returns>
        public async Task<IList<WeatherPerCountry>> GetWeatherDataPerCountry()
        {
            IList<WeatherPerCountry> weatherPerCountries = new List<WeatherPerCountry>();

            try
            {
                //CODESC: Get list of countries returned by the service
                var listCountries = await _iCountryService.GetListOfCountries<CountrtyInfo>();

                //CODESC: Check if data is returned
                if (listCountries != null && listCountries.data != null && listCountries.data.Count != 0)
                {
                    foreach (var countrty in listCountries.data)
                    {
                        //CODESC: Get weather data by country name
                        var details = await _weatherService.GetWeatherPerCountryAsync<WeatherDetails>(countrty.name);

                        if (details != null)
                        {
                            //CODESC: populate country details current weather information
                            WeatherPerCountry weatherPerCountry = new WeatherPerCountry()
                            {
                                Country = countrty,
                                weatherDetails = details
                            };
                            //CODESC: Add
                            weatherPerCountries.Add(weatherPerCountry);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return weatherPerCountries;
        }
    }
}
