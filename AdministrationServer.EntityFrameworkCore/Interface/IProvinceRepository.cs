using AdministrationServer.Core;
using AdministrationServer.Core.Models;
using System.Collections.Generic;

namespace AdministrationServer.EntityFrameworkCore
{
    public  interface IProvinceRepository : IInterfaceBaseRepository<Province>, IQueryRepository<Province>
    {      
       IEnumerable<Province> GetList();
    }
}
