

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

            CreateMap<UserMedicalCondition, UserMedicalConditionDTO>();
            CreateMap<UserMedicalConditionDTO, UserMedicalCondition>();

            CreateMap<UserUnwantedProduct, UserUnwantedProductDTO>();
            CreateMap<UserUnwantedProductDTO, UserUnwantedProduct>();

            CreateMap<UserSavedDietMeal, UserSavedDietMealDTO>();
            CreateMap<UserSavedDietMealDTO, UserSavedDietMeal>();

            CreateMap<UserSavedDiet, UserSavedDietDTO>();
            CreateMap<UserSavedDietDTO, UserSavedDiet>();

            CreateMap<BodyTarget, BodyTargetDTO>();
            CreateMap<BodyTargetDTO, BodyTarget>();

            CreateMap<Difficulty, DifficultyDTO>();
            CreateMap<DifficultyDTO, Difficulty>();

            CreateMap<Exercise, ExerciseDTO>();
            CreateMap<ExerciseDTO, Exercise>();

            CreateMap<ExerciseBodyTarget, ExerciseBodyTargetDTO>();
            CreateMap<ExerciseBodyTargetDTO, ExerciseBodyTarget>();

            CreateMap<ExerciseCategory, ExerciseCategoryDTO>();
            CreateMap<ExerciseCategoryDTO, ExerciseCategory>();

            CreateMap<Training, TrainingDTO>();
            CreateMap<TrainingDTO, Training>();

            CreateMap<TrainingCategory, TrainingCategoryDTO>();
            CreateMap<TrainingCategoryDTO, TrainingCategory>();

            CreateMap<TrainingConditionSeverity, TrainingConditionSeverityDTO>();
            CreateMap<TrainingConditionSeverityDTO, TrainingConditionSeverity>();

            CreateMap<TrainingExercise, TrainingExerciseDTO>();
            CreateMap<TrainingExerciseDTO, TrainingExercise>();

            CreateMap<UserTrainingCondition, UserTrainingConditionDTO>();
            CreateMap<UserTrainingConditionDTO, UserTrainingCondition>();

            CreateMap<TrainingCondition, TrainingConditionDTO>();
            CreateMap<TrainingConditionDTO, TrainingCondition>();

            CreateMap<UserSavedTraining, UserSavedTrainingDTO>();
            CreateMap<UserSavedTrainingDTO, UserSavedTraining>();

            CreateMap<WeightTarget, WeightTargetDTO>();
            CreateMap<WeightTargetDTO, WeightTarget>();
        }
    }
}
