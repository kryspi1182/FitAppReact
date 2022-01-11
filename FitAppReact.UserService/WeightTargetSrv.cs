//Program powstał na Wydziale Informatyki Politechniki Białostockiej

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
    public class WeightTargetSrv : IWeightTargetSrv
    {
        private readonly AppDbContext appDbContext;
        private readonly IMapper mapper;

        public WeightTargetSrv(AppDbContext _appDbContext, IMapper _mapper)
        {
            appDbContext = _appDbContext;
            mapper = _mapper;
        }

        public IEnumerable<WeightTargetDTO> GetWeightTargets()
        {
            var targets = appDbContext.WeightTargets.ToArray();
            return mapper.Map<WeightTargetDTO[]>(targets);
        }
    }
}
