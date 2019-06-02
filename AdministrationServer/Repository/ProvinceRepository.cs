using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using AdministrationServer.Data;
using AdministrationServer.Interface;
using AdministrationServer.Models;

namespace AdministrationServer.Repository
{
    public class ProvinceRepository : IProvinceRepository
    {
        private readonly ServerDbContext _context;
        public ProvinceRepository(ServerDbContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Province>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Province>> Get(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<Province> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Province>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Province>> GetByName(string name, int pageIndex, int pageSize)
        {
            return _context.Province.Where(a => a.Name.Contains(name));
        }

        public async Task SaveChange()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(Province t)
        {
            throw new NotImplementedException();
        }
    }
}