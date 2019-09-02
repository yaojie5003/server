using AdministrationServer.Core.Models;
using AdministrationServer.EntityFrameworkCore;
using Swashbuckle.Swagger.Annotations;
using System.Collections.Generic;
using System.Web.Http;
using AdministrationServer.Data;

namespace AdministrationServer.Controllers
{
    /// <summary>
    /// 省、自治区、直辖市
    /// </summary>
    [RoutePrefix("api/province")]
    public class ProvinceController : ApiController
    {
        private readonly IProvinceRepository _provinceRepository;
        /// <summary>
        /// 省、自治区、直辖市
        /// </summary>
        /// <param name="repository">省、自治区、直辖市接口</param>
        public ProvinceController(IProvinceRepository provinceRepository )
        {
            _provinceRepository = provinceRepository;
        }
        /// <summary>
        /// 获取省份列表
        /// </summary>
        /// <returns>省份列表</returns>
        [HttpGet, Route("query"), SwaggerResponse(200, "省、自治区、直辖市列表", typeof(List<Province>))]
        public async System.Threading.Tasks.Task<IHttpActionResult> GetAsync()
        {
            var result =await _provinceRepository.GetList();
            return Json(result);
        }
    }
}
