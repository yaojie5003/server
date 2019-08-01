using AdministrationServer.Core;
using AdministrationServer.Core.Models;
using System.Collections.Generic;

namespace AdministrationServer.EntityFrameworkCore
{
    /// <summary>
    /// 省、自治区、直辖市查询接口
    /// </summary>
    public  interface IProvinceRepository : IInterfaceBaseRepository<Province>, IQueryRepository<Province>
    {
        /// <summary>
        /// 获取省、自治区、直辖市
        /// </summary>
        /// <returns>省、自治区、直辖市列表</returns>
        IEnumerable<Province> GetList();
    }
}
