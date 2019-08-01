using AdministrationServer.Controllers;
using AdministrationServer.Data;
using AdministrationServer.EntityFrameworkCore;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace AdministrationServer
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
           
            GlobalConfiguration.Configure(WebApiConfig.Register);
            LightInjectConfiguration.Register(GlobalConfiguration.Configuration);
            
        }
    }
}
