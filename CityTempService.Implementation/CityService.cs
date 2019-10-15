using CityTempService.BusinessLogic.Models;
using CityTempService.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace CityTempService.Implementation
{
    public class CityService : ICityService
    {
        public IList<City> GetAllCities()
        {
            var path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            path = System.IO.Path.Combine(path, "cities.json");
            var jsonObject = JObject.Parse(System.IO.File.ReadAllText(path));
            var cityArray = jsonObject["cities"];
            var result = JsonConvert.DeserializeObject<IList<City>>(cityArray.ToString());
            return result;
        }
    }
}
