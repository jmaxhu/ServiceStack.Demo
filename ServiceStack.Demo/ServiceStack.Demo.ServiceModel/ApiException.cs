using System;

namespace ServiceStack.Demo.ServiceModel
{
    public class ApiException : Exception
    {
        public ApiException(int code, string message)
            : base(message)
        {
            Code = code;
            Message = message;
        }

        public int Code { get; set; }

        public string Message { get; set; }
    }
}
