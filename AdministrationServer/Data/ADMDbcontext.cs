using AdministrationServer.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System;

namespace AdministrationServer.Data
{
    /// <summary>
    /// 行政区划数据上下文（ef core）
    /// </summary>
    public class ADMDbcontext: AdministrationDbcontext
    {
        /// <summary>
        /// 上下文配置
        /// </summary>
        /// <param name="optionsBuilder">数据上下文配置构建</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=.\dt.db");
        }
    }
}