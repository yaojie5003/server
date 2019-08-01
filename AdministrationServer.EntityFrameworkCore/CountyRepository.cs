using AdministrationServer.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace AdministrationServer.EntityFrameworkCore
{
    public class CountyRepository : BaseRepository<County>, ICountyRepository
    {
        public CountyRepository(AdministrationDbcontext dbcontext) : base(dbcontext) { }

        public IEnumerable<County> GetCountyByCityId(int cityId) => _entity.Where(a => a.CityId == cityId);
        
    }
}