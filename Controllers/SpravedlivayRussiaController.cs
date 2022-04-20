using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AppAmalt.Dto;
using AppAmalt.Repository;

namespace AppAmalt.Controllers
{
    [Route("party/[controller]")]

    public class SpravedlivayRussiaController : ControllerBase
    {
        private readonly IResponseRepository _responseRepository;

        public SpravedlivayRussiaController(IResponseRepository iResponseRepository)
        {
            _responseRepository = iResponseRepository;
        }

        public async Task<IActionResult> GetSpravedlivayRussia()
        {
            IActionResult answer;
            try
            {
                Response response = await _responseRepository.GetResponseAsync(5);
                answer = Ok(response);
            }
            catch (Exception ex)
            {
                answer = StatusCode(StatusCodes.Status500InternalServerError);
            }
            return answer;
        }
    }
}
