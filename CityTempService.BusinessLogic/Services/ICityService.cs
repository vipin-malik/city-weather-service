using CityTempService.BusinessLogic.Models;
using System.Collections.Generic;

namespace CityTempService.Services
{
    public interface ICityService
    {
        IList<City> GetAllCities();
    }
}
