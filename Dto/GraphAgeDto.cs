using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Dto
{
    public class GraphAgeDto
    {
        [JsonProperty("less20Age")]
        public double Less20Age { get; set; }
        [JsonProperty("between20_30Age")]
        public double Between20_30Age { get; set; }
        [JsonProperty("between30_40Age")]
        public double Between30_40Age { get; set; }
        [JsonProperty("between40_60Age")]
        public double Between40_60Age { get; set; }
        [JsonProperty("over60")]
        public double Over60 { get; set; }
    }
}
