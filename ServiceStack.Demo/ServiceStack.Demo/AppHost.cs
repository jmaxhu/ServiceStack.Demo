using Funq;
using ServiceStack.Web;
using ServiceStack.Demo.ServiceModel;
using ServiceStack.Demo.ServiceInterface;

namespace ServiceStack.Demo
{
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Default constructor.
        /// Base constructor requires a name and assembly to locate web service classes. 
        /// </summary>
        public AppHost()
            : base("ServiceStack.Demo", typeof(MyServices).Assembly)
        {

        }

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        /// <param name="container"></param>
        public override void Configure(Container container)
        {
            //Config examples
            //this.Plugins.Add(new PostmanFeature());
            //this.Plugins.Add(new CorsFeature());

            this.RegisterTypedResponseFilter<ApiBaseResponse>((req, res, apiRes) =>
            {

            });

            this.ServiceExceptionHandlers.Add((req, reqDto, ex) =>
            {
                var apiEx = ex as ApiException;
                if (apiEx != null)
                {
                    return new ErrorApiResponse { Code = apiEx.Code, Message = apiEx.Message };
                }

                return DtoUtils.CreateErrorResponse(req, ex);
            });
        }
    }
}