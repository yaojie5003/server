using AdministrationServer.Controllers;
using AdministrationServer.Data;
using AdministrationServer.EntityFrameworkCore;
using LightInject;
using System.Web.Http;

namespace AdministrationServer
{
    public static class LightInjectConfiguration
    {
        private static readonly ServiceContainer _container = new ServiceContainer();
        public static void Register(HttpConfiguration configuration)
        {
            //_container = new ServiceContainer();
            _container.RegisterApiControllers();
            _container.EnableWebApi(configuration);
            //_container.EnablePerWebRequestScope();
            _container.Register<ServerDbContext>();
            _container.Register<ADMDbcontext>();
            _container.Register<ICityRepository, CityRepository<ADMDbcontext>>();
            _container.Register<IProvinceRepository, ProvinceRepository<ADMDbcontext>>();
            _container.Register<ICountyRepository, CountyRepository<ADMDbcontext>>();

        }
    }
}