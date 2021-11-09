using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.EntityFramework.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ExerciseCategoryId { get; set; }
        public ExerciseCategory ExerciseCategory { get; set; }
        public int DifficultyId { get; set; }
        public Difficulty Difficulty { get; set; }
        public ICollection<ExerciseBodyTarget> ExerciseBodyTargets { get; set; }
    }
}
