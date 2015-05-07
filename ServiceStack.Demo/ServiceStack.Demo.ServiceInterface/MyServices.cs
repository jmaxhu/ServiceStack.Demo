using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using ServiceStack.Demo.ServiceModel;

namespace ServiceStack.Demo.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            throw new ApiException(-100, "错误<>llie");

            return new ApiResponse { Code = 932, Message = "", Result = "Hello, {0}!".Fmt(request.Name) };
        }
    }
}