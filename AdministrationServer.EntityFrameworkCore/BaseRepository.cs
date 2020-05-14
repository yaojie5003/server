using AdministrationServer.Core;
using AdministrationServer.Core.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AdministrationServer.EntityFrameworkCore
{
    /// <summary>
    /// 基础仓储抽象类
    /// </summary>
    /// <typeparam name="T">实体</typeparam>
    public abstract class BaseRepository<T> : IInterfaceBaseRepository<T>, IQueryRepository<T> where T : class, IEntity
    {
        /// <summary>
        /// 数据上下文
        /// </summary>
        protected internal DbContext _context;
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="context">数据上下文</param>
        public BaseRepository(DbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// 获取实体
        /// </summary>
        protected internal DbSet<T> _entity { get { return _context.Set<T>(); } }
        /// <summary>
        /// 通过id删除实体
        /// </summary>
        /// <param name="id">实体id</param>
        /// <returns></returns>
        public async Task DeleteById(int id)
        {
            ThrowIfDisposed();
            var entity = await _entity.FirstAsync(a => a.Id == id);
            if (entity is null) { throw new ArgumentNullException(nameof(entity)); }
            _entity.Remove(entity);
        }
        private bool _disposed;
        /// <summary>
        /// Throws if this class has been disposed.
        /// </summary>
        protected void ThrowIfDisposed()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(GetType().Name);
            }
        }
        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose() => _disposed = true;
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页条数</param>
        /// <returns></returns>

        public async Task<IEnumerable<T>> Get(int pageIndex, int pageSize)
        {
            if (pageIndex<1) { throw new System.ArgumentException("页码不能小于1！"); }
            if(pageSize<1){ throw new System.ArgumentException("每页条数不能小于1"); }
            ThrowIfDisposed();
            return await _entity.Skip((pageIndex-1) * pageSize).Take(pageSize).ToListAsync();
        }
        /// <summary>
        /// 通过id获取实体
        /// </summary>
        /// <param name="id">实体id</param>
        /// <returns>实体</returns>
        public async Task<T> GetById(int id)
        {
            ThrowIfDisposed();
            return await _entity.FirstOrDefaultAsync(a => a.Id == id);
        }
        /// <summary>
        /// 将所有修改提交到数据库
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>影响条数</returns>
        public async Task<int> SaveChange(CancellationToken cancellationToken = default(CancellationToken))
        {
            ThrowIfDisposed();
            cancellationToken.ThrowIfCancellationRequested();
            return await _context.SaveChangesAsync(cancellationToken);
        }
        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="t">实体</param>
        /// <returns></returns>
        public async Task Update(T t)
        {
            ThrowIfDisposed();
            _entity.Update(t);
        }
    }
}