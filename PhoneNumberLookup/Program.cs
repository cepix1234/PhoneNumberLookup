using System;
using PhoneNumberLookup.numberLookup;
using PhoneNumberLookup.Initialization;
using PhoneNumberLookup.controllers;
using PhoneNumberLookup.Interfaces;
using System.Net.Http;
using PhoneNumberLookup.ClassWrappers;

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
            _NumberLookup.GetNumberInformation("+447488875509", _httpClient).Wait();
            _NumberLookup.GetAccountCredits(_httpClient).Wait();
            ConsoleLogger.Log(_NumberLookup._LookedUpNumberInformations[0]);
            ConsoleLogger.Log(_NumberLookup._LookedUpNumberInformations);
            Console.WriteLine("Hello World!");

        }

        static private void Initialize()
        {
            Initialization.Initialization._Initialize();
        }
    }
}
