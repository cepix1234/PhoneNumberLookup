using PhoneNumberLookup.interfaces;
using PhoneNumberLookup.Objects;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace PhoneNumberLookup.controllers
{
    public class NumberLookupControler
    {
        public static string _ApiEndpoint;
        public static string _ApiKey;

        public NumberLookupControler ()
        {
        }

        public async Task<NumberInformation> GetNumberInformation(String number, IHttpClient _httpClient)
        {
            string ApiRequequestURL = String.Format("{0}/phone?key={1}&phone={2}", _ApiEndpoint, _ApiKey, HttpUtility.UrlEncode(number));
            string json = await _httpClient.GetAsync(ApiRequequestURL);
            NumberInformation numberInfo = JsonSerializer.Deserialize<NumberInformation>(json);
            return numberInfo;
        }

        public async Task<AccountCredit> GetAccountCredits(IHttpClient _httpClient)
        {
            string ApiRequequestURL = String.Format("{0}/account/{1}", _ApiEndpoint, _ApiKey);
            string json = await _httpClient.GetAsync(ApiRequequestURL);
            return JsonSerializer.Deserialize<AccountCredit>(json);
        }
    }
}
