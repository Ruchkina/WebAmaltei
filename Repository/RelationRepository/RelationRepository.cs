using AppAmalt.Dto;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Repository
{
    public class RelationRepository : BasisRepository, IRelationRepository
    {
        public RelationRepository(DatabaseContexts context) : base(context) { }

        public async Task<GraphRelationDto> GetRelationAsync(int partyId)
        {
            var answer = await _context.Relations
                .FirstOrDefaultAsync(w => w.PartyId == partyId);
            if (answer == null)
                throw new Exception();
            return new GraphRelationDto()
            {
                Married = answer.Married,
                NotMarried = answer.NotMarried,
                HaveFriend = answer.HaveFriend,
                CivilMerriage = answer.CivilMerriage,
                Engagement = answer.Engagement,
                ActiveResearch = answer.ActiveResearch
            };
        }
    }
}
