using AppAmalt.Dto;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Repository
{
    public class PoliticalRepository : BasisRepository, IPoliticalRepository
    {
        public PoliticalRepository(DatabaseContexts context) : base(context) { }

        public async Task<GraphPoliticalDto> GetPoliticalAsync(int partyId)
        {
            var answer = await _context.Politicals
                .FirstOrDefaultAsync(w => w.PartyId == partyId);
            if (answer == null)
                throw new Exception();

            return new GraphPoliticalDto()
            {
                Communists = answer.Communists,
                Socialists = answer.Socialists,
                Moderate = answer.Moderate,
                Liberals = answer.Liberals,
                Conservatives = answer.Conservatives,
                Indifferents = answer.Indifferents

            };


        }
    }
}
