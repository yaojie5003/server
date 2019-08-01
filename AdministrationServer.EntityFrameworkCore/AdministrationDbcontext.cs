using AdministrationServer.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace AdministrationServer.EntityFrameworkCore
{
    public class AdministrationDbcontext : DbContext
    {
        public AdministrationDbcontext() : base() { }
        public AdministrationDbcontext(DbContextOptions options) : base(options)
        { }
        public DbSet<City> cities { set; get; }
        public DbSet<County> counties { set; get; }
        public DbSet<Province> provinces { set; get; }
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
          
        }
    }
}
