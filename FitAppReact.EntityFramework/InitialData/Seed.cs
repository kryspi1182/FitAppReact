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
        }
        private void Products()
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Calories = 583, Fat = 52, Carbohydrates = 6, Sugar = 3, Fibre = 11, Protein = 20, Salt = 0, Name = "Almond"},
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
                new Product { Id =21, Calories = 354, Fat = 4, Carbohydrates = 66, Sugar = 2, Fibre = 9, Protein = 9, Salt = 0, Name = "Corn" },
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
    }
}
