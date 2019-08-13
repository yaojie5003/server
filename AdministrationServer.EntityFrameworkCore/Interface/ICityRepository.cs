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
        /// 通过地级市、地区、自治州、盟id获取地级市、地区、自治州、盟
        /// </summary>
        /// <param name="provinceId">地级市、地区、自治州、盟id</param>
        /// <returns>地级市、地区、自治州、盟列表</returns>
        IEnumerable<City> GetCityByProvience(int provinceId);
        /// <summary>
        /// 通过地级市、地区、自治州、盟的名称获取地级市、地区、自治州、盟
        /// </summary>
        /// <param name="name">地级市、地区、自治州、盟的名称</param>
        /// <returns>地级市、地区、自治州、盟列表</returns>
        IEnumerable<City> GetCityByName(string name);
        /// <summary>
        /// 通过省、自治区、直辖市名称获取地级市、地区、自治州、盟
        /// </summary>
        /// <param name="provinceName">省、自治区、直辖市名称</param>
        /// <returns>地级市、地区、自治州、盟列表</returns>
        IEnumerable<City> GetCityByProvinceName(string provinceName);
        /// <summary>
        /// 分页查询地级市、地区、自治州、盟
        /// </summary>
        /// <param name="provinceId">省、自治区、直辖市id</param>
        /// <param name="name">地级市、地区、自治州、盟名称</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页大小</param>
        /// <returns>地级市、地区、自治州、盟列表</returns>
        IEnumerable<City> GetCityPage(int provinceId,string name,int pageIndex,int pageSize);
        /// <summary>
        /// 通过行政区划代码查询地级市、地区、自治州、盟
        /// </summary>
        /// <param name="code">地级市、地区、自治州、盟行政区划代码</param>
        /// <returns>地级市、地区、自治州、盟</returns>
        City GetCityByCode(string code);
    }
}
