//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using FitAppReact.Common.Classes;
using FitAppReact.Common.Enums;
using FitAppReact.Common.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Interfaces.Infrastructure
{
    public interface IMealSrv
    {
        public IEnumerable<MealDTO> GetDietMealsForCategory(Macros requirements, MealCategoryEnum mealCategory);
        public IEnumerable<MealDTO> GetMatchingMeals(UserDietParams userDietParams);
        public IEnumerable<MealDTO> GetMeals();
    }
}
