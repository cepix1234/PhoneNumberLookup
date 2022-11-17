using System.Text.Json.Serialization;

namespace PhoneNumberLookup.Objects
{
    public class NumberAssociatedEmailAddresses
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("emails")]
        public string[] Emails{ get; set; }
}
}
