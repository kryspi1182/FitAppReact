

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
        public DbSet<UserSavedDiet> UserSavedDiets { get; set; }
        public DbSet<UserSavedDietMeal> UserSavedDietMeals { get; set; }
        public DbSet<BodyTarget> BodyTargets { get; set; }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseBodyTarget> ExerciseBodyTargets { get; set; }
        public DbSet<ExerciseCategory> ExerciseCategories { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<TrainingCategory> TrainingCategories { get; set; }
        public DbSet<TrainingCondition> TrainingConditions { get; set; }
        public DbSet<TrainingConditionSeverity> TrainingConditionSeverities { get; set; }
        public DbSet<TrainingExercise> TrainingExercises { get; set; }
        public DbSet<UserTrainingCondition> UserTrainingConditions { get; set; }
        public DbSet<UserSavedTraining> UserSavedTrainings { get; set; }
        public DbSet<WeightTarget> WeightTargets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seed seed = new Seed(modelBuilder);
            seed.Add();
            base.OnModelCreating(modelBuilder);
        }
    }
}
