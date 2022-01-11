//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using FitAppReact.Common.Classes;
using FitAppReact.Common.ModelsDTO;
using FitAppReact.Interfaces.Facades;
using FitAppReact.Interfaces.Infrastructure.TrainingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Facades
{
    public class TrainingFcd : ITrainingFcd
    {
        private readonly ITrainingSrv trainingSrv;
        private readonly IExerciseSrv exerciseSrv;
        private readonly IBodyTargetSrv bodyTargetSrv;
        private readonly ITrainingCategorySrv trainingCategorySrv;
        private readonly IDifficultySrv difficultySrv;
        private readonly ITrainingConditionSrv trainingConditionSrv;
        public TrainingFcd(ITrainingSrv _trainingSrv, 
            IExerciseSrv _exerciseSrv, 
            IBodyTargetSrv _bodyTargetSrv, 
            ITrainingCategorySrv _trainingCategorySrv,
            IDifficultySrv _difficultySrv,
            ITrainingConditionSrv _trainingConditionSrv)
        {
            trainingSrv = _trainingSrv;
            exerciseSrv = _exerciseSrv;
            bodyTargetSrv = _bodyTargetSrv;
            trainingCategorySrv = _trainingCategorySrv;
            difficultySrv = _difficultySrv;
            trainingConditionSrv = _trainingConditionSrv;
        }

        public IEnumerable<TrainingDTO> GetMatchingTrainings(UserTrainingParams userTrainingParams)
        {
            return trainingSrv.GetMatchingTrainings(userTrainingParams);
        }
        public IEnumerable<TrainingDTO> GetMatchingTrainingsUserData(UserTrainingParams userTrainingParams)
        {
            return trainingSrv.GetMatchingTrainingsUserData(userTrainingParams);
        }
        public IEnumerable<ExerciseDTO> GetExercises()
        {
            return exerciseSrv.GetExercises();
        }

        public IEnumerable<BodyTargetDTO> GetBodyTargets()
        {
            return bodyTargetSrv.GetBodyTargets();
        }
        public IEnumerable<TrainingDTO> GetTrainings()
        {
            return trainingSrv.GetTrainings();
        }
        public IEnumerable<TrainingCategoryDTO> GetTrainingCategories()
        {
            return trainingCategorySrv.GetTrainingCategories();
        }
        public IEnumerable<DifficultyDTO> GetDifficutlies()
        {
            return difficultySrv.GetDifficutlies();
        }
        public IEnumerable<TrainingConditionDTO> GetTrainingConditions()
        {
            return trainingConditionSrv.GetTrainingConditions();
        }
        public IEnumerable<TrainingConditionSeverityDTO> GetTrainingConditionSeverities()
        {
            return trainingConditionSrv.GetTrainingConditionSeverities();
        }
    }
}
