using AdministrationServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdministrationServer.Data
{
    public class ServerDbContext:DbContext
    {
        public DbSet<Province> provinces { set; get; }
        public DbSet<City> cities { set; get; }
        public DbSet<County> counties { set; get; }
    } 
}