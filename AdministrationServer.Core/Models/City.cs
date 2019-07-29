using AdministrationServer.Core.Infrastructure;

namespace AdministrationServer.Core.Models
{
    /// <summary>
    /// 城市（地级市）
    /// </summary>
    public class City: IEntity
    {
        /// <summary>
        /// 获取或设置省份id
        /// </summary>
        public int ProvinceId { set; get; }
        /// <summary>
        /// 获取或设置id
        /// </summary>
        public int Id { set; get; }
        /// <summary>
        /// 获取或设置行政区划代码
        /// </summary>
        public string Code { set; get; }
        /// <summary>
        /// 获取或设置城市名
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 获取或设置城市缩写
        /// </summary>
        public string Abbreviation { set; get; }
    }
}