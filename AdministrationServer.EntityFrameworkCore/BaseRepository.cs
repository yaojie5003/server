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
    public abstract class BaseRepository<T> : IInterfaceBaseRepository<T>,IQueryRepository<T> where T : class ,IEntity
    {
        private DbContext _context;
        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        protected internal DbSet<T> _entity { get { return _context.Set<T>(); } }
    
        public async Task DeleteById(int id)
        {
            ThrowIfDisposed();
            var entity  = await _entity.FirstAsync(a => a.Id == id);
            if (entity is null ) { throw new ArgumentNullException(nameof(entity)); }
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

        public void Dispose() => _disposed = true;


        public async Task<IEnumerable<T>> Get(int pageIndex, int pageSize)
        {
            ThrowIfDisposed();
            return await _entity.Skip(pageIndex * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            ThrowIfDisposed();
            return await _entity.FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<int> SaveChange(CancellationToken cancellationToken = default(CancellationToken))
        {
            ThrowIfDisposed();
            cancellationToken.ThrowIfCancellationRequested();
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Update(T t)
        {
            ThrowIfDisposed();
            _entity.Update(t);
        }
    }
}