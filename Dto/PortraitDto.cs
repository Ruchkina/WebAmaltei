using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Dto
{
    public class PortraitDto
    {
        [JsonProperty("sex")]
        public string Sex { get; set; }
        [JsonProperty("occupation")]
        public string Occupation { get; set; }
        [JsonProperty("lifeMain")]
        public string LifeMain { get; set; }
        [JsonProperty("relation")]
        public string Relation { get; set; }
        [JsonProperty("political")]
        public string Political { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("age")]
        public string Age { get; set; }
    }
}
