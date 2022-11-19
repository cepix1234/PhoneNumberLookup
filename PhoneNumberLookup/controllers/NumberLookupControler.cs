using PhoneNumberLookup.interfaces;
using PhoneNumberLookup.Interfaces;
using PhoneNumberLookup.Objects;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace PhoneNumberLookup.numberLookup
{
    public class NumberLookupControler
    {
        public static string _ApiEndpoint;
        public static string _ApiKey;
        public List<NumberInformation> _LookedUpNumberInformations;

        public NumberLookupControler ()
        {
            _LookedUpNumberInformations = new List<NumberInformation>();
        }

        public async Task GetNumberInformation(String number, IHttpClient _httpClient)
        {
            string ApiRequequestURL = String.Format("{0}/phone?key={1}&phone={2}", _ApiEndpoint, _ApiKey, HttpUtility.UrlEncode(number));
            string json = await _httpClient.GetAsync(ApiRequequestURL);
            _LookedUpNumberInformations.Add(JsonSerializer.Deserialize<NumberInformation>(json));
        }

        public async Task<AccountCredit> GetAccountCredits(IHttpClient _httpClient)
        {
            string ApiRequequestURL = String.Format("{0}/account/{1}", _ApiEndpoint, _ApiKey);
            string json = await _httpClient.GetAsync(ApiRequequestURL);
            return JsonSerializer.Deserialize<AccountCredit>(json);
        }
    }
}
