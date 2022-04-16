
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Model
{
    public class Base
    {
        public int PartyId { get; set; }
        public int Id { get; set; }
        public Party Party { get; set; }
    }
}
