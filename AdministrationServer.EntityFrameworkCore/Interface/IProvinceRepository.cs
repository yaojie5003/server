using AdministrationServer.Core;
using AdministrationServer.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdministrationServer.EntityFrameworkCore
{
    interface IProvinceRepository :IInterfaceBaseRepository<Province>
    {
        Task<IEnumerable<Province>> GetByName(string name);
        Task<IEnumerable<Province>> GetByName(string name,int pageIndex, int pageSize);
       
    }
}
