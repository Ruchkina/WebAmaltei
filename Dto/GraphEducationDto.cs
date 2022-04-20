using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Dto
{
    public class GraphEducationDto
    {
        //University,Work,School
        [JsonProperty("university")]
        public int University { get; set; }
        [JsonProperty("work")]
        public int Work { get; set; }
        [JsonProperty("school")]
        public int School { get; set; }
    }
}
