using Newtonsoft.Json;

namespace Gasify.ExternalServices.Paystack.Models
{
    public class InitializeTransactionRequestBody
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty(PropertyName = "reference")]
        public string Reference { get; set; }

        [JsonProperty(PropertyName = "callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public MetaData MetaData { get; set; }

        [JsonProperty(PropertyName = "bearer")]
        public string Bearer { get; set; } = "account";
    }

    public class MetaData
    {
        [JsonProperty(PropertyName = "purpose")]
        public string Purpose { get; set; }
    }
}
