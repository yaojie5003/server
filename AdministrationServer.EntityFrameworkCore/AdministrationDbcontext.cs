using AdministrationServer.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace AdministrationServer.EntityFrameworkCore
{
    /// <summary>
    /// 行政区划上下文
    /// </summary>
    public class AdministrationDbcontext : DbContext
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public AdministrationDbcontext() : base() { }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="options">数据上下文参数</param>
        public AdministrationDbcontext(DbContextOptions options) : base(options)
        { }
        /// <summary>
        /// 获取或设置地级市、地区、自治州、盟实体
        /// </summary>
        public DbSet<City> cities { set; get; }
        /// <summary>
        /// 获取或设置市辖区、县级市、县…
        /// </summary>
        public DbSet<County> counties { set; get; }
        /// <summary>
        /// 获取或设置省、自治区、直辖市
        /// </summary>
        public DbSet<Province> provinces { set; get; }
        /// <summary>
        /// 获取或设置快递
        /// </summary>
        public DbSet<Express> expresses { set; get; }
        /// <summary>
        /// 实体创建方法
        /// </summary>
        /// <param name="builder">构建参数</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Province>(b => {
                b.HasKey(rc => rc.Id);
                b.ToTable("Province");
                b.HasMany<City>().WithOne().HasForeignKey(ur => ur.ProvinceId).IsRequired();
                b.HasMany<County>().WithOne().HasForeignKey(ur => ur.ProvinceId).IsRequired();
            });
           
            builder.Entity<City>(b =>
            {
                b.HasKey(rc => rc.Id);
                b.ToTable("City");
                b.HasMany<County>().WithOne().HasForeignKey(ur => ur.CityId).IsRequired();
            });

            builder.Entity<County>(b => {
                b.HasKey(rc => rc.Id);
                b.ToTable("County");               
            });

            builder.Entity<Express>(b=>b.ToTable("Express"));
        }
    }
}
