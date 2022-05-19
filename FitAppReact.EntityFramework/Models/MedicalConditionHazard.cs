

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.EntityFramework.Models
{
    public class MedicalConditionHazard
    {
        public int Id { get; set; }
        public int MedicalConditionId { get; set; }
        public int HazardId { get; set; }
        public MedicalCondition MedicalCondition { get; set; }
        public Hazard Hazard { get; set; }
    }
}
