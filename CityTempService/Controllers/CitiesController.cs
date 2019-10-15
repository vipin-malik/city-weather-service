using CityTempService.BusinessLogic.Models;
using CityTempService.Managers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace CityTempService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly IPredictionManager _predictionManager;
        private readonly ILogger _logger;

        public CitiesController(ILogger<CitiesController> logger, IPredictionManager predictionManager)
        {
            _predictionManager = predictionManager;
            _logger = logger;
        }

        /// <summary>
        /// Get list of all the cities
        /// </summary>
        /// <returns></returns>        
        [HttpGet]
        public ActionResult<IList<City>> GetAllCities()
        {
            _logger.LogInformation("Begin::GetAllCities");
            var list = _predictionManager.GetAllCities();
            _logger.LogInformation("End::GetAllCities");
            return Ok(list);
        }
    }
}