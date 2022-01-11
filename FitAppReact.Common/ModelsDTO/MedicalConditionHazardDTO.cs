//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Common.ModelsDTO
{
    public class MedicalConditionHazardDTO
    {
        public int Id { get; set; }
        public int MedicalConditionId { get; set; }
        public int HazardId { get; set; }
    }
}
