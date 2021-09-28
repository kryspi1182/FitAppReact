using System;
using FitAppReact.Common.Enums;
using FitAppReact.Common.Classes;
using FitAppReact.EntityFramework;
using FitAppReact.EntityFramework.Models;
using FitAppReact.Interfaces.Infrastructure.DietService;

namespace FitAppReact.DietService
{
    public class MacroCounter: IMacroCounter
    {
        public Macros GetDailyMacros(UserParams userParams)
        {
            return CountDailyMacros(
                userParams.weight, 
                userParams.height, userParams.activity,
                userParams.age, 
                userParams.gender);
        }

        #region Private

        private Macros CountDailyMacros(
            double _weight,
            double _height,
            double _activity, //enum value from ActivityEnum class (details commented in ActivityEnum)
            int _age,
            GenderEnum gender
            )
        {
            int calories;
            int fat;
            int carbohydrates;
            int sugar;
            int fibre;
            int protein;
            int salt;

            if (gender == GenderEnum.Male)
            {
                calories = (int)Math.Ceiling(((9.99 * _weight) + (6.25 * _height * 100) - (4.92 * _age) + 5) * _activity);
            }
            else
            {
                calories = (int)Math.Ceiling(((9.99 * _weight) + (6.25 * _height * 100) - (4.92 * _age) - 161) * _activity);
            }

            carbohydrates = (int)Math.Ceiling(calories * 0.4 / 4);
            fat = (int)Math.Ceiling(calories * 0.3 / 9);
            protein = (int)Math.Ceiling(calories * 0.3 / 4);
            sugar = (int)Math.Ceiling(carbohydrates * 0.2);
            fibre = 30;
            salt = 1;

            Macros result = new Macros
            {
                Calories = calories,
                Carbohydrates = carbohydrates,
                Fat = fat,
                Protein = protein,
                Sugar = sugar,
                Fibre = fibre,
                Salt = salt
            };

            return result;
        }

        #endregion
    }
}
