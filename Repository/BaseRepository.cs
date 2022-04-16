using DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Repository
{
    public class BasisRepository
    {
        protected readonly DatabaseContexts _context;
        public BasisRepository(DatabaseContexts context)
        {
            _context = context;
        }

    }
}
