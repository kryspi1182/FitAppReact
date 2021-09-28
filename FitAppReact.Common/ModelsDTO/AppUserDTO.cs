using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FitAppReact.Common.ModelsDTO
{
    public class AppUserDTO : IdentityUser
    {
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public decimal Activity { get; set; }
    }
}
