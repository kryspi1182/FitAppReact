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
    public class TrainingCondtionSrv : ITrainingConditionSrv
    {
        private readonly AppDbContext appDbContext;
        private readonly IMapper mapper;

        public TrainingCondtionSrv(AppDbContext _appDbContext, IMapper _mapper)
        {
            appDbContext = _appDbContext;
            mapper = _mapper;
        }

        public IEnumerable<TrainingConditionDTO> GetTrainingConditions()
        {
            var result = appDbContext.TrainingConditions.ToArray();
            return mapper.Map<TrainingConditionDTO[]>(result);
        }

        public IEnumerable<TrainingConditionSeverityDTO> GetTrainingConditionSeverities()
        {
            var result = appDbContext.TrainingConditionSeverities.ToArray();
            return mapper.Map<TrainingConditionSeverityDTO[]>(result);
        }
    }
}
