using AdministrationServer.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AdministrationServer.EntityFrameworkCore
{
    public class CityRepository <TContext>:BaseRepository<City>, ICityRepository where TContext :AdministrationDbcontext
    {
        private TContext _context;
        
        private DbSet<Province> Province { get { return _context.Set<Province>(); } }
        public CityRepository(TContext context):base(context) { _context = context; }

        public City GetCityByCode(string code)
        {
            if (string.IsNullOrEmpty(code)) { return null; }
            if (code.Length<4) { throw new System.Exception("行政区代码有误！"); }
            ThrowIfDisposed();
            code = $"{code.Substring(0, 4)}00";
            return _entity.FirstOrDefault(a => a.Code == code);
        }

        public IEnumerable<City> GetCityByName(string name)
        {
            if (string.IsNullOrEmpty(name)) { return null; }
            ThrowIfDisposed();
            return _entity.Where(a => a.Abbreviation.Contains(name));
        }

        public IEnumerable<City> GetCityByProvience(int provinceId) => _entity.Where(a => a.ProvinceId == provinceId);

        public IEnumerable<City> GetCityByProvinceName(string provinceName)
        {
            if (string.IsNullOrEmpty(provinceName)) { return null; }
            ThrowIfDisposed();
            var province = Province.Where(a => a.Abbreviation.StartsWith(provinceName));
            if (province.Count() == 1)
            {
                return GetCityByProvience(province.First().Id);
            }
            throw new System.Exception("输入省份有误！");
        }

        public IEnumerable<City> GetCityPage(int provinceId, string name, int pageIndex, int pageSize)
        {
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