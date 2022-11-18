using System;
using PhoneNumberLookup.numberLookup;
using PhoneNumberLookup.Initialization;
using PhoneNumberLookup.controllers;
using PhoneNumberLookup.Interfaces;

namespace PhoneNumberLookup
{
    class Program
    {
        private static NumberLookupControler _NumberLookup;
        static void Main(string[] args)
        {
            /**
             * parameter number: get number info and console dissplay
             * parameter file: read file line by line console dissplay for each line/ number
             * no parameters start interactive mode
             */
            Initialize();

            _NumberLookup = new NumberLookupControler();
            _NumberLookup.GetNumberInformation("+447488875509").Wait();
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
