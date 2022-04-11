using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Dto
{
    [Keyless]
    public class Response
    {
        public int Id { get; set; }
        public PortraitDto Portrait { get; set; }
        public GraphsAgeDto GraphsAge { get; set; }
        public GraphLifeMainDto GraphsLifeMain { get; set; }
        public GraphPoliticalDto GraphPolitical { get; set; }
        public GraphGenderDto GraphGender { get; set; }
        public GraphCityDto GraphCity { get; set; }

        public Response(PortraitDto portrait, GraphsAgeDto graphsAge, GraphLifeMainDto graphsLifeMain, GraphPoliticalDto graphPolitical, GraphGenderDto graphGender, GraphCityDto graphCity)
        {
            Portrait = portrait;
            GraphsAge = graphsAge;
            GraphsLifeMain = graphsLifeMain;
            GraphPolitical = graphPolitical;
            GraphGender = graphGender;
            GraphCity = graphCity;
        }
        public Response(PortraitDto portrait, GraphGenderDto graphGender, GraphLifeMainDto graphsLifeMain)
        {
            Portrait = portrait;
            GraphsLifeMain = graphsLifeMain;
            GraphGender = graphGender;
        }

        public Response(PortraitDto portrait, GraphGenderDto graphGender, GraphLifeMainDto graphsLifeMain, GraphCityDto graphCity)
        {
            Portrait = portrait;
            GraphGender = graphGender;
            GraphsLifeMain = graphsLifeMain;
            GraphCity = graphCity;
        }
    }
}
