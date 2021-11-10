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
    }
}
