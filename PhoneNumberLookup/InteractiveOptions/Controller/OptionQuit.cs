using PhoneNumberLookup.ClassWrappers;
using PhoneNumberLookup.controllers;
using PhoneNumberLookup.controllers.Helpers;
using PhoneNumberLookup.InteractiveOptions.interfaces;
using System;
using System.Threading.Tasks;

namespace PhoneNumberLookup.InteractiveOptions.Controller
{
    class OptionQuit : IOption
    {
        private static string _message = "Quit";
        string IOption.message { get => _message;  }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task Action()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            return;
        }
    }
}
