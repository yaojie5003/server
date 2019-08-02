using AdministrationServer.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AdministrationServer.EntityFrameworkCore
{
    /// <summary>
    /// 地级市、地区、自治州、盟查询仓储
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
    public class CityRepository <TContext>:BaseRepository<City>, ICityRepository where TContext :AdministrationDbcontext
    {

        /// <summary>
        /// 获取省份数据对象
        /// </summary>          
        private DbSet<Province> Province { get { return _context.Set<Province>(); } }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="context">数据上下文</param>
        public CityRepository(TContext context):base(context) { _context = context; }

        /// <summary>
        /// 通过行政区划代码查询地级市、地区、自治州、盟
        /// </summary>
        /// <param name="code">地级市、地区、自治州、盟行政区划代码</param>
        /// <returns></returns>
        public City GetCityByCode(string code)
        {
            if (string.IsNullOrEmpty(code)) { throw new System.ArgumentNullException("行政区代码不能为空！"); }
            if (System.Text.RegularExpressions.Regex.IsMatch(code, "^[0-9]+$")) { throw new System.ArgumentException("行政区代码只能包含数字！"); }
            if (code.Length<4) { throw new System.ArgumentException("行政区代码有误！"); }
            ThrowIfDisposed();
            code = $"{code.Substring(0, 4)}00";
            return _entity.FirstOrDefault(a => a.Code == code);
        }

        /// <summary>
        /// 通过地级市、地区、自治州、盟的名称获取地级市、地区、自治州、盟
        /// </summary>
        /// <param name="name">地级市、地区、自治州、盟的名称</param>
        /// <returns>地级市、地区、自治州、盟</returns>
        public IEnumerable<City> GetCityByName(string name)
        {
            if (string.IsNullOrEmpty(name)) { throw new System.ArgumentNullException("城市名不能为空！"); }
            ThrowIfDisposed();
            return _entity.Where(a => a.Abbreviation.Contains(name));
        }

        /// <summary>
        /// 通过地级市、地区、自治州、盟id获取地级市、地区、自治州、盟
        /// </summary>
        /// <param name="provinceId">地级市、地区、自治州、盟id</param>
        /// <returns>地级市、地区、自治州、盟列表</returns>
        public IEnumerable<City> GetCityByProvience(int provinceId) => _entity.Where(a => a.ProvinceId == provinceId);

        /// <summary>
        ///  通过省、自治区、直辖市名称获取地级市、地区、自治州、盟
        /// </summary>
        /// <param name="provinceName">省、自治区、直辖市名称</param>
        /// <returns>地级市、地区、自治州、盟列表</returns>
        public IEnumerable<City> GetCityByProvinceName(string provinceName)
        {
            if (string.IsNullOrEmpty(provinceName)) { throw new System.ArgumentNullException("省份不能为空！"); }
            ThrowIfDisposed();
            var province = Province.Where(a => a.Abbreviation.StartsWith(provinceName));
            if (province.Count() == 1)
            {
                return GetCityByProvience(province.First().Id);
            }
            throw new System.ArgumentException("输入省份有误！");
        }

        /// <summary>
        /// 分页查询地级市、地区、自治州、盟
        /// </summary>
        /// <param name="provinceId">省、自治区、直辖市id</param>
        /// <param name="name">地级市、地区、自治州、盟名称</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页大小</param>
        /// <returns>地级市、地区、自治州、盟列表</returns>
        public IEnumerable<City> GetCityPage(int provinceId, string name, int pageIndex, int pageSize)
        {
            if (pageIndex < 1) { throw new System.ArgumentException("页码不能小于1！"); }
            if (pageSize < 1) { throw new System.ArgumentException("每页条数不能小于1"); }
            if (string.IsNullOrEmpty(name)&& provinceId==0)
            {
                return new List<City>();
            }
            ThrowIfDisposed();
            IEnumerable<City> result;
            if (provinceId == 0) { result = _entity.Where(a => a.Abbreviation.Contains(name)); }
            else { result = _entity.Where(a => a.ProvinceId == provinceId && a.Abbreviation.Contains(name)); }
            return  result.OrderBy(a => a.Code).Skip(pageSize * (pageIndex - 1)).Take(pageSize);

        }
    }
}