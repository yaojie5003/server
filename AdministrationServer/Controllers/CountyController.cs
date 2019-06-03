using AdministrationServer.Data;
using AdministrationServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AdministrationServer.Controllers
{
    /// <summary>
    /// 区县
    /// </summary>
    public class CountyController : ApiController
    {
        /// <summary>
        /// 区县查询
        /// </summary>
        /// <param name="cityId">城市id</param>
        /// <param name="countyName">城市名</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页的数量</param>
        /// <returns>查询的记录条数</returns>
        [HttpGet]
        public IHttpActionResult Query(int cityId, string countyName="", int pageIndex=1, int pageSize=10 )
        {
            using (ServerDbContext _context = new ServerDbContext())
            {
                List<County> counties;
                counties = _context.County.Where(a => string.IsNullOrEmpty(countyName) ? a.CityId == cityId :  a.CityId == cityId && a.Name.Contains(countyName)).OrderBy(a=>a.Code).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
                return Json(counties);
            }
        }
    }
}
