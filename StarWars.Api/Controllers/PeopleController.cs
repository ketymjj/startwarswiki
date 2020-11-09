using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarWarsWikiApplication.Interfaces;
using StarWarsWikiApplication.Services;

namespace StarWars.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private IPeopleService _peopleService;


        // injeta a IPeopleService atravez do Ioc classe DependencyContainer
        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

       
        [HttpGet("{word}")]
        public async Task<IActionResult> Search(string word)
        {
            var getAllViewModel = await _peopleService.Search(word);

            return Ok(getAllViewModel);
        }
    }
}
