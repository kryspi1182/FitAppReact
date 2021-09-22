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
    }
}
