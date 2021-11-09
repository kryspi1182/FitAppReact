using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.EntityFramework.Models
{
    public class UserTrainingCondition
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public int BodyTargetId { get; set; }
        public BodyTarget BodyTarget { get; set; }
        public int TrainingConditionSeverityId { get; set; }
        public TrainingConditionSeverity TrainingConditionSeverity { get; set; }
    }
}
