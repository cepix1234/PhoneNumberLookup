using PhoneNumberLookup.ClassWrappers;
using PhoneNumberLookup.controllers.Helpers;
using PhoneNumberLookup.InteractiveOptions.Controller;
using PhoneNumberLookup.InteractiveOptions.interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace PhoneNumberLookup.controllers
{
    public class ConsoleController
    {
        private NumberLookupControler _Controller;
        private HttpClientCustom _HttpClient;
        private IOption[] _InteractiveOptions;
        public ConsoleController(NumberLookupControler controller, HttpClientCustom client)
        {
            _Controller = controller;
            _HttpClient = client;
            _InteractiveOptions = new IOption[] { new OptionLookupNumber(_Controller, _HttpClient), new OptionLookupAccount(_Controller, _HttpClient), new OptionQuit()};
        }

        public void StartConsole(string[] args)
        {
            if(args.Length == 0)
            {
                DissplayHelp();
            }

            if (args[0] == "-i")
            {
                //intteractive
                InteractiveConsoleController InteractiveController = new InteractiveConsoleController(_InteractiveOptions);
                InteractiveController.Start().GetAwaiter().GetResult();
                return;
            }
            else if (args[0] == "-n")
            {
                //only this number
                ConsoleLogger.Log(ControllerHelper.GetNumberInfo(args[1], _Controller, _HttpClient).GetAwaiter().GetResult());
                return;
            }
            else if (args[0] == "-f")
            {
                //read file
                IEnumerable<string> lines = File.ReadLines(args[1]);
                foreach (string line in lines)
                {
                    ConsoleLogger.Log(ControllerHelper .GetNumberInfo(line, _Controller, _HttpClient).GetAwaiter().GetResult());
                    Console.WriteLine("--------------------------------");
                }
                return;
            }
            else if (args[0] == "-a")
            {
                //get account information
                ConsoleLogger.Log(ControllerHelper .GetAccountCredits(_Controller, _HttpClient).GetAwaiter().GetResult());
                return;
            }
            else if (args[0] == "-h")
            {
                //help
                DissplayHelp();
                return;
            }

            DissplayHelp();
            throw new Exception(String.Format("{0} operation not recongized!!", args[0]));
            
        }

        private void DissplayHelp()
        {
                Console.WriteLine(@"This program get all awailable informaion of a phone number with country codes,
--------------------------------------------------------------------------------------------------
-i start program in iteractive mode,
-n {number} scan the provided number,
-f {file location} scan all phone numbers in a proveded files, each number in a seperate line,
-a get account information available credits,
-h dissplay this help dialog.");
        }
    }
}
