using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Common.Enums
{
    //C# does not support float values in enum
    //This is not an enum, but will be used as one
    public static class ActivityEnum
    {
        public const double None = 1.2;
        public const double Light = 1.35;
        public const double Moderate = 1.55;
        public const double High = 1.75;
    }
}
