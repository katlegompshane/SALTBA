using SALTBA.Models;

namespace SALTBA.Interfaces
{
    public interface ICountryService
    {
        /// <summary>
        /// This gets the list of countries objects returned by the call
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<T> GetListOfCountries<T>();
    }
}
