using AdministrationServer.Data;
using AdministrationServer.EntityFrameworkCore;
using LightInject;
using System.Web.Http;

namespace AdministrationServer
{
    /// <summary>
    /// LightInject注册类
    /// </summary>
    public static class LightInjectConfiguration
    {
        private static readonly ServiceContainer _container = new ServiceContainer();
        /// <summary>
        /// 注册相关的服务
        /// </summary>
        /// <param name="configuration">配置</param>
        public static void Register(HttpConfiguration configuration)
        {
            //_container = new ServiceContainer();
            _container.RegisterApiControllers();
           
            _container.Register<ADMDbcontext>();
            _container.Register<ICityRepository, CityRepository<ADMDbcontext>>();
            _container.Register<IProvinceRepository, ProvinceRepository<ADMDbcontext>>();
            _container.Register<ICountyRepository, CountyRepository<ADMDbcontext>>();
            _container.Register<IExpressRepository, ExpressRepository<ADMDbcontext>>();
            //_container.EnablePerWebRequestScope();
            _container.EnableWebApi(configuration);

        }
        /// <summary>
        ///     实例化类
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <returns>返回的实例化</returns>
        public static T Instance<T>()
        {
            return _container.GetInstance<T>();
        }
    }
}