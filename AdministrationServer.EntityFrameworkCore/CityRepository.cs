using AdministrationServer.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace AdministrationServer.EntityFrameworkCore
{
    public class CityRepository :BaseRepository<City>, ICityRepository
    {
        private AdministrationDbcontext _context;
        
        public CityRepository(AdministrationDbcontext context):base(context) { _context = context; }

        public IEnumerable<City> GetCityByProvience(int provinceId) => _entity.Where(a => a.ProvinceId == provinceId);
        
    }
}