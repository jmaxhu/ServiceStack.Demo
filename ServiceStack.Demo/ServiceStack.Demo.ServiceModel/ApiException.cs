using System;

namespace ServiceStack.Demo.ServiceModel
{
    public class ApiException : Exception
    {
        public ApiException(int code, string message)
            : base(message)
        {
            Code = code;
        }

        public int Code { get; set; }
    }
}
