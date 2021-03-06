﻿using AdministrationServer.Core.Infrastructure;

namespace AdministrationServer.Core.Models
{
    /// <summary>
    /// 省、自治区、直辖市
    /// </summary>
    public class Province: IEntity
    {
        /// <summary>
        /// 获取或设置主键
        /// </summary>
        public int Id { set; get; }
        /// <summary>
        /// 获取或设置行政区划代码
        /// </summary>
        public string Code { set; get; }
        /// <summary>
        /// 获取或设置省、自治区、直辖市名称
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 获取或设置省、自治区、直辖市名缩写
        /// </summary>
        public string Abbreviation { set; get; }
    }
}