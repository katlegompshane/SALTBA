using SALTBA.Interfaces;
using System.Text.Json;

namespace SALTBA.Classes
{
    public class WeartherService : IWeatherService
    {
        private readonly IHttpRequestService _httpRequestService;

        public WeartherService(IHttpRequestService httpRequestService)
        {
            _httpRequestService = httpRequestService;
        }
        /// <summary>
        /// Implementation to get current weather forcast of country major city, region etc
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="countryName"></param>
        /// <returns></returns>
        public async Task<T> GetWeatherPerCountryAsync<T>(string countryName)
        {
            try
            {
                //CODESC: Configure the http request messages will the type of request, URL and header information
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://weatherapi-com.p.rapidapi.com/forecast.json?q=" + countryName),
                    Headers =
                    {
                        { "X-RapidAPI-Key", "128217b352msh4e7d553569823b4p1d5d20jsnf2498ec50735" },
                        { "X-RapidAPI-Host", "weatherapi-com.p.rapidapi.com" },
                    },
                };
                //CODESC: Call the get request service
                return await _httpRequestService.GetRequest<T>(request);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
