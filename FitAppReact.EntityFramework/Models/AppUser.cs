using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FitAppReact.EntityFramework.Models
{
    public class AppUser : IdentityUser
    {
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public decimal Activity { get; set; }
        public int? DifficultyId { get; set; }
        public Difficulty Difficulty { get; set; }
        public ICollection<UserMedicalCondition> MedicalConditions { get; set; }
        public ICollection<UserUnwantedProduct> UnwantedProducts { get; set; }
        public ICollection<UserSavedDiet> UserSavedDiets { get; set; }
        public ICollection<UserSavedTraining> UserSavedTrainings { get; set; }
        public ICollection<UserTrainingCondition> TrainingConditions { get; set; }
    }
}
