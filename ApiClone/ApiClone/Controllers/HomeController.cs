using ApiClone.Core.Interfaces;
using ApiClone.Core.NewService;
using ApiClone.Domain;
using ApiClone.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiClone.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;
        private readonly IService _newService;
        public HomeController(IHomeService homeService, IService newService)
        {
            _newService = newService;
            _homeService = homeService;
        }

        [HttpPost]
        public IActionResult GetOvirPassports([FromHeader] PairValues keyValues)
        {
            return Ok(_homeService.GetOvirPassports(keyValues.PinFL));
        }

        [HttpGet]//Procedureda o'zgarish bo'lgan
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
        public IActionResult CapitalMarkets([FromForm] string Inn)
        {
            return Ok(_homeService.GetCapitalMarket(Inn));
        }

        [HttpGet]             // shunchaki URLdan kelyapti
        public IActionResult GetHigherEducation(string PinFL)
        {
            return Ok(_homeService.GetHigerEducation(PinFL));
        }

        [HttpGet]
        public IActionResult GetMofScholarship(string PINFL, string StartDate, string EndDate)
        {
            return Ok(_newService.GetMofScholarship(PINFL, StartDate, EndDate));
        }
       
        [HttpPost]
        public IActionResult GetMolDisability([FromBody] MoLRequestVm test1)
        {
            return Ok(_newService.GetMolDisability(test1.Params.body.pin));
            //return Ok(_newService.GetMolDisability(Id));
        }
    }
}