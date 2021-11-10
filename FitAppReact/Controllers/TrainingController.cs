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
    public class TrainingController : Controller
    {
        private readonly ITrainingFcd trainingFcd;

        public TrainingController(ITrainingFcd _trainingFcd)
        {
            trainingFcd = _trainingFcd;
        }

        [HttpPost]
        [Route("matchingTrainings")]
        public IActionResult GetMatchingTrainings([FromBody]UserTrainingParams userTrainingParams)
        {
            try
            {
                return Ok(trainingFcd.GetMatchingTrainings(userTrainingParams));
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }
    }
}
