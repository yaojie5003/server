using AdministrationServer.Core.Infrastructure;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AdministrationServer.Core
{
    /// <summary>
    /// 基于仓储基础接口
    /// </summary>
    /// <typeparam name="TEntity">实体</typeparam>
    public interface IInterfaceBaseRepository<TEntity>: IDisposable where TEntity : IEntity
    {
        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="t">实体</param>
        /// <returns>更新结果</returns>
        Task Update(TEntity t);
        /// <summary>
        /// 根据id删除实体
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>删除结果</returns>
        Task DeleteById(int id);
        ///// <summary>
        ///// 获取实体
        ///// </summary>
        ///// <returns>实体列表</returns>
        //Task< IEnumerable<TEntity>> Get();
      
        /// <summary>
        /// 保存更改
        /// </summary>
        /// <returns>影响条数</returns>
        Task<int> SaveChange(CancellationToken cancellationToken);
    }
}
