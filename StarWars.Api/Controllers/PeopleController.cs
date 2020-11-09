using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarWarsWikiApplication.Interfaces;

namespace StarWars.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private IPeopleService _peopleService;


        // Injeta a IPeopleService através do Ioc classe DependencyContainer
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
