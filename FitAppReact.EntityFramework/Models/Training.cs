using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.EntityFramework.Models
{
    public class Training
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TrainingCategoryId { get; set; }
        public TrainingCategory TrainingCategory { get; set; }
        public int DifficultyId { get; set; }
        public Difficulty Difficulty { get; set; }
        public ICollection<TrainingExercise> TrainingExercises { get; set; }
    }
}
