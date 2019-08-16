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
    /// 快递
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ExpressController : ControllerBase
    {
        private readonly IExpressRepository _express;
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="expressRepository"></param>
        public ExpressController(IExpressRepository expressRepository) { _express = expressRepository; }
        /// <summary>
        /// 查询快递列表
        /// </summary>
        /// <returns></returns>
        [HttpGet,Route ("query"), ProducesResponseType(typeof(List<Express>),200)]
        public async Task<IActionResult> Get() { var result= await _express.GetList();  return Ok(result); }
    }
}