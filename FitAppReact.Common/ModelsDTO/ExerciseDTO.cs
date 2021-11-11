using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Common.ModelsDTO
{
    public class ExerciseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ExerciseCategoryId { get; set; }
        public int DifficultyId { get; set; }
        public ICollection<ExerciseBodyTargetDTO> ExerciseBodyTargets { get; set; }
    }
}
