//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Common.ModelsDTO
{
    public class TrainingConditionDTO
    {
        public int Id { get; set; }
        public int BodyTargetId { get; set; }
        public int TrainingConditionSeverityId { get; set; }
    }
}
