using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AppFunc = System.Func<System.Collections.Generic.IDictionary<string, object>, System.Threading.Tasks.Task>;

namespace OwinHelloWorld.Middleware.SdnugMiddlware
{
    public class SdnugMiddlewareComponent
    {
        private readonly AppFunc _next;
        private readonly SdnugMiddlewareOptions _options;

        public SdnugMiddlewareComponent(AppFunc next, SdnugMiddlewareOptions options)
        {
            _next = next;
            _options = options;
        }

        public async Task Invoke(IDictionary<string, object> environment)
        {
            var response = environment["owin.ResponseBody"] as Stream;
            if (response != null)
                using (var writer = new StreamWriter(response))
                {
                    await writer.WriteLineAsync(string.Format("Hello {0}!", _options.Name));
                    foreach (var option in _options.MoreOptions)
                    {
                        await writer.WriteLineAsync(string.Format("Option: {0}", option));
                    }
                }
        }
    }
}