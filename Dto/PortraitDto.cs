using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Dto
{
    public class PortraitDto
    {
        public string Sex { get; set; }
        public string Occupation { get; set; }
        public string LifeMain { get; set; }
        public string Relation { get; set; }
        public string Political { get; set; }
        public string City { get; set; }
        public string Age { get; set; }


        public PortraitDto(string sex, string occupation, string lifeMain, string relation, string political, string city, string age)
        {
            Sex = sex;
            City = city;
            LifeMain = lifeMain;
            Occupation = occupation;
            Relation = relation;
            Political = political;
            Age = age;

        }

        public PortraitDto(string sex, string city)
        {
            Sex = sex;
            City = city;
        }
    }
}
