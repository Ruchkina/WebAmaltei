using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AppAmalt.Dto;

namespace AppAmalt.Controllers
{
    [Route("party/[controller]")]

    public class SpravedlivayRussiaController : ControllerBase
    {
        private readonly Response portrait = new Response(new PortraitDto(sex: "men", city: "Moscow"), new GraphGenderDto(womenFollower: 30, menFollower: 70), new GraphLifeMainDto(7, 8, 3, 4, 5, 6) /*new /*GraphCityDto(new List<City>() { new City("C", 18), new City("B", 21) })*/);

        public Response GetSpravedlivayRussia()
        {
            return portrait;
        }
    }
}
