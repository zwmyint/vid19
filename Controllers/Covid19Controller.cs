using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace vid19.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]

    public class Covid19Controller : ControllerBase
    {
        private readonly Covid19Services _covid19Service;

        public Covid19Controller(Covid19Services covid19Service)
        {
            _covid19Service = covid19Service;
        }

        [HttpGet]
        public async Task<ActionResult<Stats>> World()
        {
            return await _covid19Service.GetWorldStats();
        }



        //
    }
}