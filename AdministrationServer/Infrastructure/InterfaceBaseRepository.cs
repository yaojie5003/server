using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationServer
{
    public  interface IInterfaceBaseRepository<T>
    {
        T GetById(int id);
        bool Update(T t);
        bool DeleteById(int id);
        IEnumerable<T> Get();
        IEnumerable<T> Get(int pageIndex, int pageSize);
    }
}
