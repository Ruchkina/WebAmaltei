using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Dto
{
    public class Response
    {
        public PortraitDto Portrait { get; set; }
        public GraphsAgeDto GraphsAge { get; set; }
        public GraphLifeMainDto GraphsLifeMain { get; set; }

        public Response(PortraitDto portrait, GraphsAgeDto graphs)
        {
            Portrait = portrait;
            GraphsAge = graphs;
        }
    }
}
