//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Common.ModelsDTO
{
    public class UserSavedTrainingDTO
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int TrainingId { get; set; }
    }
}
