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
        public TrainingFcd(ITrainingSrv _trainingSrv, IExerciseSrv _exerciseSrv, IBodyTargetSrv _bodyTargetSrv)
        {
            trainingSrv = _trainingSrv;
            exerciseSrv = _exerciseSrv;
            bodyTargetSrv = _bodyTargetSrv;
        }

        public IEnumerable<TrainingDTO> GetMatchingTrainings(UserTrainingParams userTrainingParams)
        {
            return trainingSrv.GetMatchingTrainings(userTrainingParams);
        }

        public IEnumerable<ExerciseDTO> GetExercises()
        {
            return exerciseSrv.GetExercises();
        }

        public IEnumerable<BodyTargetDTO> GetBodyTargets()
        {
            return bodyTargetSrv.GetBodyTargets();
        }
    }
}
