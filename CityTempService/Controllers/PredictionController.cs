﻿using CityTempService.BusinessLogic.Models;
using CityTempService.Managers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace CityTempService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PredictionController : ControllerBase
    {
        private readonly IPredictionManager _predictionManager;
        private readonly ILogger _logger;

        public PredictionController(ILogger<PredictionController> logger, IPredictionManager predictionManager)
        {
            _predictionManager = predictionManager;
            _logger = logger;
        }

        /// <summary>
        /// Get list of all the prediction
        /// </summary>
        /// <returns></returns>        
        [HttpGet]
        public ActionResult<IList<Prediction>> GetPredictions([FromQuery]int cityid)
        {
            _logger.LogInformation("Begin::GetPredictions");
            if (cityid <= 0)
            {
                return BadRequest("Invalid City Code.");
            }
            var list = _predictionManager.GetPredictions(cityid);
            if (list == null || list.Count == 0)
            {
                return NotFound("No Predictions found for the given city " + cityid);
            }
            _logger.LogInformation("End::GetPredictions");
            return Ok(list);
        }
    }
}