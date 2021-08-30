using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitAppReact.EntityFramework.Models;

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
                new MealCategory { Id = 1, Name = "Breakfast/Dinner" },
                new MealCategory { Id = 2, Name = "Lunch" },
                new MealCategory { Id = 3, Name = "Snack" }
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

                new Meal { Id = 6, MealCategoryId = 1, Name = "Dinner 1", Description = "Description of dinner 1", Recipe = "Recipe of dinner 1" },
                new Meal { Id = 7, MealCategoryId = 1, Name = "Dinner 2", Description = "Description of dinner 2", Recipe = "Recipe of dinner 2" },
                new Meal { Id = 8, MealCategoryId = 1, Name = "Dinner 3", Description = "Description of dinner 3", Recipe = "Recipe of dinner 3" },
                new Meal { Id = 9, MealCategoryId = 1, Name = "Dinner 4", Description = "Description of dinner 4", Recipe = "Recipe of dinner 4" },
                new Meal { Id = 10, MealCategoryId = 1, Name = "Dinner 5", Description = "Description of dinner 5", Recipe = "Recipe of dinner 5" },

                new Meal { Id = 11, MealCategoryId = 2, Name = "Lunch 1", Description = "Description of lunch 1", Recipe = "Recipe of lunch 1" },
                new Meal { Id = 12, MealCategoryId = 2, Name = "Lunch 2", Description = "Description of lunch 2", Recipe = "Recipe of lunch 2" },
                new Meal { Id = 13, MealCategoryId = 2, Name = "Lunch 3", Description = "Description of lunch 3", Recipe = "Recipe of lunch 3" },
                new Meal { Id = 14, MealCategoryId = 2, Name = "Lunch 4", Description = "Description of lunch 4", Recipe = "Recipe of lunch 4" },
                new Meal { Id = 15, MealCategoryId = 2, Name = "Lunch 5", Description = "Description of lunch 5", Recipe = "Recipe of lunch 5" },

                new Meal { Id = 16, MealCategoryId = 3, Name = "Snack 1", Description = "Description of snack 1", Recipe = "Recipe of snack 1" },
                new Meal { Id = 17, MealCategoryId = 3, Name = "Snack 2", Description = "Description of snack 2", Recipe = "Recipe of snack 2" },
                new Meal { Id = 18, MealCategoryId = 3, Name = "Snack 3", Description = "Description of snack 3", Recipe = "Recipe of snack 3" },
                new Meal { Id = 19, MealCategoryId = 3, Name = "Snack 4", Description = "Description of snack 4", Recipe = "Recipe of snack 4" },
                new Meal { Id = 20, MealCategoryId = 3, Name = "Snack 5", Description = "Description of snack 5", Recipe = "Recipe of snack 5" }
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
                new MealProduct { Id = 60, MealId = 20, ProductId = 28, Quantity = 1 }
                );
        }
        #endregion
    }
}
