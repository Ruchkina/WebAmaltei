using AppAmalt.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Repository
{
    public interface IGenderRepository
    {
        Task<GraphGenderDto> GetGenderAsync(int idParty);
    }
}
