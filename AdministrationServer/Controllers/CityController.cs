using AdministrationServer.Core.Models;
using AdministrationServer.EntityFrameworkCore;
using Swashbuckle.Swagger.Annotations;
using System.Collections.Generic;
using System.Web.Http;

namespace AdministrationServer.Controllers
{
    /// <summary>
    ///  地级市、地区、自治州、盟
    /// </summary>
    [RoutePrefix("api/city")]
    public class CityController : ApiController
    {
        private readonly ICityRepository _cityRepository;

        /// <summary>
        /// 地级市、地区、自治州、盟
        /// </summary>
        /// <param name="cityRepository">仓储接口</param>
        public CityController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;  }

        /// <summary>
        /// 地级市、地区、自治州、盟分页查询
        /// </summary>
        /// <param name="provinceId">省份id</param>
        /// <param name="cityName">地级市、地区、自治州、盟名</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页数据量</param>
        /// <returns>地级市、地区、自治州、盟列表</returns>
        [HttpGet, Route("query"), SwaggerResponse(200, "地级市、地区、自治州、盟列表", typeof(List<City>))]
        public IHttpActionResult Query(int provinceId = 0, string cityName = "", int pageIndex = 1, int pageSize = 10)
        {
            if (string.IsNullOrEmpty(cityName) && provinceId < 1) { return NotFound(); }
            if (pageIndex < 1) { return BadRequest("页码不能小于1！"); }
            if (pageSize < 1) { return BadRequest("每页条数不能小于1！"); }
            return  Json( _cityRepository.GetCityPage(provinceId, cityName, pageIndex, pageSize));           
        }

        /// <summary>
        /// 通过地级市、地区、自治州、盟id获取地级市、地区、自治州、盟
        /// </summary>
        /// <param name="provinceId">地级市、地区、自治州、盟id</param>
        /// <returns>地级市、地区、自治州、盟列表</returns>
        [HttpGet,Route("queryByProvinceId"), SwaggerResponse(200, "地级市、地区、自治州、盟列表", typeof(List<City>))]
        public IHttpActionResult QueryByProvinceId(int provinceId)
        {          
           var result=  _cityRepository.GetCityByProvience(provinceId);
            return Json(result);
        }

        /// <summary>
        /// 地级市、地区、自治州、盟查询
        /// </summary>
        /// <param name="code">行政区划代码</param>
        /// <returns>地级市、地区、自治州、盟</returns>
        [HttpGet,Route("queryByCode"), SwaggerResponse(200, "地级市、地区、自治州、盟", typeof(City))]
        public IHttpActionResult QueryByCode(string code)
        {
            if (string.IsNullOrEmpty(code)) { return BadRequest("行政区划代码不能为空！"); }
            var result = _cityRepository.GetCityByCode(code);
            return Json(result);
        }

        /// <summary>
        /// 通过地级市、地区、自治州、盟的名称获取地级市、地区、自治州、盟
        /// </summary>
        /// <param name="name">地级市、地区、自治州、盟的名称</param>
        /// <returns>地级市、地区、自治州、盟列表</returns>
        [HttpGet,Route("queryByName"), SwaggerResponse(200, "地级市、地区、自治州、盟列表", typeof(List<City>))]
        public IHttpActionResult QueryByName(string name)
        {
            if (string.IsNullOrEmpty(name)) { return BadRequest("地级市、地区、自治州、盟名称不能为空！"); }
            var result = _cityRepository.GetCityByName(name);
            return Json(result);
        }
    }
}
