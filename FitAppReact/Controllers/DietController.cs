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
            try
            {
                return Ok(dietFcd.GetDietMealsForBreakfast(macros));
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
            try
            {
                return Ok(dietFcd.GetDietMealsForLunch(macros));
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
            try
            {
                return Ok(dietFcd.GetDietMealsForDinner(macros));
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
            try
            {
                return Ok(dietFcd.GetDietMealsForBreakfast(macros));
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }
    }
}
