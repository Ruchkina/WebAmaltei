using AppAmalt.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Repository
{
    public interface ICityRepository
    {
        Task<GraphCityDto> GetCityAsync(int idParty);
    }
}
