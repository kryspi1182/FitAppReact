//Program powstał na Wydziale Informatyki Politechniki Białostockiej

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
        private readonly IMacroSrv macroSrv;
        private readonly IMealSrv mealSrv;
        private readonly IProductSrv productSrv;

        public DietFcd(IMacroSrv _macroSrv, IMealSrv _mealSrv, IProductSrv _productSrv)
        {
            macroSrv = _macroSrv;
            mealSrv = _mealSrv;
            productSrv = _productSrv;
        }

        public Macros GetDailyMacros(UserParams userParams)
        {
            return macroSrv.GetDailyMacros(userParams);
        }
        public IEnumerable<MealDTO> GetMatchingMeals(UserDietParams userDietParams)
        {
            if ((userDietParams.conditionIds.Count() == 0) && (userDietParams.unwantedProductIds.Count() == 0))
                return mealSrv.GetDietMealsForCategory(userDietParams.macros, userDietParams.mealCategory);
            else 
                return mealSrv.GetMatchingMeals(userDietParams);
        }

        public IEnumerable<MealDTO> GetDietMealsForBreakfast(Macros requirements)
        {
            return mealSrv.GetDietMealsForCategory(requirements, MealCategoryEnum.Breakfast);
        }
        public IEnumerable<MealDTO> GetDietMealsForLunch(Macros requirements)
        {
            return mealSrv.GetDietMealsForCategory(requirements, MealCategoryEnum.Lunch);
        }
        public IEnumerable<MealDTO> GetDietMealsForDinner(Macros requirements)
        {
            return mealSrv.GetDietMealsForCategory(requirements, MealCategoryEnum.Dinner);
        }
        public IEnumerable<MealDTO> GetDietMealsForSnack(Macros requirements)
        {
            return mealSrv.GetDietMealsForCategory(requirements, MealCategoryEnum.Snack);
        }
        public IEnumerable<ProductDTO> GetProducts()
        {
            return productSrv.GetProducts();
        }
        public IEnumerable<MealDTO> GetMeals()
        {
            return mealSrv.GetMeals();
        }
    }
}
