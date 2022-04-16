using AppAmalt.Dto;
using AppAmalt.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppAmalt.Controllers
{
    [Route("party/[controller]")]
    public class EdinayRussiaController : ControllerBase
    {

        //private readonly Response _portrait;
        private readonly ResponseRepository _responseRepository;

        /* private readonly Response portrait = new Response(new PortraitDto(sex: "men", city: "Moscow"), new GraphGenderDto(womenFollower: 30, menFollower: 70, 2, 1), new GraphLifeMainDto(1, 2, 3, 4, 5, 6, 2, 2)*//*, new GraphCityDto(new List<City>() { new City("A", 18), new City("B", 21) })*//*);*/
        public EdinayRussiaController()
        {
            
        }


        public async Task<Response> GetEdinayRussia()
        {
            Response response = await _responseRepository.DoResponseAsync(1);
            return response;
        }
    }
    
}