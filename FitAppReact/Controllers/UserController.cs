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
    }
}
