using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdministrationServer.Core.Models;

namespace AdministrationServer.EntityFrameworkCore
{
    public class CityRepository : ICityRepository
    {
        public async Task<bool> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<City>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<City>> Get(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<City> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<City>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<City>> GetByName(string name, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task SaveChange()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(City t)
        {
            throw new NotImplementedException();
        }
    }
}