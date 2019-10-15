﻿using CityTempService.BusinessLogic.Enums;
using Newtonsoft.Json;
using System;

namespace CityTempService.BusinessLogic.Models
{
    public class Prediction
    {
        [JsonProperty(PropertyName = "city_id")]
        public int CityId { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "temprature")]
        public Temprature Temprature { get; set; }

        [JsonProperty(PropertyName = "rain_type")]
        public RainType RainType { get; set; }

        [JsonProperty(PropertyName = "suggestion")]
        public string Suggestion { get; set; }

    }
}
