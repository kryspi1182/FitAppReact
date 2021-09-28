using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Common.ModelsDTO
{
    public class MealDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Recipe { get; set; }
        public int MealCategoryId { get; set; }
        public ICollection<MealProductDTO> MealProducts { get; set; }
    }
}
