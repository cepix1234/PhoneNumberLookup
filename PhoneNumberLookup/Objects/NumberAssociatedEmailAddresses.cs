using PhoneNumberLookup.interfaces;
using System.Text.Json.Serialization;

namespace PhoneNumberLookup.Objects
{
    public class NumberAssociatedEmailAddresses : IObject
    {
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("emails")]
        public string[]? Emails { get; set; }

        public override string ToString()
        {
            string EmailsString = "";
            foreach (string email in Emails)
            {
                string.Format(" {0}\n", email);
            }
            return string.Format("{0}: \n {1}", Status, EmailsString);
        }
    }
}
