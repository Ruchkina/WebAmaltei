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

    public class NewPeopleController : ControllerBase
    {
        private readonly Response portrait;
        /*       private readonly Response portrait = new Response(new PortraitDto(sex: "men", city: "Moscow"), new GraphGenderDto(womenFollower: 30, menFollower: 70, 1), new GraphLifeMainDto(1, 2, 3, 4, 5, 6, 1)*//* new /*GraphCityDto(new List<City>() { new City("A", 18), new City("B", 21) })*//*);*/

        public Response GetNewPeople()
        {
            return portrait;
        }
    }
}
