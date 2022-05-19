

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

        [HttpPost]
        [Route("matchingTrainings/user")]
        public IActionResult GetMatchingTrainingsUserData([FromBody] UserTrainingParams userTrainingParams)
        {
            try
            {
                return Ok(trainingFcd.GetMatchingTrainingsUserData(userTrainingParams));
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpGet]
        [Route("exercises/get")]
        public IActionResult GetExercises()
        {
            try
            {
                return Ok(trainingFcd.GetExercises());
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpGet]
        [Route("bodyTargets/get")]
        public IActionResult GetBodyTargets()
        {
            try
            {
                return Ok(trainingFcd.GetBodyTargets());
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpGet]
        [Route("trainings/get")]
        public IActionResult GetTrainings()
        {
            try
            {
                return Ok(trainingFcd.GetTrainings());
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpGet]
        [Route("trainingCategories/get")]
        public IActionResult GetTrainingCategories()
        {
            try
            {
                return Ok(trainingFcd.GetTrainingCategories());
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpGet]
        [Route("difficulties/get")]
        public IActionResult GetDifficulties()
        {
            try
            {
                return Ok(trainingFcd.GetDifficutlies());
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpGet]
        [Route("trainingConditions/get")]
        public IActionResult GetTrainingConditions()
        {
            try
            {
                return Ok(trainingFcd.GetTrainingConditions());
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpGet]
        [Route("trainingConditionSeverities/get")]
        public IActionResult GetTrainingConditionSeverities()
        {
            try
            {
                return Ok(trainingFcd.GetTrainingConditionSeverities());
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }
    }
}
