using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using PresentationDemo.Middleware;

namespace OwinHelloWorld.Middleware.SdnugMiddlware
{
    public class DemoMiddlewareComponent
    {
        private readonly DemoMiddlewareOption _options;
        private readonly Func<IDictionary<string, object>, Task> _next;

        public DemoMiddlewareComponent(Func<IDictionary<string, object>, Task> next, DemoMiddlewareOption option)
        {
            _next = next;
            _options = option;
        }

        public async Task Invoke(IDictionary<string, object> environment)
        {
            var response = environment["owin.ResponseBody"] as Stream;
            using (var writer = new StreamWriter(response))
            {
                await writer.WriteLineAsync(string.Format("Demo Component!", _options.Name));
                foreach (var option in _options.MoreOptions)
                {
                    _next.Invoke(environment);
                    Console.WriteLine("I hope this works");
                    await writer.WriteLineAsync(string.Format("Option: {0}", option));                    
                }
            }
        }
    }
}