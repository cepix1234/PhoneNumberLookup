using PhoneNumberLookup.ClassWrappers;
using PhoneNumberLookup.controllers.Helpers;
using PhoneNumberLookup.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PhoneNumberLookup.controllers
{
    public class ConsoleController
    {
        private NumberLookupControler _Controller;
        private HttpClientCustom _HttpClient;
        public ConsoleController(NumberLookupControler controller, HttpClientCustom client)
        {
            _Controller = controller;
            _HttpClient = client;
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
                InteractiveConsoleController InteractiveController = new InteractiveConsoleController(_Controller, _HttpClient);
                InteractiveController.Start();
                return;
            }
            else if (args[0] == "-n")
            {
                //only this number
                ConsoleLogger.Log(ControllerHelper.GetNumberInfo(args[1], _Controller, _HttpClient));
                return;
            }
            else if (args[0] == "-f")
            {
                //read file
                IEnumerable<string> lines = File.ReadLines(args[1]);
                foreach (string line in lines)
                {
                    ConsoleLogger.Log(ControllerHelper.GetNumberInfo(line, _Controller, _HttpClient));
                    Console.WriteLine("--------------------------------");
                }
                return;
            }
            else if (args[0] == "-a")
            {
                //get account information
                ConsoleLogger.Log(ControllerHelper.GetAccountCredits(_Controller, _HttpClient));
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
