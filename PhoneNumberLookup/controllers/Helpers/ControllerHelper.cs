using PhoneNumberLookup.ClassWrappers;
using PhoneNumberLookup.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumberLookup.controllers.Helpers
{
    public static class ControllerHelper
    {
        public static Task<NumberInformation> GetNumberInfo(string number, NumberLookupControler controller, HttpClientCustom client)
        {
            return controller.GetNumberInformation(number, client);
        }

        public static Task<AccountCredit> GetAccountCredits(NumberLookupControler controller, HttpClientCustom client)
        {
            return controller.GetAccountCredits(client);
        }
    }
}
