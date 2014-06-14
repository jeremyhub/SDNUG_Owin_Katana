using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationDemo.Middleware
{
    public class DemoMiddlewareOption
    {
        /// <summary>
        /// Setup defaults
        /// </summary>
        public DemoMiddlewareOption()
        {
            Name = "Demo Middleware";
            MoreOptions = new List<string>{"A default option"};
        }

        public string Name { get; set; }
        public List<string> MoreOptions { get; set; }
    }
}