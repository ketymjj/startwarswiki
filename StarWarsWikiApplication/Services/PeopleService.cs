using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarWarsWiki.Domain.Interfaces;
using StarWarsWikiApplication.Interfaces;
using StarWarsWikiApplication.Mapper;
using StarWarsWikiApplication.ViewModels.SearchPeople;

namespace StarWarsWikiApplication.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository _peopleRepository;
        private readonly IPlanetRepository _planetRepository;
        private readonly IStarshipRepository _starshipRepository;

        public PeopleService(IPeopleRepository peopleRepository, IPlanetRepository planetRepository, IStarshipRepository starshipRepository)
        {
            _peopleRepository = peopleRepository;
            _planetRepository = planetRepository;
            _starshipRepository = starshipRepository;
            
        }

        public async Task<IEnumerable<SearchPeopleViewModel>> Search(string word)
        {
            var searchPeopleDto = await _peopleRepository.Search(word);

            var peoples = searchPeopleDto.Select(async people =>
             {
                 //split para pegar o id
                 var idPlanet = people.Homeworld.Split("/")[5];

                 // Busca os planetas dos personagens.
                 var planet = await _planetRepository.GetByIdAsync(int.Parse(idPlanet));

                 // Para todo planeta que retorna buscar os residentes.
                 var residentsTasks = planet.Residents.Select(async resident =>
                  {
                      // split pegar id people
                      var idPeople = resident.Split("/")[5];

                      var people = await _peopleRepository.GetByIdAsync(int.Parse(idPeople));

                      return people;
                  });

                 // Para cada personaegem buscar a nave.
                 var starShipsTasks = people.Starships.Select(async x =>
                 {
                     var idPeople = x.Split("/")[5];

                     var people = await _starshipRepository.GetByIdAsync(int.Parse(idPeople));

                     return people;
                 });

                 var residents = await Task.WhenAll(residentsTasks);
                 var starShips = await Task.WhenAll(starShipsTasks);

                 // Mappper transformar dto em viewmodel, para reparação usando onion deve segregar as classes.
                 return people.ToSearchPeopleViewModel(planet, residents, starShips);

             });

            var listSearchPeopleViewModel = await Task.WhenAll(peoples);

            return listSearchPeopleViewModel;

        }
    }
}
