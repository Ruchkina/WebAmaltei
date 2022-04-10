using AppAmalt.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AppAmalt.Controllers
{
    [Route("party/[controller]")]
    public class EdinayRussiaController : ControllerBase
    {
        private readonly List<Response> _portraits = new List<Response>()
        {
            //new PortraitDto(sex:1,city:4,ocuupation:"work"),

            new Response(new PortraitDto(sex:"men",city:"Moscow"), new GraphsDto(womenFollower:30,menfollower:70))
        };

        public Response GetEdinayRussia()
        {
            return _portraits[0];
        }

        /*public PortraitDto GetSR()
        {
            return _portraits[1];
        }

        public PortraitDto GetKPRF()
        {
            return _portraits[2];
        }*/
    }
}