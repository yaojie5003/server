using AdministrationServer.Core.Models;
using AdministrationServer.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdministrationServerCore.Controllers
{
    /// <summary>
    /// 省、自治区、直辖市
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
       private readonly   IProvinceRepository _provinceRepository;

        /// <summary>
        /// 省、自治区、直辖市
        /// </summary>
        /// <param name="provinceRepository">省、自治区、直辖市接口</param>
        public ProvinceController(IProvinceRepository provinceRepository) { _provinceRepository = provinceRepository; }

        /// <summary>
        /// 获取省、自治区、直辖市列表
        /// </summary>
        /// <returns>省份列表</returns>
        [HttpGet, Route("query"),ProducesResponseType(typeof(List<Province>), StatusCodes.Status200OK)]
        public  async Task<IActionResult> Get()
        {
            var result = await  _provinceRepository.GetList();
            return Ok(result);
        }
        /// <summary>
        /// 通过省、自治区、直辖市的名称获取省、自治区、直辖市
        /// </summary>
        /// <param name="name">省、自治区、直辖市的名称</param>
        /// <returns>省、自治区、直辖市列表</returns>
        [HttpGet, Route("queryByName"), ProducesResponseType(typeof(List<Province>), StatusCodes.Status200OK)]
        public IActionResult QueryByName(string name)
        {
            if (string.IsNullOrEmpty(name)) { return BadRequest("省、自治区、直辖市名称不能为空！"); }
            var result = _provinceRepository.GetProvinceByName(name);
            return Ok(result);
        }
    }
}