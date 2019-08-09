using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace AdministrationServerCore
{
    public class Program
    {
        public static void Main(string[] args)
        {           
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) {
            return WebHost.CreateDefaultBuilder(args).UseKestrel().UseStartup<Startup>().ConfigureKestrel((context, options) =>
            {
               // options.ListenAnyIP(5020);
            });

        }
            
    }
}
