using Owin;
using OwinHelloWorld.Middleware;
using PresentationDemo.Middleware;
using DemoMiddlewareComponent = OwinHelloWorld.Middleware.SdnugMiddlware.DemoMiddlewareComponent;

namespace OwinHelloWorld
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
            app.UseSdnugMiddleware();
            app.Use<DemoMiddlewareComponent>(
                new DemoMiddlewareOption());
            
        }                        
    }
}