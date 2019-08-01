using AdministrationServer.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System;

namespace AdministrationServer.Data
{
    public class ADMDbcontext: AdministrationDbcontext
    {
        public ADMDbcontext():base ( ) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=.\dt.db");
        }
    }
}