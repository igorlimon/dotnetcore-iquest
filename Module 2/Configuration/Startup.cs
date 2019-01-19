using Microsoft.AspNetCore.Builder;

namespace Configuration
{
    internal class Startup
    {
        private readonly Exampels _exampels = new Exampels();

        public void Configure(IApplicationBuilder app)
        {
            _exampels.InMemory(app);
        }
    }
}