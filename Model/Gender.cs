
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Model
{
    public class Gender : Base
    {
        /*public int PartyId { get; set; }
        public int Id { get; set; }*/
        public double WomenFollower { get; set; }
        public double MenFollower { get; set; }
 /*       public Party Party { get; set; }*/

        public Gender(double womenFollower, double menFollower/*, int partyId, int id*/)
        {
            WomenFollower = womenFollower;
            MenFollower = menFollower;
/*            PartyId = partyId;
            Id = id;*/
        }


    }
}
