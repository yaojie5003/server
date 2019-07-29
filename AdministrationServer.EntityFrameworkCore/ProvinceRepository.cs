using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdministrationServer.Core;
using AdministrationServer.Core.Models;

namespace AdministrationServer.EntityFrameworkCore
{
    public class ProvinceRepository : IProvinceRepository
    {
        private readonly AdministrationDbcontext _context;
        public ProvinceRepository(AdministrationDbcontext context)
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
            return _context.provinces.Where(a => a.Name.Contains(name));
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