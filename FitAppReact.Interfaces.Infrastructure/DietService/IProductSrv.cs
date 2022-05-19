

using FitAppReact.Common.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Interfaces.Infrastructure.DietService
{
    public interface IProductSrv
    {
        public IEnumerable<ProductDTO> GetProducts();
    }
}
