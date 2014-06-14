using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AppFunc = System.Func<System.Collections.Generic.IDictionary<string, object>, System.Threading.Tasks.Task>;

namespace PresentationDemo.Middleware
{
    public class DemoMiddlewareComponent
    {
        private readonly DemoMiddlewareOption _options;
        private readonly AppFunc _next;

        public DemoMiddlewareComponent(AppFunc next, DemoMiddlewareOption option)
        {
            _next = next;
            _options = option;
        }

        public async Task Invoke(IDictionary<string, object> environment)
        {
            var response = environment["owin.ResponseBody"] as Stream;
            using (var writer = new StreamWriter(response))
            {
                await writer.WriteLineAsync(string.Format("Hello {0}!", _options.Name));
                foreach (var option in _options.MoreOptions)
                {
                    
                    Console.WriteLine("I hope this works");
                    await writer.WriteLineAsync(string.Format("Option: {0}", option));
                    //await null;
                }
            }
        }
    }
}