using AutoMapper;
using FitAppReact.Common.ModelsDTO;
using FitAppReact.EntityFramework;
using FitAppReact.Interfaces.Infrastructure.DietService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.DietService
{
    public class ProductSrv : IProductSrv
    {
        private readonly AppDbContext appDbContext;
        private readonly IMapper mapper;

        public ProductSrv(AppDbContext _appDbContext, IMapper _mapper)
        {
            appDbContext = _appDbContext;
            mapper = _mapper;
        }

        public IEnumerable<ProductDTO> GetProducts()
        {
            return appDbContext.Products.Select(x => mapper.Map<ProductDTO>(x)).ToArray();
        }
    }
}
