
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Model
{
    public class Portrait : Base
    {
/*        public Party Party { get; set; }
        public int PartyId { get; set; }
        public int Id { get; set; }*/
        public string Sex { get; set; }
        public string Occupation { get; set; }
        public string LifeMain { get; set; }
        public string Relation { get; set; }
        public string Political { get; set; }
        public string City { get; set; }
        public string Age { get; set; }


        public Portrait(string sex, string occupation, string lifeMain, string relation, string political, string city, string age)
        {
            Sex = sex;
            City = city;
            LifeMain = lifeMain;
            Occupation = occupation;
            Relation = relation;
            Political = political;
            Age = age;

        }

        public Portrait(string sex, string city)
        {
            Sex = sex;
            City = city;
        }

        public Portrait(int partyId, int id, string sex, string occupation, string lifeMain, string relation, string political, string city, string age)
        {
            PartyId = partyId;
            Id = id;
            Sex = sex;
            Occupation = occupation;
            LifeMain = lifeMain;
            Relation = relation;
            Political = political;
            City = city;
            Age = age;
        }
    }
}
