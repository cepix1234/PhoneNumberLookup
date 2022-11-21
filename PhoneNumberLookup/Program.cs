using System;
using PhoneNumberLookup.numberLookup;
using PhoneNumberLookup.controllers;
using PhoneNumberLookup.ClassWrappers;
using PhoneNumberLookup.Objects;

namespace PhoneNumberLookup
{
    class Program
    {
        private static NumberLookupControler _NumberLookup;
        private static HttpClientCustom _httpClient;
        static void Main(string[] args)
        {
            /**
             * parameter number: get number info and console dissplay
             * parameter file: read file line by line console dissplay for each line/ number
             * no parameters start interactive mode
             */
            Initialize();
            _httpClient = new HttpClientCustom();

            _NumberLookup = new NumberLookupControler();
            var task = _NumberLookup.GetNumberInformation("+447488875509", _httpClient);
            task.Wait();
            NumberInformation info = task.Result;
            _NumberLookup.GetAccountCredits(_httpClient).Wait();
            ConsoleLogger.Log(info);

        }

        static private void Initialize()
        {
            Initialization.Initialization._Initialize();
        }
    }
}
