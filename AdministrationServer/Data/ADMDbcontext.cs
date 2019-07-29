using AdministrationServer.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System;

namespace AdministrationServer.Data
{
    public class ADMDbcontext: AdministrationDbcontext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite( "dt2.db");
        }
    }
}