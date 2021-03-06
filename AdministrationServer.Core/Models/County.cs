﻿using AdministrationServer.Core.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdministrationServer.Core.Models
{
    /// <summary>
    /// 市辖区、县级市、县…
    /// </summary>
    public class County:IEntity
    {
        /// <summary>
        /// 获取或设置省份id
        /// </summary>
        [ForeignKey("Province")]
        public int ProvinceId { set; get; }
        /// <summary>
        /// 获取或设置城市id
        /// </summary>
        [ForeignKey("City")]
        public int CityId { set; get; }
        /// <summary>
        /// 获取或设置主键
        /// </summary>
        public int Id { set; get; }
        /// <summary>
        /// 获取或设置行政区划代码
        /// </summary>
        public string Code { set; get; }
        /// <summary>
        /// 获取或设置区县名称
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 获取或设置区县缩写
        /// </summary>
        public string Abbreviation { set; get; }
    }
}