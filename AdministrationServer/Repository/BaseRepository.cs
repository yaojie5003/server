﻿using AdministrationServer.Data;
using AdministrationServer.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AdministrationServer.Repository
{
    public class BaseRepository<T> : IInterfaceBaseRepository<T> where T : class ,IEntity
    {
        private DbContext _context;
        public BaseRepository()
        {
            _context = new ServerDbContext();
           // _data= context.Set<T>();
        }
        public Task<bool> DeleteById(int id)
        {

            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> Get(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChange()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}