using AppAmalt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Dto
{
    public class Response
    {
        public PortraitDto Portrait { get; set; }
        public GraphAgeDto GraphAge { get; set; }
        public GraphLifeMainDto GraphLifeMain { get; set; }
        public GraphPoliticalDto GraphPolitical { get; set; }
        public GraphGenderDto GraphGender { get; set; }
        public GraphCityDto GraphCity { get; set; }
        public GraphRelationDto GraphRelation { get; set; }
        public GraphEducationDto GraphEducation { get; set; }

    }
}
