using AdministrationServer.Interface;
using AdministrationServer.Repository;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AdministrationServer
{
    public static class LightInjectConfiguration
    {
        public static void Register(HttpConfiguration configuration)
        {
            var container = new ServiceContainer();
            container.RegisterApiControllers();           
            container.EnableWebApi(configuration);
            container.Register<IProvinceRepository, ProvinceRepository>();
        }
    }
}