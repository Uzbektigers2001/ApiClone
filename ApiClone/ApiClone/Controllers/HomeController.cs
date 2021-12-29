using ApiClone.Core.Interfaces;
using ApiClone.Domain;
using ApiClone.Domain.Models;
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
            return Ok(_homeService.GetOvirPassports(keyValues.PinFL));
        }

        [HttpGet]
        public IActionResult GetTaxCommiteeInn(string PinFL)
        {
            return Ok(_homeService.GetInn(PinFL));
        }

        [HttpPost]
        public IActionResult GetPerosnAlimony([FromBody] object Json)
        {
            return Ok(_homeService.GetAlimony(Json));
        }

        [HttpGet]
        public IActionResult CapitalMarkets([FromQuery]string Inn)
        {
            return Ok(_homeService.GetCapitalMarket(Inn));
        }

        [HttpPost]
        public IActionResult GetGaiAutos([FromHeader] KeyValues values)
        {
            return Ok(_homeService.GetGaiAutos(values.PinFL));
        }

    }
}