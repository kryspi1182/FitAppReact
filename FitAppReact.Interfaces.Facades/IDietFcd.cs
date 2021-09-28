using FitAppReact.Common.Classes;
using FitAppReact.Common.Enums;
using FitAppReact.Common.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Interfaces.Facades
{
    public interface IDietFcd
    {
        public Macros GetDailyMacros(UserParams userParams);
        public IEnumerable<MealDTO> GetDietMealsForBreakfast(Macros requirements);
        public IEnumerable<MealDTO> GetDietMealsForLunch(Macros requirements);
        public IEnumerable<MealDTO> GetDietMealsForDinner(Macros requirements);
        public IEnumerable<MealDTO> GetDietMealsForSnack(Macros requirements);
        public IEnumerable<ProductDTO> GetProducts();
    }
}
