using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Models
{
    public partial class Product
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("pantone_value")]
        public string PantoneValue { get; set; }
    }
}
