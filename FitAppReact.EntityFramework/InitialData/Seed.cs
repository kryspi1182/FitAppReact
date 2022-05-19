

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitAppReact.EntityFramework.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace FitAppReact.EntityFramework.InitialData
{
    public class Seed
    {
        private readonly ModelBuilder modelBuilder;

        public Seed(ModelBuilder _modelBuilder)
        {
            modelBuilder = _modelBuilder;
        }
        public void Add()
        {
            Products();
            Hazards();
            MedicalConditions();
            MealCategories();
            Meals();

            MedicalConditionHazards();
            ProductHazards();
            MealProducts();

            BodyTargets();
            Difficulties();
            ExerciseCategories();
            TrainingCategories();
            TrainingConditionSeverities();
            TrainingConditions();
            Exercises();
            ExerciseBodyTargets();
            Trainings();
            TrainingExercises();
            WeightTargets();

            Roles();
        }
        #region Private
        private void Products()
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Calories = 583, Fat = 52, Carbohydrates = 6, Sugar = 3, Fibre = 11, Protein = 20, Salt = 0, Name = "Almond" },
                new Product { Id = 2, Calories = 54, Fat = 0, Carbohydrates = 12, Sugar = 12, Fibre = 2, Protein = 0, Salt = 0, Name = "Apple" },
                new Product { Id = 3, Calories = 60, Fat = 0, Carbohydrates = 12, Sugar = 8, Fibre = 2, Protein = 1, Salt = 0, Name = "Apricot" },
                new Product { Id = 4, Calories = 17, Fat = 0, Carbohydrates = 1, Sugar = 1, Fibre = 2, Protein = 2, Salt = 0, Name = "Aspargus" },
                new Product { Id = 5, Calories = 188, Fat = 18, Carbohydrates = 2, Sugar = 1, Fibre = 6, Protein = 3, Salt = 0, Name = "Avocado" },
                new Product { Id = 6, Calories = 86, Fat = 0, Carbohydrates = 19, Sugar = 18, Fibre = 2, Protein = 1, Salt = 0, Name = "Banana" },
                new Product { Id = 7, Calories = 114, Fat = 1, Carbohydrates = 15, Sugar = 0, Fibre = 11, Protein = 8, Salt = 0, Name = "Beans(white)" },
                new Product { Id = 8, Calories = 198, Fat = 9, Carbohydrates = 1, Sugar = 0, Fibre = 0, Protein = 30, Salt = 0, Name = "Beef" },
                new Product { Id = 9, Calories = 58, Fat = 1, Carbohydrates = 9, Sugar = 7, Fibre = 5, Protein = 1, Salt = 0, Name = "Blackberry" },
                new Product { Id = 10, Calories = 75, Fat = 0, Carbohydrates = 15, Sugar = 14, Fibre = 7, Protein = 1, Salt = 0, Name = "Berry" },
                new Product { Id = 11, Calories = 283, Fat = 2, Carbohydrates = 58, Sugar = 2, Fibre = 4, Protein = 8, Salt = 0, Name = "Bread(white)" },
                new Product { Id = 12, Calories = 262, Fat = 3, Carbohydrates = 45, Sugar = 2, Fibre = 6, Protein = 10, Salt = 0, Name = "Bread(whole wheat)" },
                new Product { Id = 13, Calories = 29, Fat = 0, Carbohydrates = 2, Sugar = 2, Fibre = 4, Protein = 3, Salt = 0, Name = "Broccoli" },
                new Product { Id = 14, Calories = 25, Fat = 0, Carbohydrates = 3, Sugar = 3, Fibre = 5, Protein = 3, Salt = 0, Name = "Brussels" },
                new Product { Id = 15, Calories = 375, Fat = 1, Carbohydrates = 80, Sugar = 2, Fibre = 2, Protein = 10, Salt = 0, Name = "Bulgur groats" },
                new Product { Id = 16, Calories = 735, Fat = 83, Carbohydrates = 1, Sugar = 1, Fibre = 0, Protein = 1, Salt = 0, Name = "Butter" },
                new Product { Id = 17, Calories = 27, Fat = 0, Carbohydrates = 5, Sugar = 4, Fibre = 3, Protein = 1, Salt = 0, Name = "Carrot" },
                new Product { Id = 18, Calories = 20, Fat = 0, Carbohydrates = 2, Sugar = 2, Fibre = 2, Protein = 2, Salt = 0, Name = "Califlower" },
                new Product { Id = 19, Calories = 157, Fat = 4, Carbohydrates = 0, Sugar = 0, Fibre = 0, Protein = 30, Salt = 0, Name = "Chicken breast" },
                new Product { Id = 20, Calories = 103, Fat = 2, Carbohydrates = 0, Sugar = 0, Fibre = 0, Protein = 21, Salt = 0, Name = "Chicken leg" },
                new Product { Id = 21, Calories = 354, Fat = 4, Carbohydrates = 66, Sugar = 2, Fibre = 9, Protein = 9, Salt = 0, Name = "Corn" },
                new Product { Id = 22, Calories = 225, Fat = 17, Carbohydrates = 0, Sugar = 0, Fibre = 0, Protein = 18, Salt = 0, Name = "Duck" },
                new Product { Id = 23, Calories = 235, Fat = 20, Carbohydrates = 1, Sugar = 0, Fibre = 0, Protein = 14, Salt = 0, Name = "Eggs" },
                new Product { Id = 24, Calories = 247, Fat = 12, Carbohydrates = 18, Sugar = 1, Fibre = 2, Protein = 15, Salt = 0, Name = "Fish sticks" },
                new Product { Id = 25, Calories = 307, Fat = 11, Carbohydrates = 46, Sugar = 0, Fibre = 3, Protein = 6, Salt = 0, Name = "French fries" },
                new Product { Id = 26, Calories = 57, Fat = 0, Carbohydrates = 14, Sugar = 13, Fibre = 1, Protein = 1, Salt = 0, Name = "Grapes" },
                new Product { Id = 27, Calories = 201, Fat = 13, Carbohydrates = 1, Sugar = 1, Fibre = 0, Protein = 22, Salt = 0, Name = "Ham" },
                new Product { Id = 28, Calories = 667, Fat = 63, Carbohydrates = 11, Sugar = 9, Fibre = 8, Protein = 14, Salt = 0, Name = "Hazelnut" },
                new Product { Id = 29, Calories = 308, Fat = 0, Carbohydrates = 76, Sugar = 75, Fibre = 0, Protein = 0, Salt = 0, Name = "Honey" },
                new Product { Id = 30, Calories = 247, Fat = 0, Carbohydrates = 60, Sugar = 59, Fibre = 2, Protein = 0, Salt = 0, Name = "Jam" },
                new Product { Id = 31, Calories = 116, Fat = 5, Carbohydrates = 1, Sugar = 0, Fibre = 0, Protein = 17, Salt = 0, Name = "Kidneys(pork)" },
                new Product { Id = 32, Calories = 48, Fat = 0, Carbohydrates = 10, Sugar = 8, Fibre = 1, Protein = 1, Salt = 0, Name = "Kiwi" },
                new Product { Id = 33, Calories = 11, Fat = 0, Carbohydrates = 1, Sugar = 1, Fibre = 1, Protein = 1, Salt = 0, Name = "Lettuce" },
                new Product { Id = 34, Calories = 132, Fat = 4, Carbohydrates = 2, Sugar = 2, Fibre = 0, Protein = 22, Salt = 0, Name = "Liver(pork)" },
                new Product { Id = 35, Calories = 741, Fat = 82, Carbohydrates = 3, Sugar = 3, Fibre = 0, Protein = 2, Salt = 0, Name = "Mayonese" },
                new Product { Id = 36, Calories = 62, Fat = 3, Carbohydrates = 4, Sugar = 4, Fibre = 0, Protein = 4, Salt = 0, Name = "Milk" },
                new Product { Id = 37, Calories = 359, Fat = 1, Carbohydrates = 80, Sugar = 0, Fibre = 0, Protein = 8, Salt = 0, Name = "Rice" }
                );
        }
        private void Hazards()
        {
            modelBuilder.Entity<Hazard>().HasData(
                new Hazard { Id = 1, Name = "Sugar", Description = "High amounts of sugar" },
                new Hazard { Id = 2, Name = "Lactose", Description = "Presence of lactose" },
                new Hazard { Id = 3, Name = "Nuts", Description = "Presence of nuts" }
                );
        }
        private void MedicalConditions()
        {
            modelBuilder.Entity<MedicalCondition>().HasData(
                new MedicalCondition { Id = 1, Name = "Diabetes", Description = "Avoid sugars" },
                new MedicalCondition { Id = 2, Name = "Lactose intolerance", Description = "Avoid lactose" },
                new MedicalCondition { Id = 3, Name = "Nut allergy", Description = "Avoid nuts" }
                );
        }
        private void MedicalConditionHazards()
        {
            modelBuilder.Entity<MedicalConditionHazard>().HasData(
                new MedicalConditionHazard { Id = 1, HazardId = 1, MedicalConditionId = 1 },
                new MedicalConditionHazard { Id = 2, HazardId = 2, MedicalConditionId = 2 },
                new MedicalConditionHazard { Id = 3, HazardId = 3, MedicalConditionId = 3 }
                );
        }
        private void ProductHazards()
        {
            modelBuilder.Entity<ProductHazard>().HasData(
                new ProductHazard { Id = 1, HazardId = 1, ProductId = 29 },
                new ProductHazard { Id = 2, HazardId = 1, ProductId = 30 },
                new ProductHazard { Id = 3, HazardId = 2, ProductId = 36 },
                new ProductHazard { Id = 4, HazardId = 3, ProductId = 1 }
                );
        }
        private void MealCategories()
        {
            modelBuilder.Entity<MealCategory>().HasData(
                new MealCategory { Id = 1, Name = "Breakfast" },
                new MealCategory { Id = 2, Name = "Lunch" },
                new MealCategory { Id = 3, Name = "Snack" },
                new MealCategory { Id = 4, Name = "Second breakfast" },
                new MealCategory { Id = 5, Name = "Dinner" }
                );
        }
        private void Meals()
        {
            modelBuilder.Entity<Meal>().HasData(
                new Meal { Id = 1, MealCategoryId = 1, Name = "Breakfast 1", Description = "Description of breakfast 1", Recipe = "Recipe of breakfast 1" },
                new Meal { Id = 2, MealCategoryId = 1, Name = "Breakfast 2", Description = "Description of breakfast 2", Recipe = "Recipe of breakfast 2" },
                new Meal { Id = 3, MealCategoryId = 1, Name = "Breakfast 3", Description = "Description of breakfast 3", Recipe = "Recipe of breakfast 3" },
                new Meal { Id = 4, MealCategoryId = 1, Name = "Breakfast 4", Description = "Description of breakfast 4", Recipe = "Recipe of breakfast 4" },
                new Meal { Id = 5, MealCategoryId = 1, Name = "Breakfast 5", Description = "Description of breakfast 5", Recipe = "Recipe of breakfast 5" },

                new Meal { Id = 6, MealCategoryId = 5, Name = "Dinner 1", Description = "Description of dinner 1", Recipe = "Recipe of dinner 1" },
                new Meal { Id = 7, MealCategoryId = 5, Name = "Dinner 2", Description = "Description of dinner 2", Recipe = "Recipe of dinner 2" },
                new Meal { Id = 8, MealCategoryId = 5, Name = "Dinner 3", Description = "Description of dinner 3", Recipe = "Recipe of dinner 3" },
                new Meal { Id = 9, MealCategoryId = 5, Name = "Dinner 4", Description = "Description of dinner 4", Recipe = "Recipe of dinner 4" },
                new Meal { Id = 10, MealCategoryId = 5, Name = "Dinner 5", Description = "Description of dinner 5", Recipe = "Recipe of dinner 5" },

                new Meal { Id = 11, MealCategoryId = 2, Name = "Lunch 1", Description = "Description of lunch 1", Recipe = "Recipe of lunch 1" },
                new Meal { Id = 12, MealCategoryId = 2, Name = "Lunch 2", Description = "Description of lunch 2", Recipe = "Recipe of lunch 2" },
                new Meal { Id = 13, MealCategoryId = 2, Name = "Lunch 3", Description = "Description of lunch 3", Recipe = "Recipe of lunch 3" },
                new Meal { Id = 14, MealCategoryId = 2, Name = "Lunch 4", Description = "Description of lunch 4", Recipe = "Recipe of lunch 4" },
                new Meal { Id = 15, MealCategoryId = 2, Name = "Lunch 5", Description = "Description of lunch 5", Recipe = "Recipe of lunch 5" },

                new Meal { Id = 16, MealCategoryId = 3, Name = "Snack 1", Description = "Description of snack 1", Recipe = "Recipe of snack 1" },
                new Meal { Id = 17, MealCategoryId = 3, Name = "Snack 2", Description = "Description of snack 2", Recipe = "Recipe of snack 2" },
                new Meal { Id = 18, MealCategoryId = 3, Name = "Snack 3", Description = "Description of snack 3", Recipe = "Recipe of snack 3" },
                new Meal { Id = 19, MealCategoryId = 3, Name = "Snack 4", Description = "Description of snack 4", Recipe = "Recipe of snack 4" },
                new Meal { Id = 20, MealCategoryId = 3, Name = "Snack 5", Description = "Description of snack 5", Recipe = "Recipe of snack 5" },

                new Meal { Id = 21, MealCategoryId = 4, Name = "Second breakfast 1", Description = "Description of Second breakfast 1", Recipe = "Recipe of Second breakfast 1" },
                new Meal { Id = 22, MealCategoryId = 4, Name = "Second breakfast 2", Description = "Description of Second breakfast 2", Recipe = "Recipe of Second breakfast 2" },
                new Meal { Id = 23, MealCategoryId = 4, Name = "Second breakfast 3", Description = "Description of Second breakfast 3", Recipe = "Recipe of Second breakfast 3" },
                new Meal { Id = 24, MealCategoryId = 4, Name = "Second breakfast 4", Description = "Description of Second breakfast 4", Recipe = "Recipe of Second breakfast 4" },
                new Meal { Id = 25, MealCategoryId = 4, Name = "Second breakfast 5", Description = "Description of Second breakfast 5", Recipe = "Recipe of Second breakfast 5" },

                new Meal { Id = 61, MealCategoryId = 1, Name = "Breakfast 61", Description = "Description of Breakfast 61", Recipe = "Recipe of Breakfast 61" },
                new Meal { Id = 62, MealCategoryId = 1, Name = "Breakfast 62", Description = "Description of Breakfast 62", Recipe = "Recipe of Breakfast 62" },
                new Meal { Id = 63, MealCategoryId = 1, Name = "Breakfast 63", Description = "Description of Breakfast 63", Recipe = "Recipe of Breakfast 63" },
                new Meal { Id = 64, MealCategoryId = 1, Name = "Breakfast 64", Description = "Description of Breakfast 64", Recipe = "Recipe of Breakfast 64" },
                new Meal { Id = 65, MealCategoryId = 1, Name = "Breakfast 65", Description = "Description of Breakfast 65", Recipe = "Recipe of Breakfast 65" },
                new Meal { Id = 66, MealCategoryId = 1, Name = "Breakfast 66", Description = "Description of Breakfast 66", Recipe = "Recipe of Breakfast 66" },
                new Meal { Id = 67, MealCategoryId = 1, Name = "Breakfast 67", Description = "Description of Breakfast 67", Recipe = "Recipe of Breakfast 67" },
                new Meal { Id = 68, MealCategoryId = 1, Name = "Breakfast 68", Description = "Description of Breakfast 68", Recipe = "Recipe of Breakfast 68" },
                new Meal { Id = 69, MealCategoryId = 1, Name = "Breakfast 69", Description = "Description of Breakfast 69", Recipe = "Recipe of Breakfast 69" },
                new Meal { Id = 70, MealCategoryId = 1, Name = "Breakfast 70", Description = "Description of Breakfast 70", Recipe = "Recipe of Breakfast 70" },
                new Meal { Id = 71, MealCategoryId = 1, Name = "Breakfast 71", Description = "Description of Breakfast 71", Recipe = "Recipe of Breakfast 71" },
                new Meal { Id = 72, MealCategoryId = 1, Name = "Breakfast 72", Description = "Description of Breakfast 72", Recipe = "Recipe of Breakfast 72" },
                new Meal { Id = 73, MealCategoryId = 1, Name = "Breakfast 73", Description = "Description of Breakfast 73", Recipe = "Recipe of Breakfast 73" },
                new Meal { Id = 74, MealCategoryId = 1, Name = "Breakfast 74", Description = "Description of Breakfast 74", Recipe = "Recipe of Breakfast 74" },
                new Meal { Id = 75, MealCategoryId = 1, Name = "Breakfast 75", Description = "Description of Breakfast 75", Recipe = "Recipe of Breakfast 75" },
                new Meal { Id = 76, MealCategoryId = 1, Name = "Breakfast 76", Description = "Description of Breakfast 76", Recipe = "Recipe of Breakfast 76" },
                new Meal { Id = 77, MealCategoryId = 1, Name = "Breakfast 77", Description = "Description of Breakfast 77", Recipe = "Recipe of Breakfast 77" },
                new Meal { Id = 78, MealCategoryId = 1, Name = "Breakfast 78", Description = "Description of Breakfast 78", Recipe = "Recipe of Breakfast 78" },
                new Meal { Id = 79, MealCategoryId = 1, Name = "Breakfast 79", Description = "Description of Breakfast 79", Recipe = "Recipe of Breakfast 79" },
                new Meal { Id = 80, MealCategoryId = 1, Name = "Breakfast 80", Description = "Description of Breakfast 80", Recipe = "Recipe of Breakfast 80" },
                new Meal { Id = 81, MealCategoryId = 1, Name = "Breakfast 81", Description = "Description of Breakfast 81", Recipe = "Recipe of Breakfast 81" },
                new Meal { Id = 82, MealCategoryId = 1, Name = "Breakfast 82", Description = "Description of Breakfast 82", Recipe = "Recipe of Breakfast 82" },
                new Meal { Id = 83, MealCategoryId = 1, Name = "Breakfast 83", Description = "Description of Breakfast 83", Recipe = "Recipe of Breakfast 83" },
                new Meal { Id = 84, MealCategoryId = 1, Name = "Breakfast 84", Description = "Description of Breakfast 84", Recipe = "Recipe of Breakfast 84" },
                new Meal { Id = 85, MealCategoryId = 1, Name = "Breakfast 85", Description = "Description of Breakfast 85", Recipe = "Recipe of Breakfast 85" },
                new Meal { Id = 86, MealCategoryId = 1, Name = "Breakfast 86", Description = "Description of Breakfast 86", Recipe = "Recipe of Breakfast 86" },
                new Meal { Id = 87, MealCategoryId = 1, Name = "Breakfast 87", Description = "Description of Breakfast 87", Recipe = "Recipe of Breakfast 87" },
                new Meal { Id = 88, MealCategoryId = 1, Name = "Breakfast 88", Description = "Description of Breakfast 88", Recipe = "Recipe of Breakfast 88" },
                new Meal { Id = 89, MealCategoryId = 1, Name = "Breakfast 89", Description = "Description of Breakfast 89", Recipe = "Recipe of Breakfast 89" },
                new Meal { Id = 90, MealCategoryId = 1, Name = "Breakfast 90", Description = "Description of Breakfast 90", Recipe = "Recipe of Breakfast 90" },
                new Meal { Id = 91, MealCategoryId = 1, Name = "Breakfast 91", Description = "Description of Breakfast 91", Recipe = "Recipe of Breakfast 91" },
                new Meal { Id = 92, MealCategoryId = 1, Name = "Breakfast 92", Description = "Description of Breakfast 92", Recipe = "Recipe of Breakfast 92" },
                new Meal { Id = 93, MealCategoryId = 1, Name = "Breakfast 93", Description = "Description of Breakfast 93", Recipe = "Recipe of Breakfast 93" },
                new Meal { Id = 94, MealCategoryId = 1, Name = "Breakfast 94", Description = "Description of Breakfast 94", Recipe = "Recipe of Breakfast 94" },
                new Meal { Id = 95, MealCategoryId = 1, Name = "Breakfast 95", Description = "Description of Breakfast 95", Recipe = "Recipe of Breakfast 95" },
                new Meal { Id = 96, MealCategoryId = 1, Name = "Breakfast 96", Description = "Description of Breakfast 96", Recipe = "Recipe of Breakfast 96" },
                new Meal { Id = 97, MealCategoryId = 1, Name = "Breakfast 97", Description = "Description of Breakfast 97", Recipe = "Recipe of Breakfast 97" },
                new Meal { Id = 98, MealCategoryId = 1, Name = "Breakfast 98", Description = "Description of Breakfast 98", Recipe = "Recipe of Breakfast 98" },
                new Meal { Id = 99, MealCategoryId = 1, Name = "Breakfast 99", Description = "Description of Breakfast 99", Recipe = "Recipe of Breakfast 99" },
                new Meal { Id = 100, MealCategoryId = 1, Name = "Breakfast 100", Description = "Description of Breakfast 100", Recipe = "Recipe of Breakfast 100" },

                new Meal { Id = 101, MealCategoryId = 5, Name = "Dinner 101", Description = "Description of Dinner 101", Recipe = "Recipe of Dinner 101" },
                new Meal { Id = 102, MealCategoryId = 5, Name = "Dinner 102", Description = "Description of Dinner 102", Recipe = "Recipe of Dinner 102" },
                new Meal { Id = 103, MealCategoryId = 5, Name = "Dinner 103", Description = "Description of Dinner 103", Recipe = "Recipe of Dinner 103" },
                new Meal { Id = 104, MealCategoryId = 5, Name = "Dinner 104", Description = "Description of Dinner 104", Recipe = "Recipe of Dinner 104" },
                new Meal { Id = 105, MealCategoryId = 5, Name = "Dinner 105", Description = "Description of Dinner 105", Recipe = "Recipe of Dinner 105" },
                new Meal { Id = 106, MealCategoryId = 5, Name = "Dinner 106", Description = "Description of Dinner 106", Recipe = "Recipe of Dinner 106" },
                new Meal { Id = 107, MealCategoryId = 5, Name = "Dinner 107", Description = "Description of Dinner 107", Recipe = "Recipe of Dinner 107" },
                new Meal { Id = 108, MealCategoryId = 5, Name = "Dinner 108", Description = "Description of Dinner 108", Recipe = "Recipe of Dinner 108" },
                new Meal { Id = 109, MealCategoryId = 5, Name = "Dinner 109", Description = "Description of Dinner 109", Recipe = "Recipe of Dinner 109" },
                new Meal { Id = 110, MealCategoryId = 5, Name = "Dinner 110", Description = "Description of Dinner 110", Recipe = "Recipe of Dinner 110" },
                new Meal { Id = 111, MealCategoryId = 5, Name = "Dinner 111", Description = "Description of Dinner 111", Recipe = "Recipe of Dinner 111" },
                new Meal { Id = 112, MealCategoryId = 5, Name = "Dinner 112", Description = "Description of Dinner 112", Recipe = "Recipe of Dinner 112" },
                new Meal { Id = 113, MealCategoryId = 5, Name = "Dinner 113", Description = "Description of Dinner 113", Recipe = "Recipe of Dinner 113" },
                new Meal { Id = 114, MealCategoryId = 5, Name = "Dinner 114", Description = "Description of Dinner 114", Recipe = "Recipe of Dinner 114" },
                new Meal { Id = 115, MealCategoryId = 5, Name = "Dinner 115", Description = "Description of Dinner 115", Recipe = "Recipe of Dinner 115" },
                new Meal { Id = 116, MealCategoryId = 5, Name = "Dinner 116", Description = "Description of Dinner 116", Recipe = "Recipe of Dinner 116" },
                new Meal { Id = 117, MealCategoryId = 5, Name = "Dinner 117", Description = "Description of Dinner 117", Recipe = "Recipe of Dinner 117" },
                new Meal { Id = 118, MealCategoryId = 5, Name = "Dinner 118", Description = "Description of Dinner 118", Recipe = "Recipe of Dinner 118" },
                new Meal { Id = 119, MealCategoryId = 5, Name = "Dinner 119", Description = "Description of Dinner 119", Recipe = "Recipe of Dinner 119" },
                new Meal { Id = 120, MealCategoryId = 5, Name = "Dinner 120", Description = "Description of Dinner 120", Recipe = "Recipe of Dinner 120" },
                new Meal { Id = 121, MealCategoryId = 5, Name = "Dinner 121", Description = "Description of Dinner 121", Recipe = "Recipe of Dinner 121" },
                new Meal { Id = 122, MealCategoryId = 5, Name = "Dinner 122", Description = "Description of Dinner 122", Recipe = "Recipe of Dinner 122" },
                new Meal { Id = 123, MealCategoryId = 5, Name = "Dinner 123", Description = "Description of Dinner 123", Recipe = "Recipe of Dinner 123" },
                new Meal { Id = 124, MealCategoryId = 5, Name = "Dinner 124", Description = "Description of Dinner 124", Recipe = "Recipe of Dinner 124" },
                new Meal { Id = 125, MealCategoryId = 5, Name = "Dinner 125", Description = "Description of Dinner 125", Recipe = "Recipe of Dinner 125" },
                new Meal { Id = 126, MealCategoryId = 5, Name = "Dinner 126", Description = "Description of Dinner 126", Recipe = "Recipe of Dinner 126" },
                new Meal { Id = 127, MealCategoryId = 5, Name = "Dinner 127", Description = "Description of Dinner 127", Recipe = "Recipe of Dinner 127" },
                new Meal { Id = 128, MealCategoryId = 5, Name = "Dinner 128", Description = "Description of Dinner 128", Recipe = "Recipe of Dinner 128" },
                new Meal { Id = 129, MealCategoryId = 5, Name = "Dinner 129", Description = "Description of Dinner 129", Recipe = "Recipe of Dinner 129" },
                new Meal { Id = 130, MealCategoryId = 5, Name = "Dinner 130", Description = "Description of Dinner 130", Recipe = "Recipe of Dinner 130" },
                new Meal { Id = 131, MealCategoryId = 5, Name = "Dinner 131", Description = "Description of Dinner 131", Recipe = "Recipe of Dinner 131" },
                new Meal { Id = 132, MealCategoryId = 5, Name = "Dinner 132", Description = "Description of Dinner 132", Recipe = "Recipe of Dinner 132" },
                new Meal { Id = 133, MealCategoryId = 5, Name = "Dinner 133", Description = "Description of Dinner 133", Recipe = "Recipe of Dinner 133" },
                new Meal { Id = 134, MealCategoryId = 5, Name = "Dinner 134", Description = "Description of Dinner 134", Recipe = "Recipe of Dinner 134" },
                new Meal { Id = 135, MealCategoryId = 5, Name = "Dinner 135", Description = "Description of Dinner 135", Recipe = "Recipe of Dinner 135" },
                new Meal { Id = 136, MealCategoryId = 5, Name = "Dinner 136", Description = "Description of Dinner 136", Recipe = "Recipe of Dinner 136" },
                new Meal { Id = 137, MealCategoryId = 5, Name = "Dinner 137", Description = "Description of Dinner 137", Recipe = "Recipe of Dinner 137" },
                new Meal { Id = 138, MealCategoryId = 5, Name = "Dinner 138", Description = "Description of Dinner 138", Recipe = "Recipe of Dinner 138" },
                new Meal { Id = 139, MealCategoryId = 5, Name = "Dinner 139", Description = "Description of Dinner 139", Recipe = "Recipe of Dinner 139" },
                new Meal { Id = 140, MealCategoryId = 5, Name = "Dinner 140", Description = "Description of Dinner 140", Recipe = "Recipe of Dinner 140" },

                new Meal { Id = 141, MealCategoryId = 2, Name = "Lunch 141", Description = "Description of Lunch 141", Recipe = "Recipe of Lunch 141" },
                new Meal { Id = 142, MealCategoryId = 2, Name = "Lunch 142", Description = "Description of Lunch 142", Recipe = "Recipe of Lunch 142" },
                new Meal { Id = 143, MealCategoryId = 2, Name = "Lunch 143", Description = "Description of Lunch 143", Recipe = "Recipe of Lunch 143" },
                new Meal { Id = 144, MealCategoryId = 2, Name = "Lunch 144", Description = "Description of Lunch 144", Recipe = "Recipe of Lunch 144" },
                new Meal { Id = 145, MealCategoryId = 2, Name = "Lunch 145", Description = "Description of Lunch 145", Recipe = "Recipe of Lunch 145" },
                new Meal { Id = 146, MealCategoryId = 2, Name = "Lunch 146", Description = "Description of Lunch 146", Recipe = "Recipe of Lunch 146" },
                new Meal { Id = 147, MealCategoryId = 2, Name = "Lunch 147", Description = "Description of Lunch 147", Recipe = "Recipe of Lunch 147" },
                new Meal { Id = 148, MealCategoryId = 2, Name = "Lunch 148", Description = "Description of Lunch 148", Recipe = "Recipe of Lunch 148" },
                new Meal { Id = 149, MealCategoryId = 2, Name = "Lunch 149", Description = "Description of Lunch 149", Recipe = "Recipe of Lunch 149" },
                new Meal { Id = 150, MealCategoryId = 2, Name = "Lunch 150", Description = "Description of Lunch 150", Recipe = "Recipe of Lunch 150" },
                new Meal { Id = 151, MealCategoryId = 2, Name = "Lunch 151", Description = "Description of Lunch 151", Recipe = "Recipe of Lunch 151" },
                new Meal { Id = 152, MealCategoryId = 2, Name = "Lunch 152", Description = "Description of Lunch 152", Recipe = "Recipe of Lunch 152" },
                new Meal { Id = 153, MealCategoryId = 2, Name = "Lunch 153", Description = "Description of Lunch 153", Recipe = "Recipe of Lunch 153" },
                new Meal { Id = 154, MealCategoryId = 2, Name = "Lunch 154", Description = "Description of Lunch 154", Recipe = "Recipe of Lunch 154" },
                new Meal { Id = 155, MealCategoryId = 2, Name = "Lunch 155", Description = "Description of Lunch 155", Recipe = "Recipe of Lunch 155" },
                new Meal { Id = 156, MealCategoryId = 2, Name = "Lunch 156", Description = "Description of Lunch 156", Recipe = "Recipe of Lunch 156" },
                new Meal { Id = 157, MealCategoryId = 2, Name = "Lunch 157", Description = "Description of Lunch 157", Recipe = "Recipe of Lunch 157" },
                new Meal { Id = 158, MealCategoryId = 2, Name = "Lunch 158", Description = "Description of Lunch 158", Recipe = "Recipe of Lunch 158" },
                new Meal { Id = 159, MealCategoryId = 2, Name = "Lunch 159", Description = "Description of Lunch 159", Recipe = "Recipe of Lunch 159" },
                new Meal { Id = 160, MealCategoryId = 2, Name = "Lunch 160", Description = "Description of Lunch 160", Recipe = "Recipe of Lunch 160" },
                new Meal { Id = 161, MealCategoryId = 2, Name = "Lunch 161", Description = "Description of Lunch 161", Recipe = "Recipe of Lunch 161" },
                new Meal { Id = 162, MealCategoryId = 2, Name = "Lunch 162", Description = "Description of Lunch 162", Recipe = "Recipe of Lunch 162" },
                new Meal { Id = 163, MealCategoryId = 2, Name = "Lunch 163", Description = "Description of Lunch 163", Recipe = "Recipe of Lunch 163" },
                new Meal { Id = 164, MealCategoryId = 2, Name = "Lunch 164", Description = "Description of Lunch 164", Recipe = "Recipe of Lunch 164" },
                new Meal { Id = 165, MealCategoryId = 2, Name = "Lunch 165", Description = "Description of Lunch 165", Recipe = "Recipe of Lunch 165" },
                new Meal { Id = 166, MealCategoryId = 2, Name = "Lunch 166", Description = "Description of Lunch 166", Recipe = "Recipe of Lunch 166" },
                new Meal { Id = 167, MealCategoryId = 2, Name = "Lunch 167", Description = "Description of Lunch 167", Recipe = "Recipe of Lunch 167" },
                new Meal { Id = 168, MealCategoryId = 2, Name = "Lunch 168", Description = "Description of Lunch 168", Recipe = "Recipe of Lunch 168" },
                new Meal { Id = 169, MealCategoryId = 2, Name = "Lunch 169", Description = "Description of Lunch 169", Recipe = "Recipe of Lunch 169" },
                new Meal { Id = 170, MealCategoryId = 2, Name = "Lunch 170", Description = "Description of Lunch 170", Recipe = "Recipe of Lunch 170" },
                new Meal { Id = 171, MealCategoryId = 2, Name = "Lunch 171", Description = "Description of Lunch 171", Recipe = "Recipe of Lunch 171" },
                new Meal { Id = 172, MealCategoryId = 2, Name = "Lunch 172", Description = "Description of Lunch 172", Recipe = "Recipe of Lunch 172" },
                new Meal { Id = 173, MealCategoryId = 2, Name = "Lunch 173", Description = "Description of Lunch 173", Recipe = "Recipe of Lunch 173" },
                new Meal { Id = 174, MealCategoryId = 2, Name = "Lunch 174", Description = "Description of Lunch 174", Recipe = "Recipe of Lunch 174" },
                new Meal { Id = 175, MealCategoryId = 2, Name = "Lunch 175", Description = "Description of Lunch 175", Recipe = "Recipe of Lunch 175" },
                new Meal { Id = 176, MealCategoryId = 2, Name = "Lunch 176", Description = "Description of Lunch 176", Recipe = "Recipe of Lunch 176" },
                new Meal { Id = 177, MealCategoryId = 2, Name = "Lunch 177", Description = "Description of Lunch 177", Recipe = "Recipe of Lunch 177" },
                new Meal { Id = 178, MealCategoryId = 2, Name = "Lunch 178", Description = "Description of Lunch 178", Recipe = "Recipe of Lunch 178" },
                new Meal { Id = 179, MealCategoryId = 2, Name = "Lunch 179", Description = "Description of Lunch 179", Recipe = "Recipe of Lunch 179" },
                new Meal { Id = 180, MealCategoryId = 2, Name = "Lunch 180", Description = "Description of Lunch 180", Recipe = "Recipe of Lunch 180" },

                new Meal { Id = 181, MealCategoryId = 3, Name = "Snack 181", Description = "Description of Snack 181", Recipe = "Recipe of Snack 181" },
                new Meal { Id = 182, MealCategoryId = 3, Name = "Snack 182", Description = "Description of Snack 182", Recipe = "Recipe of Snack 182" },
                new Meal { Id = 183, MealCategoryId = 3, Name = "Snack 183", Description = "Description of Snack 183", Recipe = "Recipe of Snack 183" },
                new Meal { Id = 184, MealCategoryId = 3, Name = "Snack 184", Description = "Description of Snack 184", Recipe = "Recipe of Snack 184" },
                new Meal { Id = 185, MealCategoryId = 3, Name = "Snack 185", Description = "Description of Snack 185", Recipe = "Recipe of Snack 185" },
                new Meal { Id = 186, MealCategoryId = 3, Name = "Snack 186", Description = "Description of Snack 186", Recipe = "Recipe of Snack 186" },
                new Meal { Id = 187, MealCategoryId = 3, Name = "Snack 187", Description = "Description of Snack 187", Recipe = "Recipe of Snack 187" },
                new Meal { Id = 188, MealCategoryId = 3, Name = "Snack 188", Description = "Description of Snack 188", Recipe = "Recipe of Snack 188" },
                new Meal { Id = 189, MealCategoryId = 3, Name = "Snack 189", Description = "Description of Snack 189", Recipe = "Recipe of Snack 189" },
                new Meal { Id = 190, MealCategoryId = 3, Name = "Snack 190", Description = "Description of Snack 190", Recipe = "Recipe of Snack 190" },
                new Meal { Id = 191, MealCategoryId = 3, Name = "Snack 191", Description = "Description of Snack 191", Recipe = "Recipe of Snack 191" },
                new Meal { Id = 192, MealCategoryId = 3, Name = "Snack 192", Description = "Description of Snack 192", Recipe = "Recipe of Snack 192" },
                new Meal { Id = 193, MealCategoryId = 3, Name = "Snack 193", Description = "Description of Snack 193", Recipe = "Recipe of Snack 193" },
                new Meal { Id = 194, MealCategoryId = 3, Name = "Snack 194", Description = "Description of Snack 194", Recipe = "Recipe of Snack 194" },
                new Meal { Id = 195, MealCategoryId = 3, Name = "Snack 195", Description = "Description of Snack 195", Recipe = "Recipe of Snack 195" },
                new Meal { Id = 196, MealCategoryId = 3, Name = "Snack 196", Description = "Description of Snack 196", Recipe = "Recipe of Snack 196" },
                new Meal { Id = 197, MealCategoryId = 3, Name = "Snack 197", Description = "Description of Snack 197", Recipe = "Recipe of Snack 197" },
                new Meal { Id = 198, MealCategoryId = 3, Name = "Snack 198", Description = "Description of Snack 198", Recipe = "Recipe of Snack 198" },
                new Meal { Id = 199, MealCategoryId = 3, Name = "Snack 199", Description = "Description of Snack 199", Recipe = "Recipe of Snack 199" },
                new Meal { Id = 200, MealCategoryId = 3, Name = "Snack 200", Description = "Description of Snack 200", Recipe = "Recipe of Snack 200" },
                new Meal { Id = 201, MealCategoryId = 3, Name = "Snack 201", Description = "Description of Snack 201", Recipe = "Recipe of Snack 201" },
                new Meal { Id = 202, MealCategoryId = 3, Name = "Snack 202", Description = "Description of Snack 202", Recipe = "Recipe of Snack 202" },
                new Meal { Id = 203, MealCategoryId = 3, Name = "Snack 203", Description = "Description of Snack 203", Recipe = "Recipe of Snack 203" },
                new Meal { Id = 204, MealCategoryId = 3, Name = "Snack 204", Description = "Description of Snack 204", Recipe = "Recipe of Snack 204" },
                new Meal { Id = 205, MealCategoryId = 3, Name = "Snack 205", Description = "Description of Snack 205", Recipe = "Recipe of Snack 205" },
                new Meal { Id = 206, MealCategoryId = 3, Name = "Snack 206", Description = "Description of Snack 206", Recipe = "Recipe of Snack 206" },
                new Meal { Id = 207, MealCategoryId = 3, Name = "Snack 207", Description = "Description of Snack 207", Recipe = "Recipe of Snack 207" },
                new Meal { Id = 208, MealCategoryId = 3, Name = "Snack 208", Description = "Description of Snack 208", Recipe = "Recipe of Snack 208" },
                new Meal { Id = 209, MealCategoryId = 3, Name = "Snack 209", Description = "Description of Snack 209", Recipe = "Recipe of Snack 209" },
                new Meal { Id = 210, MealCategoryId = 3, Name = "Snack 210", Description = "Description of Snack 210", Recipe = "Recipe of Snack 210" },
                new Meal { Id = 211, MealCategoryId = 3, Name = "Snack 211", Description = "Description of Snack 211", Recipe = "Recipe of Snack 211" },
                new Meal { Id = 212, MealCategoryId = 3, Name = "Snack 212", Description = "Description of Snack 212", Recipe = "Recipe of Snack 212" },
                new Meal { Id = 213, MealCategoryId = 3, Name = "Snack 213", Description = "Description of Snack 213", Recipe = "Recipe of Snack 213" },
                new Meal { Id = 214, MealCategoryId = 3, Name = "Snack 214", Description = "Description of Snack 214", Recipe = "Recipe of Snack 214" },
                new Meal { Id = 215, MealCategoryId = 3, Name = "Snack 215", Description = "Description of Snack 215", Recipe = "Recipe of Snack 215" },
                new Meal { Id = 216, MealCategoryId = 3, Name = "Snack 216", Description = "Description of Snack 216", Recipe = "Recipe of Snack 216" },
                new Meal { Id = 217, MealCategoryId = 3, Name = "Snack 217", Description = "Description of Snack 217", Recipe = "Recipe of Snack 217" },
                new Meal { Id = 218, MealCategoryId = 3, Name = "Snack 218", Description = "Description of Snack 218", Recipe = "Recipe of Snack 218" },
                new Meal { Id = 219, MealCategoryId = 3, Name = "Snack 219", Description = "Description of Snack 219", Recipe = "Recipe of Snack 219" },
                new Meal { Id = 220, MealCategoryId = 3, Name = "Snack 220", Description = "Description of Snack 220", Recipe = "Recipe of Snack 220" },

                new Meal { Id = 221, MealCategoryId = 4, Name = "Second breakfast 221", Description = "Description of Second breakfast 221", Recipe = "Recipe of Second breakfast 221" },
                new Meal { Id = 222, MealCategoryId = 4, Name = "Second breakfast 222", Description = "Description of Second breakfast 222", Recipe = "Recipe of Second breakfast 222" },
                new Meal { Id = 223, MealCategoryId = 4, Name = "Second breakfast 223", Description = "Description of Second breakfast 223", Recipe = "Recipe of Second breakfast 223" },
                new Meal { Id = 224, MealCategoryId = 4, Name = "Second breakfast 224", Description = "Description of Second breakfast 224", Recipe = "Recipe of Second breakfast 224" },
                new Meal { Id = 225, MealCategoryId = 4, Name = "Second breakfast 225", Description = "Description of Second breakfast 225", Recipe = "Recipe of Second breakfast 225" },
                new Meal { Id = 226, MealCategoryId = 4, Name = "Second breakfast 226", Description = "Description of Second breakfast 226", Recipe = "Recipe of Second breakfast 226" },
                new Meal { Id = 227, MealCategoryId = 4, Name = "Second breakfast 227", Description = "Description of Second breakfast 227", Recipe = "Recipe of Second breakfast 227" },
                new Meal { Id = 228, MealCategoryId = 4, Name = "Second breakfast 228", Description = "Description of Second breakfast 228", Recipe = "Recipe of Second breakfast 228" },
                new Meal { Id = 229, MealCategoryId = 4, Name = "Second breakfast 229", Description = "Description of Second breakfast 229", Recipe = "Recipe of Second breakfast 229" },
                new Meal { Id = 230, MealCategoryId = 4, Name = "Second breakfast 230", Description = "Description of Second breakfast 230", Recipe = "Recipe of Second breakfast 230" },
                new Meal { Id = 231, MealCategoryId = 4, Name = "Second breakfast 231", Description = "Description of Second breakfast 231", Recipe = "Recipe of Second breakfast 231" },
                new Meal { Id = 232, MealCategoryId = 4, Name = "Second breakfast 232", Description = "Description of Second breakfast 232", Recipe = "Recipe of Second breakfast 232" },
                new Meal { Id = 233, MealCategoryId = 4, Name = "Second breakfast 233", Description = "Description of Second breakfast 233", Recipe = "Recipe of Second breakfast 233" },
                new Meal { Id = 234, MealCategoryId = 4, Name = "Second breakfast 234", Description = "Description of Second breakfast 234", Recipe = "Recipe of Second breakfast 234" },
                new Meal { Id = 235, MealCategoryId = 4, Name = "Second breakfast 235", Description = "Description of Second breakfast 235", Recipe = "Recipe of Second breakfast 235" },
                new Meal { Id = 236, MealCategoryId = 4, Name = "Second breakfast 236", Description = "Description of Second breakfast 236", Recipe = "Recipe of Second breakfast 236" },
                new Meal { Id = 237, MealCategoryId = 4, Name = "Second breakfast 237", Description = "Description of Second breakfast 237", Recipe = "Recipe of Second breakfast 237" },
                new Meal { Id = 238, MealCategoryId = 4, Name = "Second breakfast 238", Description = "Description of Second breakfast 238", Recipe = "Recipe of Second breakfast 238" },
                new Meal { Id = 239, MealCategoryId = 4, Name = "Second breakfast 239", Description = "Description of Second breakfast 239", Recipe = "Recipe of Second breakfast 239" },
                new Meal { Id = 240, MealCategoryId = 4, Name = "Second breakfast 240", Description = "Description of Second breakfast 240", Recipe = "Recipe of Second breakfast 240" },
                new Meal { Id = 241, MealCategoryId = 4, Name = "Second breakfast 241", Description = "Description of Second breakfast 241", Recipe = "Recipe of Second breakfast 241" },
                new Meal { Id = 242, MealCategoryId = 4, Name = "Second breakfast 242", Description = "Description of Second breakfast 242", Recipe = "Recipe of Second breakfast 242" },
                new Meal { Id = 243, MealCategoryId = 4, Name = "Second breakfast 243", Description = "Description of Second breakfast 243", Recipe = "Recipe of Second breakfast 243" },
                new Meal { Id = 244, MealCategoryId = 4, Name = "Second breakfast 244", Description = "Description of Second breakfast 244", Recipe = "Recipe of Second breakfast 244" },
                new Meal { Id = 245, MealCategoryId = 4, Name = "Second breakfast 245", Description = "Description of Second breakfast 245", Recipe = "Recipe of Second breakfast 245" },
                new Meal { Id = 246, MealCategoryId = 4, Name = "Second breakfast 246", Description = "Description of Second breakfast 246", Recipe = "Recipe of Second breakfast 246" },
                new Meal { Id = 247, MealCategoryId = 4, Name = "Second breakfast 247", Description = "Description of Second breakfast 247", Recipe = "Recipe of Second breakfast 247" },
                new Meal { Id = 248, MealCategoryId = 4, Name = "Second breakfast 248", Description = "Description of Second breakfast 248", Recipe = "Recipe of Second breakfast 248" },
                new Meal { Id = 249, MealCategoryId = 4, Name = "Second breakfast 249", Description = "Description of Second breakfast 249", Recipe = "Recipe of Second breakfast 249" },
                new Meal { Id = 250, MealCategoryId = 4, Name = "Second breakfast 250", Description = "Description of Second breakfast 250", Recipe = "Recipe of Second breakfast 250" },
                new Meal { Id = 251, MealCategoryId = 4, Name = "Second breakfast 251", Description = "Description of Second breakfast 251", Recipe = "Recipe of Second breakfast 251" },
                new Meal { Id = 252, MealCategoryId = 4, Name = "Second breakfast 252", Description = "Description of Second breakfast 252", Recipe = "Recipe of Second breakfast 252" },
                new Meal { Id = 253, MealCategoryId = 4, Name = "Second breakfast 253", Description = "Description of Second breakfast 253", Recipe = "Recipe of Second breakfast 253" },
                new Meal { Id = 254, MealCategoryId = 4, Name = "Second breakfast 254", Description = "Description of Second breakfast 254", Recipe = "Recipe of Second breakfast 254" },
                new Meal { Id = 255, MealCategoryId = 4, Name = "Second breakfast 255", Description = "Description of Second breakfast 255", Recipe = "Recipe of Second breakfast 255" },
                new Meal { Id = 256, MealCategoryId = 4, Name = "Second breakfast 256", Description = "Description of Second breakfast 256", Recipe = "Recipe of Second breakfast 256" },
                new Meal { Id = 257, MealCategoryId = 4, Name = "Second breakfast 257", Description = "Description of Second breakfast 257", Recipe = "Recipe of Second breakfast 257" },
                new Meal { Id = 258, MealCategoryId = 4, Name = "Second breakfast 258", Description = "Description of Second breakfast 258", Recipe = "Recipe of Second breakfast 258" },
                new Meal { Id = 259, MealCategoryId = 4, Name = "Second breakfast 259", Description = "Description of Second breakfast 259", Recipe = "Recipe of Second breakfast 259" },
                new Meal { Id = 260, MealCategoryId = 4, Name = "Second breakfast 260", Description = "Description of Second breakfast 260", Recipe = "Recipe of Second breakfast 260" }

                );
        }
        private void MealProducts()
        {
            modelBuilder.Entity<MealProduct>().HasData(
                new MealProduct { Id = 1, MealId = 1, ProductId = 4, Quantity = 2 },
                new MealProduct { Id = 2, MealId = 1, ProductId = 28, Quantity = 3 },
                new MealProduct { Id = 3, MealId = 1, ProductId = 4, Quantity = 3 },

                new MealProduct { Id = 4, MealId = 2, ProductId = 30, Quantity = 3 },
                new MealProduct { Id = 5, MealId = 2, ProductId = 24, Quantity = 2 },
                new MealProduct { Id = 6, MealId = 2, ProductId = 7, Quantity = 2 },

                new MealProduct { Id = 7, MealId = 3, ProductId = 15, Quantity = 1 },
                new MealProduct { Id = 8, MealId = 3, ProductId = 30, Quantity = 3 },
                new MealProduct { Id = 9, MealId = 3, ProductId = 35, Quantity = 3 },

                new MealProduct { Id = 10, MealId = 4, ProductId = 12, Quantity = 1 },
                new MealProduct { Id = 11, MealId = 4, ProductId = 30, Quantity = 2 },
                new MealProduct { Id = 12, MealId = 4, ProductId = 9, Quantity = 3 },

                new MealProduct { Id = 13, MealId = 5, ProductId = 17, Quantity = 1 },
                new MealProduct { Id = 14, MealId = 5, ProductId = 14, Quantity = 1 },
                new MealProduct { Id = 15, MealId = 5, ProductId = 28, Quantity = 3 },

                new MealProduct { Id = 16, MealId = 6, ProductId = 23, Quantity = 2 },
                new MealProduct { Id = 17, MealId = 6, ProductId = 12, Quantity = 1 },
                new MealProduct { Id = 18, MealId = 6, ProductId = 24, Quantity = 1 },

                new MealProduct { Id = 19, MealId = 7, ProductId = 4, Quantity = 2 },
                new MealProduct { Id = 20, MealId = 7, ProductId = 8, Quantity = 1 },
                new MealProduct { Id = 21, MealId = 7, ProductId = 26, Quantity = 3 },

                new MealProduct { Id = 22, MealId = 8, ProductId = 9, Quantity = 3 },
                new MealProduct { Id = 23, MealId = 8, ProductId = 18, Quantity = 1 },
                new MealProduct { Id = 24, MealId = 8, ProductId = 6, Quantity = 1 },

                new MealProduct { Id = 25, MealId = 9, ProductId = 31, Quantity = 3 },
                new MealProduct { Id = 26, MealId = 9, ProductId = 20, Quantity = 3 },
                new MealProduct { Id = 27, MealId = 9, ProductId = 31, Quantity = 1 },

                new MealProduct { Id = 28, MealId = 10, ProductId = 29, Quantity = 3 },
                new MealProduct { Id = 29, MealId = 10, ProductId = 5, Quantity = 1 },
                new MealProduct { Id = 30, MealId = 10, ProductId = 15, Quantity = 3 },

                new MealProduct { Id = 31, MealId = 11, ProductId = 20, Quantity = 2 },
                new MealProduct { Id = 32, MealId = 11, ProductId = 37, Quantity = 3 },
                new MealProduct { Id = 33, MealId = 11, ProductId = 29, Quantity = 3 },

                new MealProduct { Id = 34, MealId = 12, ProductId = 5, Quantity = 1 },
                new MealProduct { Id = 35, MealId = 12, ProductId = 19, Quantity = 2 },
                new MealProduct { Id = 36, MealId = 12, ProductId = 33, Quantity = 1 },

                new MealProduct { Id = 37, MealId = 13, ProductId = 28, Quantity = 1 },
                new MealProduct { Id = 38, MealId = 13, ProductId = 17, Quantity = 3 },
                new MealProduct { Id = 39, MealId = 13, ProductId = 5, Quantity = 2 },

                new MealProduct { Id = 40, MealId = 14, ProductId = 9, Quantity = 1 },
                new MealProduct { Id = 41, MealId = 14, ProductId = 4, Quantity = 1 },
                new MealProduct { Id = 42, MealId = 14, ProductId = 15, Quantity = 3 },

                new MealProduct { Id = 43, MealId = 15, ProductId = 7, Quantity = 2 },
                new MealProduct { Id = 44, MealId = 15, ProductId = 23, Quantity = 1 },
                new MealProduct { Id = 45, MealId = 15, ProductId = 18, Quantity = 3 },

                new MealProduct { Id = 46, MealId = 16, ProductId = 5, Quantity = 1 },
                new MealProduct { Id = 47, MealId = 16, ProductId = 10, Quantity = 2 },
                new MealProduct { Id = 48, MealId = 16, ProductId = 21, Quantity = 1 },

                new MealProduct { Id = 49, MealId = 17, ProductId = 36, Quantity = 1 },
                new MealProduct { Id = 50, MealId = 17, ProductId = 36, Quantity = 3 },
                new MealProduct { Id = 51, MealId = 17, ProductId = 6, Quantity = 1 },

                new MealProduct { Id = 52, MealId = 18, ProductId = 29, Quantity = 1 },
                new MealProduct { Id = 53, MealId = 18, ProductId = 37, Quantity = 1 },
                new MealProduct { Id = 54, MealId = 18, ProductId = 8, Quantity = 2 },

                new MealProduct { Id = 55, MealId = 19, ProductId = 30, Quantity = 3 },
                new MealProduct { Id = 56, MealId = 19, ProductId = 25, Quantity = 2 },
                new MealProduct { Id = 57, MealId = 19, ProductId = 30, Quantity = 1 },

                new MealProduct { Id = 58, MealId = 20, ProductId = 28, Quantity = 2 },
                new MealProduct { Id = 59, MealId = 20, ProductId = 8, Quantity = 1 },
                new MealProduct { Id = 60, MealId = 20, ProductId = 28, Quantity = 1 },

                new MealProduct { Id = 62, MealId = 61, ProductId = 23, Quantity = 3 },
                new MealProduct { Id = 63, MealId = 61, ProductId = 12, Quantity = 4 },
                new MealProduct { Id = 64, MealId = 61, ProductId = 32, Quantity = 2 },

                new MealProduct { Id = 65, MealId = 62, ProductId = 25, Quantity = 3 },
                new MealProduct { Id = 66, MealId = 62, ProductId = 15, Quantity = 4 },
                new MealProduct { Id = 67, MealId = 62, ProductId = 20, Quantity = 3 },

                new MealProduct { Id = 68, MealId = 63, ProductId = 13, Quantity = 3 },
                new MealProduct { Id = 69, MealId = 63, ProductId = 4, Quantity = 2 },
                new MealProduct { Id = 70, MealId = 63, ProductId = 12, Quantity = 3 },

                new MealProduct { Id = 71, MealId = 64, ProductId = 31, Quantity = 4 },
                new MealProduct { Id = 72, MealId = 64, ProductId = 5, Quantity = 3 },
                new MealProduct { Id = 73, MealId = 64, ProductId = 27, Quantity = 1 },

                new MealProduct { Id = 74, MealId = 65, ProductId = 14, Quantity = 4 },
                new MealProduct { Id = 75, MealId = 65, ProductId = 25, Quantity = 4 },
                new MealProduct { Id = 76, MealId = 65, ProductId = 26, Quantity = 4 },

                new MealProduct { Id = 77, MealId = 66, ProductId = 19, Quantity = 4 },
                new MealProduct { Id = 78, MealId = 66, ProductId = 12, Quantity = 4 },
                new MealProduct { Id = 79, MealId = 66, ProductId = 28, Quantity = 1 },

                new MealProduct { Id = 80, MealId = 67, ProductId = 20, Quantity = 2 },
                new MealProduct { Id = 81, MealId = 67, ProductId = 30, Quantity = 3 },
                new MealProduct { Id = 82, MealId = 67, ProductId = 20, Quantity = 1 },

                new MealProduct { Id = 83, MealId = 68, ProductId = 9, Quantity = 4 },
                new MealProduct { Id = 84, MealId = 68, ProductId = 32, Quantity = 4 },
                new MealProduct { Id = 85, MealId = 68, ProductId = 26, Quantity = 2 },

                new MealProduct { Id = 86, MealId = 69, ProductId = 4, Quantity = 1 },
                new MealProduct { Id = 87, MealId = 69, ProductId = 21, Quantity = 1 },
                new MealProduct { Id = 88, MealId = 69, ProductId = 13, Quantity = 4 },

                new MealProduct { Id = 89, MealId = 70, ProductId = 31, Quantity = 1 },
                new MealProduct { Id = 90, MealId = 70, ProductId = 12, Quantity = 1 },
                new MealProduct { Id = 91, MealId = 70, ProductId = 24, Quantity = 4 },

                new MealProduct { Id = 92, MealId = 71, ProductId = 23, Quantity = 3 },
                new MealProduct { Id = 93, MealId = 71, ProductId = 14, Quantity = 2 },
                new MealProduct { Id = 94, MealId = 71, ProductId = 28, Quantity = 3 },

                new MealProduct { Id = 95, MealId = 72, ProductId = 6, Quantity = 1 },
                new MealProduct { Id = 96, MealId = 72, ProductId = 28, Quantity = 1 },
                new MealProduct { Id = 97, MealId = 72, ProductId = 32, Quantity = 4 },

                new MealProduct { Id = 98, MealId = 73, ProductId = 24, Quantity = 4 },
                new MealProduct { Id = 99, MealId = 73, ProductId = 10, Quantity = 4 },
                new MealProduct { Id = 100, MealId = 73, ProductId = 3, Quantity = 4 },

                new MealProduct { Id = 101, MealId = 74, ProductId = 29, Quantity = 2 },
                new MealProduct { Id = 102, MealId = 74, ProductId = 27, Quantity = 4 },
                new MealProduct { Id = 103, MealId = 74, ProductId = 17, Quantity = 2 },

                new MealProduct { Id = 104, MealId = 75, ProductId = 28, Quantity = 1 },
                new MealProduct { Id = 105, MealId = 75, ProductId = 26, Quantity = 3 },
                new MealProduct { Id = 106, MealId = 75, ProductId = 11, Quantity = 4 },

                new MealProduct { Id = 107, MealId = 76, ProductId = 10, Quantity = 3 },
                new MealProduct { Id = 108, MealId = 76, ProductId = 22, Quantity = 4 },
                new MealProduct { Id = 109, MealId = 76, ProductId = 17, Quantity = 1 },

                new MealProduct { Id = 110, MealId = 77, ProductId = 12, Quantity = 1 },
                new MealProduct { Id = 111, MealId = 77, ProductId = 16, Quantity = 4 },
                new MealProduct { Id = 112, MealId = 77, ProductId = 1, Quantity = 4 },

                new MealProduct { Id = 113, MealId = 78, ProductId = 16, Quantity = 1 },
                new MealProduct { Id = 114, MealId = 78, ProductId = 36, Quantity = 4 },
                new MealProduct { Id = 115, MealId = 78, ProductId = 7, Quantity = 2 },

                new MealProduct { Id = 116, MealId = 79, ProductId = 12, Quantity = 2 },
                new MealProduct { Id = 117, MealId = 79, ProductId = 4, Quantity = 2 },
                new MealProduct { Id = 118, MealId = 79, ProductId = 7, Quantity = 4 },

                new MealProduct { Id = 119, MealId = 80, ProductId = 33, Quantity = 4 },
                new MealProduct { Id = 120, MealId = 80, ProductId = 12, Quantity = 1 },
                new MealProduct { Id = 121, MealId = 80, ProductId = 21, Quantity = 3 },

                new MealProduct { Id = 122, MealId = 81, ProductId = 34, Quantity = 2 },
                new MealProduct { Id = 123, MealId = 81, ProductId = 10, Quantity = 2 },
                new MealProduct { Id = 124, MealId = 81, ProductId = 19, Quantity = 1 },

                new MealProduct { Id = 125, MealId = 82, ProductId = 15, Quantity = 3 },
                new MealProduct { Id = 126, MealId = 82, ProductId = 36, Quantity = 1 },
                new MealProduct { Id = 127, MealId = 82, ProductId = 18, Quantity = 1 },

                new MealProduct { Id = 128, MealId = 83, ProductId = 27, Quantity = 1 },
                new MealProduct { Id = 129, MealId = 83, ProductId = 36, Quantity = 3 },
                new MealProduct { Id = 130, MealId = 83, ProductId = 24, Quantity = 3 },

                new MealProduct { Id = 131, MealId = 84, ProductId = 21, Quantity = 4 },
                new MealProduct { Id = 132, MealId = 84, ProductId = 23, Quantity = 3 },
                new MealProduct { Id = 133, MealId = 84, ProductId = 30, Quantity = 4 },

                new MealProduct { Id = 134, MealId = 85, ProductId = 15, Quantity = 1 },
                new MealProduct { Id = 135, MealId = 85, ProductId = 19, Quantity = 4 },
                new MealProduct { Id = 136, MealId = 85, ProductId = 31, Quantity = 2 },

                new MealProduct { Id = 137, MealId = 86, ProductId = 31, Quantity = 3 },
                new MealProduct { Id = 138, MealId = 86, ProductId = 9, Quantity = 3 },
                new MealProduct { Id = 139, MealId = 86, ProductId = 33, Quantity = 1 },

                new MealProduct { Id = 140, MealId = 87, ProductId = 6, Quantity = 2 },
                new MealProduct { Id = 141, MealId = 87, ProductId = 21, Quantity = 2 },
                new MealProduct { Id = 142, MealId = 87, ProductId = 26, Quantity = 4 },

                new MealProduct { Id = 143, MealId = 88, ProductId = 23, Quantity = 3 },
                new MealProduct { Id = 144, MealId = 88, ProductId = 9, Quantity = 3 },
                new MealProduct { Id = 145, MealId = 88, ProductId = 23, Quantity = 1 },

                new MealProduct { Id = 146, MealId = 89, ProductId = 13, Quantity = 3 },
                new MealProduct { Id = 147, MealId = 89, ProductId = 34, Quantity = 2 },
                new MealProduct { Id = 148, MealId = 89, ProductId = 5, Quantity = 1 },

                new MealProduct { Id = 149, MealId = 90, ProductId = 11, Quantity = 2 },
                new MealProduct { Id = 150, MealId = 90, ProductId = 21, Quantity = 2 },
                new MealProduct { Id = 151, MealId = 90, ProductId = 15, Quantity = 3 },

                new MealProduct { Id = 152, MealId = 91, ProductId = 16, Quantity = 4 },
                new MealProduct { Id = 153, MealId = 91, ProductId = 18, Quantity = 4 },
                new MealProduct { Id = 154, MealId = 91, ProductId = 26, Quantity = 2 },

                new MealProduct { Id = 155, MealId = 92, ProductId = 10, Quantity = 1 },
                new MealProduct { Id = 156, MealId = 92, ProductId = 23, Quantity = 3 },
                new MealProduct { Id = 157, MealId = 92, ProductId = 7, Quantity = 2 },

                new MealProduct { Id = 158, MealId = 93, ProductId = 25, Quantity = 1 },
                new MealProduct { Id = 159, MealId = 93, ProductId = 3, Quantity = 2 },
                new MealProduct { Id = 160, MealId = 93, ProductId = 18, Quantity = 2 },

                new MealProduct { Id = 161, MealId = 94, ProductId = 20, Quantity = 2 },
                new MealProduct { Id = 162, MealId = 94, ProductId = 11, Quantity = 2 },
                new MealProduct { Id = 163, MealId = 94, ProductId = 14, Quantity = 1 },

                new MealProduct { Id = 164, MealId = 95, ProductId = 21, Quantity = 2 },
                new MealProduct { Id = 165, MealId = 95, ProductId = 19, Quantity = 1 },
                new MealProduct { Id = 166, MealId = 95, ProductId = 21, Quantity = 4 },

                new MealProduct { Id = 167, MealId = 96, ProductId = 36, Quantity = 4 },
                new MealProduct { Id = 168, MealId = 96, ProductId = 28, Quantity = 4 },
                new MealProduct { Id = 169, MealId = 96, ProductId = 8, Quantity = 4 },

                new MealProduct { Id = 170, MealId = 97, ProductId = 4, Quantity = 3 },
                new MealProduct { Id = 171, MealId = 97, ProductId = 9, Quantity = 3 },
                new MealProduct { Id = 172, MealId = 97, ProductId = 23, Quantity = 2 },

                new MealProduct { Id = 173, MealId = 98, ProductId = 1, Quantity = 2 },
                new MealProduct { Id = 174, MealId = 98, ProductId = 18, Quantity = 1 },
                new MealProduct { Id = 175, MealId = 98, ProductId = 18, Quantity = 3 },

                new MealProduct { Id = 176, MealId = 99, ProductId = 22, Quantity = 2 },
                new MealProduct { Id = 177, MealId = 99, ProductId = 1, Quantity = 3 },
                new MealProduct { Id = 178, MealId = 99, ProductId = 28, Quantity = 2 },

                new MealProduct { Id = 179, MealId = 100, ProductId = 23, Quantity = 3 },
                new MealProduct { Id = 180, MealId = 100, ProductId = 30, Quantity = 3 },
                new MealProduct { Id = 181, MealId = 100, ProductId = 29, Quantity = 2 },

                new MealProduct { Id = 183, MealId = 101, ProductId = 4, Quantity = 4 },
                new MealProduct { Id = 184, MealId = 101, ProductId = 6, Quantity = 3 },
                new MealProduct { Id = 185, MealId = 101, ProductId = 5, Quantity = 1 },

                new MealProduct { Id = 186, MealId = 102, ProductId = 36, Quantity = 4 },
                new MealProduct { Id = 187, MealId = 102, ProductId = 32, Quantity = 3 },
                new MealProduct { Id = 188, MealId = 102, ProductId = 32, Quantity = 3 },

                new MealProduct { Id = 189, MealId = 103, ProductId = 31, Quantity = 1 },
                new MealProduct { Id = 190, MealId = 103, ProductId = 33, Quantity = 4 },
                new MealProduct { Id = 191, MealId = 103, ProductId = 23, Quantity = 1 },

                new MealProduct { Id = 192, MealId = 104, ProductId = 14, Quantity = 4 },
                new MealProduct { Id = 193, MealId = 104, ProductId = 34, Quantity = 1 },
                new MealProduct { Id = 194, MealId = 104, ProductId = 33, Quantity = 1 },

                new MealProduct { Id = 195, MealId = 105, ProductId = 6, Quantity = 3 },
                new MealProduct { Id = 196, MealId = 105, ProductId = 13, Quantity = 4 },
                new MealProduct { Id = 197, MealId = 105, ProductId = 37, Quantity = 4 },

                new MealProduct { Id = 198, MealId = 106, ProductId = 3, Quantity = 3 },
                new MealProduct { Id = 199, MealId = 106, ProductId = 29, Quantity = 1 },
                new MealProduct { Id = 200, MealId = 106, ProductId = 18, Quantity = 2 },

                new MealProduct { Id = 201, MealId = 107, ProductId = 30, Quantity = 1 },
                new MealProduct { Id = 202, MealId = 107, ProductId = 4, Quantity = 3 },
                new MealProduct { Id = 203, MealId = 107, ProductId = 33, Quantity = 3 },

                new MealProduct { Id = 204, MealId = 108, ProductId = 25, Quantity = 1 },
                new MealProduct { Id = 205, MealId = 108, ProductId = 35, Quantity = 2 },
                new MealProduct { Id = 206, MealId = 108, ProductId = 3, Quantity = 3 },

                new MealProduct { Id = 207, MealId = 109, ProductId = 20, Quantity = 4 },
                new MealProduct { Id = 208, MealId = 109, ProductId = 5, Quantity = 1 },
                new MealProduct { Id = 209, MealId = 109, ProductId = 27, Quantity = 3 },

                new MealProduct { Id = 210, MealId = 110, ProductId = 34, Quantity = 3 },
                new MealProduct { Id = 211, MealId = 110, ProductId = 15, Quantity = 3 },
                new MealProduct { Id = 212, MealId = 110, ProductId = 12, Quantity = 4 },

                new MealProduct { Id = 213, MealId = 111, ProductId = 7, Quantity = 4 },
                new MealProduct { Id = 214, MealId = 111, ProductId = 29, Quantity = 2 },
                new MealProduct { Id = 215, MealId = 111, ProductId = 1, Quantity = 2 },

                new MealProduct { Id = 216, MealId = 112, ProductId = 16, Quantity = 4 },
                new MealProduct { Id = 217, MealId = 112, ProductId = 6, Quantity = 2 },
                new MealProduct { Id = 218, MealId = 112, ProductId = 33, Quantity = 3 },

                new MealProduct { Id = 219, MealId = 113, ProductId = 36, Quantity = 4 },
                new MealProduct { Id = 220, MealId = 113, ProductId = 13, Quantity = 1 },
                new MealProduct { Id = 221, MealId = 113, ProductId = 13, Quantity = 2 },

                new MealProduct { Id = 222, MealId = 114, ProductId = 16, Quantity = 1 },
                new MealProduct { Id = 223, MealId = 114, ProductId = 32, Quantity = 3 },
                new MealProduct { Id = 224, MealId = 114, ProductId = 23, Quantity = 4 },

                new MealProduct { Id = 225, MealId = 115, ProductId = 12, Quantity = 3 },
                new MealProduct { Id = 226, MealId = 115, ProductId = 17, Quantity = 3 },
                new MealProduct { Id = 227, MealId = 115, ProductId = 3, Quantity = 2 },

                new MealProduct { Id = 228, MealId = 116, ProductId = 17, Quantity = 1 },
                new MealProduct { Id = 229, MealId = 116, ProductId = 23, Quantity = 4 },
                new MealProduct { Id = 230, MealId = 116, ProductId = 32, Quantity = 1 },

                new MealProduct { Id = 231, MealId = 117, ProductId = 9, Quantity = 3 },
                new MealProduct { Id = 232, MealId = 117, ProductId = 9, Quantity = 2 },
                new MealProduct { Id = 233, MealId = 117, ProductId = 36, Quantity = 2 },

                new MealProduct { Id = 234, MealId = 118, ProductId = 37, Quantity = 4 },
                new MealProduct { Id = 235, MealId = 118, ProductId = 20, Quantity = 2 },
                new MealProduct { Id = 236, MealId = 118, ProductId = 16, Quantity = 4 },

                new MealProduct { Id = 237, MealId = 119, ProductId = 24, Quantity = 3 },
                new MealProduct { Id = 238, MealId = 119, ProductId = 7, Quantity = 3 },
                new MealProduct { Id = 239, MealId = 119, ProductId = 36, Quantity = 1 },

                new MealProduct { Id = 240, MealId = 120, ProductId = 30, Quantity = 2 },
                new MealProduct { Id = 241, MealId = 120, ProductId = 7, Quantity = 4 },
                new MealProduct { Id = 242, MealId = 120, ProductId = 18, Quantity = 2 },

                new MealProduct { Id = 243, MealId = 121, ProductId = 32, Quantity = 4 },
                new MealProduct { Id = 244, MealId = 121, ProductId = 24, Quantity = 2 },
                new MealProduct { Id = 245, MealId = 121, ProductId = 8, Quantity = 4 },

                new MealProduct { Id = 246, MealId = 122, ProductId = 2, Quantity = 1 },
                new MealProduct { Id = 247, MealId = 122, ProductId = 35, Quantity = 3 },
                new MealProduct { Id = 248, MealId = 122, ProductId = 32, Quantity = 3 },

                new MealProduct { Id = 249, MealId = 123, ProductId = 23, Quantity = 3 },
                new MealProduct { Id = 250, MealId = 123, ProductId = 17, Quantity = 2 },
                new MealProduct { Id = 251, MealId = 123, ProductId = 34, Quantity = 1 },

                new MealProduct { Id = 252, MealId = 124, ProductId = 32, Quantity = 1 },
                new MealProduct { Id = 253, MealId = 124, ProductId = 32, Quantity = 3 },
                new MealProduct { Id = 254, MealId = 124, ProductId = 7, Quantity = 3 },

                new MealProduct { Id = 255, MealId = 125, ProductId = 32, Quantity = 4 },
                new MealProduct { Id = 256, MealId = 125, ProductId = 5, Quantity = 4 },
                new MealProduct { Id = 257, MealId = 125, ProductId = 37, Quantity = 4 },

                new MealProduct { Id = 258, MealId = 126, ProductId = 37, Quantity = 3 },
                new MealProduct { Id = 259, MealId = 126, ProductId = 3, Quantity = 2 },
                new MealProduct { Id = 260, MealId = 126, ProductId = 8, Quantity = 3 },

                new MealProduct { Id = 261, MealId = 127, ProductId = 27, Quantity = 1 },
                new MealProduct { Id = 262, MealId = 127, ProductId = 30, Quantity = 3 },
                new MealProduct { Id = 263, MealId = 127, ProductId = 10, Quantity = 2 },

                new MealProduct { Id = 264, MealId = 128, ProductId = 22, Quantity = 2 },
                new MealProduct { Id = 265, MealId = 128, ProductId = 16, Quantity = 4 },
                new MealProduct { Id = 266, MealId = 128, ProductId = 33, Quantity = 4 },

                new MealProduct { Id = 267, MealId = 129, ProductId = 4, Quantity = 2 },
                new MealProduct { Id = 268, MealId = 129, ProductId = 34, Quantity = 4 },
                new MealProduct { Id = 269, MealId = 129, ProductId = 36, Quantity = 4 },

                new MealProduct { Id = 270, MealId = 130, ProductId = 13, Quantity = 2 },
                new MealProduct { Id = 271, MealId = 130, ProductId = 19, Quantity = 1 },
                new MealProduct { Id = 272, MealId = 130, ProductId = 27, Quantity = 4 },

                new MealProduct { Id = 273, MealId = 131, ProductId = 24, Quantity = 2 },
                new MealProduct { Id = 274, MealId = 131, ProductId = 33, Quantity = 2 },
                new MealProduct { Id = 275, MealId = 131, ProductId = 33, Quantity = 1 },

                new MealProduct { Id = 276, MealId = 132, ProductId = 23, Quantity = 4 },
                new MealProduct { Id = 277, MealId = 132, ProductId = 11, Quantity = 1 },
                new MealProduct { Id = 278, MealId = 132, ProductId = 35, Quantity = 1 },

                new MealProduct { Id = 279, MealId = 133, ProductId = 6, Quantity = 3 },
                new MealProduct { Id = 280, MealId = 133, ProductId = 1, Quantity = 2 },
                new MealProduct { Id = 281, MealId = 133, ProductId = 10, Quantity = 3 },

                new MealProduct { Id = 282, MealId = 134, ProductId = 35, Quantity = 3 },
                new MealProduct { Id = 283, MealId = 134, ProductId = 21, Quantity = 2 },
                new MealProduct { Id = 284, MealId = 134, ProductId = 33, Quantity = 1 },

                new MealProduct { Id = 285, MealId = 135, ProductId = 25, Quantity = 4 },
                new MealProduct { Id = 286, MealId = 135, ProductId = 4, Quantity = 2 },
                new MealProduct { Id = 287, MealId = 135, ProductId = 5, Quantity = 3 },

                new MealProduct { Id = 288, MealId = 136, ProductId = 19, Quantity = 3 },
                new MealProduct { Id = 289, MealId = 136, ProductId = 33, Quantity = 4 },
                new MealProduct { Id = 290, MealId = 136, ProductId = 6, Quantity = 2 },

                new MealProduct { Id = 291, MealId = 137, ProductId = 6, Quantity = 4 },
                new MealProduct { Id = 292, MealId = 137, ProductId = 14, Quantity = 4 },
                new MealProduct { Id = 293, MealId = 137, ProductId = 31, Quantity = 1 },

                new MealProduct { Id = 294, MealId = 138, ProductId = 18, Quantity = 2 },
                new MealProduct { Id = 295, MealId = 138, ProductId = 30, Quantity = 1 },
                new MealProduct { Id = 296, MealId = 138, ProductId = 3, Quantity = 1 },

                new MealProduct { Id = 297, MealId = 139, ProductId = 36, Quantity = 4 },
                new MealProduct { Id = 298, MealId = 139, ProductId = 37, Quantity = 2 },
                new MealProduct { Id = 299, MealId = 139, ProductId = 35, Quantity = 1 },

                new MealProduct { Id = 300, MealId = 140, ProductId = 2, Quantity = 4 },
                new MealProduct { Id = 301, MealId = 140, ProductId = 25, Quantity = 3 },
                new MealProduct { Id = 302, MealId = 140, ProductId = 28, Quantity = 3 },

                new MealProduct { Id = 304, MealId = 141, ProductId = 23, Quantity = 3 },
                new MealProduct { Id = 305, MealId = 141, ProductId = 1, Quantity = 1 },
                new MealProduct { Id = 306, MealId = 141, ProductId = 25, Quantity = 2 },

                new MealProduct { Id = 307, MealId = 142, ProductId = 35, Quantity = 1 },
                new MealProduct { Id = 308, MealId = 142, ProductId = 35, Quantity = 3 },
                new MealProduct { Id = 309, MealId = 142, ProductId = 26, Quantity = 2 },

                new MealProduct { Id = 310, MealId = 143, ProductId = 1, Quantity = 2 },
                new MealProduct { Id = 311, MealId = 143, ProductId = 36, Quantity = 3 },
                new MealProduct { Id = 312, MealId = 143, ProductId = 20, Quantity = 2 },

                new MealProduct { Id = 313, MealId = 144, ProductId = 29, Quantity = 3 },
                new MealProduct { Id = 314, MealId = 144, ProductId = 21, Quantity = 3 },
                new MealProduct { Id = 315, MealId = 144, ProductId = 30, Quantity = 3 },

                new MealProduct { Id = 316, MealId = 145, ProductId = 26, Quantity = 3 },
                new MealProduct { Id = 317, MealId = 145, ProductId = 20, Quantity = 2 },
                new MealProduct { Id = 318, MealId = 145, ProductId = 36, Quantity = 1 },

                new MealProduct { Id = 319, MealId = 146, ProductId = 4, Quantity = 4 },
                new MealProduct { Id = 320, MealId = 146, ProductId = 24, Quantity = 1 },
                new MealProduct { Id = 321, MealId = 146, ProductId = 3, Quantity = 2 },

                new MealProduct { Id = 322, MealId = 147, ProductId = 19, Quantity = 2 },
                new MealProduct { Id = 323, MealId = 147, ProductId = 12, Quantity = 2 },
                new MealProduct { Id = 324, MealId = 147, ProductId = 28, Quantity = 3 },

                new MealProduct { Id = 325, MealId = 148, ProductId = 21, Quantity = 2 },
                new MealProduct { Id = 326, MealId = 148, ProductId = 34, Quantity = 2 },
                new MealProduct { Id = 327, MealId = 148, ProductId = 33, Quantity = 4 },

                new MealProduct { Id = 328, MealId = 149, ProductId = 24, Quantity = 3 },
                new MealProduct { Id = 329, MealId = 149, ProductId = 34, Quantity = 4 },
                new MealProduct { Id = 330, MealId = 149, ProductId = 31, Quantity = 1 },

                new MealProduct { Id = 331, MealId = 150, ProductId = 20, Quantity = 3 },
                new MealProduct { Id = 332, MealId = 150, ProductId = 15, Quantity = 4 },
                new MealProduct { Id = 333, MealId = 150, ProductId = 2, Quantity = 3 },

                new MealProduct { Id = 334, MealId = 151, ProductId = 27, Quantity = 4 },
                new MealProduct { Id = 335, MealId = 151, ProductId = 32, Quantity = 3 },
                new MealProduct { Id = 336, MealId = 151, ProductId = 3, Quantity = 3 },

                new MealProduct { Id = 337, MealId = 152, ProductId = 9, Quantity = 4 },
                new MealProduct { Id = 338, MealId = 152, ProductId = 3, Quantity = 4 },
                new MealProduct { Id = 339, MealId = 152, ProductId = 11, Quantity = 4 },

                new MealProduct { Id = 340, MealId = 153, ProductId = 35, Quantity = 3 },
                new MealProduct { Id = 341, MealId = 153, ProductId = 18, Quantity = 2 },
                new MealProduct { Id = 342, MealId = 153, ProductId = 34, Quantity = 2 },

                new MealProduct { Id = 343, MealId = 154, ProductId = 7, Quantity = 1 },
                new MealProduct { Id = 344, MealId = 154, ProductId = 8, Quantity = 1 },
                new MealProduct { Id = 345, MealId = 154, ProductId = 24, Quantity = 1 },

                new MealProduct { Id = 346, MealId = 155, ProductId = 13, Quantity = 3 },
                new MealProduct { Id = 347, MealId = 155, ProductId = 5, Quantity = 4 },
                new MealProduct { Id = 348, MealId = 155, ProductId = 20, Quantity = 1 },

                new MealProduct { Id = 349, MealId = 156, ProductId = 28, Quantity = 1 },
                new MealProduct { Id = 350, MealId = 156, ProductId = 20, Quantity = 2 },
                new MealProduct { Id = 351, MealId = 156, ProductId = 37, Quantity = 2 },

                new MealProduct { Id = 352, MealId = 157, ProductId = 31, Quantity = 4 },
                new MealProduct { Id = 353, MealId = 157, ProductId = 21, Quantity = 3 },
                new MealProduct { Id = 354, MealId = 157, ProductId = 3, Quantity = 4 },

                new MealProduct { Id = 355, MealId = 158, ProductId = 23, Quantity = 3 },
                new MealProduct { Id = 356, MealId = 158, ProductId = 10, Quantity = 2 },
                new MealProduct { Id = 357, MealId = 158, ProductId = 4, Quantity = 4 },

                new MealProduct { Id = 358, MealId = 159, ProductId = 27, Quantity = 4 },
                new MealProduct { Id = 359, MealId = 159, ProductId = 30, Quantity = 1 },
                new MealProduct { Id = 360, MealId = 159, ProductId = 31, Quantity = 3 },

                new MealProduct { Id = 361, MealId = 160, ProductId = 20, Quantity = 1 },
                new MealProduct { Id = 362, MealId = 160, ProductId = 2, Quantity = 2 },
                new MealProduct { Id = 363, MealId = 160, ProductId = 28, Quantity = 3 },

                new MealProduct { Id = 364, MealId = 161, ProductId = 22, Quantity = 1 },
                new MealProduct { Id = 365, MealId = 161, ProductId = 8, Quantity = 2 },
                new MealProduct { Id = 366, MealId = 161, ProductId = 12, Quantity = 3 },

                new MealProduct { Id = 367, MealId = 162, ProductId = 9, Quantity = 3 },
                new MealProduct { Id = 368, MealId = 162, ProductId = 29, Quantity = 3 },
                new MealProduct { Id = 369, MealId = 162, ProductId = 17, Quantity = 3 },

                new MealProduct { Id = 370, MealId = 163, ProductId = 18, Quantity = 3 },
                new MealProduct { Id = 371, MealId = 163, ProductId = 7, Quantity = 4 },
                new MealProduct { Id = 372, MealId = 163, ProductId = 8, Quantity = 2 },

                new MealProduct { Id = 373, MealId = 164, ProductId = 16, Quantity = 1 },
                new MealProduct { Id = 374, MealId = 164, ProductId = 34, Quantity = 1 },
                new MealProduct { Id = 375, MealId = 164, ProductId = 34, Quantity = 3 },

                new MealProduct { Id = 376, MealId = 165, ProductId = 33, Quantity = 4 },
                new MealProduct { Id = 377, MealId = 165, ProductId = 3, Quantity = 1 },
                new MealProduct { Id = 378, MealId = 165, ProductId = 31, Quantity = 2 },

                new MealProduct { Id = 379, MealId = 166, ProductId = 32, Quantity = 2 },
                new MealProduct { Id = 380, MealId = 166, ProductId = 35, Quantity = 2 },
                new MealProduct { Id = 381, MealId = 166, ProductId = 19, Quantity = 2 },

                new MealProduct { Id = 382, MealId = 167, ProductId = 3, Quantity = 3 },
                new MealProduct { Id = 383, MealId = 167, ProductId = 23, Quantity = 1 },
                new MealProduct { Id = 384, MealId = 167, ProductId = 5, Quantity = 2 },

                new MealProduct { Id = 385, MealId = 168, ProductId = 21, Quantity = 2 },
                new MealProduct { Id = 386, MealId = 168, ProductId = 16, Quantity = 3 },
                new MealProduct { Id = 387, MealId = 168, ProductId = 21, Quantity = 1 },

                new MealProduct { Id = 388, MealId = 169, ProductId = 26, Quantity = 3 },
                new MealProduct { Id = 389, MealId = 169, ProductId = 31, Quantity = 1 },
                new MealProduct { Id = 390, MealId = 169, ProductId = 12, Quantity = 1 },

                new MealProduct { Id = 391, MealId = 170, ProductId = 26, Quantity = 3 },
                new MealProduct { Id = 392, MealId = 170, ProductId = 9, Quantity = 3 },
                new MealProduct { Id = 393, MealId = 170, ProductId = 37, Quantity = 3 },

                new MealProduct { Id = 394, MealId = 171, ProductId = 7, Quantity = 1 },
                new MealProduct { Id = 395, MealId = 171, ProductId = 5, Quantity = 2 },
                new MealProduct { Id = 396, MealId = 171, ProductId = 7, Quantity = 4 },

                new MealProduct { Id = 397, MealId = 172, ProductId = 33, Quantity = 2 },
                new MealProduct { Id = 398, MealId = 172, ProductId = 12, Quantity = 4 },
                new MealProduct { Id = 399, MealId = 172, ProductId = 28, Quantity = 2 },

                new MealProduct { Id = 400, MealId = 173, ProductId = 2, Quantity = 2 },
                new MealProduct { Id = 401, MealId = 173, ProductId = 31, Quantity = 4 },
                new MealProduct { Id = 402, MealId = 173, ProductId = 3, Quantity = 1 },

                new MealProduct { Id = 403, MealId = 174, ProductId = 30, Quantity = 1 },
                new MealProduct { Id = 404, MealId = 174, ProductId = 1, Quantity = 2 },
                new MealProduct { Id = 405, MealId = 174, ProductId = 2, Quantity = 2 },

                new MealProduct { Id = 406, MealId = 175, ProductId = 20, Quantity = 4 },
                new MealProduct { Id = 407, MealId = 175, ProductId = 6, Quantity = 3 },
                new MealProduct { Id = 408, MealId = 175, ProductId = 15, Quantity = 3 },

                new MealProduct { Id = 409, MealId = 176, ProductId = 33, Quantity = 1 },
                new MealProduct { Id = 410, MealId = 176, ProductId = 17, Quantity = 2 },
                new MealProduct { Id = 411, MealId = 176, ProductId = 35, Quantity = 1 },

                new MealProduct { Id = 412, MealId = 177, ProductId = 1, Quantity = 2 },
                new MealProduct { Id = 413, MealId = 177, ProductId = 23, Quantity = 2 },
                new MealProduct { Id = 414, MealId = 177, ProductId = 22, Quantity = 2 },

                new MealProduct { Id = 415, MealId = 178, ProductId = 2, Quantity = 1 },
                new MealProduct { Id = 416, MealId = 178, ProductId = 8, Quantity = 2 },
                new MealProduct { Id = 417, MealId = 178, ProductId = 6, Quantity = 1 },

                new MealProduct { Id = 418, MealId = 179, ProductId = 14, Quantity = 1 },
                new MealProduct { Id = 419, MealId = 179, ProductId = 29, Quantity = 3 },
                new MealProduct { Id = 420, MealId = 179, ProductId = 19, Quantity = 3 },

                new MealProduct { Id = 421, MealId = 180, ProductId = 19, Quantity = 2 },
                new MealProduct { Id = 422, MealId = 180, ProductId = 10, Quantity = 4 },
                new MealProduct { Id = 423, MealId = 180, ProductId = 25, Quantity = 2 },

                new MealProduct { Id = 425, MealId = 181, ProductId = 32, Quantity = 2 },
                new MealProduct { Id = 426, MealId = 181, ProductId = 19, Quantity = 4 },
                new MealProduct { Id = 427, MealId = 181, ProductId = 26, Quantity = 4 },

                new MealProduct { Id = 428, MealId = 182, ProductId = 35, Quantity = 4 },
                new MealProduct { Id = 429, MealId = 182, ProductId = 36, Quantity = 3 },
                new MealProduct { Id = 430, MealId = 182, ProductId = 20, Quantity = 3 },

                new MealProduct { Id = 431, MealId = 183, ProductId = 18, Quantity = 3 },
                new MealProduct { Id = 432, MealId = 183, ProductId = 28, Quantity = 1 },
                new MealProduct { Id = 433, MealId = 183, ProductId = 18, Quantity = 1 },

                new MealProduct { Id = 434, MealId = 184, ProductId = 30, Quantity = 3 },
                new MealProduct { Id = 435, MealId = 184, ProductId = 19, Quantity = 4 },
                new MealProduct { Id = 436, MealId = 184, ProductId = 31, Quantity = 2 },

                new MealProduct { Id = 437, MealId = 185, ProductId = 7, Quantity = 1 },
                new MealProduct { Id = 438, MealId = 185, ProductId = 37, Quantity = 1 },
                new MealProduct { Id = 439, MealId = 185, ProductId = 12, Quantity = 3 },

                new MealProduct { Id = 440, MealId = 186, ProductId = 30, Quantity = 3 },
                new MealProduct { Id = 441, MealId = 186, ProductId = 28, Quantity = 2 },
                new MealProduct { Id = 442, MealId = 186, ProductId = 1, Quantity = 4 },

                new MealProduct { Id = 443, MealId = 187, ProductId = 33, Quantity = 2 },
                new MealProduct { Id = 444, MealId = 187, ProductId = 20, Quantity = 2 },
                new MealProduct { Id = 445, MealId = 187, ProductId = 4, Quantity = 2 },

                new MealProduct { Id = 446, MealId = 188, ProductId = 5, Quantity = 4 },
                new MealProduct { Id = 447, MealId = 188, ProductId = 15, Quantity = 1 },
                new MealProduct { Id = 448, MealId = 188, ProductId = 13, Quantity = 1 },

                new MealProduct { Id = 449, MealId = 189, ProductId = 5, Quantity = 4 },
                new MealProduct { Id = 450, MealId = 189, ProductId = 32, Quantity = 3 },
                new MealProduct { Id = 451, MealId = 189, ProductId = 25, Quantity = 3 },

                new MealProduct { Id = 452, MealId = 190, ProductId = 28, Quantity = 3 },
                new MealProduct { Id = 453, MealId = 190, ProductId = 9, Quantity = 1 },
                new MealProduct { Id = 454, MealId = 190, ProductId = 10, Quantity = 1 },

                new MealProduct { Id = 455, MealId = 191, ProductId = 36, Quantity = 3 },
                new MealProduct { Id = 456, MealId = 191, ProductId = 11, Quantity = 4 },
                new MealProduct { Id = 457, MealId = 191, ProductId = 12, Quantity = 4 },

                new MealProduct { Id = 458, MealId = 192, ProductId = 5, Quantity = 2 },
                new MealProduct { Id = 459, MealId = 192, ProductId = 25, Quantity = 3 },
                new MealProduct { Id = 460, MealId = 192, ProductId = 9, Quantity = 1 },

                new MealProduct { Id = 461, MealId = 193, ProductId = 4, Quantity = 2 },
                new MealProduct { Id = 462, MealId = 193, ProductId = 13, Quantity = 4 },
                new MealProduct { Id = 463, MealId = 193, ProductId = 35, Quantity = 4 },

                new MealProduct { Id = 464, MealId = 194, ProductId = 22, Quantity = 4 },
                new MealProduct { Id = 465, MealId = 194, ProductId = 6, Quantity = 2 },
                new MealProduct { Id = 466, MealId = 194, ProductId = 16, Quantity = 4 },

                new MealProduct { Id = 467, MealId = 195, ProductId = 7, Quantity = 4 },
                new MealProduct { Id = 468, MealId = 195, ProductId = 35, Quantity = 3 },
                new MealProduct { Id = 469, MealId = 195, ProductId = 31, Quantity = 2 },

                new MealProduct { Id = 470, MealId = 196, ProductId = 19, Quantity = 4 },
                new MealProduct { Id = 471, MealId = 196, ProductId = 23, Quantity = 4 },
                new MealProduct { Id = 472, MealId = 196, ProductId = 35, Quantity = 1 },

                new MealProduct { Id = 473, MealId = 197, ProductId = 22, Quantity = 2 },
                new MealProduct { Id = 474, MealId = 197, ProductId = 12, Quantity = 2 },
                new MealProduct { Id = 475, MealId = 197, ProductId = 28, Quantity = 4 },

                new MealProduct { Id = 476, MealId = 198, ProductId = 9, Quantity = 3 },
                new MealProduct { Id = 477, MealId = 198, ProductId = 13, Quantity = 4 },
                new MealProduct { Id = 478, MealId = 198, ProductId = 17, Quantity = 2 },

                new MealProduct { Id = 479, MealId = 199, ProductId = 12, Quantity = 4 },
                new MealProduct { Id = 480, MealId = 199, ProductId = 18, Quantity = 2 },
                new MealProduct { Id = 481, MealId = 199, ProductId = 31, Quantity = 3 },

                new MealProduct { Id = 482, MealId = 200, ProductId = 4, Quantity = 2 },
                new MealProduct { Id = 483, MealId = 200, ProductId = 20, Quantity = 3 },
                new MealProduct { Id = 484, MealId = 200, ProductId = 30, Quantity = 4 },

                new MealProduct { Id = 485, MealId = 201, ProductId = 22, Quantity = 3 },
                new MealProduct { Id = 486, MealId = 201, ProductId = 18, Quantity = 3 },
                new MealProduct { Id = 487, MealId = 201, ProductId = 9, Quantity = 4 },

                new MealProduct { Id = 488, MealId = 202, ProductId = 36, Quantity = 4 },
                new MealProduct { Id = 489, MealId = 202, ProductId = 21, Quantity = 4 },
                new MealProduct { Id = 490, MealId = 202, ProductId = 36, Quantity = 4 },

                new MealProduct { Id = 491, MealId = 203, ProductId = 10, Quantity = 2 },
                new MealProduct { Id = 492, MealId = 203, ProductId = 29, Quantity = 2 },
                new MealProduct { Id = 493, MealId = 203, ProductId = 2, Quantity = 2 },

                new MealProduct { Id = 494, MealId = 204, ProductId = 30, Quantity = 1 },
                new MealProduct { Id = 495, MealId = 204, ProductId = 16, Quantity = 1 },
                new MealProduct { Id = 496, MealId = 204, ProductId = 6, Quantity = 2 },

                new MealProduct { Id = 497, MealId = 205, ProductId = 30, Quantity = 4 },
                new MealProduct { Id = 498, MealId = 205, ProductId = 1, Quantity = 2 },
                new MealProduct { Id = 499, MealId = 205, ProductId = 5, Quantity = 3 },

                new MealProduct { Id = 500, MealId = 206, ProductId = 15, Quantity = 2 },
                new MealProduct { Id = 501, MealId = 206, ProductId = 25, Quantity = 4 },
                new MealProduct { Id = 502, MealId = 206, ProductId = 8, Quantity = 2 },

                new MealProduct { Id = 503, MealId = 207, ProductId = 9, Quantity = 3 },
                new MealProduct { Id = 504, MealId = 207, ProductId = 14, Quantity = 4 },
                new MealProduct { Id = 505, MealId = 207, ProductId = 37, Quantity = 3 },

                new MealProduct { Id = 506, MealId = 208, ProductId = 17, Quantity = 2 },
                new MealProduct { Id = 507, MealId = 208, ProductId = 33, Quantity = 1 },
                new MealProduct { Id = 508, MealId = 208, ProductId = 25, Quantity = 2 },

                new MealProduct { Id = 509, MealId = 209, ProductId = 9, Quantity = 4 },
                new MealProduct { Id = 510, MealId = 209, ProductId = 18, Quantity = 4 },
                new MealProduct { Id = 511, MealId = 209, ProductId = 26, Quantity = 4 },

                new MealProduct { Id = 512, MealId = 210, ProductId = 22, Quantity = 2 },
                new MealProduct { Id = 513, MealId = 210, ProductId = 21, Quantity = 2 },
                new MealProduct { Id = 514, MealId = 210, ProductId = 35, Quantity = 1 },

                new MealProduct { Id = 515, MealId = 211, ProductId = 5, Quantity = 2 },
                new MealProduct { Id = 516, MealId = 211, ProductId = 27, Quantity = 3 },
                new MealProduct { Id = 517, MealId = 211, ProductId = 20, Quantity = 1 },

                new MealProduct { Id = 518, MealId = 212, ProductId = 32, Quantity = 4 },
                new MealProduct { Id = 519, MealId = 212, ProductId = 27, Quantity = 4 },
                new MealProduct { Id = 520, MealId = 212, ProductId = 16, Quantity = 3 },

                new MealProduct { Id = 521, MealId = 213, ProductId = 34, Quantity = 4 },
                new MealProduct { Id = 522, MealId = 213, ProductId = 35, Quantity = 4 },
                new MealProduct { Id = 523, MealId = 213, ProductId = 4, Quantity = 2 },

                new MealProduct { Id = 524, MealId = 214, ProductId = 23, Quantity = 2 },
                new MealProduct { Id = 525, MealId = 214, ProductId = 36, Quantity = 2 },
                new MealProduct { Id = 526, MealId = 214, ProductId = 21, Quantity = 2 },

                new MealProduct { Id = 527, MealId = 215, ProductId = 23, Quantity = 3 },
                new MealProduct { Id = 528, MealId = 215, ProductId = 19, Quantity = 4 },
                new MealProduct { Id = 529, MealId = 215, ProductId = 23, Quantity = 1 },

                new MealProduct { Id = 530, MealId = 216, ProductId = 13, Quantity = 2 },
                new MealProduct { Id = 531, MealId = 216, ProductId = 6, Quantity = 3 },
                new MealProduct { Id = 532, MealId = 216, ProductId = 2, Quantity = 2 },

                new MealProduct { Id = 533, MealId = 217, ProductId = 3, Quantity = 2 },
                new MealProduct { Id = 534, MealId = 217, ProductId = 24, Quantity = 2 },
                new MealProduct { Id = 535, MealId = 217, ProductId = 20, Quantity = 1 },

                new MealProduct { Id = 536, MealId = 218, ProductId = 14, Quantity = 1 },
                new MealProduct { Id = 537, MealId = 218, ProductId = 22, Quantity = 3 },
                new MealProduct { Id = 538, MealId = 218, ProductId = 33, Quantity = 3 },

                new MealProduct { Id = 539, MealId = 219, ProductId = 21, Quantity = 4 },
                new MealProduct { Id = 540, MealId = 219, ProductId = 33, Quantity = 1 },
                new MealProduct { Id = 541, MealId = 219, ProductId = 12, Quantity = 2 },

                new MealProduct { Id = 542, MealId = 220, ProductId = 12, Quantity = 2 },
                new MealProduct { Id = 543, MealId = 220, ProductId = 17, Quantity = 4 },
                new MealProduct { Id = 544, MealId = 220, ProductId = 31, Quantity = 4 },

                new MealProduct { Id = 545, MealId = 221, ProductId = 32, Quantity = 2 },
                new MealProduct { Id = 546, MealId = 221, ProductId = 19, Quantity = 4 },
                new MealProduct { Id = 547, MealId = 221, ProductId = 26, Quantity = 4 },

                new MealProduct { Id = 548, MealId = 222, ProductId = 35, Quantity = 4 },
                new MealProduct { Id = 549, MealId = 222, ProductId = 36, Quantity = 3 },
                new MealProduct { Id = 550, MealId = 222, ProductId = 20, Quantity = 3 },

                new MealProduct { Id = 551, MealId = 223, ProductId = 18, Quantity = 3 },
                new MealProduct { Id = 552, MealId = 223, ProductId = 28, Quantity = 1 },
                new MealProduct { Id = 553, MealId = 223, ProductId = 18, Quantity = 1 },

                new MealProduct { Id = 554, MealId = 224, ProductId = 30, Quantity = 3 },
                new MealProduct { Id = 555, MealId = 224, ProductId = 19, Quantity = 4 },
                new MealProduct { Id = 556, MealId = 224, ProductId = 31, Quantity = 2 },

                new MealProduct { Id = 557, MealId = 225, ProductId = 7, Quantity = 1 },
                new MealProduct { Id = 558, MealId = 225, ProductId = 37, Quantity = 1 },
                new MealProduct { Id = 559, MealId = 225, ProductId = 12, Quantity = 3 },

                new MealProduct { Id = 560, MealId = 226, ProductId = 30, Quantity = 3 },
                new MealProduct { Id = 561, MealId = 226, ProductId = 28, Quantity = 2 },
                new MealProduct { Id = 562, MealId = 226, ProductId = 1, Quantity = 4 },

                new MealProduct { Id = 563, MealId = 227, ProductId = 33, Quantity = 2 },
                new MealProduct { Id = 564, MealId = 227, ProductId = 20, Quantity = 2 },
                new MealProduct { Id = 565, MealId = 227, ProductId = 4, Quantity = 2 },

                new MealProduct { Id = 566, MealId = 228, ProductId = 5, Quantity = 4 },
                new MealProduct { Id = 567, MealId = 228, ProductId = 15, Quantity = 1 },
                new MealProduct { Id = 568, MealId = 228, ProductId = 13, Quantity = 1 },

                new MealProduct { Id = 569, MealId = 229, ProductId = 5, Quantity = 4 },
                new MealProduct { Id = 570, MealId = 229, ProductId = 32, Quantity = 3 },
                new MealProduct { Id = 571, MealId = 229, ProductId = 25, Quantity = 3 },

                new MealProduct { Id = 572, MealId = 230, ProductId = 28, Quantity = 3 },
                new MealProduct { Id = 573, MealId = 230, ProductId = 9, Quantity = 1 },
                new MealProduct { Id = 574, MealId = 230, ProductId = 10, Quantity = 1 },

                new MealProduct { Id = 575, MealId = 231, ProductId = 36, Quantity = 3 },
                new MealProduct { Id = 576, MealId = 231, ProductId = 11, Quantity = 4 },
                new MealProduct { Id = 577, MealId = 231, ProductId = 12, Quantity = 4 },

                new MealProduct { Id = 578, MealId = 232, ProductId = 5, Quantity = 2 },
                new MealProduct { Id = 579, MealId = 232, ProductId = 25, Quantity = 3 },
                new MealProduct { Id = 580, MealId = 232, ProductId = 9, Quantity = 1 },

                new MealProduct { Id = 581, MealId = 233, ProductId = 4, Quantity = 2 },
                new MealProduct { Id = 582, MealId = 233, ProductId = 13, Quantity = 4 },
                new MealProduct { Id = 583, MealId = 223, ProductId = 35, Quantity = 4 },

                new MealProduct { Id = 584, MealId = 234, ProductId = 22, Quantity = 4 },
                new MealProduct { Id = 585, MealId = 234, ProductId = 6, Quantity = 2 },
                new MealProduct { Id = 586, MealId = 234, ProductId = 16, Quantity = 4 },

                new MealProduct { Id = 587, MealId = 235, ProductId = 7, Quantity = 4 },
                new MealProduct { Id = 588, MealId = 235, ProductId = 35, Quantity = 3 },
                new MealProduct { Id = 589, MealId = 235, ProductId = 31, Quantity = 2 },

                new MealProduct { Id = 590, MealId = 236, ProductId = 19, Quantity = 4 },
                new MealProduct { Id = 591, MealId = 236, ProductId = 23, Quantity = 4 },
                new MealProduct { Id = 592, MealId = 236, ProductId = 35, Quantity = 1 },

                new MealProduct { Id = 593, MealId = 237, ProductId = 22, Quantity = 2 },
                new MealProduct { Id = 594, MealId = 237, ProductId = 12, Quantity = 2 },
                new MealProduct { Id = 595, MealId = 237, ProductId = 28, Quantity = 4 },

                new MealProduct { Id = 596, MealId = 238, ProductId = 9, Quantity = 3 },
                new MealProduct { Id = 597, MealId = 238, ProductId = 13, Quantity = 4 },
                new MealProduct { Id = 598, MealId = 238, ProductId = 17, Quantity = 2 },

                new MealProduct { Id = 599, MealId = 239, ProductId = 12, Quantity = 4 },
                new MealProduct { Id = 600, MealId = 239, ProductId = 18, Quantity = 2 },
                new MealProduct { Id = 601, MealId = 239, ProductId = 31, Quantity = 3 },

                new MealProduct { Id = 602, MealId = 240, ProductId = 4, Quantity = 2 },
                new MealProduct { Id = 603, MealId = 240, ProductId = 20, Quantity = 3 },
                new MealProduct { Id = 604, MealId = 240, ProductId = 30, Quantity = 4 },

                new MealProduct { Id = 605, MealId = 241, ProductId = 22, Quantity = 3 },
                new MealProduct { Id = 606, MealId = 241, ProductId = 18, Quantity = 3 },
                new MealProduct { Id = 607, MealId = 241, ProductId = 9, Quantity = 4 },

                new MealProduct { Id = 608, MealId = 242, ProductId = 36, Quantity = 4 },
                new MealProduct { Id = 609, MealId = 242, ProductId = 21, Quantity = 4 },
                new MealProduct { Id = 610, MealId = 242, ProductId = 36, Quantity = 4 },

                new MealProduct { Id = 611, MealId = 243, ProductId = 10, Quantity = 2 },
                new MealProduct { Id = 612, MealId = 243, ProductId = 29, Quantity = 2 },
                new MealProduct { Id = 613, MealId = 243, ProductId = 2, Quantity = 2 },

                new MealProduct { Id = 614, MealId = 244, ProductId = 30, Quantity = 1 },
                new MealProduct { Id = 615, MealId = 244, ProductId = 16, Quantity = 1 },
                new MealProduct { Id = 616, MealId = 244, ProductId = 6, Quantity = 2 },

                new MealProduct { Id = 617, MealId = 245, ProductId = 30, Quantity = 4 },
                new MealProduct { Id = 618, MealId = 245, ProductId = 1, Quantity = 2 },
                new MealProduct { Id = 619, MealId = 245, ProductId = 5, Quantity = 3 },

                new MealProduct { Id = 620, MealId = 246, ProductId = 15, Quantity = 2 },
                new MealProduct { Id = 621, MealId = 246, ProductId = 25, Quantity = 4 },
                new MealProduct { Id = 622, MealId = 246, ProductId = 8, Quantity = 2 },

                new MealProduct { Id = 623, MealId = 247, ProductId = 9, Quantity = 3 },
                new MealProduct { Id = 624, MealId = 247, ProductId = 14, Quantity = 4 },
                new MealProduct { Id = 625, MealId = 247, ProductId = 37, Quantity = 3 },

                new MealProduct { Id = 626, MealId = 248, ProductId = 17, Quantity = 2 },
                new MealProduct { Id = 627, MealId = 248, ProductId = 33, Quantity = 1 },
                new MealProduct { Id = 628, MealId = 248, ProductId = 25, Quantity = 2 },

                new MealProduct { Id = 629, MealId = 249, ProductId = 9, Quantity = 4 },
                new MealProduct { Id = 630, MealId = 249, ProductId = 18, Quantity = 4 },
                new MealProduct { Id = 631, MealId = 249, ProductId = 26, Quantity = 4 },

                new MealProduct { Id = 632, MealId = 250, ProductId = 22, Quantity = 2 },
                new MealProduct { Id = 633, MealId = 250, ProductId = 21, Quantity = 2 },
                new MealProduct { Id = 634, MealId = 250, ProductId = 35, Quantity = 1 },

                new MealProduct { Id = 635, MealId = 251, ProductId = 5, Quantity = 2 },
                new MealProduct { Id = 636, MealId = 251, ProductId = 27, Quantity = 3 },
                new MealProduct { Id = 637, MealId = 251, ProductId = 20, Quantity = 1 },

                new MealProduct { Id = 638, MealId = 252, ProductId = 32, Quantity = 4 },
                new MealProduct { Id = 639, MealId = 252, ProductId = 27, Quantity = 4 },
                new MealProduct { Id = 640, MealId = 252, ProductId = 16, Quantity = 3 },

                new MealProduct { Id = 641, MealId = 253, ProductId = 34, Quantity = 4 },
                new MealProduct { Id = 642, MealId = 253, ProductId = 35, Quantity = 4 },
                new MealProduct { Id = 643, MealId = 253, ProductId = 4, Quantity = 2 },

                new MealProduct { Id = 644, MealId = 254, ProductId = 23, Quantity = 2 },
                new MealProduct { Id = 645, MealId = 254, ProductId = 36, Quantity = 2 },
                new MealProduct { Id = 646, MealId = 254, ProductId = 21, Quantity = 2 },

                new MealProduct { Id = 647, MealId = 255, ProductId = 23, Quantity = 3 },
                new MealProduct { Id = 648, MealId = 255, ProductId = 19, Quantity = 4 },
                new MealProduct { Id = 649, MealId = 255, ProductId = 23, Quantity = 1 },

                new MealProduct { Id = 650, MealId = 256, ProductId = 13, Quantity = 2 },
                new MealProduct { Id = 651, MealId = 256, ProductId = 6, Quantity = 3 },
                new MealProduct { Id = 652, MealId = 256, ProductId = 2, Quantity = 2 },

                new MealProduct { Id = 653, MealId = 257, ProductId = 3, Quantity = 2 },
                new MealProduct { Id = 654, MealId = 257, ProductId = 24, Quantity = 2 },
                new MealProduct { Id = 655, MealId = 257, ProductId = 20, Quantity = 1 },

                new MealProduct { Id = 656, MealId = 258, ProductId = 14, Quantity = 1 },
                new MealProduct { Id = 657, MealId = 258, ProductId = 22, Quantity = 3 },
                new MealProduct { Id = 658, MealId = 258, ProductId = 33, Quantity = 3 },

                new MealProduct { Id = 659, MealId = 259, ProductId = 21, Quantity = 4 },
                new MealProduct { Id = 660, MealId = 259, ProductId = 33, Quantity = 1 },
                new MealProduct { Id = 661, MealId = 259, ProductId = 12, Quantity = 2 },

                new MealProduct { Id = 662, MealId = 260, ProductId = 12, Quantity = 2 },
                new MealProduct { Id = 663, MealId = 260, ProductId = 17, Quantity = 4 },
                new MealProduct { Id = 664, MealId = 260, ProductId = 31, Quantity = 4 },

                new MealProduct { Id = 665, MealId = 21, ProductId = 5, Quantity = 1 },
                new MealProduct { Id = 666, MealId = 21, ProductId = 10, Quantity = 2 },
                new MealProduct { Id = 667, MealId = 21, ProductId = 21, Quantity = 1 },

                new MealProduct { Id = 668, MealId = 22, ProductId = 36, Quantity = 1 },
                new MealProduct { Id = 669, MealId = 22, ProductId = 36, Quantity = 3 },
                new MealProduct { Id = 670, MealId = 22, ProductId = 6, Quantity = 1 },

                new MealProduct { Id = 671, MealId = 23, ProductId = 29, Quantity = 1 },
                new MealProduct { Id = 672, MealId = 23, ProductId = 37, Quantity = 1 },
                new MealProduct { Id = 673, MealId = 23, ProductId = 8, Quantity = 2 },

                new MealProduct { Id = 674, MealId = 24, ProductId = 30, Quantity = 3 },
                new MealProduct { Id = 675, MealId = 24, ProductId = 25, Quantity = 2 },
                new MealProduct { Id = 676, MealId = 24, ProductId = 30, Quantity = 1 },

                new MealProduct { Id = 677, MealId = 25, ProductId = 28, Quantity = 2 },
                new MealProduct { Id = 678, MealId = 25, ProductId = 8, Quantity = 1 },
                new MealProduct { Id = 679, MealId = 25, ProductId = 28, Quantity = 1 }
                );
        }
        private void Roles()
        {
            string[] roles = new string[] { "User", "Administrator" };
            IdentityRole[] identityRoles = roles.Select(role => new IdentityRole(role)).ToArray();
            modelBuilder.Entity<IdentityRole>().HasData(identityRoles);
        }
        private void BodyTargets()
        {
            modelBuilder.Entity<BodyTarget>().HasData(
                new BodyTarget { Id = 1, Target = "Cardio" },
                new BodyTarget { Id = 2, Target = "Legs" },
                new BodyTarget { Id = 3, Target = "Arms" },
                new BodyTarget { Id = 4, Target = "Chest" },
                new BodyTarget { Id = 5, Target = "Back" },
                new BodyTarget { Id = 6, Target = "Stomach" }
                );
        }

        private void Difficulties()
        {
            modelBuilder.Entity<Difficulty>().HasData(
                new Difficulty { Id = 1, Name = "Beginner", Description = "You have next to no experience in sports/workouts. That's okay, you've begun your journey, every athlete has at some point." },
                new Difficulty { Id = 2, Name = "Intermediate", Description = "You've exercised before, you know the basics, nothing fancy but we'll change that." },
                new Difficulty { Id = 3, Name = "Advanced", Description = "You feel confident while working out, you are aware of your body, you know what are you doing and what you want to achieve and you want to keep moving forward." },
                new Difficulty { Id = 4, Name = "Professional", Description = "You know why you're here, no need for introductions, let's get to work." }
                );
        }

        private void ExerciseCategories()
        {
            modelBuilder.Entity<ExerciseCategory>().HasData(
                new ExerciseCategory { Id = 1, Name = "Warmup", Description = "Exercises meant to prepare your body for the training. Mainly cardio exercises to force faster heart rate and heavier breathing." },
                new ExerciseCategory { Id = 2, Name = "Main", Description = "The main course. Exercises which will help rebuild your body the way you want and put in effort." },
                new ExerciseCategory { Id = 3, Name = "Stretch", Description = "Stretching is an important element of every training. Stretching before working out can provide better results, due to muscles being ready and unlocked. Also reduces risks of muscle, tendons and joint injuries." }
                );
        }

        private void TrainingCategories()
        {
            modelBuilder.Entity<TrainingCategory>().HasData(
                new TrainingCategory { Id = 1, Name = "Continuous", Description = "Maintain the heart rate at a desired level. Examples are: running, swimming, cycling etc."},
                new TrainingCategory { Id = 2, Name = "Fartlek", Description = "Training which uses periods of high intensity, low intensity and rest. Example: full sprint for 10 seconds, walk for 1 minute, jog for 2 minutes, repeat."},
                new TrainingCategory { Id = 3, Name = "Circuit", Description = "Training which involves completing short sets of different exercises one after the other. Example: burpess, press ups, sit ups, squats, rest, repeat."},
                new TrainingCategory { Id = 4, Name = "Interval", Description = "Training with periods of rest mixed with high intensity exercises. Example: 50m sprint, 30 seconds rest, repeat 10 times."},
                new TrainingCategory { Id = 5, Name = "Plyometric", Description = "Training which involves short bursts of very high intensity. Example: box jumps."},
                new TrainingCategory { Id = 6, Name = "Flexibility", Description = "Training focused on improving range of motion. Example: calf raise."},
                new TrainingCategory { Id = 7, Name = "Weight", Description = "Training focused on muscle movement with additional resistance in the form of a heavy weight. If exercises are not done correctly, there is a serious risk of injury."}
                );
        }

        private void TrainingConditionSeverities()
        {
            modelBuilder.Entity<TrainingConditionSeverity>().HasData(
                new TrainingConditionSeverity { Id = 1, Name = "Unnoticable", Description = "A condition you almost forgot about. Nothing to worry, yet better be safe than sorry. Exercises affecting the body part will be highlighted so you know what to observe more carefully." },
                new TrainingConditionSeverity { Id = 2, Name = "Mild", Description = "Nothing serious, yet you are aware something is not 100% good. Exercises highlighted in yellow should be done with caution, listen to your body and in case anything is wrong, lower the intensity or even leave it alone. Focus on your health, without it there won't be any gains." },
                new TrainingConditionSeverity { Id = 3, Name = "Severe", Description = "A serious condition that affects the ability to use said body part. Exercises affecting the chosen body part will not be listed for you. Health should always be a top priority. If you are looking for rehab exercises, we reccomend consulting a specialist." }
                );
        }

        private void TrainingConditions()
        {
            modelBuilder.Entity<TrainingCondition>().HasData(
                new TrainingCondition { Id = 1, BodyTargetId = 1, TrainingConditionSeverityId = 1},
                new TrainingCondition { Id = 2, BodyTargetId = 1, TrainingConditionSeverityId = 2},
                new TrainingCondition { Id = 3, BodyTargetId = 1, TrainingConditionSeverityId = 3},
                new TrainingCondition { Id = 4, BodyTargetId = 2, TrainingConditionSeverityId = 1},
                new TrainingCondition { Id = 5, BodyTargetId = 2, TrainingConditionSeverityId = 2},
                new TrainingCondition { Id = 6, BodyTargetId = 2, TrainingConditionSeverityId = 3},
                new TrainingCondition { Id = 7, BodyTargetId = 3, TrainingConditionSeverityId = 1},
                new TrainingCondition { Id = 8, BodyTargetId = 3, TrainingConditionSeverityId = 2},
                new TrainingCondition { Id = 9, BodyTargetId = 3, TrainingConditionSeverityId = 3},
                new TrainingCondition { Id = 10, BodyTargetId = 4, TrainingConditionSeverityId = 1},
                new TrainingCondition { Id = 11, BodyTargetId = 4, TrainingConditionSeverityId = 2},
                new TrainingCondition { Id = 12, BodyTargetId = 4, TrainingConditionSeverityId = 3},
                new TrainingCondition { Id = 13, BodyTargetId = 5, TrainingConditionSeverityId = 1},
                new TrainingCondition { Id = 14, BodyTargetId = 5, TrainingConditionSeverityId = 2},
                new TrainingCondition { Id = 15, BodyTargetId = 5, TrainingConditionSeverityId = 3},
                new TrainingCondition { Id = 16, BodyTargetId = 6, TrainingConditionSeverityId = 1},
                new TrainingCondition { Id = 17, BodyTargetId = 6, TrainingConditionSeverityId = 2},
                new TrainingCondition { Id = 18, BodyTargetId = 6, TrainingConditionSeverityId = 3}
                );
        }

        private void Exercises()
        {
            modelBuilder.Entity<Exercise>().HasData(
                new Exercise {  Id = 1, DifficultyId = 1, ExerciseCategoryId = 1, Name = "Light jog"},
                new Exercise {  Id = 2, DifficultyId = 1, ExerciseCategoryId = 2, Name = "Bicep curls"},
                new Exercise {  Id = 3, DifficultyId = 1, ExerciseCategoryId = 3, Name = "Arm stretch"},
                new Exercise {  Id = 4, DifficultyId = 1, ExerciseCategoryId = 1, Name = "Jumping rope"},
                new Exercise {  Id = 5, DifficultyId = 2, ExerciseCategoryId = 2, Name = "Squats"},
                new Exercise {  Id = 6, DifficultyId = 1, ExerciseCategoryId = 3, Name = "Bends"}
                );
        }

        private void ExerciseBodyTargets()
        {
            modelBuilder.Entity<ExerciseBodyTarget>().HasData(
                new ExerciseBodyTarget {  Id = 1, ExerciseId = 1, BodyTargetId = 1},
                new ExerciseBodyTarget {  Id = 2, ExerciseId = 2, BodyTargetId = 3},
                new ExerciseBodyTarget {  Id = 3, ExerciseId = 3, BodyTargetId = 3},
                new ExerciseBodyTarget {  Id = 4, ExerciseId = 3, BodyTargetId = 5},
                new ExerciseBodyTarget {  Id = 5, ExerciseId = 4, BodyTargetId = 1},
                new ExerciseBodyTarget {  Id = 6, ExerciseId = 4, BodyTargetId = 2},
                new ExerciseBodyTarget {  Id = 7, ExerciseId = 4, BodyTargetId = 3},
                new ExerciseBodyTarget {  Id = 8, ExerciseId = 5, BodyTargetId = 2},
                new ExerciseBodyTarget {  Id = 9, ExerciseId = 5, BodyTargetId = 5},
                new ExerciseBodyTarget {  Id = 10, ExerciseId = 5, BodyTargetId = 6},
                new ExerciseBodyTarget {  Id = 11, ExerciseId = 6, BodyTargetId = 2}
                );
        }

        private void Trainings()
        {
            modelBuilder.Entity<Training>().HasData(
                new Training {  Id = 1, DifficultyId = 1, TrainingCategoryId = 7, Name = "Bicepz gainz", Description = "Beginner friendly workout aiming to grow one of the most popular muscles - biceps."},
                new Training {  Id = 2, DifficultyId = 1, TrainingCategoryId = 7, Name = "Quads for days", Description = "Get dem quads going bois"}
                );
        }

        private void TrainingExercises()
        {
            modelBuilder.Entity<TrainingExercise>().HasData(
                new TrainingExercise {  Id = 1, ExerciseId = 4, TrainingId = 1, Series = 10, RepsPerSeries = 1 },
                new TrainingExercise {  Id = 2, ExerciseId = 2, TrainingId = 1, Series = 5, RepsPerSeries = 20 },
                new TrainingExercise {  Id = 3, ExerciseId = 3, TrainingId = 1, Series = 10, RepsPerSeries = 10 },
                new TrainingExercise {  Id = 4, ExerciseId = 1, TrainingId = 2, Series = 10, RepsPerSeries = 30 },
                new TrainingExercise {  Id = 5, ExerciseId = 5, TrainingId = 2, Series = 10, RepsPerSeries = 10 },
                new TrainingExercise {  Id = 6, ExerciseId = 6, TrainingId = 2, Series = 10, RepsPerSeries = 10 }
                );
        }
        private void WeightTargets()
        {
            modelBuilder.Entity<WeightTarget>().HasData(
                new WeightTarget { Id = 1, Name = "Lose weight" },
                new WeightTarget { Id = 2, Name = "Maintain weight" },
                new WeightTarget { Id = 3, Name = "Gain weight" }
                );
        }
        #endregion
    }
}
