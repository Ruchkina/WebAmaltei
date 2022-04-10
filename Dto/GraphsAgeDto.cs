using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Dto
{
    public class GraphsAgeDto
    {
        public GraphsAgeDto(int less20Age, int between20_30Age, int between30_40Age, int between40_60Age, int over60)
        {
            Less20Age = less20Age;
            Between20_30Age = between20_30Age;
            Between30_40Age = between30_40Age;
            Between40_60Age = between40_60Age;
            Over60 = over60;
        }
        public int Less20Age { get; set; }
        public int Between20_30Age { get; set; }
        public int Between30_40Age { get; set; }
        public int Between40_60Age { get; set; }
        public int Over60 { get; set; }


    }
}
