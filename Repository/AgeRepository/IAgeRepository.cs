using AppAmalt.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Repository
{
    public interface IAgeRepository
    {
        Task<GraphAgeDto> GetAgeAsync(int idParty);
    }
}
