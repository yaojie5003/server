using AdministrationServer.Core.Models;
using AdministrationServer.Data;
using AdministrationServer.EntityFrameworkCore;
using Swashbuckle.Swagger.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace AdministrationServer.Controllers
{
    /// <summary>
    /// 省份
    /// </summary>
    [SwaggerResponse(200, "省份列表")]
    public class ProvinceController : ApiController
    {
        private readonly IProvinceRepository _provinceRepository;
        public ProvinceController(IProvinceRepository repository) { _provinceRepository = repository; }
        /// <summary>
        /// 获取省份列表
        /// </summary>
        /// <returns>省份列表</returns>
        [HttpGet, SwaggerResponse(200, "省份列表", typeof(List<Province>))]
        public async Task<IHttpActionResult> Get()
        {
            var result = _provinceRepository.GetList();
            return Json(result);
        }        
    }
}
