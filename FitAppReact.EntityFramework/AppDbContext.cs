using Microsoft.EntityFrameworkCore;
using System;
using FitAppReact.EntityFramework.Models;
using Microsoft.Extensions.Configuration;
using FitAppReact.EntityFramework.InitialData;

namespace FitAppReact.EntityFramework
{
    public class AppDbContext: DbContext
    {
        public AppDbContext() : base() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealProduct> MealProducts { get; set; }
        public DbSet<MealCategory> MealCategories { get; set; }
        public DbSet<Hazard> Hazards { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductHazard> ProductHazards { get; set; }
        public DbSet<MedicalCondition> MedicalConditions { get; set; }
        public DbSet<MedicalConditionHazard> MedicalConditionHazards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seed seed = new Seed(modelBuilder);
            seed.Add();
            base.OnModelCreating(modelBuilder);
        }
    }
}
