namespace SALTBA.Interfaces
{
    public interface IWeatherService
    {
        /// <summary>
        /// This gets current weather forcast of country major city, region etc
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="countryName"></param>
        /// <returns></returns>
        Task<T> GetWeatherPerCountryAsync<T>(string countryName);
    }
}
