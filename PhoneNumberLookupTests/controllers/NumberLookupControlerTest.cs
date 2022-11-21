using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PhoneNumberLookup.interfaces;
using PhoneNumberLookup.numberLookup;
using PhoneNumberLookup.Objects;

namespace PhoneNumberLookupTests.controllers
{
    [TestClass]
    public class NumberLookupControlerTest
    {
        private const string JsonExample = @"{
   ""message"":""Phone is valid."",
   ""success"":true,
   ""formatted"":""+447488875509"",
   ""local_format"":""07488 875509"",
   ""valid"":true,
   ""fraud_score"":65,
   ""recent_abuse"":false,
   ""VOIP"":true,
   ""prepaid"":null,
   ""risky"":true,
   ""active"":true,
   ""carrier"":""Ziron Limited"",
   ""line_type"":""VOIP"",
   ""country"":""GB"",
   ""city"":""N\\/A"",
   ""zip_code"":""N\\/A"",
   ""region"":""United Kingdom"",
   ""dialing_code"":44,
   ""active_status"":""N\\/A"",
   ""sms_domain"":""N\\/A"",
   ""associated_email_addresses"":{
      ""status"":""Enterprise Plus or higher required."",
      ""emails"":[
         
      ]
   },
   ""user_activity"":""Enterprise L4+ required."",
   ""mnc"":""N\\/A"",
   ""mcc"":""N\\/A"",
   ""leaked"":false,
   ""spammer"":false,
   ""request_id"":""8wTDFkSYuy"",
   ""name"":""N\\/A"",
   ""timezone"":""Europe\\/London"",
   ""do_not_call"":false,
   ""sms_email"":""N\\/A""
}";

        [TestMethod]
        public void Number_lookup_contoler_desirializes_json_correctly_test()
        {
            NumberLookupControler _controller = new NumberLookupControler();
            var HttpClientStub = new Mock<IHttpClient>();
            HttpClientStub.Setup(client => client.GetAsync("some url")).ReturnsAsync(JsonExample);
            var task =  _controller.GetNumberInformation("someNumber", (IHttpClient)HttpClientStub);
            task.Wait();
            NumberInformation result = task.Result;
            Assert.IsTrue(result.Message == "Phone is valid.", "Resulting json is correctly saved into lookedup numbers");
        }
}
}
