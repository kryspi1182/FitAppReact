//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.EntityFramework.Models
{
    public class MealCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Meal> Meals { get; set; }
    }
}
