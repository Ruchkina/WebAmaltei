
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Model
{
    public class LifeMain : Base
    {
        public LifeMain(int family, int careerMoney, int famePower, int entertainment, int science, int selfDevelopment, int partyId, int id)
        {
            Family = family;
            CareerMoney = careerMoney;
            FamePower = famePower;
            Entertainment = entertainment;
            Science = science;
            SelfDevelopment = selfDevelopment;
            PartyId = partyId;
            Id = id;
        }
        public int Family { get; set; }
        public int CareerMoney { get; set; }
        public int FamePower { get; set; }
        public int Entertainment { get; set; }
        public int Science { get; set; }
        public int SelfDevelopment { get; set; }
    }
}
