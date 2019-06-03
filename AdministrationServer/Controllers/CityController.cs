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
    /// 城市（地级市）
    /// </summary>
    public class CityController : ApiController
    {
        /// <summary>
        /// 城市查询
        /// </summary>
        /// <param name="provinceId">省份id</param>
        /// <param name="cityName">城市名</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页数据量</param>
        /// <returns>城市列表</returns>
        [HttpGet]
        public IHttpActionResult Query(int provinceId=0,string cityName="",int pageIndex=1,int pageSize=10)
        {
            using (ServerDbContext _context = new ServerDbContext())
            {
                List<City> cities;
                IQueryable<City> result;
                if (provinceId == 0)
                {
                    if (string.IsNullOrEmpty(cityName))
                    {
                        result = _context.City.AsQueryable();
                    }
                    else { result = _context.City.Where(a => a.Name.Contains(cityName)); }
                }
                else
                {
                    if (string.IsNullOrEmpty(cityName))
                    {
                        result = _context.City.Where(a => a.Id==provinceId);
                    }
                    else { result = _context.City.Where(a =>a.Id == provinceId&&a.Name.Contains(cityName)); }
                }
                 cities = result.OrderBy(a => a.Code).Skip(pageSize*(pageIndex-1)).Take(pageSize).ToList();
                return Json(cities);
            }
        }
    }
}
