using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FitAppReact.Common.ModelsDTO;
using FitAppReact.EntityFramework.Models;

namespace FitAppReact.EntityFramework.AutoMapper
{
    public class InitialMappingProfile : Profile
    {
        public InitialMappingProfile()
        {
            CreateMap<Hazard, HazardDTO>();
            CreateMap<HazardDTO, Hazard>();

            CreateMap<Meal, MealDTO>();
            CreateMap<MealDTO, Meal>();

            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();

            CreateMap<MedicalCondition, MedicalConditionDTO>();
            CreateMap<MedicalConditionDTO, MedicalCondition>();

            CreateMap<MedicalConditionHazard, MedicalConditionHazardDTO>();
            CreateMap<MedicalConditionHazardDTO, MedicalConditionHazard>();

            CreateMap<MealCategory, MealCategoryDTO>();
            CreateMap<MealCategoryDTO, MealCategory>();

            CreateMap<MealProduct, MealProductDTO>();
            CreateMap<MealProductDTO, MealProduct>();

            CreateMap<ProductHazard, ProductHazardDTO>();
            CreateMap<ProductHazardDTO, ProductHazard>();

            CreateMap<AppUser, AppUserDTO>();
            CreateMap<AppUserDTO, AppUser>();
        }
    }
}
