using AppAmalt.Dto;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppAmalt.Repository
{
    public class ResponseRepository : IResponseRepository
    {
        private readonly IAgeRepository _ageRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IGenderRepository _genderRepository;
        private readonly ILifeMainRepository _lifeMainRepository;
        private readonly IPoliticalRepository _politicalRepository;
        private readonly IPortraitRepository _portraitRepository;
        private readonly IRelationRepository _relationRepository;
        private readonly IEducationRepository _educationRepository;


        public ResponseRepository(IAgeRepository ageRepository, ICityRepository cityRepository, IGenderRepository genderRepository, ILifeMainRepository lifeMainRepository, IPoliticalRepository politicalRepository, IPortraitRepository portraitRepository, IEducationRepository educationRepository, IRelationRepository relationRepository)
        {
            _ageRepository = ageRepository;
            _cityRepository = cityRepository;
            _genderRepository = genderRepository;
            _lifeMainRepository = lifeMainRepository;
            _politicalRepository = politicalRepository;
            _portraitRepository = portraitRepository;
            _educationRepository = educationRepository;
            _relationRepository = relationRepository;
        }
        public async Task<Response> GetResponseAsync(int idParty)
        {
            return new Response()
            {
                Portrait = await _portraitRepository.GetPortraitAsync(idParty),
                GraphAge = await _ageRepository.GetAgeAsync(idParty),
                GraphGender = await _genderRepository.GetGenderAsync(idParty),
                GraphLifeMain = await _lifeMainRepository.GetLifeMainAsync(idParty),
                GraphPolitical = await _politicalRepository.GetPoliticalAsync(idParty),
                GraphCity = await _cityRepository.GetCityAsync(idParty),
                GraphRelation = await _relationRepository.GetRelationAsync(idParty),
                GraphEducation = await _educationRepository.GetEducationAsync(idParty)

            };

        }
            


        
    }
}





