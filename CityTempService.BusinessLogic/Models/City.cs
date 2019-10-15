using Newtonsoft.Json;

namespace CityTempService.BusinessLogic.Models
{
    public class City
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
