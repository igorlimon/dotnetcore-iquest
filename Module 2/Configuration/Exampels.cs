using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Builder.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Configuration
{
    internal class Exampels
    {
        internal void InMemory(IApplicationBuilder app)
        {
            Dictionary<string, string> arrayDict = new Dictionary<string, string>
            {
                {"date", "09/12/2018"},
                {"name", "PeakIT"}
            };
            var builder = new ConfigurationBuilder();
            builder.AddInMemoryCollection(arrayDict);
            var config = builder.Build();

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync($"Event name : {config["name"]} Event date : {config["date"]}");
            });
        }
    }
}