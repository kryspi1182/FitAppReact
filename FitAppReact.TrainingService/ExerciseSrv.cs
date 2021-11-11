using AutoMapper;
using FitAppReact.Common.ModelsDTO;
using FitAppReact.EntityFramework;
using FitAppReact.Interfaces.Infrastructure.TrainingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FitAppReact.TrainingService
{
    public class ExerciseSrv : IExerciseSrv
    {
        private readonly AppDbContext appDbContext;
        private readonly IMapper mapper;

        public ExerciseSrv(AppDbContext _appDbContext, IMapper _mapper)
        {
            appDbContext = _appDbContext;
            mapper = _mapper;
        }

        public IEnumerable<ExerciseDTO> GetExercises()
        {
            var result = appDbContext.Exercises
                .Include(x => x.ExerciseBodyTargets)
                .ToArray();
            return mapper.Map<ExerciseDTO[]>(result);
        }
    }
}
