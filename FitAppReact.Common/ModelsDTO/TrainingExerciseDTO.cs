//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Common.ModelsDTO
{
    public class TrainingExerciseDTO
    {
        public int Id { get; set; }
        public int Series { get; set; }
        public int RepsPerSeries { get; set; }
        public int TrainingId { get; set; }
        public int ExerciseId { get; set; }
    }
}
