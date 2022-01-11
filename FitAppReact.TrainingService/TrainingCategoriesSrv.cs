//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using AutoMapper;
using FitAppReact.Common.ModelsDTO;
using FitAppReact.EntityFramework;
using FitAppReact.Interfaces.Infrastructure.TrainingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.TrainingService
{
    public class TrainingCategoriesSrv : ITrainingCategorySrv
    {
        private readonly AppDbContext appDbContext;
        private readonly IMapper mapper;

        public TrainingCategoriesSrv(AppDbContext _appDbContext, IMapper _mapper)
        {
            appDbContext = _appDbContext;
            mapper = _mapper;
        }

        public IEnumerable<TrainingCategoryDTO> GetTrainingCategories()
        {
            var result = appDbContext.TrainingCategories.ToArray();
            return mapper.Map<TrainingCategoryDTO[]>(result);
        }
    }
}
