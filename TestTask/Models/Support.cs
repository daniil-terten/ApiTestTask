using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Models
{
    public partial class Support
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
