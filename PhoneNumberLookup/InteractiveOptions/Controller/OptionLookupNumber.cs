using PhoneNumberLookup.ClassWrappers;
using PhoneNumberLookup.controllers;
using PhoneNumberLookup.controllers.Helpers;
using PhoneNumberLookup.InteractiveOptions.interfaces;
using System;
using System.Threading.Tasks;

namespace PhoneNumberLookup.InteractiveOptions.Controller
{
    class OptionLookupNumber : IOption
    {
        private NumberLookupControler _Controller;
        private HttpClientCustom _HttpClient;

        private static string _message = "Scan a phone number";

        string IOption.message { get => _message; }

        public OptionLookupNumber(NumberLookupControler controller, HttpClientCustom client) {
            _Controller = controller;
            _HttpClient = client;
        }

        public async Task Action()
        {
            Console.WriteLine("Enter phone number to scan:");
            string redPhoneNumber = Console.ReadLine().ToString();
            ConsoleLogger.Log(await ControllerHelper.GetNumberInfo(redPhoneNumber, _Controller, _HttpClient));
        }
    }
}
