using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace ConfigApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, string> arrayDict = new Dictionary<string, string>
            {
                {"date", "21/01/2019"},
                {"name", "IQuest"}
            };
            var builder = new ConfigurationBuilder();
            builder.AddCommandLine(args);
            var configuration = builder.Build();

            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, configurationBuilder) =>
                {
                    //context.Configuration.
                })
                .UseConfiguration(configuration)
                .UseStartup<StartUp>()
                .Build()
                .Run();
        }
    }

    internal class StartUp
    {
        public void Configure(IApplicationBuilder app)
        {
            Dictionary<string, string> arrayDict = new Dictionary<string, string>
            {
                {"date", "21/01/2019"},
                {"name", "IQuest"}
            };
            var builder = new ConfigurationBuilder();
            builder.AddInMemoryCollection(arrayDict);
            var configuration = builder.Build();
            
            app.Use(async (context, next) =>
                await context.Response.WriteAsync($"Event name : {configuration["name"]} Event date : {configuration["date"]} City: {configuration["city"]}"));
        }
    }
}
