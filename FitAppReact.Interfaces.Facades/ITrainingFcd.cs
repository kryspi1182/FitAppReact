

using FitAppReact.Common.Classes;
using FitAppReact.Common.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Interfaces.Facades
{
    public interface ITrainingFcd
    {
        public IEnumerable<TrainingDTO> GetMatchingTrainings(UserTrainingParams userTrainingParams);
        public IEnumerable<TrainingDTO> GetMatchingTrainingsUserData(UserTrainingParams userTrainingParams);
        public IEnumerable<ExerciseDTO> GetExercises();
        public IEnumerable<BodyTargetDTO> GetBodyTargets();
        public IEnumerable<TrainingDTO> GetTrainings();
        public IEnumerable<TrainingCategoryDTO> GetTrainingCategories();
        public IEnumerable<DifficultyDTO> GetDifficutlies();
        public IEnumerable<TrainingConditionDTO> GetTrainingConditions();
        public IEnumerable<TrainingConditionSeverityDTO> GetTrainingConditionSeverities();
    }
}
