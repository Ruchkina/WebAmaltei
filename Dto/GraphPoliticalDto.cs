

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Dto
{
    public class GraphPoliticalDto
    {
        [JsonProperty("communists")]
        public double Communists { get; set; }
        [JsonProperty("socialists")]
        public double Socialists { get; set; }
        [JsonProperty("moderate")]
        public double Moderate { get; set; }
        [JsonProperty("liberals")]
        public double Liberals { get; set; }
        [JsonProperty("conservatives")]
        public double Conservatives { get; set; }
        [JsonProperty("indifferents")]
        public double Indifferents { get; set; }
    }
}
