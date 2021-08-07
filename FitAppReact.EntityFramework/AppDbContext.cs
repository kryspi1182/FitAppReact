using Microsoft.EntityFrameworkCore;
using System;
using FitAppReact.EntityFramework.Models;

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

        }
    }
}
