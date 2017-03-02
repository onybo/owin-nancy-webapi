using Microsoft.Owin;
using Owin;
using System.Web.Http;

namespace OwinTest
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapWhen(a => !IsNancyRoute(a), WebApiConfiguration);
            app.MapWhen(IsNancyRoute, NancyConfiguration);
        }

        private void WebApiConfiguration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();

            app.UseWebApi(config);
        }

        private void NancyConfiguration(IAppBuilder app)
        {
            app.UseNancy();
        }

        private bool IsNancyRoute(IOwinContext context)
        {
            return context
                .Request
                .Path
                .StartsWithSegments(
                    new PathString("/nancy"));
        }        
    }
}