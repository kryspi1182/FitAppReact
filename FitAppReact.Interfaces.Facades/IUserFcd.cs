using FitAppReact.Common.Classes;
using FitAppReact.Common.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Interfaces.Facades
{
    public interface IUserFcd
    {
        public AppUserDTO GetUserById(string id);
        public void UpdateUser(string id, UserParams userParams);
        public IEnumerable<MedicalConditionDTO> GetMedicalConditions();
        public UserSavedDietDTO AddUserSavedDiet(UserSavedDietParams userDietObjectParams);
        public IEnumerable<UserSavedDietDTO> GetUserSavedDiets(string id);
        public UserSavedTrainingDTO AddUserSavedTraining(UserSavedTrainingParams userSavedTrainingParams);
        public IEnumerable<UserSavedTrainingDTO> GetUserSavedTrainings(string id);
        public IEnumerable<WeightTargetDTO> GetWeightTargets();
        public UserSavedTrainingDTO DeleteUserSavedTraining(int id);
        public UserSavedDietDTO DeleteUserSavedDiet(int id);
    }
}
