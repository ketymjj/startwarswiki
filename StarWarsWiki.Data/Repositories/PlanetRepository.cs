using AutoMapper;
using Newtonsoft.Json;
using StarWarsWiki.Data.Repositories.Models;
using StarWarsWiki.Domain.Dto;
using StarWarsWiki.Domain.Interfaces;
using StarWarsWiki.Domain.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace StarWarsWiki.Data.Repositories
{
    public class PlanetRepository : IPlanetRepository
    {
        private const string _url = "planets";
        private readonly IHttpClientFactory _clientFactory;
        IMapper _mapper;

        public PlanetRepository(IHttpClientFactory clientFactory, IMapper mapper)
        {
            _clientFactory = clientFactory;
            _mapper = mapper;
        }

        public async Task<GetPlanetDto> GetByIdAsync(int id)
        {
            var client = _clientFactory.CreateClient("swapi");
            var response = await client.GetAsync($"{_url}/{id}/");
            string responseBody = await response.Content.ReadAsStringAsync();
            var peopleRemoteModel = JsonConvert.DeserializeObject<PlanetRemoteModel>(responseBody);

            return _mapper.Map<GetPlanetDto>(peopleRemoteModel);
        }
    }
}
