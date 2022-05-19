

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.EntityFramework.Models
{
    public class UserSavedDietMeal
    {
        public int Id { get; set; }
        public int UserSavedDietId { get; set; }
        public int MealId { get; set; }
        public UserSavedDiet UserSavedDiet { get; set; }
        public Meal Meal { get; set; }
    }
}
