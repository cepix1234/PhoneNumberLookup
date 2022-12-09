using PhoneNumberLookup.ClassWrappers;
using PhoneNumberLookup.controllers;
using PhoneNumberLookup.controllers.Helpers;
using PhoneNumberLookup.InteractiveOptions.interfaces;
using System;
using System.Threading.Tasks;

namespace PhoneNumberLookup.InteractiveOptions.Controller
{
    class OptionLookupAccount : IOption
    {
        private NumberLookupControler _Controller;
        private HttpClientCustom _HttpClient;

        private static string _message = "Get account information";
        string IOption.message { get => _message;}

        public OptionLookupAccount(NumberLookupControler controller, HttpClientCustom client)
        {
            _Controller = controller;
            _HttpClient = client;
        }

        public async Task Action()
        {
            ConsoleLogger.Log(await ControllerHelper.GetAccountCredits(_Controller, _HttpClient));
        }
    }
}
