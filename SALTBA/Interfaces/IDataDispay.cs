namespace SALTBA.Interfaces
{
    public interface IDataDispay<T> where T : class
    {
        /// <summary>
        /// This returns weather data per country
        /// </summary>
        /// <returns></returns>
        Task<IList<T>> GetWeatherDataPerCountry();
    }
}
