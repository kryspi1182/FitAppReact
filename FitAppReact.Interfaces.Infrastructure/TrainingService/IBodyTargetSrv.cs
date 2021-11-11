using FitAppReact.Common.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Interfaces.Infrastructure.TrainingService
{
    public interface IBodyTargetSrv
    {
        public IEnumerable<BodyTargetDTO> GetBodyTargets();
    }
}
