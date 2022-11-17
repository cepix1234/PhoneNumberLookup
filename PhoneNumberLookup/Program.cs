using System;
using PhoneNumberLookup.numberLookup;
using PhoneNumberLookup.Initialization;

namespace PhoneNumberLookup
{
    class Program
    {
        private static NumberLookup _NumberLookup;
        static void Main(string[] args)
        {
            /**
             * parameter number: get number info and console dissplay
             * parameter file: read file line by line console dissplay for each line/ number
             * no parameters start interactive mode
             */
            Initialization.Initialization._Initialize();

            _NumberLookup = new NumberLookup();
            _NumberLookup.GetNumberInformation("+447488875509").Wait();

            Console.WriteLine("Hello World!");

        }
    }
}
