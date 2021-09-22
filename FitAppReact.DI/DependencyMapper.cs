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
using FitAppReact.EntityFramework.Models;
using Microsoft.AspNetCore.Authentication;
using FitAppReact.Interfaces.Infrastructure.UserService;
using FitAppReact.UserService;

namespace FitAppReact.DI
{
    public static class DependencyMapper
    {
        public static void AddDependencies(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            #region Context
            serviceCollection.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Local")));

            serviceCollection.AddDatabaseDeveloperPageExceptionFilter();

            serviceCollection.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<AppDbContext>();

            serviceCollection.AddIdentityServer()
                .AddApiAuthorization<AppUser, AppDbContext>();

            serviceCollection.AddAuthentication()
                .AddIdentityServerJwt();

            #endregion

            #region Facades
            serviceCollection.AddScoped<IDietFcd, DietFcd>();
            serviceCollection.AddScoped<IUserFcd, UserFcd>();

            #endregion

            #region Services
            serviceCollection.AddScoped<IMealPicker, MealPicker>();
            serviceCollection.AddScoped<IMacroCounter, MacroCounter>();
            serviceCollection.AddScoped<IAppUserSrv, AppUserSrv>();

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
