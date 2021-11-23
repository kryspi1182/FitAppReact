using FitAppReact.Common.Enums;
using FitAppReact.Common.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Common.Classes
{
    public class UserTrainingParams
    {
        public TrainingCategoryEnum trainingCategory { get; set; }
        public DifficultyEnum difficulty { get; set; }
        public IEnumerable<TrainingConditionDTO> trainingConditions { get; set; }
        public BodyTargetEnum bodyTarget { get; set; }
    }
}
