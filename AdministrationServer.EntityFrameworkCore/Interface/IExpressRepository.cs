using AdministrationServer.Core;
using AdministrationServer.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdministrationServer.EntityFrameworkCore
{
    /// <summary>
    /// 快递仓储接口
    /// </summary>
    public interface IExpressRepository: IInterfaceBaseRepository<Express>, IQueryRepository<Express>
    {
        /// <summary>
        /// 获取快递列表
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Express>> GetList();
    }
}
