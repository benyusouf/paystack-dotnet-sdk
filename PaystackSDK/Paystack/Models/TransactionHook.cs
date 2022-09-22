using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Gasify.ExternalServices.Paystack.Models
{
    public class TransactionHistory
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }
    }

    public class TransactionLog
    {
        [JsonProperty("time_spent")]
        public int TimeSpent { get; set; }

        [JsonProperty("attempts")]
        public int Attempts { get; set; }

        [JsonProperty("authentication")]
        public string Authentication { get; set; }

        [JsonProperty("errors")]
        public int Errors { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("mobile")]
        public bool Mobile { get; set; }

        [JsonProperty("input")]
        public List<object> Input { get; set; }

        [JsonProperty("channel")]
        public object Channel { get; set; }

        [JsonProperty("history")]
        public List<TransactionHistory> History { get; set; }
    }

    public class TransactionCustomer
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("customer_code")]
        public string CustomerCode { get; set; }

        [JsonProperty("phone")]
        public object Phone { get; set; }

        [JsonProperty("metadata")]
        public object Metadata { get; set; }

        [JsonProperty("risk_action")]
        public string RiskAction { get; set; }
    }

    public class TransactionAuthorization
    {
        [JsonProperty("authorization_code")]
        public string AuthorizationCode { get; set; }

        [JsonProperty("bin")]
        public string Bin { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("exp_month")]
        public string ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public string ExpYear { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("account_name")]
        public string AccountName { get; set; }
    }

    public class TransactionPlan
    {
    }

    public class TransactionData
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("message")]
        public object Message { get; set; }

        [JsonProperty("gateway_response")]
        public string GatewayResponse { get; set; }

        [JsonProperty("paid_at")]
        public DateTime PaidAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("metadata")]
        public int Metadata { get; set; }

        [JsonProperty("log")]
        public TransactionLog Log { get; set; }

        [JsonProperty("fees")]
        public object Fees { get; set; }

        [JsonProperty("customer")]
        public TransactionCustomer Customer { get; set; }

        [JsonProperty("authorization")]
        public TransactionAuthorization Authorization { get; set; }

        [JsonProperty("plan")]
        public TransactionPlan Plan { get; set; }
    }

    public class TransactionHook
    {
        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("data")]
        public TransactionData Data { get; set; }
    }


}
