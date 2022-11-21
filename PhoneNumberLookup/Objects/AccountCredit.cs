using PhoneNumberLookup.interfaces;
using System.Text.Json.Serialization;

namespace PhoneNumberLookup.Objects
{
    public class AccountCredit : IObject
    {
        [JsonPropertyName("success")]
        public bool? Success { get; set; }

        [JsonPropertyName("message")]
        public string? Message { get; set; }

        [JsonPropertyName("credits")]
        public int? Credits { get; set; }

        [JsonPropertyName("usage")]
        public int? Usage { get; set; }

        [JsonPropertyName("proxy_usage")]
        public int? ProxyUsage { get; set; }

        [JsonPropertyName("email_usage")]
        public int? EmailUsage { get; set; }

        [JsonPropertyName("fingerprint_usage")]
        public int? FingerprintUsage { get; set; }

        [JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, available credits: {1}",Message, Credits);
        }
    }
}
