using AdministrationServer.Core;
using AdministrationServer.Core.Models;
using System.Collections.Generic;

namespace AdministrationServer.EntityFrameworkCore
{
    /// <summary>
    /// 地级市、地区、自治州、盟查询接口
    /// </summary>
    public interface ICityRepository:IInterfaceBaseRepository<City>, IQueryRepository<City>
    {
        /// <summary>
        /// 通过数据id获取地级市、地区、自治州、盟
        /// </summary>
        /// <param name="provinceId"></param>
        /// <returns></returns>
        IEnumerable<City> GetCityByProvience(int provinceId);
        /// <summary>
        /// 通过地级市、地区、自治州、盟的名称获取城市名
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IEnumerable<City> GetCityByName(string name);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="provinceName"></param>
        /// <returns></returns>
        IEnumerable<City> GetCityByProvinceName(string provinceName);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="provinceId"></param>
        /// <param name="Name"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        IEnumerable<City> GetCityPage(int provinceId,string name,int pageIndex,int pageSize);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        City GetCityByCode(string code);
    }
}
