using AutoMapper;
using FitAppReact.Common.ModelsDTO;
using FitAppReact.EntityFramework;
using FitAppReact.Interfaces.Infrastructure.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.UserService
{
    public class MedicalConditionSrv: IMedicalConditionSrv
    {
        private readonly AppDbContext appDbContext;
        private readonly IMapper mapper;

        public MedicalConditionSrv(AppDbContext _appDbContext, IMapper _mapper)
        {
            appDbContext = _appDbContext;
            mapper = _mapper;
        }

        public IEnumerable<MedicalConditionDTO> GetMedicalConditions()
        {
            return appDbContext.MedicalConditions.Select(x => mapper.Map<MedicalConditionDTO>(x)).ToArray();
        }
    }
}
