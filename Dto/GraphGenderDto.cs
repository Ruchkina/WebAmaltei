using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Dto
{
    public class GraphGenderDto
    {
        [JsonProperty("man")]
        public double Man { get; set; }
        [JsonProperty("woman")]
        public double Woman { get; set; }
    }
}
