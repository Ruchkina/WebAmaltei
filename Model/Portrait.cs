
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Model
{
    public class Portrait : Base
    {
        public string Sex { get; set; }
        public string Occupation { get; set; }
        public string LifeMain { get; set; }
        public string Relation { get; set; }
        public string Political { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public string Age { get; set; }



    }
}
