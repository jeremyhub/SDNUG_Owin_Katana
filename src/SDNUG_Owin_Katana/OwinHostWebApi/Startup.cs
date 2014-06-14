using System;
using System.Net.Http;
using System.Web.Http;
using Owin;

namespace OwinHostWebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.Run(context =>
            //    {
            //        context.Response.ContentType = "text/plain";
            //        return context.Response.WriteAsync("Hello World 2");
            //    });
            var config = new HttpConfiguration();
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            app.UseWebApi(config);

            //app.Run(context =>
            //    {
            //        var baseUrl = "http://localhost:5000";
            //        var client = new HttpClient();

            //        var response = client.GetAsync(baseUrl + "api/test").Result;

            //        context.Response.ContentType = "text/plain"; 
            //        return context.Response.WriteAsync(response.Content.ReadAsStringAsync().Result);
            //    });
            
        }
    }
}