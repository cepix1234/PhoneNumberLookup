using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using PhoneNumberLookup.interfaces;

namespace PhoneNumberLookup.ClassWrappers
{
    public class HttpClientCustom : IHttpClient
    {
        private static HttpClient _httpClient;

        public HttpClientCustom()
        {
            _httpClient = new HttpClient();
        }
        public async Task<string> GetAsync(string requestUri)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(requestUri);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
