//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Common.Classes
{
    public class UserSavedDietParams
    {
        public string userId { get; set; }
        public string name { get; set; }
        public ICollection<int> mealIds { get; set; }
    }
}
