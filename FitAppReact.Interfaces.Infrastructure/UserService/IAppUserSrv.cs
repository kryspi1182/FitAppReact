using FitAppReact.Common.Classes;
using FitAppReact.Common.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Interfaces.Infrastructure.UserService
{
    public interface IAppUserSrv
    {
        public AppUserDTO GetUserById(string id);
        public void UpdateUser(string id, UserParams userParams);
        public void AddUserDiet(UserDietObjectParams userDietObjectParams);
    }
}
