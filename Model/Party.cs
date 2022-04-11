using System;
using System.Collections.Generic;

namespace eModels
{
    public class Party
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Party(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
