using AppAmalt.Dto;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Repository
{
    public class PortraitRepository : BasisRepository, IPortraitRepository
    {
        public PortraitRepository(DatabaseContexts context) : base(context) { }

        public async Task<PortraitDto> GetPortraitAsync(int partyId)
        {
            var answer = await _context.Portraits
                .Include(u => u.City)
                .FirstOrDefaultAsync(w => w.PartyId == partyId);
            if (answer == null)
                throw new Exception();

            return new PortraitDto()
            {
                Sex = answer.Sex,
                Occupation = answer.Occupation,
                LifeMain = answer.LifeMain,
                Relation = answer.Relation,
                Political = answer.Political,
                City = answer.City.Name,
                Age = answer.Age
            };

        }
    }
}
