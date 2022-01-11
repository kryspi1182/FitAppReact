//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Common.ModelsDTO
{
    public class TrainingDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TrainingCategoryId { get; set; }
        public int DifficultyId { get; set; }
        public ICollection<TrainingExerciseDTO> TrainingExercises { get; set; }
    }
}
