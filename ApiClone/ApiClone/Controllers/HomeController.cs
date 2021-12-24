using ApiClone.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        public IActionResult GetOvirPassports(string PinFL)
        {
            return Ok(_homeService.OvirPassports(PinFL));
        }

    }
}
