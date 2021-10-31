using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.EntityFramework.Models
{
    public class UserDietMeal
    {
        public int Id { get; set; }
        public int UserDietId { get; set; }
        public int MealId { get; set; }
        public UserDiet UserDiet { get; set; }
        public Meal Meal { get; set; }
    }
}
