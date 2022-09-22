using Newtonsoft.Json;

namespace Gasify.ExternalServices.Paystack.Models
{
    public class TransferRequestBody
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
