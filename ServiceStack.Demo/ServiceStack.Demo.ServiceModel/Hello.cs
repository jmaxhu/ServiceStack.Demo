
namespace ServiceStack.Demo.ServiceModel
{
    [Route("/hello/{Name}")]
    public class Hello : IReturn<ApiBaseResponse>
    {
        public string Name { get; set; }
    }

    public class HelloResponse : ApiBaseResponse
    {
        public string Result { get; set; }
    }
}