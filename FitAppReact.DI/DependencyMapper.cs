using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using FitAppReact.EntityFramework;
using FitAppReact.EntityFramework.AutoMapper;
using AutoMapper;
using FitAppReact.Facades;
using FitAppReact.Interfaces.Facades;
using FitAppReact.Interfaces.Infrastructure;
using FitAppReact.DietService;
using FitAppReact.Interfaces.Infrastructure.DietService;

namespace FitAppReact.DI
{
    public static class DependencyMapper
    {
        public static void AddDependencies(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            #region Context
            serviceCollection.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Local")));

            #endregion

            #region Facades
            serviceCollection.AddScoped<IDietFcd, DietFcd>();

            #endregion

            #region Services
            serviceCollection.AddScoped<IMealPicker, MealPicker>();
            serviceCollection.AddScoped<IMacroCounter, MacroCounter>();

            #endregion

            #region Mapper
            MapperConfiguration mapperConfiguration = new MapperConfiguration(config =>
            {
                config.AddProfile(new InitialMappingProfile());
            });
            IMapper mapper = mapperConfiguration.CreateMapper();
            serviceCollection.AddSingleton(mapper);
            #endregion
        }
    }
}
