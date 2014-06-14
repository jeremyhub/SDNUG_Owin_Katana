using System.Collections.Generic;
using System.Web.Http;

namespace OwinHostWebApi.Controllers
{
    public class TestController : ApiController
    {
        // GET api/values 
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        } 
    }
}