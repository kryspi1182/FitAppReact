using AutoMapper;
using FitAppReact.Common.ModelsDTO;
using FitAppReact.EntityFramework;
using FitAppReact.Interfaces.Infrastructure.UserService;
using Microsoft.EntityFrameworkCore;
using System;
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
                .Select(x => mapper.Map<AppUserDTO>(x))
                .FirstOrDefault();

            return result;
        }
    }
}
