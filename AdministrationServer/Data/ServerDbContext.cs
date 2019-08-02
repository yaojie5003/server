using AdministrationServer.Core.Models;
using SQLite.CodeFirst;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SQLite;
using System.IO;

namespace AdministrationServer.Data
{
    /// <summary>
    /// ef6的数据上下文（已抛弃）
    /// </summary>
    public class ServerDbContext:DbContext
    {
        public ServerDbContext():base (new SQLiteConnection()
        {
            ConnectionString = new SQLiteConnectionStringBuilder()
            {
                DataSource =Path.Combine( AppDomain.CurrentDomain.BaseDirectory, "App_Data\\dt.db"),
                ForeignKeys = true
            }.ConnectionString
        }, true)
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var initializer = new SqliteDropCreateDatabaseWhenModelChanges<ServerDbContext>(modelBuilder);
            Database.SetInitializer(initializer);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Province>().ToTable("Province");
            modelBuilder.Entity<City>().ToTable("City");
            modelBuilder.Entity<County>().ToTable("County");
        }
        public DbSet<Province> Province { set; get; }
        public DbSet<City> City { set; get; }
        public DbSet<County> County { set; get; }
    }
    internal sealed class ContextMigrationConfiguration : DbMigrationsConfiguration<ServerDbContext>
    {
        public ContextMigrationConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
          
        }
    }
   
}