using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DI
{
    public class CustomDi
    {
        private readonly ServiceCollection _services = new ServiceCollection();

        internal void PopulateService()
        {
            _services.AddTransient<IPeakItService>(s => new PeakItService("MyConnectionString"));
        }

        internal IPeakItService GetPeakItService()
        {
            var provider = _services.BuildServiceProvider();

            return provider.GetService<IPeakItService>();
        }
    }
}