using AdministrationServer.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdministrationServer.Core
{
    public interface IQueryRepository<TEntity> : IDisposable where TEntity : IEntity
    {

        /// <summary>
        /// 通过id获取实体
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>实体</returns>
        Task<TEntity> GetById(int id);

        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页数量</param>
        /// <returns>返回的实体</returns>
        Task<IEnumerable<TEntity>> Get(int pageIndex, int pageSize);

    }
}
