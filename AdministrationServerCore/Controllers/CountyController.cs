using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdministrationServer.Core.Models;
using AdministrationServer.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdministrationServerCore.Controllers
{
    /// <summary>
    /// 市辖区、县级市、县
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CountyController : ControllerBase
    {
        private readonly ICountyRepository _countyRepository;
        /// <summary>
        /// 市辖区、县级市、县
        /// </summary>
        /// <param name="countyRepository">市辖区、县级市、县接口</param>
        public CountyController(ICountyRepository countyRepository) { _countyRepository = countyRepository; }
        /// <summary>
        /// 分页市辖区、县级市、县查询
        /// </summary>
        /// <param name="cityId">城市id</param>
        /// <param name="countyName">城市名</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页的数量</param>
        /// <returns>市辖区、县级市、县列表</returns>
        [HttpGet,Route("query"), ProducesResponseType( typeof(List<County>),200)]
        public IActionResult Query(int cityId, string countyName = "", int pageIndex = 1, int pageSize = 10)
        {
            if (string.IsNullOrEmpty(countyName) && cityId < 1) { return NotFound(); }
            if (pageIndex < 1) { return BadRequest("页码不能小于1！"); }
            if (pageSize < 1) { return BadRequest("每页条数不能小于1！"); }
            return Ok(_countyRepository.GetCountyPage(cityId, countyName, pageIndex, pageSize));
        }
        /// <summary>
        /// 根据地级市、地区、自治州、盟id查询市辖区、县级市、县
        /// </summary>
        /// <param name="cityId">城市id</param>
        /// <returns>市辖区、县级市、县列表</returns>
        [HttpGet,Route("queryByCity"), ProducesResponseType(  typeof(List<County>), 200)]
        public IActionResult GetByCity(int cityId)
        {
            return Ok(_countyRepository.GetCountyByCityId(cityId));
        }
        /// <summary>
        /// 根据市辖区、县级市、县代码获取信息
        /// </summary>
        /// <param name="code">区县代码</param>
        /// <returns>市辖区、县级市、县</returns>
        [HttpGet, Route("queryByCode"), ProducesResponseType(  typeof(County), 200)]
        public IActionResult QueryByCode(string code)
        {
            if (string.IsNullOrEmpty(code)) { return BadRequest("行政区划代码不能为空！"); }
            return Ok(_countyRepository.GetCountyByCode(code));
        }
        /// <summary>
        /// 根据地级市、地区、自治州、盟名称查询市辖区、县级市、县
        /// </summary>
        /// <param name="cityName">地级市、地区、自治州、盟名称</param>
        /// <returns>市辖区、县级市、县列表</returns>
        [HttpGet ,Route("queryByCityName"), ProducesResponseType(  typeof(List<County>), 200)]
        public IActionResult QueryByCityName(string cityName)
        {
            if (string.IsNullOrEmpty(cityName)) { return BadRequest("地级市、地区、自治州、盟名称不能为空！"); }
            return Ok(_countyRepository.GetCountyByCityName(cityName));
        }
    }
}