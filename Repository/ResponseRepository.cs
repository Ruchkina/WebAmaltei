using AppAmalt.Dto;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppAmalt.Repository
{
    public class ResponseRepository 
    {
        private readonly AgeRepository _ageRepository;
        public async Task<Response> DoResponseAsync(int idParty)
        {
            return new Response()
            {
                GraphsAge = await _ageRepository.GetAgeAsync(idParty)
            };

        }
            


        
    }
}





