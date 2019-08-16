using AdministrationServer.Core.Infrastructure;
namespace AdministrationServer.Core.Models
{
    /// <summary>
    /// 快递
    /// </summary>
    public class Express: IEntity
    {
        /// <summary>
        /// 获取或设置主键
        /// </summary>
        public int Id { set; get; }
        /// <summary>
        /// 获取或设置快递名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 获取或设置图标
        /// </summary>
        public string Logo { set; get; }
        /// <summary>
        /// 获取或设置官网
        /// </summary>
        public string Official { set; get; }
    }
}
