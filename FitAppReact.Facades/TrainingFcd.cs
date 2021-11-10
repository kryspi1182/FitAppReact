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

        public TrainingFcd(ITrainingSrv _trainingSrv)
        {
            trainingSrv = _trainingSrv;
        }

        public IEnumerable<TrainingDTO> GetMatchingTrainings(UserTrainingParams userTrainingParams)
        {
            return trainingSrv.GetMatchingTrainings(userTrainingParams);
        }
    }
}
