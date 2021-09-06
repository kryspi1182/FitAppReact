using FitAppReact.Common.Classes;
using FitAppReact.Common.Enums;
using FitAppReact.Common.ModelsDTO;
using FitAppReact.Interfaces.Facades;
using FitAppReact.Interfaces.Infrastructure;
using FitAppReact.Interfaces.Infrastructure.DietService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Facades
{
    public class DietFcd: IDietFcd
    {
        private readonly IMacroCounter macroCounter;
        private readonly IMealPicker mealPicker;

        public DietFcd(IMacroCounter _macroCounter, IMealPicker _mealPicker)
        {
            macroCounter = _macroCounter;
            mealPicker = _mealPicker;
        }

        public Macros GetDailyMacros(UserParams userParams)
        {
            return macroCounter.GetDailyMacros(userParams);
        }

        public IEnumerable<MealDTO> GetDietMealsForBreakfast(Macros requirements)
        {
            return mealPicker.GetDietMealsForCategory(requirements, MealCategoryEnum.BreakfastDinner);
        }
        public IEnumerable<MealDTO> GetDietMealsForLunch(Macros requirements)
        {
            return mealPicker.GetDietMealsForCategory(requirements, MealCategoryEnum.Lunch);
        }
        public IEnumerable<MealDTO> GetDietMealsForDinner(Macros requirements)
        {
            return mealPicker.GetDietMealsForCategory(requirements, MealCategoryEnum.BreakfastDinner);
        }
        public IEnumerable<MealDTO> GetDietMealsForSnack(Macros requirements)
        {
            return mealPicker.GetDietMealsForCategory(requirements, MealCategoryEnum.Snack);
        }
    }
}
