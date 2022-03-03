using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Models
{
    public partial class ProductsResponse
    {
        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("per_page")]
        public long PerPage { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }

        [JsonProperty("data")]
        public Product[] Data { get; set; }

        [JsonProperty("support")]
        public Support Support { get; set; }
    }
}
