using AdministrationServer.Core.Infrastructure;

namespace AdministrationServer.Core.Models
{
    /// <summary>
    /// 区县（县级市）
    /// </summary>
    public class County:IEntity
    {
        /// <summary>
        /// 获取或设置省份id
        /// </summary>
        public int ProvinceId { set; get; }
        /// <summary>
        /// 获取或设置城市id
        /// </summary>
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