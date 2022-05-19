

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.EntityFramework.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Calories { get; set; }
        public decimal Fat { get; set; }
        public decimal Carbohydrates { get; set; }
        public decimal Sugar { get; set; }
        public decimal Fibre { get; set; }
        public decimal Protein { get; set; }
        public decimal Salt { get; set; }
        public ICollection<ProductHazard> ProductHazards { get; set; }
        public ICollection<MealProduct> MealProducts { get; set; }
        public ICollection<UserUnwantedProduct> UserUnwantedProducts { get; set; }
    }
}
