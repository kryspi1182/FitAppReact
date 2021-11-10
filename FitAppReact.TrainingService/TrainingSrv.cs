using AutoMapper;
using FitAppReact.Common.Classes;
using FitAppReact.Common.Enums;
using FitAppReact.Common.ModelsDTO;
using FitAppReact.EntityFramework;
using FitAppReact.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FitAppReact.Interfaces.Infrastructure.TrainingService;

namespace FitAppReact.TrainingService
{
    public class TrainingSrv : ITrainingSrv
    {
        private readonly AppDbContext appDbContext;
        private readonly IMapper mapper;

        public TrainingSrv(AppDbContext _appDbContext, IMapper _mapper)
        {
            appDbContext = _appDbContext;
            mapper = _mapper;
        }

        public IEnumerable<TrainingDTO> GetMatchingTrainings(UserTrainingParams userTrainingParams)
        {
            var trainings = appDbContext.Trainings
                .Where(x => x.DifficultyId == ((int)userTrainingParams.difficulty) 
                    && x.TrainingCategoryId == ((int)userTrainingParams.trainingCategory))
                .Include(x => x.TrainingExercises)
                .ToArray();
            var trainingConditions = mapper.Map<TrainingCondition[]>(userTrainingParams.trainingConditions);
            var result = trainings.Where(x => CheckTraining(x, trainingConditions, userTrainingParams.bodyTarget));
            return mapper.Map<TrainingDTO[]>(result);
        }

        private bool CheckTraining(Training training, IEnumerable<TrainingCondition> trainingConditions, BodyTargetEnum bodyTarget)
        {
            var exercises = appDbContext.TrainingExercises
                .Where(x => training.TrainingExercises.Contains(x))
                .Include(x => x.Exercise)
                .Select(x => x.Exercise)
                .ToArray();

            //if exercise targets a body part which has a severe condition, return false
            //if exercise does not target bodyTarget, return false

            return true;
        }
    }
}
