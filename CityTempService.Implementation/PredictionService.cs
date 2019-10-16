using CityTempService.BusinessLogic.Enums;
using CityTempService.BusinessLogic.Models;
using CityTempService.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CityTempService.Implementation
{
    public class PredictionService : IPredictionService
    {
        public IList<Prediction> GetPredictions(int cityId)
        {
            var list = new List<Prediction>();
            var path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            path = System.IO.Path.Combine(path, "cities.json");
            var jsonObject = JObject.Parse(System.IO.File.ReadAllText(path));
            var predictions = jsonObject["predictions"];
            var jsonResult = JsonConvert.DeserializeObject<IList<Prediction>>(predictions.ToString(),
                new JsonSerializerSettings() { DateFormatString = "dd-MM-yyyy" });
            if (jsonResult != null && jsonResult.Count > 0)
            {
                list = jsonResult.Where(p => p.CityId == cityId).ToList();
            }
            foreach (var item in list)
            {
                if (item.WeatherType == WeatherType.Rainy)
                {
                    item.Suggestion = "Carry umbrella";
                }
                else if (item.Temprature != null && item.Temprature.HighValue > 40)
                {
                    item.Suggestion = "Use sunscreen lotion";
                }
                else
                {
                    item.Suggestion = "Enjoy !!!";
                }
            }
            return list;
        }
    }
}
