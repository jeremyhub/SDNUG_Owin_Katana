using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;
using PresentationDemo.Middleware;

namespace PresentationDemo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.Run(context =>
            //{
            //    context.Response.ContentType = "text/plain";
            //    return context.Response.WriteAsync("Hello World!");
            //});

            //app.Use()
            app.Use<DemoMiddlewareComponent>(new DemoMiddlewareOption());
            
        }
    }
}