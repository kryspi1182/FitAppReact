using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using FitAppReact.EntityFramework;

namespace FitAppReact.DI
{
    public static class DependencyMapper
    {
        public static void AddDependencies(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Local")));
        }
    }
}
