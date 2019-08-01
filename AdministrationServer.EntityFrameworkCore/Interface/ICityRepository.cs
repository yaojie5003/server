using AdministrationServer.Core;
using AdministrationServer.Core.Models;
using System.Collections.Generic;

namespace AdministrationServer.EntityFrameworkCore
{
    public interface ICityRepository:IInterfaceBaseRepository<City>, IQueryRepository<City>
    {
        IEnumerable<City> GetCityByProvience(int provinceId);
    }
}
