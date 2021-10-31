using Microsoft.EntityFrameworkCore;
using System;
using FitAppReact.EntityFramework.Models;
using Microsoft.Extensions.Configuration;
using FitAppReact.EntityFramework.InitialData;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using IdentityServer4.EntityFramework.Options;
using Microsoft.Extensions.Options;

namespace FitAppReact.EntityFramework
{
    public class AppDbContext: ApiAuthorizationDbContext<AppUser>
    {
        //public AppDbContext(IOptions<OperationalStoreOptions> operationalStoreOptions) : base(operationalStoreOptions) { }
        public AppDbContext(
            DbContextOptions<AppDbContext> options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions) { }
        
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealProduct> MealProducts { get; set; }
        public DbSet<MealCategory> MealCategories { get; set; }
        public DbSet<Hazard> Hazards { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductHazard> ProductHazards { get; set; }
        public DbSet<MedicalCondition> MedicalConditions { get; set; }
        public DbSet<MedicalConditionHazard> MedicalConditionHazards { get; set; }
        public DbSet<UserUnwantedProduct> UserUnwantedProducts { get; set; }
        public DbSet<UserMedicalCondition> UserMedicalConditions { get; set; }
        public DbSet<UserDiet> UserDiets { get; set; }
        public DbSet<UserDietMeal> UserDietMeals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seed seed = new Seed(modelBuilder);
            seed.Add();
            base.OnModelCreating(modelBuilder);
        }
    }
}
