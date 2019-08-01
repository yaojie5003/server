using AdministrationServer.Core;
using AdministrationServer.Core.Models;
using System.Collections.Generic;

namespace AdministrationServer.EntityFrameworkCore
{
    public interface ICountyRepository:IInterfaceBaseRepository<County>, IQueryRepository<County>
    {
        IEnumerable<County> GetCountyByCityId(int cityId);
        IEnumerable<County> GetCountyPage(int cityId, string countyName, int pageIndex, int pageSize);
        IEnumerable<County> GetCountyByCityName(string cityName);
    }
}
