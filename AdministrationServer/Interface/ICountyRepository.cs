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
        Task<IEnumerable<County>> GetByName(string name);
        Task<IEnumerable<County>> GetByName(string name, int pageIndex, int pageSize);
    }
}
