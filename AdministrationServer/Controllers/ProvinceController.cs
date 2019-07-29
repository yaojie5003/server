using AdministrationServer.Core.Models;
using AdministrationServer.Data;
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
    public class ProvinceController : ApiController
    {
        /// <summary>
        /// 获取省份列表
        /// </summary>
        /// <returns>省份列表</returns>
        [HttpGet, SwaggerResponse(200, "省份列表", typeof(List<Province>))]
        public async Task< IHttpActionResult> Get()
        {
            using (ServerDbContext _context = new ServerDbContext())
            {               
                var result = _context.Province.ToList();
                return Json(result);
            }
        }
        [HttpGet, SwaggerResponse(200, "省份列表", typeof(List<Province>))]
        public async Task<IHttpActionResult> Query(string code,string name="")
        {
            using (ServerDbContext _context = new ServerDbContext())
            {
                IQueryable<Province> provinces;
                provinces = _context.Province.Where(a => a.Code == code);
                var result = provinces.ToList();
                
                return Json(result);
            }
        }
    }
}
