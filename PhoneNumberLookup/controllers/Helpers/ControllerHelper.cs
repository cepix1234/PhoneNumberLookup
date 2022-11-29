using PhoneNumberLookup.ClassWrappers;
using PhoneNumberLookup.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneNumberLookup.controllers.Helpers
{
    public static class ControllerHelper
    {
        public static NumberInformation GetNumberInfo(string number, NumberLookupControler controller, HttpClientCustom client)
        {
            var task = controller.GetNumberInformation(number, client);
            task.Wait();
            return task.Result; //TODO dont do this make everything async, in Program start with _= Task.Run()
        }

        public static AccountCredit GetAccountCredits(NumberLookupControler controller, HttpClientCustom client)
        {
            var task = controller.GetAccountCredits(client);
            task.Wait();
            return task.Result;
        }
    }
}
