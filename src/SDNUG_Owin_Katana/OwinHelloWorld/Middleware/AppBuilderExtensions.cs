using Owin;
using OwinHelloWorld.Middleware.SdnugMiddlware;

namespace OwinHelloWorld.Middleware
{
    public static class AppBuilderExtensions
    {
        public static void UseSdnugMiddleware(this IAppBuilder app, SdnugMiddlewareOptions options = null)
        {
            options = options ?? new SdnugMiddlewareOptions();
            app.Use<SdnugMiddlewareComponent>(options);
        }
    }
}