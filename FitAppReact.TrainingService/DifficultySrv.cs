

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
    public class DifficultySrv : IDifficultySrv
    {
        private readonly AppDbContext appDbContext;
        private readonly IMapper mapper;

        public DifficultySrv(AppDbContext _appDbContext, IMapper _mapper)
        {
            appDbContext = _appDbContext;
            mapper = _mapper;
        }

        public IEnumerable<DifficultyDTO> GetDifficutlies()
        {
            var result = appDbContext.Difficulties.ToArray();
            return mapper.Map<DifficultyDTO[]>(result);
        }
    }
}
