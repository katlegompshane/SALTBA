using SALTBA.Interfaces;
using SALTBA.Models;
using SALTBA.Models.Countries;
using System.Net.Http.Headers;
using System.Text.Json;

namespace SALTBA.Classes
{
    public class CountryService : ICountryService
    {
        private readonly IWeatherService _weatherService;
        private readonly IHttpRequestService _httpRequestService; 


        public CountryService(IWeatherService weatherService, IHttpRequestService httpRequestService)
        {
            _weatherService = weatherService;
            _httpRequestService = httpRequestService;
        }

        /// <summary>
        /// Implementation to get list of countries objects returned by the API call
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<T> GetListOfCountries<T>()
        {
            try
            {
                //CODESC: Configure the http request object with the type of request,url and headers
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://wft-geo-db.p.rapidapi.com/v1/geo/countries"),
                    Headers =
                         {
                            { "X-RapidAPI-Key", "128217b352msh4e7d553569823b4p1d5d20jsnf2498ec50735" },
                            { "X-RapidAPI-Host", "wft-geo-db.p.rapidapi.com" },
                        },
                };
                //CODESC: Create a http client to call the remote API: Get countries
                var result = await _httpRequestService.GetRequest<T>(request);

                return result;

            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
