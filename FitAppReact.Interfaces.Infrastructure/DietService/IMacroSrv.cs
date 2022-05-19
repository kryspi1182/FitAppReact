

using FitAppReact.Common.Classes;
using FitAppReact.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Interfaces.Infrastructure.DietService
{
    public interface IMacroSrv
    {
        public Macros GetDailyMacros(UserParams userParams);
    }
}
