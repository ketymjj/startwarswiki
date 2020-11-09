using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using Newtonsoft.Json;
using StarWarsWiki.Data.Repositories.Models;
using StarWarsWiki.Domain.Dto;
using StarWarsWiki.Domain.Interfaces;

namespace StarWarsWiki.Data.Repositories
{
    public class StarshipRepository : IStarshipRepository
    {
        private const string _url = "starships";
        private readonly IHttpClientFactory _clientFactory;
        IMapper _mapper;

        public StarshipRepository(IHttpClientFactory clientFactory, IMapper mapper)
        {
            _clientFactory = clientFactory;
            _mapper = mapper;
        }

        public async Task<GetStarShipDto> GetByIdAsync(int id)
        {
            var client = _clientFactory.CreateClient("swapi");
            var response = await client.GetAsync($"{_url}/{id}/");
            string responseBody = await response.Content.ReadAsStringAsync();
            var peopleRemoteModel = JsonConvert.DeserializeObject<StarShipRemoteModel>(responseBody);

            return _mapper.Map<GetStarShipDto>(peopleRemoteModel);
        }
    }
}
