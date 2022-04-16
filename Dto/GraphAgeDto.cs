using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Dto
{
    public class GraphAgeDto
    {
        public int Less20Age { get; set; }
        public int Between20_30Age { get; set; }
        public int Between30_40Age { get; set; }
        public int Between40_60Age { get; set; }
        public int Over60 { get; set; }
    }
}
