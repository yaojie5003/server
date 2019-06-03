using AdministrationServer.Data;
using LightInject;
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
            container.Register<ServerDbContext>();

            //container.Register<IProvinceRepository, ProvinceRepository>();
            //container.Register<ICountyRepository, CountyRepository>();
            //container.Register<ICityRepository, CityRepository>();
        }
    }
}