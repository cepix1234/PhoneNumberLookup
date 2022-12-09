using System;
using PhoneNumberLookup.controllers;
using PhoneNumberLookup.ClassWrappers;
using PhoneNumberLookup.Objects;
using System.Threading.Tasks;

namespace PhoneNumberLookup
{
    class Program
    {
        private static NumberLookupControler _NumberLookup;
        private static HttpClientCustom _HttpClient;
        private static ConsoleController _ConsoleController;
        static void Main(string[] args)
        {
            /**
             * parameter number: get number info and console dissplay
             * parameter file: read file line by line console dissplay for each line/ number
             * no parameters start interactive mode
             */

            //-n + 447488875509
            Initialize();

            _HttpClient = new HttpClientCustom();
            _NumberLookup = new NumberLookupControler();
            _ConsoleController = new ConsoleController(_NumberLookup, _HttpClient);

            _ConsoleController.StartConsole(args);
        }

        static private void Initialize()
        {
            Initialization.Initialization._Initialize();
        }
    }
}
