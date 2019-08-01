using AdministrationServer.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace AdministrationServer.EntityFrameworkCore
{
    public class ProvinceRepository<TContext> : BaseRepository<Province>, IProvinceRepository where TContext : AdministrationDbcontext
    {
        private readonly TContext _context;
        public ProvinceRepository(TContext context):base(context)
        {
            _context = context;
        }

        public IEnumerable<Province> GetList() => _entity.AsEnumerable();
      
    }
}