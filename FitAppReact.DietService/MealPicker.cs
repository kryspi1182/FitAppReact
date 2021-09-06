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

            var finalResult = result.FindAll(meal => CheckMeal(meal, requirements)).ToArray();

            return mapper.Map<MealDTO[]>(finalResult);
        }

        #region Private

        private bool CheckMeal(Meal meal, Macros requirements)
        {
            Macros mealMacros = new Macros();
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
            if((mealMacros.Calories > requirements.Calories * 1.2 || mealMacros.Calories < requirements.Calories * 0.8) /*||
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
