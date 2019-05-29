using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdministrationServer.Interface;
using AdministrationServer.Models;

namespace AdministrationServer.Repository
{
    public class ProvinceRepository : IProvinceRepository
    {
        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Province> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Province> Get(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Province GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Province> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Province> GetByName(string name, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public bool Update(Province t)
        {
            throw new NotImplementedException();
        }
    }
}