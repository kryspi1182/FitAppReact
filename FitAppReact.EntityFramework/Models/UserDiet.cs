using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.EntityFramework.Models
{
    public class UserDiet
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public AppUser User { get; set; }
        public ICollection<UserDietMeal> Meals { get; set; }
    }
}
