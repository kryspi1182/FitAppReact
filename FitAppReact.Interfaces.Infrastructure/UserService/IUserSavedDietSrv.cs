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
    public interface IUserSavedDietSrv
    {
        public Task<UserSavedDietDTO> AddUserSavedDiet(UserSavedDietParams userDietObjectParams);
        public IEnumerable<UserSavedDietDTO> GetUserSavedDiets(string id);
        public Task<UserSavedDietDTO> DeleteUserSavedDiet(int id);
    }
}
