//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using FitAppReact.Common.Classes;
using FitAppReact.Common.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Interfaces.Infrastructure.TrainingService
{
    public interface ITrainingSrv
    {
        public IEnumerable<TrainingDTO> GetMatchingTrainings(UserTrainingParams userTrainingParams);
        public IEnumerable<TrainingDTO> GetMatchingTrainingsUserData(UserTrainingParams userTrainingParams);
        public IEnumerable<TrainingDTO> GetTrainings();
    }
}
