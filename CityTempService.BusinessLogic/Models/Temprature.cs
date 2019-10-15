using Newtonsoft.Json;

namespace CityTempService.BusinessLogic.Models
{
    public class Temprature
    {
        [JsonProperty(PropertyName = "high_value")]
        public double HighValue { get; set; }

        [JsonProperty(PropertyName = "low_value")]
        public double LowValue { get; set; }

        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }
    }
}
