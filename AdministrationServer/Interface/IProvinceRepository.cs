using AdministrationServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationServer.Interface
{
    interface IProvinceRepository :IInterfaceBaseRepository<Province>
    {
        IEnumerable<Province> GetByName(string name);
        IEnumerable<Province> GetByName(string name,int pageIndex, int pageSize);
    }
}
