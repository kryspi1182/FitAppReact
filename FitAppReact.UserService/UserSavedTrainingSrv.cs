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
    public class UserSavedTrainingSrv : IUserSavedTrainingSrv
    {
        private readonly AppDbContext appDbContext;
        private readonly IMapper mapper;

        public UserSavedTrainingSrv(AppDbContext _appDbContext, IMapper _mapper)
        {
            appDbContext = _appDbContext;
            mapper = _mapper;
        }

        public async Task<UserSavedTrainingDTO> AddUserSavedTraining(UserSavedTrainingParams userSavedTrainingParams)
        {
            if (!appDbContext.UserSavedTrainings
                .Any(x => x.UserId == userSavedTrainingParams.UserId 
                && x.TrainingId == userSavedTrainingParams.TrainingId))
            {
                appDbContext.UserSavedTrainings
                    .Add(new UserSavedTraining { UserId = userSavedTrainingParams.UserId, TrainingId = userSavedTrainingParams.TrainingId });
                await appDbContext.SaveChangesAsync();
            }
            var result = appDbContext.UserSavedTrainings
                .Where(x => x.UserId == userSavedTrainingParams.UserId
                && x.TrainingId == userSavedTrainingParams.TrainingId)
                .Select(x => mapper.Map<UserSavedTrainingDTO>(x))
                .FirstOrDefault();

            return result;
        }

        public IEnumerable<UserSavedTrainingDTO> GetUserSavedTrainings(string id)
        {
            var result = appDbContext.UserSavedTrainings
                .AsNoTracking()
                .Where(x => x.UserId == id)
                .Select(x => mapper.Map<UserSavedTrainingDTO>(x))
                .ToArray();

            return result;
        }

        public async Task<UserSavedTrainingDTO> DeleteUserSavedTraining(int id)
        {
            var training = appDbContext.UserSavedTrainings
                .AsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefault();

            var result = mapper.Map<UserSavedTrainingDTO>(training);
            appDbContext.UserSavedTrainings.Remove(training);
            await appDbContext.SaveChangesAsync();

            return result;
        }
    }
}
