using System.Collections.Generic;
using ServiceStack.Demo.ServiceModel;
using ServiceStack.Demo.ServiceModel.Types;

namespace ServiceStack.Demo.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            //throw new ApiException(-100, "错误<>llie");

            return new HelloResponse { Code = 932, Message = "", Result = string.Format("Hello {0}", request.Name) };
        }

        public object Get(Welcome welcome)
        {
            var persons = new List<Person>();
            for (var i = 0; i < welcome.Times; i++)
            {
                persons.Add(new Person
                {
                    Name = string.Format("{0}_{1}", welcome.Words, i),
                    Age = i
                });
            }

            return new WelcomeResponse { Code = 11, Persons = persons };
        }
    }
}