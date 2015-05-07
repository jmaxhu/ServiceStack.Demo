using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;

namespace ServiceStack.Demo.ServiceModel
{
    [Route("/hello/{Name}")]
    public class Hello : IReturn<ApiResponse>
    {
        public string Name { get; set; }
    }

    //public class HelloResponse : ApiResponse
    //{
    //}
}