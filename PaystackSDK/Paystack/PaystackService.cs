using Gasify.ExternalServices.Paystack.Models;
using PaystackSDK.Client;
using PaystackSDK.Exceptions;
using PaystackSDK.Paystack.Models;
using RestSharp;

namespace Gasify.ExternalServices.Paystack
{
    public class PaystackService: IPaystackService
    {
        private const string BaseUri = "https://api.paystack.co/";
        private const string SecretKey = "SHOULD BE KEPT SOMEWHERE SAFE";

        public PaystackService()
        {
            ApiClient = new ApiClient(BaseUri);
        }

        public BaseResponse<InitializeTransactionResponse> InitializeTransaction(InitializeTransactionRequestBody body, string origin)
        {
            if (body is null) throw new ApiException(400, "Missing required parameter 'body' when calling InitializeTransaction");

            if (string.IsNullOrWhiteSpace(body.Email)) throw new ApiException(400, "Missing required property 'Email' when calling InitializeTransaction");

            if (string.IsNullOrWhiteSpace(body.Amount)) throw new ApiException(400, "Missing required property 'Amount' when calling InitializeTransaction");

            body.CallbackUrl = $"{origin}/verify-transaction";
            

            var postBody = ApiClient.Serialize(body);

            var path = "transaction/initialize";

            var authSettings = new string[] { "bearer" };

            var headerParams = new Dictionary<string, string>();

            var result = new BaseResponse<InitializeTransactionResponse>();

            try {
                var response = (RestResponse )ApiClient.CallApi(path, Method.Post, SecretKey, authSettings, postBody: postBody, headerParams: headerParams);

                result = (BaseResponse<InitializeTransactionResponse>) ApiClient.Deserialize(response.Content, typeof(BaseResponse<InitializeTransactionResponse>));
            }
            catch(Exception e)
            {
                throw new ApiException(500, e.Message);
            }
            return result;
        }

        public BaseResponse<VerifyTransactionResponse> VerifyTransaction(string reference)
        {
            if (string.IsNullOrWhiteSpace(reference)) throw new ApiException(400, "Missing required parameter 'reference' when calling VerifyTransaction");

            var path = "transaction/verify/" + reference;

            var authSettings = new string[] { "bearer" };

            var headerParams = new Dictionary<string, string>();

            var result = new BaseResponse<VerifyTransactionResponse>();

            try
            {
                var response = (RestResponse )ApiClient.CallApi(path, Method.Get, SecretKey, authSettings, headerParams: headerParams);

                result = (BaseResponse<VerifyTransactionResponse>)ApiClient.Deserialize(response.Content, typeof(BaseResponse<VerifyTransactionResponse>));
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
            return result;
        }

        public BaseResponse<AccountResolveResponse> ResolveAccount(string accountNumber, string bankCode)
        {
            if (string.IsNullOrWhiteSpace(accountNumber)) throw new ApiException(400, "Missing required parameter 'accountNumber' when calling VerifyTransaction");
            if (string.IsNullOrWhiteSpace(bankCode)) throw new ApiException(400, "Missing required parameter 'bankCode' when calling VerifyTransaction");

            var path = $"bank/resolve?account_number={accountNumber}&bank_code={bankCode}";

            var authSettings = new string[] { "bearer" };

            var headerParams = new Dictionary<string, string>();

            var result = new BaseResponse<AccountResolveResponse>();

            try
            {
                var response = (RestResponse )ApiClient.CallApi(path, Method.Get, SecretKey, authSettings, headerParams: headerParams);

                result = (BaseResponse<AccountResolveResponse>)ApiClient.Deserialize(response.Content,
                    typeof(BaseResponse<AccountResolveResponse>));
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
            return result;
        }

        public BusinessResponse<IList<PaystackBank>> GetPaystackBanks()
        {
            var path = "bank";

            var authSettings = new string[] { "bearer" };

            var headerParams = new Dictionary<string, string>();

            var queryParams = new Dictionary<string, string>
            {
                { "country", "nigeria" }
            };

            var result = new BusinessResponse<IList<PaystackBank>>();

            try
            {
                var response = (RestResponse )ApiClient.CallApi(path, Method.Get, SecretKey, authSettings, headerParams: headerParams, queryParams: queryParams);

                result = (BusinessResponse<IList<PaystackBank>>)ApiClient.Deserialize(response.Content, typeof(BusinessResponse<IList<PaystackBank>>));
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
            return result;
        }

        public BaseResponse<RecipientResponse> CreateTransferRecipient(TransferRecipient model)
        {
            if (model is null) throw new ApiException(400, "Missing required parameter 'model' when calling InitializeTransaction");

            if (string.IsNullOrWhiteSpace(model.AccountNumber)) throw new ApiException(400, "Missing required property 'AccountNumber' when calling CreateTransferRecipient");

            if (string.IsNullOrWhiteSpace(model.Name)) throw new ApiException(400, "Missing required property 'Name' when calling CreateTransferRecipient");

            if (string.IsNullOrWhiteSpace(model.BankCode)) throw new ApiException(400, "Missing required property 'BankCode' when calling CreateTransferRecipient");

            if (string.IsNullOrWhiteSpace(model.Type)) throw new ApiException(400, "Missing required property 'Type' when calling CreateTransferRecipient");

            var body = ApiClient.Serialize(model);

            var path = "transferrecipient";

            var authSettings = new string[] { "bearer" };

            var headerParams = new Dictionary<string, string>();

            var result = new BaseResponse<RecipientResponse>();

            try
            {
                var response = (RestResponse )ApiClient.CallApi(path, Method.Post, SecretKey, authSettings, postBody: body, headerParams: headerParams);

                result = (BaseResponse<RecipientResponse>)ApiClient.Deserialize(response.Content, typeof(BaseResponse<RecipientResponse>));
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
            return result;
        }

        public BaseResponse<TransferResponse> InitiateTransfer(TransferRequestBody model)
        {
            if (model is null) throw new ApiException(400, "Missing required parameter 'model' when calling InitiateTransfer");

            if (model.Amount < 100m) throw new ApiException(400, "Transfer amount too low");

            if (string.IsNullOrWhiteSpace(model.Source)) throw new ApiException(400, "Missing required property 'Source' when calling InitiateTransfer");

            if (string.IsNullOrWhiteSpace(model.Recipient)) throw new ApiException(400, "Missing required property 'Recipient' when calling InitiateTransfer");

            if (string.IsNullOrWhiteSpace(model.Reference)) throw new ApiException(400, "Missing required property 'Reference' when calling InitiateTransfer");

            var body = ApiClient.Serialize(model);

            var path = "transfer";

            var authSettings = new string[] { "bearer" };

            var headerParams = new Dictionary<string, string>();

            var result = new BaseResponse<TransferResponse>();

            try
            {
                var response = (RestResponse)ApiClient.CallApi(path, Method.Post, SecretKey, authSettings, postBody: body, headerParams: headerParams);

                result = (BaseResponse<TransferResponse>)ApiClient.Deserialize(response.Content, typeof(BaseResponse<TransferResponse>));
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
            return result;
        }

        public ApiClient ApiClient { get; set; }
    }

    public interface IPaystackService
    {
        BaseResponse<InitializeTransactionResponse> InitializeTransaction(InitializeTransactionRequestBody body, string origin);

        BaseResponse<VerifyTransactionResponse> VerifyTransaction(string reference);

        BaseResponse<AccountResolveResponse> ResolveAccount(string accountNumber, string bankCode);

        BusinessResponse<IList<PaystackBank>> GetPaystackBanks();

        BaseResponse<RecipientResponse> CreateTransferRecipient(TransferRecipient model);

        BaseResponse<TransferResponse> InitiateTransfer(TransferRequestBody model);
    }
}
