using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Dto
{
    public class GraphRelationDto
    {
        //Married;NotMarried;HaveFriend;CivilMerriage;Engagement;ActiveResearch
        [JsonProperty("married")]
        public int Married { get; set; }
        [JsonProperty("notMarried")]
        public int NotMarried { get; set; }
        [JsonProperty("haveFriend")]
        public int HaveFriend { get; set; }
        
        [JsonProperty("civilMerriage")]
        public int CivilMerriage { get; set; }
        [JsonProperty("engagement")]
        public int Engagement { get; set; }
        [JsonProperty("activeResearch")]
        public int ActiveResearch { get; set; }
    }
}
