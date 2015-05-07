
namespace ServiceStack.Demo.ServiceModel
{
    public abstract class ApiBaseResponse
    {
        public int Code { get; set; }

        public string Message { get; set; }
    }
}
