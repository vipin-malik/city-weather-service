using CityTempService.BusinessLogic.Models;
using CityTempService.Services;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace CityTempService.Managers
{
    internal class PredictionManager : IPredictionManager
    {
        private readonly ILogger _logger;
        private readonly ICityService _cityService;
        private readonly IPredictionService _predictionService;
        public PredictionManager(ICityService cityService, IPredictionService predictionService)
        {
            _cityService = cityService;
            _predictionService = predictionService;
        }
        public IList<City> GetAllCities()
        {
            return _cityService.GetAllCities();
        }

        public IList<Prediction> GetPredictions(int cityId)
        {
            return _predictionService.GetPredictions(cityId);
        }
    }
}
