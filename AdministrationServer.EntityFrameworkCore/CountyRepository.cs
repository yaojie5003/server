using AdministrationServer.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdministrationServer.EntityFrameworkCore
{
    /// <summary>
    /// 市辖区、县级市、县…仓储
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
    public class CountyRepository<TContext> : BaseRepository<County>, ICountyRepository where TContext : AdministrationDbcontext
    {

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="dbcontext">数据上下文</param>
        public CountyRepository(TContext dbcontext) : base(dbcontext) { }

        /// <summary>
        /// 获取地级市、地区、自治州、盟数据对象
        /// </summary>
        private DbSet<City> _city { get { return _context.Set<City>(); } }

        /// <summary>
        ///  通过地级市、地区、自治州、盟Id查询市辖区、县级市、县…
        /// </summary>
        /// <param name="cityId">地级市、地区、自治州、盟Id</param>
        /// <returns>市辖区、县级市、县…列表</returns>
        public IEnumerable<County> GetCountyByCityId(int cityId) => _entity.Where(a => a.CityId == cityId);

        /// <summary>
        /// 通过地级市、地区、自治州、盟名查询市辖区、县级市、县…
        /// </summary>
        /// <param name="cityName">地级市、地区、自治州、盟名</param>
        /// <returns>市辖区、县级市、县…列表</returns>
        public IEnumerable<County> GetCountyByCityName(string cityName)
        {
            if (string.IsNullOrEmpty(cityName)) { throw new ArgumentNullException("城市名称不能为空！"); }
            ThrowIfDisposed();

            var city = _city.Where(a => a.Abbreviation.StartsWith(cityName));
            if (city.Count() != 1) { return GetCountyByCityId(city.First().Id); }
            throw new System.Exception("输入城市有误！");
        }

        /// <summary>
        /// 通过市辖区、县级市、县…行政区代码查询市辖区、县级市、县…
        /// </summary>
        /// <param name="code">市辖区、县级市、县…行政区代码</param>
        /// <returns>市辖区、县级市、县…</returns>
        public County GetCountyByCode(string code)
        {
            if (string.IsNullOrEmpty(code)) { throw new System.ArgumentNullException("行政区代码不能为空！"); }
            if (System.Text.RegularExpressions.Regex.IsMatch(code, "^[0-9]+$")) { throw new ArgumentException("行政区代码只能包含数字！"); }
            if (code.Length < 6) { throw new System.ArgumentException("行政区代码有误！"); }
            ThrowIfDisposed();
            code = $"{code.Substring(0, 6)}";
            return _entity.FirstOrDefault(a => a.Code == code);
        }

        /// <summary>
        /// 分页查询市辖区、县级市、县…
        /// </summary>
        /// <param name="cityId">地级市、地区、自治州、盟Id</param>
        /// <param name="countyName">辖区、县级市、县…名称</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页大小</param>
        /// <returns>市辖区、县级市、县…列表</returns>
        public IEnumerable<County> GetCountyPage(int cityId, string countyName, int pageIndex, int pageSize)
        {
            if (pageIndex < 1) { throw new System.ArgumentException("页码不能小于1！"); }
            if (pageSize < 1) { throw new System.ArgumentException("每页条数不能小于1"); }
            if (string.IsNullOrEmpty(countyName) && cityId == 0)
            {
                return new List<County>();
            }
            ThrowIfDisposed();
            IEnumerable<County> result;
            if (cityId == 0) { result = _entity.Where(a => a.Abbreviation.Contains(countyName)); }
            else { result = _entity.Where(a => a.CityId == cityId && a.Abbreviation.Contains(countyName)); }
            return result.OrderBy(a => a.Code).Skip(pageSize * (pageIndex - 1)).Take(pageSize);

        }
    }
}