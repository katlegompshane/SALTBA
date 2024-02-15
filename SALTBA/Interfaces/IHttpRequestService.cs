namespace SALTBA.Interfaces
{
    public interface IHttpRequestService
    {
        /// <summary>
        /// The creates a http request : get Requests
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="httpRequestMessag"></param>
        /// <returns></returns>
        public Task<T> GetRequest<T>(HttpRequestMessage httpRequestMessag);
    }
}
