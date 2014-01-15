using System.Web.Http;

namespace OwinHostWebApi.Controllers
{
    public class TestController : ApiController
    {
        public string Get()
        {
            return "Hello world";
        }
    }
}