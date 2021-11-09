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
        public int? TrainingId { get; set; } //for some reason EF throws a cascade error when this is not nullable, this specific FK, none other which are done the same way :)
        public Training Training { get; set; }
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
    }
}
