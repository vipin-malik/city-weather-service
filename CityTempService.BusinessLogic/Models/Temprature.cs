using Newtonsoft.Json;

namespace CityTempService.BusinessLogic.Models
{
    public class Temprature
    {
        [JsonProperty(PropertyName = "value")]
        public double Value { get; set; }

        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }
    }
}
