using CityTempService.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityTempService.Services
{
    public interface IPredictionService
    {
        IList<Prediction> GetPredictions(int cityId);
    }
}
