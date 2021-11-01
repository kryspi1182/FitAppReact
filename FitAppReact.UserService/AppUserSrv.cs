using AutoMapper;
using FitAppReact.Common.Classes;
using FitAppReact.Common.ModelsDTO;
using FitAppReact.EntityFramework;
using FitAppReact.EntityFramework.Models;
using FitAppReact.Interfaces.Infrastructure.UserService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FitAppReact.UserService
{
    public class AppUserSrv : IAppUserSrv
    {
        private readonly AppDbContext appDbContext;
        private readonly IMapper mapper;

        public AppUserSrv(AppDbContext _appDbContext, IMapper _mapper)
        {
            appDbContext = _appDbContext;
            mapper = _mapper;
        }

        public AppUserDTO GetUserById(string id)
        {
            var result = appDbContext.Users
                .AsNoTracking()
                .Where(x => x.Id == id)
                .Include(x => x.MedicalConditions)
                .Include(x => x.UnwantedProducts)
                .Select(x => mapper.Map<AppUserDTO>(x))
                .FirstOrDefault();

            return result;
        }

        public void UpdateUser(string id, UserParams userParams)
        {
            var user = appDbContext.Users
                .Where(x => x.Id == id)
                .Include(x => x.UnwantedProducts)
                .Include(x => x.MedicalConditions)
                .FirstOrDefault();
            user.Activity = (decimal)userParams.activity;
            user.Age = userParams.age;
            user.Gender = (int)userParams.gender;
            user.Height = (decimal)userParams.height;
            user.Weight = (decimal)userParams.weight;

            if(userParams.medicalConditions != null)
            {
                foreach (var medicalCondition in userParams.medicalConditions)
                {
                    if (!user.MedicalConditions.Any(x => x.MedicalConditionId == medicalCondition.MedicalConditionId))
                    {
                        user.MedicalConditions.Add(new UserMedicalCondition { UserId = user.Id, MedicalConditionId = medicalCondition.MedicalConditionId });
                    }
                }
            }
            if(userParams.unwantedProducts != null)
            {
                foreach (var unwantedProduct in userParams.unwantedProducts)
                {
                    if (!user.UnwantedProducts.Any(x => x.ProductId == unwantedProduct.ProductId))
                    {
                        user.UnwantedProducts.Add(new UserUnwantedProduct { UserId = user.Id, ProductId = unwantedProduct.ProductId });
                    }
                }
            }
            
            appDbContext.Users.Update(user);
            appDbContext.SaveChanges();
        }
        
    }
}
