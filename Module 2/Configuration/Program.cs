using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore;
using System;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Configuration
{
    public class Program
    {
         public static IConfigurationRoot Config { get; private set; }
             private static void SetupSimpleConfiguration()
        {
            Config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();  
        }

        public static void Main(string[] args)
        {
            string val1 = Config["SimpleConfig"];
            string val2 = Config["config1"];
            string val3 = Config["config2"];
            Console.WriteLine($"{val1} {val2} {val3}");
            Console.WriteLine();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseEnvironment("Development");
    }
}
