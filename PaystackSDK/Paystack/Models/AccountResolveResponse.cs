using Newtonsoft.Json;

namespace Gasify.ExternalServices.Paystack.Models
{
    public class AccountResolveResponse
    {
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("account_name")]
        public string AccountName { get; set; }

        [JsonProperty("bank_id")]
        public int BankId { get; set; }
    }
}
