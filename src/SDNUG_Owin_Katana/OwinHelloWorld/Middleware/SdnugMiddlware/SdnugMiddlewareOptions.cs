using System.Collections.Generic;

namespace OwinHelloWorld.Middleware.SdnugMiddlware
{
    public class SdnugMiddlewareOptions
    {
        /// <summary>
        /// Setup defaults
        /// </summary>
        public SdnugMiddlewareOptions()
        {
            Name = "SDNUG Middleware";
            MoreOptions = new List<string>{"A default option"};
        }

        public string Name { get; set; }
        public List<string> MoreOptions { get; set; }
    }
}