using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Model
{
    public class Relation : Base
    {
        //Married;NotMarried;HaveFriend;CivilMerriage;Engagement;ActiveResearch

        public int Married { get; set; }
        public int NotMarried { get; set; }
        public int HaveFriend { get; set; }
        public int CivilMerriage { get; set; }
        public int Engagement { get; set; }
        public int ActiveResearch { get; set; }

    }
}
