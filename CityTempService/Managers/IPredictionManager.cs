using CityTempService.BusinessLogic.Models;
using System.Collections.Generic;

namespace CityTempService.Managers
{
    public interface IPredictionManager
    {
        IList<City> GetAllCities();
        IList<Prediction> GetPredictions(int cityId);
    }
}
