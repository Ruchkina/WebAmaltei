using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Dto
{
    public class GraphGenderDto
    {
        public int IdParty { get; set; }
        public int WomenFollower { get; set; }
        public int MenFollower { get; set; }

        public GraphGenderDto(int womenFollower, int menFollower, int idParty)
        {
            WomenFollower = womenFollower;
            MenFollower = menFollower;
            IdParty = idParty;
        }


    }
}
