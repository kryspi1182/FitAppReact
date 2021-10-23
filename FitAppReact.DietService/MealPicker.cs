using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitAppReact.Common.Classes;
using FitAppReact.Common.Enums;
using FitAppReact.EntityFramework;
using FitAppReact.EntityFramework.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using FitAppReact.Common.ModelsDTO;
using FitAppReact.Interfaces.Infrastructure;

namespace FitAppReact.DietService
{
    public class MealPicker: IMealPicker
    {
        private readonly AppDbContext appDbContext;
        private readonly IMapper mapper;
        public MealPicker (AppDbContext _appDbContext, IMapper _mapper)
        {
            appDbContext = _appDbContext;
            mapper = _mapper;
        }
        public IEnumerable<MealDTO> GetDietMealsForCategory(Macros requirements, MealCategoryEnum mealCategory)
        {
            var result = appDbContext.Meals
                .AsNoTracking()
                .Include(x => x.MealProducts)
                .ThenInclude(x => x.Product)
                .Where(meal => meal.MealCategoryId == ((int)mealCategory))
                .ToList();

            var finalResult = result.FindAll(meal => CheckMeal(meal, requirements, mealCategory)).ToArray();

            return mapper.Map<MealDTO[]>(finalResult);
        }
        public IEnumerable<MealDTO> GetMatchingMeals(UserDietParams userDietParams)
        {
            var result = appDbContext.Meals
                .AsNoTracking()
                .Include(x => x.MealProducts)
                .ThenInclude(x => x.Product)
                .ThenInclude(x => x.ProductHazards)
                .Where(meal => meal.MealCategoryId == ((int)userDietParams.mealCategory)
                    && !meal.MealProducts.Any(product => userDietParams.unwantedProductIds.Contains(product.ProductId))
                    && !meal.MealProducts.Any(product => product.Product.ProductHazards.Any(hazard => userDietParams.conditionIds.Contains(hazard.HazardId))))
                .ToList();

            var finalResult = result.FindAll(meal => CheckMeal(meal, userDietParams.macros, userDietParams.mealCategory)).ToArray();

            return mapper.Map<MealDTO[]>(finalResult);
        }

        #region Private

        private bool CheckMeal(Meal meal, Macros requirements, MealCategoryEnum mealCategory)
        {
            Macros mealMacros = new Macros();
            double fraction = 0;
            switch(mealCategory)
            {
                case MealCategoryEnum.BreakfastDinner:
                    fraction = 0.2;
                    break;
                case MealCategoryEnum.Lunch:
                    fraction = 0.4;
                    break;
                case MealCategoryEnum.Snack:
                    fraction = 0.1;
                    break;
            }
            foreach(MealProduct mealProduct in meal.MealProducts)
            {
                mealMacros.Calories += (int)mealProduct.Product.Calories;
                mealMacros.Carbohydrates += (int)mealProduct.Product.Carbohydrates;
                mealMacros.Fat += (int)mealProduct.Product.Fat;
                mealMacros.Fibre += (int)mealProduct.Product.Fibre;
                mealMacros.Protein += (int)mealProduct.Product.Protein;
                mealMacros.Sugar += (int)mealProduct.Product.Sugar;
                mealMacros.Salt += (int)mealProduct.Product.Salt;
            }
            //TODO: change margin of error when more complete data exists in the database
            if((mealMacros.Calories > requirements.Calories * fraction * 1.2 || mealMacros.Calories < requirements.Calories * fraction * 0.8) /*||
                (mealMacros.Carbohydrates > requirements.Carbohydrates * 1.5 || mealMacros.Carbohydrates < requirements.Carbohydrates * 0.5) ||
                (mealMacros.Fat > requirements.Fat * 1.5 || mealMacros.Fat < requirements.Fat * 0.5) ||
                (mealMacros.Fibre > requirements.Fibre * 1.5 || mealMacros.Fibre < requirements.Fibre * 0.5) ||
                (mealMacros.Protein > requirements.Protein * 1.5 || mealMacros.Protein < requirements.Protein * 0.5) ||
                (mealMacros.Sugar > requirements.Sugar * 1.5) ||
                (mealMacros.Salt > requirements.Salt * 1.5)*/)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion
    }
}
