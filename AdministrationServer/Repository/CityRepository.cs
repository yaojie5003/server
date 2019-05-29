using AdministrationServer.Interface;
using AdministrationServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdministrationServer.Repository
{
    public class CityRepository : ICityRepository
    {
        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> Get(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public City GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetByName(string name, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public bool Update(City t)
        {
            throw new NotImplementedException();
        }
    }
}