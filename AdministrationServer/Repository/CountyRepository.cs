using AdministrationServer.Interface;
using AdministrationServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AdministrationServer.Repository
{
    public class CountyRepository : ICountyRepository
    {
        public async Task<bool> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<County>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<County>> Get(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<County> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<County>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<County>> GetByName(string name, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task SaveChange()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(County t)
        {
            throw new NotImplementedException();
        }
    }
}