﻿using PhoneNumberLookup.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;

namespace PhoneNumberLookup.numberLookup
{
    public class NumberLookupControler
    {
        public static string _ApiEndpoint;
        public static string _ApiKey;
        private HttpClient _httpClient;
        public List<NumberInformation> _LookedUpNumberInformations;

        public NumberLookupControler ()
        {
            _httpClient = new HttpClient();
        }

        public async Task GetNumberInformation(String number)
        {
            string ApiRequequestURL = String.Format("{0}?key={1}&phone={2}", _ApiEndpoint, _ApiKey, HttpUtility.UrlEncode(number));
            HttpResponseMessage response = await _httpClient.GetAsync(ApiRequequestURL);
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();
            _LookedUpNumberInformations.Add(JsonSerializer.Deserialize<NumberInformation>(json));
        }
    }
}