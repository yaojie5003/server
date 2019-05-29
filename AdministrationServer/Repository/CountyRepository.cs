using AdministrationServer.Interface;
using AdministrationServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdministrationServer.Repository
{
    public class CountyRepository : ICountyRepository
    {
        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<County> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<County> Get(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public County GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<County> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<County> GetByName(string name, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public bool Update(County t)
        {
            throw new NotImplementedException();
        }
    }
}