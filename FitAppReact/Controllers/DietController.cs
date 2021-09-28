using FitAppReact.Common.Classes;
using FitAppReact.Interfaces.Facades;
using FitAppReact.Common.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitAppReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DietController : ControllerBase
    {
        private readonly IDietFcd dietFcd;

        public DietController(IDietFcd _dietFcd)
        {
            dietFcd = _dietFcd;
        }

        [HttpPost]
        [Route("macros/count")]
        public IActionResult GetDailyMacros([FromBody] UserParams userParams)
        {
            try
            {
                return Ok(dietFcd.GetDailyMacros(userParams));
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpPost]
        [Route("meals/breakfast")]
        public IActionResult GetDietMealsForBreakfast([FromBody] Macros macros)
        {
            Macros breakfastMacros = new Macros()
            {
                Calories = (int)Math.Ceiling(macros.Calories * 0.2),
                Carbohydrates = (int)Math.Ceiling(macros.Carbohydrates * 0.2),
                Fat = (int)Math.Ceiling(macros.Fat * 0.2),
                Fibre = (int)Math.Ceiling(macros.Fibre * 0.2),
                Protein = (int)Math.Ceiling(macros.Protein * 0.2),
                Salt = (int)Math.Ceiling(macros.Salt * 0.2),
                Sugar = (int)Math.Ceiling(macros.Sugar * 0.2)
            };
            try
            {
                return Ok(dietFcd.GetDietMealsForBreakfast(breakfastMacros));
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpPost]
        [Route("meals/lunch")]
        public IActionResult GetDietMealsForLunch([FromBody] Macros macros)
        {
            Macros lunchMacros = new Macros()
            {
                Calories = (int)Math.Ceiling(macros.Calories * 0.4),
                Carbohydrates = (int)Math.Ceiling(macros.Carbohydrates * 0.4),
                Fat = (int)Math.Ceiling(macros.Fat * 0.4),
                Fibre = (int)Math.Ceiling(macros.Fibre * 0.4),
                Protein = (int)Math.Ceiling(macros.Protein * 0.4),
                Salt = (int)Math.Ceiling(macros.Salt * 0.4),
                Sugar = (int)Math.Ceiling(macros.Sugar * 0.4)
            };
            try
            {
                return Ok(dietFcd.GetDietMealsForLunch(lunchMacros));
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpPost]
        [Route("meals/dinner")]
        public IActionResult GetDietMealsForDinner([FromBody] Macros macros)
        {
            Macros dinnerMacros = new Macros()
            {
                Calories = (int)Math.Ceiling(macros.Calories * 0.2),
                Carbohydrates = (int)Math.Ceiling(macros.Carbohydrates * 0.2),
                Fat = (int)Math.Ceiling(macros.Fat * 0.2),
                Fibre = (int)Math.Ceiling(macros.Fibre * 0.2),
                Protein = (int)Math.Ceiling(macros.Protein * 0.2),
                Salt = (int)Math.Ceiling(macros.Salt * 0.2),
                Sugar = (int)Math.Ceiling(macros.Sugar * 0.2)
            };
            try
            {
                return Ok(dietFcd.GetDietMealsForDinner(dinnerMacros));
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpPost]
        [Route("meals/snack")]
        public IActionResult GetDietMealsForSnack([FromBody] Macros macros)
        {
            Macros snackMacros = new Macros()
            {
                Calories = (int)Math.Ceiling(macros.Calories * 0.1),
                Carbohydrates = (int)Math.Ceiling(macros.Carbohydrates * 0.1),
                Fat = (int)Math.Ceiling(macros.Fat * 0.1),
                Fibre = (int)Math.Ceiling(macros.Fibre * 0.1),
                Protein = (int)Math.Ceiling(macros.Protein * 0.1),
                Salt = (int)Math.Ceiling(macros.Salt * 0.1),
                Sugar = (int)Math.Ceiling(macros.Sugar * 0.1)
            };
            try
            {
                return Ok(dietFcd.GetDietMealsForSnack(snackMacros));
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }
        
        [HttpGet]
        [Route("products")]
        public IActionResult GetProducts()
        {
            try
            {
                return Ok(dietFcd.GetProducts());
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }
    }
}
