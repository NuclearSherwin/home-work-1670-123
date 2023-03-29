using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace day_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Start App");
            IHostBuilder builder = Host.CreateDefaultBuilder();
            builder.ConfigureWebHostDefaults((IWebHostBuilder webBuilder) => {
                webBuilder.UseWebRoot("public");
                webBuilder.UseStartup<MyStartUp>();
            });

            IHost host = builder.Build();
            host.Run();
            
        }

        // public static void Main(string[] args)
        // {
        //     CreateHostBuilder(args).Build().Run();
        // }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
