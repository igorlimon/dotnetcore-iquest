using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Host
{
    internal class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Use(async (context, next) => 
            {
                await context.Response.WriteAsync("Peak IT");
            });
        }
    }
}