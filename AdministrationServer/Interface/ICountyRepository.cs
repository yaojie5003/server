using AdministrationServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationServer.Interface
{
    interface ICountyRepository:IInterfaceBaseRepository<County>
    {
        IEnumerable<County> GetByName(string name);
        IEnumerable<County> GetByName(string name, int pageIndex, int pageSize);
    }
}
