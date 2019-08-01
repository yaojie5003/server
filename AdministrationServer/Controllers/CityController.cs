using AdministrationServer.Core.Models;
using AdministrationServer.Data;
using AdministrationServer.EntityFrameworkCore;
using Swashbuckle.Swagger.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AdministrationServer.Controllers
{
    /// <summary>
    ///  地级市、地区、自治州、盟
    /// </summary>
    
    public class CityController : ApiController
    {
        private readonly ICityRepository _cityRepository;
        public CityController(ICityRepository cityRepository) { _cityRepository = cityRepository; }
        /// <summary>
        /// 城市查询
        /// </summary>
        /// <param name="provinceId">省份id</param>
        /// <param name="cityName">城市名</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页数据量</param>
        /// <returns>城市列表</returns>
        [HttpGet]
        public IHttpActionResult Query(int provinceId = 0, string cityName = "", int pageIndex = 1, int pageSize = 10)
        {
          return  Json( _cityRepository.GetCityPage(provinceId, cityName, pageIndex, pageSize));
            //using (ServerDbContext _context = new ServerDbContext())
            //{
            //    List<City> cities;
            //    IEnumerable<City> result;
            //    if (provinceId == 0)
            //    {
            //        if (string.IsNullOrEmpty(cityName))
            //        {
            //            result = _context.City.AsQueryable();
            //        }
            //        else { result = _context.Database.SqlQuery<City>("SELECT * FROM City WHERE Name LIKE '%" + cityName + "%'").AsEnumerable(); }
            //    }
            //    else
            //    {
            //        if (string.IsNullOrEmpty(cityName))
            //        {
            //            result = _context.City.Where(a => a.ProvinceId == provinceId);
            //        }
            //        else { result = _context.City.Where(a => a.ProvinceId == provinceId && a.Name.Contains(cityName)); }
            //    }
            //    cities = result.OrderBy(a => a.Code).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
            //    return Json(cities);
            //}
        }
        /// <summary>
        /// 城市查询
        /// </summary>
        /// <param name="provinceId"></param>
        /// <returns></returns>
        [HttpGet, SwaggerResponse(200, "地级市、地区、自治州、盟列表", typeof(List<City>))]
        public IHttpActionResult QueryByProvinceId(int provinceId)
        {
           var result=  _cityRepository.GetCityByProvience(provinceId);
            return Json(result);
        }
        /// <summary>
        /// 城市查询
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        [HttpGet, SwaggerResponse(200, "地级市、地区、自治州、盟列表", typeof(City))]
        public IHttpActionResult QueryByCode(string code)
        {
            var result = _cityRepository.GetCityByCode(code);
            return Json(result);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult QueryByName(string name)
        {
            var result = _cityRepository.GetCityByName(name);
            return Json(result);
        }
    }
}
