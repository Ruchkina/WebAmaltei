using AppAmalt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Dto
{
    public class Response
    {
        public int Id { get; set; }
        public Portrait Portrait { get; set; }
        public GraphAgeDto GraphsAge { get; set; }
        public LifeMain GraphsLifeMain { get; set; }
        public Political GraphPolitical { get; set; }
        public Gender GraphGender { get; set; }
        public GraphCityDto GraphCity { get; set; }

        public Response(GraphAgeDto graphsAge)
        {
            GraphsAge = graphsAge;
        }
        public Response(Portrait portrait, GraphAgeDto graphsAge, LifeMain graphsLifeMain, Political graphPolitical, Gender graphGender/*, GraphCityDto graphCity*/)
        {
            Portrait = portrait;
            GraphsAge = graphsAge;
            GraphsLifeMain = graphsLifeMain;
            GraphPolitical = graphPolitical;
            GraphGender = graphGender;
            //GraphCity = graphCity;
        }
        public Response(Portrait portrait, Gender graphGender, LifeMain graphsLifeMain)
        {
            Portrait = portrait;
            GraphsLifeMain = graphsLifeMain;
            GraphGender = graphGender;
        }

        public Response(Portrait portrait, Gender graphGender, LifeMain graphsLifeMain, GraphCityDto graphCity)
        {
            Portrait = portrait;
            GraphGender = graphGender;
            GraphsLifeMain = graphsLifeMain;
            GraphCity = graphCity;
        }

        public Response()
        {
        }
    }
}
