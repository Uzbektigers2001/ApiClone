using ApiClone.Core.Interfaces;
using ApiClone.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiClone.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpPost]
        public IActionResult GetOvirPassports([FromHeader] PairValues keyValues)
        {
            return Ok(_homeService.OvirPassports(keyValues.PinFL));
        }

    }
}
