//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.EntityFramework.Models
{
    public class UserMedicalCondition
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int MedicalConditionId { get; set; }
        public AppUser User { get; set; }
        public MedicalCondition MedicalCondition { get; set; }
    }
}
