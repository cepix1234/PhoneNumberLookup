using PhoneNumberLookup.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneNumberLookup.controllers
{
    class ConsoleLogger
    {
        public static void Log(IObject numberInformation)
        {
            Console.WriteLine(numberInformation.ToString());
        }

        public static void Log(List<IObject> numberInformations)
        {

        }
    }
}
