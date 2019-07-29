using AdministrationServer.Core;
using AdministrationServer.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdministrationServer.EntityFrameworkCore
{
    interface ICityRepository:IInterfaceBaseRepository<City>
    {
       Task<  IEnumerable<City>> GetByName(string name);
       Task< IEnumerable<City>> GetByName(string name, int pageIndex, int pageSize);
    }
}
