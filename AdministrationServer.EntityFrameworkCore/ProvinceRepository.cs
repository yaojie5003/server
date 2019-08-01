using AdministrationServer.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace AdministrationServer.EntityFrameworkCore
{
    public class ProvinceRepository : BaseRepository<Province>, IProvinceRepository
    {
        private readonly AdministrationDbcontext _context;
        public ProvinceRepository(AdministrationDbcontext context):base(context)
        {
            _context = context;
        }

        public IEnumerable<Province> GetList() => _entity.AsEnumerable();
      
    }
}