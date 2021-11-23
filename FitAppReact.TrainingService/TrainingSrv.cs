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
            var result = trainings.Where(x => CheckTraining(x, trainingConditions, userTrainingParams.bodyTarget)).ToArray();
            return mapper.Map<TrainingDTO[]>(result);
        }

        public IEnumerable<TrainingDTO> GetMatchingTrainingsUserData(UserTrainingParams userTrainingParams)
        {
            var trainings = appDbContext.Trainings
                .Where(x => x.DifficultyId == ((int)userTrainingParams.difficulty))
                .Include(x => x.TrainingExercises)
                .ToArray();
            var trainingConditions = mapper.Map<TrainingCondition[]>(userTrainingParams.trainingConditions);
            var result = trainings.Where(x => CheckTraining(x, trainingConditions)).ToArray();
            return mapper.Map<TrainingDTO[]>(result);
        }

        public IEnumerable<TrainingDTO> GetTrainings()
        {
            var result = appDbContext.Trainings
                .Include(x => x.TrainingExercises)
                .ToArray();

            return mapper.Map<TrainingDTO[]>(result);
        }

        private bool CheckTraining(Training training, IEnumerable<TrainingCondition> trainingConditions, BodyTargetEnum bodyTarget)
        {
            var exercises = appDbContext.TrainingExercises
                .Where(x => training.TrainingExercises.Contains(x))
                .Include(x => x.Exercise)
                    .ThenInclude(x => x.ExerciseBodyTargets)
                .Select(x => x.Exercise)
                .ToArray();

            var forbiddenTargets = trainingConditions
                .Where(x => x.TrainingConditionSeverityId == ((int)TrainingConditionSeverityEnum.Severe))
                .Select(x => x.BodyTargetId);

            foreach(var exercise in exercises)
            {
                if (exercise.ExerciseBodyTargets.Where(x => forbiddenTargets.Contains(x.BodyTargetId)).Count() > 0
                    || (exercise.ExerciseBodyTargets.Where(x => x.BodyTargetId == ((int)bodyTarget)).Count() == 0
                    && exercise.ExerciseCategoryId == ((int)ExerciseCategoryEnum.Main)))
                {
                    return false;
                }
            }

            return true;
        }

        private bool CheckTraining(Training training, IEnumerable<TrainingCondition> trainingConditions)
        {
            var exercises = appDbContext.TrainingExercises
                .Where(x => training.TrainingExercises.Contains(x))
                .Include(x => x.Exercise)
                    .ThenInclude(x => x.ExerciseBodyTargets)
                .Select(x => x.Exercise)
                .ToArray();

            var forbiddenTargets = trainingConditions
                .Where(x => x.TrainingConditionSeverityId == ((int)TrainingConditionSeverityEnum.Severe))
                .Select(x => x.BodyTargetId);

            foreach (var exercise in exercises)
            {
                if (exercise.ExerciseBodyTargets.Where(x => forbiddenTargets.Contains(x.BodyTargetId)).Count() > 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
