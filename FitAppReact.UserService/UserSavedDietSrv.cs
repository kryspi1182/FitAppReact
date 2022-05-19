

using AutoMapper;
using FitAppReact.Common.Classes;
using FitAppReact.Common.ModelsDTO;
using FitAppReact.EntityFramework;
using FitAppReact.EntityFramework.Models;
using FitAppReact.Interfaces.Infrastructure.UserService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.UserService
{
    public class UserSavedDietSrv: IUserSavedDietSrv
    {
        private readonly AppDbContext appDbContext;
        private readonly IMapper mapper;

        public UserSavedDietSrv(AppDbContext _appDbContext, IMapper _mapper)
        {
            appDbContext = _appDbContext;
            mapper = _mapper;
        }

        public async Task<UserSavedDietDTO> AddUserSavedDiet(UserSavedDietParams userDietObjectParams)
        {
            if (appDbContext.UserSavedDiets.Where(x => x.UserId == userDietObjectParams.userId).Count() >= 5)
            {
                return null;
            }
            var meals = appDbContext.Meals
                .AsNoTracking()
                .Where(x => userDietObjectParams.mealIds.Contains(x.Id))
                .ToArray();

            UserSavedDiet userDiet = new UserSavedDiet();
            userDiet.Name = userDietObjectParams.name;
            userDiet.UserId = userDietObjectParams.userId;
            appDbContext.UserSavedDiets.Add(userDiet);
            await appDbContext.SaveChangesAsync();

            List<UserSavedDietMeal> dietMeals = new List<UserSavedDietMeal>();
            foreach(int mealId in userDietObjectParams.mealIds)
            {
                UserSavedDietMeal dietMeal = new UserSavedDietMeal { MealId = mealId, UserSavedDietId = userDiet.Id };
                dietMeals.Add(dietMeal);
            }
            appDbContext.UserSavedDietMeals.AddRange(dietMeals);
            await appDbContext.SaveChangesAsync();

            var result = appDbContext.UserSavedDiets
                .AsNoTracking()
                .Where(x => x.Id == userDiet.Id)
                .Include(x => x.Meals)
                .ThenInclude(x => x.Meal)
                .Select(x => mapper.Map<UserSavedDietDTO>(x))
                .FirstOrDefault();

            return result;
        }

        public async Task<UserSavedDietDTO> DeleteUserSavedDiet(int id)
        {
            var diet = appDbContext.UserSavedDiets
                .AsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefault();

            var result = mapper.Map<UserSavedDietDTO>(diet);
            appDbContext.UserSavedDiets.Remove(diet);
            await appDbContext.SaveChangesAsync();

            return result;
        }
        public IEnumerable<UserSavedDietDTO> GetUserSavedDiets(string id)
        {
            var result = appDbContext.UserSavedDiets
                .AsNoTracking()
                .Where(x => x.UserId == id)
                .Include(x => x.Meals)
                .ThenInclude(x => x.Meal)
                .Select(x => mapper.Map<UserSavedDietDTO>(x))
                .ToArray();

            return result;
        }
    }
}
