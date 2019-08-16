using AdministrationServer.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationServer.EntityFrameworkCore
{
    /// <summary>
    /// 快递信息仓储
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
    public class ExpressRepository<TContext> : BaseRepository<Express>, IExpressRepository where TContext : AdministrationDbcontext
    {
        /// <summary>
        /// 获取快递数据对象
        /// </summary>          
        private DbSet<Express> Express { get { return _context.Set<Express>(); } }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="context">数据上下文</param>
        public ExpressRepository(TContext context) : base(context) { _context = context; }
        /// <summary>
        /// 获取快递列表
        /// </summary>
        /// <returns></returns>
        public  Task<IEnumerable<Express>> GetList()
        {
            return Task.Run(() => _entity.AsEnumerable());
        }
    }
}
