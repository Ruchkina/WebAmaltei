using AppAmalt.Dto;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Repository
{
    public class LifeMainRepository : BasisRepository, ILifeMainRepository
    {
        public LifeMainRepository(DatabaseContexts context) : base(context) { }

        public async Task<GraphLifeMainDto> GetLifeMainAsync(int partyId)
        {
            var answer = await _context.LifeMains
                .FirstOrDefaultAsync(w => w.PartyId == partyId);
            if (answer == null)
                throw new Exception();

            return new GraphLifeMainDto()
            {
                Family = answer.Family,
                CareerMoney = answer.CareerMoney,
                FamePower = answer.FamePower,
                Entertainment = answer.Entertainment,
                Science = answer.Science,
                SelfDevelopment = answer.SelfDevelopment
            };

        }
    }
}
