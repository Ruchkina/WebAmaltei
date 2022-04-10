using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Dto
{
    public class Response
    {
        public PortraitDto Portrait { get; set; }
        public GraphsAgeDto Graphs { get; set; }

        public Response(PortraitDto portrait, GraphsAgeDto graphs)
        {
            Portrait = portrait;
            Graphs = graphs;
        }
    }
}
