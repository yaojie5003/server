using AdministrationServer.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationServer
{
    public  interface IInterfaceBaseRepository<TEntity>: IDisposable where TEntity : IEntity
    {
        Task<TEntity>  GetById(int id);
        Task<bool> Update(TEntity t);
        Task<bool> DeleteById(int id);
        Task< IEnumerable<TEntity>> Get();
        Task< IEnumerable<TEntity>> Get(int pageIndex, int pageSize);
        Task SaveChange();
    }
}
