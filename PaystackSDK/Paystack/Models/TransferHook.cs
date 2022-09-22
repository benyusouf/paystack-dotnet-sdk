using System;
using Newtonsoft.Json;

namespace Gasify.ExternalServices.Paystack.Models
{
    public class TransferHook
    {
        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("data")]
        public TransferData Data { get; set; }
    }

    public class Integration
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_live")]
        public bool IsLive { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }
    }

    public class TransferDetails
    {
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("account_name")]
        public object AccountName { get; set; }

        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }
    }

    public class Recipient
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("email")]
        public object Email { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("integration")]
        public int Integration { get; set; }

        [JsonProperty("metadata")]
        public object Metadata { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("recipient_code")]
        public string RecipientCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("details")]
        public TransferDetails Details { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

    public class Session
    {
        [JsonProperty("provider")]
        public object Provider { get; set; }

        [JsonProperty("id")]
        public object Id { get; set; }
    }

    public class TransferData
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("failures")]
        public object Failures { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("integration")]
        public Integration Integration { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("source_details")]
        public object SourceDetails { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("titan_code")]
        public object TitanCode { get; set; }

        [JsonProperty("transfer_code")]
        public string TransferCode { get; set; }

        [JsonProperty("transferred_at")]
        public object TransferredAt { get; set; }

        [JsonProperty("recipient")]
        public Recipient Recipient { get; set; }

        [JsonProperty("session")]
        public Session Session { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
