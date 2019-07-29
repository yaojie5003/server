using AdministrationServer.Core.Infrastructure;

namespace AdministrationServer.Core.Models
{
    /// <summary>
    /// 省份
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
        /// 获取或设置省份名称
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 获取或设置省份名缩写
        /// </summary>
        public string Abbreviation { set; get; }
    }
}