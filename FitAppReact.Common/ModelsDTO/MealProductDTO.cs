//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Common.ModelsDTO
{
    public class MealProductDTO
    {
        public int Id { get; set; }
        public int MealId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
    }
}
