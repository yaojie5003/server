using AdministrationServer.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace AdministrationServer.EntityFrameworkCore
{
    /// <summary>
    /// 省、自治区、直辖市查询接口
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
    public class ProvinceRepository<TContext> : BaseRepository<Province>, IProvinceRepository where TContext : AdministrationDbcontext
    {

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="context">数据上下文</param>
        public ProvinceRepository(TContext context) : base(context)
        {
        }
        /// <summary>
        /// 获取省、自治区、直辖市
        /// </summary>
        /// <returns>省、自治区、直辖市列表</returns>
        public IEnumerable<Province> GetList() => _entity.AsEnumerable();

    }
}