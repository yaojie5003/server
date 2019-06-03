using AdministrationServer.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationServer
{
    /// <summary>
    /// 仓储基础接口
    /// </summary>
    /// <typeparam name="TEntity">实体</typeparam>
    public  interface IInterfaceBaseRepository<TEntity>: IDisposable where TEntity : IEntity
    {
        /// <summary>
        /// 通过id获取实体
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>实体</returns>
        Task<TEntity>  GetById(int id);
        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="t">实体</param>
        /// <returns>更新结果</returns>
        Task<bool> Update(TEntity t);
        /// <summary>
        /// 根据id删除实体
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>删除结果</returns>
        Task<bool> DeleteById(int id);
        /// <summary>
        /// 获取实体
        /// </summary>
        /// <returns>实体列表</returns>
        Task< IEnumerable<TEntity>> Get();
        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页数量</param>
        /// <returns>返回的实体</returns>
        Task< IEnumerable<TEntity>> Get(int pageIndex, int pageSize);
        /// <summary>
        /// 保存更改
        /// </summary>
        /// <returns></returns>
        Task SaveChange();
    }
}
