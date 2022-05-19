

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.EntityFramework.Models
{
    public class TrainingExercise
    {
        public int Id { get; set; }
        public int Series { get; set; }
        public int RepsPerSeries { get; set; }
        public int? TrainingId { get; set; }
        public Training Training { get; set; }
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
    }
}
