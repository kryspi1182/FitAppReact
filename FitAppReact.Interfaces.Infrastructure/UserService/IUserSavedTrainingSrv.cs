//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using FitAppReact.Common.Classes;
using FitAppReact.Common.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Interfaces.Infrastructure.UserService
{
    public interface IUserSavedTrainingSrv
    {
        public IEnumerable<UserSavedTrainingDTO> GetUserSavedTrainings(string id);
        public Task<UserSavedTrainingDTO> AddUserSavedTraining(UserSavedTrainingParams userSavedTrainingParams);
        public Task<UserSavedTrainingDTO> DeleteUserSavedTraining(int id);
    }
}
