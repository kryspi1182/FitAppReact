using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.EntityFramework.Models
{
    public class ProductHazard
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int HazardId { get; set; }
        public Product Product { get; set; }
        public Hazard Hazard { get; set; }
    }
}
