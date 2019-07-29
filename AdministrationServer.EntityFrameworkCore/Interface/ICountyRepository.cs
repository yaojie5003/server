using AdministrationServer.Core;
using AdministrationServer.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdministrationServer.EntityFrameworkCore
{
    interface ICountyRepository:IInterfaceBaseRepository<County>
    {
        Task<IEnumerable<County>> GetByName(string name);
        Task<IEnumerable<County>> GetByName(string name, int pageIndex, int pageSize);
    }
}
