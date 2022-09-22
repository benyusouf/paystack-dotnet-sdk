using System;
using Newtonsoft.Json;

namespace Gasify.ExternalServices.Paystack.Models
{
    public class PaystackBank
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("longcode")]
        public string Longcode { get; set; }

        [JsonProperty("gateway")]
        public object Gateway { get; set; }

        [JsonProperty("pay_with_bank")]
        public bool PayWithBank { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("is_deleted")]
        public bool? IsDeleted { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
    }

}
