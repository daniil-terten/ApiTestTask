using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Models
{
    public partial class LoginResponse
    {
        [JsonProperty("token")]
        public string token { get; set; }

        [JsonProperty("error")]
        public string error { get; set; }
    }
}
