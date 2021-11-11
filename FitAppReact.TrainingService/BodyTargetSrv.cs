using AutoMapper;
using FitAppReact.Common.ModelsDTO;
using FitAppReact.EntityFramework;
using FitAppReact.Interfaces.Infrastructure.TrainingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.TrainingService
{
    public class BodyTargetSrv : IBodyTargetSrv
    {
        private readonly AppDbContext appDbContext;
        private readonly IMapper mapper;

        public BodyTargetSrv(AppDbContext _appDbContext, IMapper _mapper)
        {
            appDbContext = _appDbContext;
            mapper = _mapper;
        }

        public IEnumerable<BodyTargetDTO> GetBodyTargets()
        {
            var result = appDbContext.BodyTargets.ToArray();
            return mapper.Map<BodyTargetDTO[]>(result);
        }
    }
}
