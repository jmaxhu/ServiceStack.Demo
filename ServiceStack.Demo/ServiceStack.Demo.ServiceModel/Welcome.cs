using System.Collections.Generic;
using ServiceStack.Demo.ServiceModel.Types;

namespace ServiceStack.Demo.ServiceModel
{

    [Route("/welcome", Verbs = "GET")]
    public class Welcome : IReturn<WelcomeResponse>
    {
        public string Words { get; set; }

        public int Times { get; set; }
    }

    public class WelcomeResponse : ApiBaseResponse
    {
        public IList<Person> Persons { get; set; }
    }
}
