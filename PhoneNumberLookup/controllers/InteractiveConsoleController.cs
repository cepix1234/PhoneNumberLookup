using PhoneNumberLookup.ClassWrappers;
using PhoneNumberLookup.controllers.Helpers;
using System;

namespace PhoneNumberLookup.controllers
{
    public class InteractiveConsoleController
    {
        private NumberLookupControler _Controller;
        private HttpClientCustom _HttpClient;
        public string[] _Options;
        public InteractiveConsoleController(NumberLookupControler controller, HttpClientCustom client)
        {
            _Controller = controller;
            _HttpClient = client;
            //TODO Create options class that will handle all options functions.
            _Options = new string[] { "Scan phone number", "Get account information", "Quit"};
        }

        public void Start()
        {
            int option = 0;
            do
            {
                Console.WriteLine("---------------------------------------------");
                dissplayOptions();
                option = Convert.ToInt32(Console.ReadLine().ToString());
                Console.Clear();
                PerformOption(option);
            } while (option < _Options.Length - 1);
        }

        private void dissplayOptions()
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("---------------------------------------------");
            for (int i = 0; i<_Options.Length; i++)
            {
                Console.WriteLine(String.Format("{0}: {1}", i, _Options[i]));
            }

            Console.WriteLine("---------------------------------------------");
        }

        private void PerformOption(int option)
        {
            switch (option) {
                case 0:
                    Console.WriteLine("Enter phone numebr to scan:");
                    string redPhoneNumber = Console.ReadLine().ToString();
                    ConsoleLogger.Log(ControllerHelper.GetNumberInfo(redPhoneNumber, _Controller, _HttpClient));
                    break;
                case 1:
                    ConsoleLogger.Log(ControllerHelper.GetAccountCredits(_Controller, _HttpClient));
                    break;
            }
        }
    }
}
