using FitAppReact.Common.Classes;
using FitAppReact.Common.ModelsDTO;
using FitAppReact.Interfaces.Facades;
using FitAppReact.Interfaces.Infrastructure.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Facades
{
    public class UserFcd : IUserFcd
    {
        private readonly IAppUserSrv appUserSrv;
        private readonly IMedicalConditionSrv medicalConditionSrv;
        private readonly IUserSavedDietSrv userSavedDietSrv;
        private readonly IUserSavedTrainingSrv userSavedTrainingSrv;
        private readonly IWeightTargetSrv weightTargetSrv;
        public UserFcd(IAppUserSrv _appUserSrv, 
            IMedicalConditionSrv _medicalConditionSrv, 
            IUserSavedDietSrv _userSavedDietSrv, 
            IUserSavedTrainingSrv _userSavedTrainingSrv,
            IWeightTargetSrv _weightTargetSrv)
        {
            appUserSrv = _appUserSrv;
            medicalConditionSrv = _medicalConditionSrv;
            userSavedDietSrv = _userSavedDietSrv;
            userSavedTrainingSrv = _userSavedTrainingSrv;
            weightTargetSrv = _weightTargetSrv;
        }

        public AppUserDTO GetUserById(string id)
        {
            return appUserSrv.GetUserById(id);
        }
        public void UpdateUser(string id, UserParams userParams)
        {
            appUserSrv.UpdateUser(id, userParams);
        }
        public IEnumerable<MedicalConditionDTO> GetMedicalConditions()
        {
            return medicalConditionSrv.GetMedicalConditions();
        }
        public UserSavedDietDTO AddUserSavedDiet(UserSavedDietParams userDietObjectParams)
        {
            return userSavedDietSrv.AddUserSavedDiet(userDietObjectParams).Result;
        }
        public IEnumerable<UserSavedDietDTO> GetUserSavedDiets(string id)
        {
            return userSavedDietSrv.GetUserSavedDiets(id);
        }
        public UserSavedTrainingDTO AddUserSavedTraining(UserSavedTrainingParams userSavedTrainingParams)
        {
            return userSavedTrainingSrv.AddUserSavedTraining(userSavedTrainingParams).Result;
        }
        public IEnumerable<UserSavedTrainingDTO> GetUserSavedTrainings(string id)
        {
            return userSavedTrainingSrv.GetUserSavedTrainings(id);
        }
        public IEnumerable<WeightTargetDTO> GetWeightTargets()
        {
            return weightTargetSrv.GetWeightTargets();
        }
        public UserSavedTrainingDTO DeleteUserSavedTraining(int id)
        {
            return userSavedTrainingSrv.DeleteUserSavedTraining(id).Result;
        }
        public UserSavedDietDTO DeleteUserSavedDiet(int id)
        {
            return userSavedDietSrv.DeleteUserSavedDiet(id).Result;
        }
    }
}
