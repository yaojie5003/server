using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AdministrationServer.Startup))]

namespace AdministrationServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            LightInjectConfiguration.Register(config);
            SwaggerConfig.Register(config);
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}
