using AdministrationServer.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace AdministrationServer.EntityFrameworkCore
{
    public class CountyRepository<TContext> : BaseRepository<County>, ICountyRepository where TContext :AdministrationDbcontext
    {

        public CountyRepository(TContext dbcontext) : base(dbcontext) { }

        

        public IEnumerable<County> GetCountyByCityId(int cityId) => _entity.Where(a => a.CityId == cityId);

        public IEnumerable<County> GetCountyByCityName(string cityName)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<County> GetCountyPage(int cityId, string countyName, int pageIndex, int pageSize)
        {
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