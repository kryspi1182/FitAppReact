using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FitAppReact.Common.ModelsDTO
{
    public class AppUserDTO : IdentityUser
    {
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public decimal Activity { get; set; }
        public int? DifficultyId { get; set; }
        public int? WeightTargetId { get; set; }
        public ICollection<UserMedicalConditionDTO> MedicalConditions { get; set; }
        public ICollection<UserUnwantedProductDTO> UnwantedProducts { get; set; }
        public ICollection<UserTrainingConditionDTO> TrainingConditions { get; set; }
    }
}
