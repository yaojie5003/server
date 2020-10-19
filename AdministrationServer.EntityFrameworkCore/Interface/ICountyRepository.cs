using AdministrationServer.Core;
using AdministrationServer.Core.Models;
using System.Collections.Generic;

namespace AdministrationServer.EntityFrameworkCore
{
    /// <summary>
    /// 市辖区、县级市、县…接口
    /// </summary>
    public interface ICountyRepository:IInterfaceBaseRepository<County>, IQueryRepository<County>
    {
        /// <summary>
        /// 通过地级市、地区、自治州、盟Id查询市辖区、县级市、县…
        /// </summary>
        /// <param name="cityId">地级市、地区、自治州、盟Id</param>
        /// <returns>市辖区、县级市、县…列表</returns>
        IEnumerable<County> GetCountyByCityId(int cityId);
        /// <summary>
        /// 分页查询市辖区、县级市、县…
        /// </summary>
        /// <param name="cityId">地级市、地区、自治州、盟Id</param>
        /// <param name="countyName">辖区、县级市、县…名称</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页大小</param>
        /// <returns>市辖区、县级市、县…列表</returns>
        IEnumerable<County> GetCountyPage(int cityId, string countyName, int pageIndex, int pageSize);
        /// <summary>
        /// 通过地级市、地区、自治州、盟名查询市辖区、县级市、县…
        /// </summary>
        /// <param name="cityName">地级市、地区、自治州、盟名</param>
        /// <returns>市辖区、县级市、县…列表</returns>
        IEnumerable<County> GetCountyByCityName(string cityName);
        /// <summary>
        /// 通过市辖区、县级市、县…行政区代码查询辖区、县级市、县…
        /// </summary>
        /// <param name="code">辖区、县级市、县…行政区代码</param>
        /// <returns>市辖区、县级市、县…</returns>
        County GetCountyByCode(string code);
        /// <summary>
        /// 通过地市辖区、县级市、县名查询市辖区、县级市、县
        /// </summary>
        /// <param name="cityName">市辖区、县级市、县名</param>
        /// <returns>市辖区、县级市、县…列表</returns>
        IEnumerable<County> GetCountyByName(string name);
    }
}
