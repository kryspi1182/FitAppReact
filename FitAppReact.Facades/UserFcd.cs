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

        public UserFcd(IAppUserSrv _appUserSrv, IMedicalConditionSrv _medicalConditionSrv)
        {
            appUserSrv = _appUserSrv;
            medicalConditionSrv = _medicalConditionSrv;
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
    }
}
