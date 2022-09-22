using Newtonsoft.Json;

namespace Gasify.ExternalServices.Paystack.Models
{
    public class TransferRecipient
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
