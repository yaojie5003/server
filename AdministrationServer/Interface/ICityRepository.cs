using AdministrationServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationServer.Interface
{
    interface ICityRepository:IInterfaceBaseRepository<City>
    {
        IEnumerable<City> GetByName(string name);
        IEnumerable<City> GetByName(string name, int pageIndex, int pageSize);
    }
}
