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
    }
}