using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.EntityFramework.Models
{
    public class MealProduct
    {
        public int Id { get; set; }
        public int MealId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public Meal Meal { get; set; }
        public Product Product { get; set; }
    }
}
