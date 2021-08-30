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

namespace FitAppReact.DietService
{
    public class MealPicker
    {
        private readonly AppDbContext appDbContext;
        private readonly IMapper mapper;
        public MealPicker (AppDbContext _appDbContext, IMapper _mapper)
        {
            appDbContext = _appDbContext;
            mapper = _mapper;
        }
        public void GetMeal(Macros requirements, MealCategoryEnum mealCategory)
        {
            Meal result = appDbContext.Meals.Where(meal => CheckMeal(meal, requirements)).FirstOrDefault();
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
            if((mealMacros.Calories > requirements.Calories * 1.1 || mealMacros.Calories < requirements.Calories * 0.9) ||
                (mealMacros.Carbohydrates > requirements.Carbohydrates * 1.1 || mealMacros.Carbohydrates < requirements.Carbohydrates * 0.9) ||
                (mealMacros.Fat > requirements.Fat * 1.1 || mealMacros.Fat < requirements.Fat * 0.9) ||
                (mealMacros.Fibre > requirements.Fibre * 1.1 || mealMacros.Fibre < requirements.Fibre * 0.9) ||
                (mealMacros.Protein > requirements.Protein * 1.1 || mealMacros.Protein < requirements.Protein * 0.9) ||
                (mealMacros.Sugar > requirements.Sugar * 1.1) ||
                (mealMacros.Salt > requirements.Salt * 1.1))
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
