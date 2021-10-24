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
        public ICollection<UserMedicalCondition> MedicalConditions { get; set; }
        public ICollection<UserUnwantedProduct> UnwantedProducts { get; set; }

    }
}
