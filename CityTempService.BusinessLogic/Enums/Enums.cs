using Newtonsoft.Json;

namespace CityTempService.BusinessLogic.Enums
{
    public enum TempratureUnit
    {
        [JsonProperty(PropertyName = "celsius")]
        Celsius,
        [JsonProperty(PropertyName = "fahrenheit")]
        Fahrenheit,
        [JsonProperty(PropertyName = "kelvin")]
        Kelvin
    }
    public enum RainType
    {
        [JsonProperty(PropertyName = "normal")]
        Normal,
        [JsonProperty(PropertyName = "rainy")]
        Rainy
    }
}
