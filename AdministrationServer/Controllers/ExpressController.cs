using AdministrationServer.Core.Models;
using AdministrationServer.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace AdministrationServer.Controllers
{
    /// <summary>
    /// 快递
    /// </summary>
    [RoutePrefix("api/express")]
    public class ExpressController : ApiController
    {
        private readonly IExpressRepository _express;

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="expressRepository"></param>
        public ExpressController()
        {
            _express = LightInjectConfiguration.Instance<IExpressRepository>();
        }
        /// <summary>
        /// 查询列表
        /// </summary>
        /// <returns></returns>
        [HttpGet,Route("query"), Swashbuckle.Swagger.Annotations.SwaggerResponse(200, "快递列表", typeof(List<Express>))]

        public async Task< IHttpActionResult> Get() { var result = await _express.GetList(); return Ok(result); }
    }
}