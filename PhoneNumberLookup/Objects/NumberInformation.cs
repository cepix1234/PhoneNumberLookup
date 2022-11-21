using PhoneNumberLookup.interfaces;
using System;
using System.Text.Json.Serialization;

namespace PhoneNumberLookup.Objects
{
    public class NumberInformation: IObject
	{
		[JsonPropertyName("message")]
		public string? Message { get; set; }

		[JsonPropertyName("success")]
		public Boolean? Success { get; set; }

		[JsonPropertyName("formatted")]
		public string? Formatted { get; set; }

		[JsonPropertyName("local_format")]
		public string? LocalFormat { get; set; }

		[JsonPropertyName("valid")]
		public Boolean? Valid { get; set; }

		[JsonPropertyName("fraud_score")]
		public int? FraudScore { get; set; }

		[JsonPropertyName("recent_abuse")]
		public Boolean? RecentAbuse { get; set; }

		public Boolean? VOIP { get; set; }

		[JsonPropertyName("prepaid")]
		public Boolean? Prepaid { get; set; }

		[JsonPropertyName("risky")]
		public Boolean? Risky { get; set; }

		[JsonPropertyName("active")]
		public Boolean? Active { get; set; }

		[JsonPropertyName("name")]
		public string? Name { get; set; }

		[JsonPropertyName("carrier")]
		public string? Carrier { get; set; }

		[JsonPropertyName("line_type")]
		public string? Line_type { get; set; }

		[JsonPropertyName("country")]
		public string? Country { get; set; }

		[JsonPropertyName("region")]
		public string? Region { get; set; }

		[JsonPropertyName("city")]
		public string? City { get; set; }

		[JsonPropertyName("timezone")]
		public string? Timezone { get; set; }

		[JsonPropertyName("zip_code")]
		public string? ZipCode { get; set; }

		[JsonPropertyName("dialing_code")]
		public int? DialingCode { get; set; }

		[JsonPropertyName("do_not_call")]
		public Boolean? DoNotCall { get; set; }

		[JsonPropertyName("leaked")]
		public Boolean? Leaked { get; set; }

		[JsonPropertyName("spammer")]
		public Boolean? Spammer { get; set; }

		[JsonPropertyName("active_status")]
		public string? ActiveStatus { get; set; }

		[JsonPropertyName("user_activity")]
		public string? UserActivity { get; set; }

		[JsonPropertyName("associated_email_addresses")]
		public NumberAssociatedEmailAddresses? AssociatedEmailAddresses { get; set; }

		[JsonPropertyName("request_id")]
		public string? RequestId { get; set; }

        public override string ToString()
        {
			return String.Format(@"{0}
PhoneNumber: {1};{2}
Is valid: {3}
Recent abuse: {4}
VOIP: {5}
Risky: {6}
Active: {7}
Leaked: {8}
Spammer: {9}
Name: {10}
Carrier: {11}
Line type: {12}
Country: {13}
User active: {14}
Associated emails: {15}",
				Message, Formatted, LocalFormat, Valid.ToString(), RecentAbuse.ToString(), VOIP.ToString(), Risky.ToString(), Active.ToString(), Leaked.ToString(), Spammer.ToString(), Name, Carrier, Line_type, Country, Region, City, UserActivity, AssociatedEmailAddresses.ToString());
        }
    }
}
