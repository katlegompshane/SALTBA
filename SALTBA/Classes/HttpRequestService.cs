using SALTBA.Interfaces;
using System.Text.Json;

namespace SALTBA.Classes
{
    public class HttpRequestService : IHttpRequestService
    {
        /// <summary>
        /// Implementation to make get request to the configured API in the HttpRequestMessage object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="httpRequestMessage"></param>
        /// <returns></returns>
        public async Task<T> GetRequest<T>(HttpRequestMessage httpRequestMessage)
        {
            try
            {
                //CODESC: Create a http client
                using (var client = new HttpClient())
                {
                    //CODESC: Call the configired request
                    HttpResponseMessage response = await client.SendAsync(httpRequestMessage);

                    //CODESC: Check if request is success
                    if (response.IsSuccessStatusCode)
                    {
                        //CODESC: Return json to the required object
                        response.EnsureSuccessStatusCode();
                        var body = await response.Content.ReadAsStringAsync();
                        var result = JsonSerializer.Deserialize<T>(body);
                        return result;

                    }
                    else
                    {
                        throw new Exception($"Remote API call failed with status code: {response.StatusCode}");
                    }
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
