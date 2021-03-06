//Program powstał na Wydziale Informatyki Politechniki Białostockiej

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
using System.Linq;
using FitAppReact.Interfaces.Infrastructure.TrainingService;
using FitAppReact.TrainingService;
using FitAppReact.Common.Configurations;
using FitAppReact.EmailService;
using FitAppReact.Interfaces.Infrastructure.EmailService;

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
                .AddApiAuthorization<AppUser, AppDbContext>(options => 
                {
                    options.Clients.AddNativeApp("FitAppReactNative", app => app.WithScopes("openid", "profile", "FitAppReactAPI", "offline_access"));
                    var client = options.Clients.Single(c => c.ClientId == "FitAppReactNative");
                    client.RequirePkce = true;
                    client.AllowOfflineAccess = true;
                    client.RedirectUris.Clear();
                    client.RedirectUris.Add("https://auth.expo.io/@krystian1182/FitAppReactNative");
                });

            serviceCollection.AddAuthentication()
                .AddIdentityServerJwt();

            #endregion

            #region Configs
            serviceCollection.AddSingleton<IEmailConfiguration>(configuration.GetSection("EmailConfig").Get<EmailConfiguration>());
            #endregion

            #region Facades
            serviceCollection.AddScoped<IDietFcd, DietFcd>();
            serviceCollection.AddScoped<IUserFcd, UserFcd>();
            serviceCollection.AddScoped<ITrainingFcd, TrainingFcd>();
            serviceCollection.AddScoped<IEmailFcd, EmailFcd>();
            #endregion

            #region Services
            serviceCollection.AddScoped<IMealSrv, MealSrv>();
            serviceCollection.AddScoped<IMacroSrv, MacroSrv>();
            serviceCollection.AddScoped<IAppUserSrv, AppUserSrv>();
            serviceCollection.AddScoped<IProductSrv, ProductSrv>();
            serviceCollection.AddScoped<IMedicalConditionSrv, MedicalConditionSrv>();
            serviceCollection.AddScoped<IUserSavedDietSrv, UserSavedDietSrv>();
            serviceCollection.AddScoped<ITrainingSrv, TrainingSrv>();
            serviceCollection.AddScoped<IExerciseSrv, ExerciseSrv>();
            serviceCollection.AddScoped<IBodyTargetSrv, BodyTargetSrv>();
            serviceCollection.AddScoped<IUserSavedTrainingSrv, UserSavedTrainingSrv>();
            serviceCollection.AddScoped<ITrainingCategorySrv, TrainingCategoriesSrv>();
            serviceCollection.AddScoped<IDifficultySrv, DifficultySrv>();
            serviceCollection.AddScoped<ITrainingConditionSrv, TrainingCondtionSrv>();
            serviceCollection.AddScoped<IEmailSrv, EmailSrv>();
            serviceCollection.AddScoped<IWeightTargetSrv, WeightTargetSrv>();
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
