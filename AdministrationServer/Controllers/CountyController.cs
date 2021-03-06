﻿using AdministrationServer.Core.Models;
using AdministrationServer.EntityFrameworkCore;
using System.Collections.Generic;
using System.Web.Http;

namespace AdministrationServer.Controllers
{
    /// <summary>
    /// 市辖区、县级市、县…
    /// </summary>
    [RoutePrefix("api/county")]
    public class CountyController : ApiController
    {
        private readonly ICountyRepository _countyRepository;

        /// <summary>
        /// 市辖区、县级市、县
        /// </summary>
        /// <param name="countyRepository">市辖区、县级市、县接口</param>
        public CountyController(ICountyRepository countyRepository)
        {
            _countyRepository = countyRepository;  }

        /// <summary>
        /// 分页市辖区、县级市、县查询
        /// </summary>
        /// <param name="cityId">城市id</param>
        /// <param name="countyName">城市名</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页的数量</param>
        /// <returns>市辖区、县级市、县列表</returns>
        [HttpGet, Route("query"), Swashbuckle.Swagger.Annotations.SwaggerResponse(200, "市辖区、县级市、县列表", typeof(List<County>))]
        public IHttpActionResult Query(int cityId, string countyName = "", int pageIndex = 1, int pageSize = 10)
        {
            if (string.IsNullOrEmpty(countyName)&& cityId<1) { return NotFound(); }

            if (string.IsNullOrEmpty(countyName))
            {
                countyName = "";
            }
            if (pageIndex < 1) { return BadRequest("页码不能小于1！"); }
            if (pageSize < 1) { return BadRequest("每页条数不能小于1！"); }
            return Json(_countyRepository.GetCountyPage(cityId, countyName, pageIndex, pageSize));
        }

        /// <summary>
        /// 根据地级市、地区、自治州、盟id查询市辖区、县级市、县
        /// </summary>
        /// <param name="cityId">城市id</param>
        /// <returns>市辖区、县级市、县列表</returns>
        [HttpGet,Route("getByCity"), Swashbuckle.Swagger.Annotations.SwaggerResponse(200, "市辖区、县级市、县列表", typeof(List<County>))]
        public IHttpActionResult GetByCity(int cityId)
        {
            return Json(_countyRepository.GetCountyByCityId(cityId));
        }

        /// <summary>
        /// 根据市辖区、县级市、县代码获取信息
        /// </summary>
        /// <param name="code">区县代码</param>
        /// <returns>市辖区、县级市、县</returns>
        [HttpGet,Route("queryByCode"), Swashbuckle.Swagger.Annotations.SwaggerResponse(200, "市辖区、县级市、县", typeof(County))]
        public IHttpActionResult QueryByCode(string code)
        {
            if (string.IsNullOrEmpty(code)) { return BadRequest("行政区划代码不能为空！"); }
            return Json(_countyRepository.GetCountyByCode(code));
        }

        /// <summary>
        /// 根据地级市、地区、自治州、盟名称查询市辖区、县级市、县
        /// </summary>
        /// <param name="cityName">地级市、地区、自治州、盟名称</param>
        /// <returns>市辖区、县级市、县列表</returns>
        [HttpGet,Route("queryByCityName"), Swashbuckle.Swagger.Annotations.SwaggerResponse(200, "市辖区、县级市、县列表", typeof(List<County>))]
        public IHttpActionResult QueryByCityName(string cityName)
        {
            if (string.IsNullOrEmpty(cityName)) { return BadRequest("地级市、地区、自治州、盟名称不能为空！"); }
            return Json(_countyRepository.GetCountyByCityName(cityName));
        }
        /// <summary>
        /// 根据市辖区、县级市、县名称查询市辖区、县级市、县
        /// </summary>
        /// <param name="name">市辖区、县级市、县名称</param>
        /// <returns>市辖区、县级市、县列表</returns>
        [HttpGet, Route("queryByName"), Swashbuckle.Swagger.Annotations.SwaggerResponse(200, "市辖区、县级市、县列表", typeof(List<County>))]
        public IHttpActionResult QueryByName(string name)
        {
            if (string.IsNullOrEmpty(name)) { return BadRequest("市辖区、县级市、县名称不能为空！"); }
            return Json(_countyRepository.GetCountyByName(name));
        }
    }
}
