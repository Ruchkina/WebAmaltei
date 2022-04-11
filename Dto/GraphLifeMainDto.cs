using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Dto
{
    public class GraphLifeMainDto
    {
        public GraphLifeMainDto(int family, int careerMoney, int famePower, int entertainment, int science, int selfDevelopment)
        {
            Family = family;
            CareerMoney = careerMoney;
            FamePower = famePower;
            Entertainment = entertainment;
            Science = science;
            SelfDevelopment = selfDevelopment;
        }

        public int Family { get; set; }
        public int CareerMoney { get; set; }
        public int FamePower { get; set; }
        public int Entertainment { get; set; }
        public int Science { get; set; }
        public int SelfDevelopment { get; set; }
    }
}
