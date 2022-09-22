namespace PaystackSDK.Paystack.Models
{
    public class BaseResponse<T>
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public BaseResponse()
        {
        }

        public BaseResponse(bool status, string message)
        {
            Status = status;
            Message = message;
        }

        public BaseResponse(bool status, T data)
        {
            Status = status;
            Data = data;
        }

        public BaseResponse(bool status, string message, T data)
        {
            Status = status;
            Message = message;
            Data = data;
        }


    }

    public class BusinessResponse<T>
    {


        public BusinessResponse()
        {

        }

        public BusinessResponse(BusinessResponse<T> response)
        {
            if (response != null)
            {
                Message = response?.Message;
                Status = response.Status;
                Data = response.Data;
            }

        }

        public BusinessResponse(bool isSuccessful, string message)
        {
            Message = message;
            Status = isSuccessful;
        }



        public BusinessResponse(bool isSuccessful, string message, T responseObject)
        {
            Status = isSuccessful;
            Message = message;
            Data = responseObject;
        }
        public bool Status { get; set; }
        public string Message { get; set; }

        public T Data { get; set; }


    }
}
