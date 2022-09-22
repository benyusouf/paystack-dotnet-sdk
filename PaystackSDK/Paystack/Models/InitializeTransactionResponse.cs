using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Gasify.ExternalServices.Paystack.Models
{
    [DataContract]
    public class InitializeTransactionResponse
    {
        [JsonProperty("authorization_url")]
        public string AuthorizationUrl { get; set; }

        [JsonProperty("access_code")]
        public string AccessCode { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
