using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Model
{
    public class City
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public ValueCity ValueCity { get; set; }

        public City(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
