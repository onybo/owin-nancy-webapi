using System.Web.Http;

namespace OwinTest
{
    [RoutePrefix("webapi")]
    public class WebApiController : ApiController
    {
        [Route]
        public IHttpActionResult Get()
        {
            return Ok("Hello from WebAPI");
        }
    }
}