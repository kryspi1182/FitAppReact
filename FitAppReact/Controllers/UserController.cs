using FitAppReact.Common.Classes;
using FitAppReact.Interfaces.Facades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitAppReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserFcd userFcd;

        public UserController(IUserFcd _userFcd)
        {
            userFcd = _userFcd;
        }

        [HttpGet]
        [Route("getUser/{id}")]
        public IActionResult GetUser(string id)
        {
            try
            {
                var result = userFcd.GetUserById(id);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
            
        }
        [HttpPut]
        [Route("updateUser/{id}")]
        public IActionResult UpdateUser(string id, [FromBody] UserParams userParams)
        {
            try
            {
                userFcd.UpdateUser(id, userParams);
                return Ok(userParams);
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }
        [HttpGet]
        [Route("medicalConditions")]
        public IActionResult GetMedicalConditions()
        {
            try
            {
                return Ok(userFcd.GetMedicalConditions());
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }
        [HttpGet]
        [Route("weightTargets")]
        public IActionResult GetWeightTargets()
        {
            try
            {
                return Ok(userFcd.GetWeightTargets());
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }
        [HttpPost]
        [Route("userSavedDiet/add")]
        public IActionResult AddUserSavedDiet([FromBody] UserSavedDietParams userSavedDietParams)
        {
            try
            {
                var result = userFcd.AddUserSavedDiet(userSavedDietParams);
                return Ok(result);
            }
            catch(Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }
        [HttpGet]
        [Route("userSavedDiet/{id}")]
        public IActionResult GetUserSavedDiets(string id)
        {
            try
            {
                return Ok(userFcd.GetUserSavedDiets(id));
            }
            catch(Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }
        [HttpPost]
        [Route("userSavedTraining/add")]
        public IActionResult AddUserSavedTraining([FromBody] UserSavedTrainingParams userSavedTrainingParams)
        {
            try
            {
                var result = userFcd.AddUserSavedTraining(userSavedTrainingParams);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }
        [HttpGet]
        [Route("userSavedTraining/{id}")]
        public IActionResult GetUserSavedTrainings(string id)
        {
            try
            {
                return Ok(userFcd.GetUserSavedTrainings(id));
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpPost]
        [Route("userSavedTraining/delete/{id}")]
        public IActionResult DeleteUserSavedTraining(string id)
        {
            try
            {
                var result = userFcd.DeleteUserSavedTraining(int.Parse(id));
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpPost]
        [Route("userSavedDiet/delete/{id}")]
        public IActionResult DeleteUserSavedDiet(string id)
        {
            try
            {
                var result = userFcd.DeleteUserSavedDiet(int.Parse(id));
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }
    }
}
