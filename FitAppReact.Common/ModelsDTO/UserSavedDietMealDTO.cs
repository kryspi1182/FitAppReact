//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Common.ModelsDTO
{
    public class UserSavedDietMealDTO
    {
        public int Id { get; set; }
        public int UserSavedDietId { get; set; }
        public int MealId { get; set; }
        public MealDTO Meal { get; set; }
    }
}
