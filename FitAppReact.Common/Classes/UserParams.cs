using FitAppReact.Common.Enums;
using FitAppReact.Common.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Common.Classes
{
    public class UserParams
    {
        public float weight { get; set; }
        public float height { get; set; }
        public double activity { get; set; }
        public int age { get; set; }
        public GenderEnum gender { get; set; }
        public ICollection<UserMedicalConditionDTO> medicalConditions { get; set; }
        public ICollection<UserUnwantedProductDTO> unwantedProducts { get; set; }
    }
}
