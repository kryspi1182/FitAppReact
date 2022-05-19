

using FitAppReact.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Common.Classes
{
    public class UserDietParams
    {
        public Macros macros { get; set; }
        public IEnumerable<int> unwantedProductIds { get; set; }
        public IEnumerable<int> conditionIds { get; set; }
        public MealCategoryEnum mealCategory { get; set; }
        public WeightTargetEnum weightTarget { get; set; }
    }
}
