using AutoMapper;
using Newtonsoft.Json;
using StarWarsWiki.Data.Repositories.Models;
using StarWarsWiki.Domain.Dto;
using StarWarsWiki.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace StarWarsWiki.Data.Repositories
{
    public class PeopleRepository : IPeopleRepository
    {
        private const string _url = "people";
        private readonly IHttpClientFactory _clientFactory;
        IMapper _mapper;

        public PeopleRepository(IHttpClientFactory clientFactory, IMapper mapper)
        {
            _clientFactory = clientFactory;
            _mapper = mapper;
        }

        public async Task<GetPeopleDto> GetByIdAsync(int id)
        {

            var client = _clientFactory.CreateClient("swapi");
            var response = await client.GetAsync($"{_url}/{id}/");
            string responseBody = await response.Content.ReadAsStringAsync();
            var peopleRemoteModel = JsonConvert.DeserializeObject<PeopleRemoteModelResult>(responseBody);

            return _mapper.Map<GetPeopleDto>(peopleRemoteModel);
        }


        public async Task<IEnumerable<GetPeopleDto>> Search(string word)
        {
            var client = _clientFactory.CreateClient("swapi");
            var response = await client.GetAsync($"{_url}/?search={word}");
            string responseBody = await response.Content.ReadAsStringAsync();

            // Seguindo o modelo de Onion architecture separamos o modelo de repositorio dos demais.
            var peopleRemoteModel = JsonConvert.DeserializeObject<PeopleRemoteModel>(responseBody);

            // Foi usado o automapper para fazer o map das entidades dentro ioc
            return peopleRemoteModel.Results.Select(x => _mapper.Map<GetPeopleDto>(x));
        }
    }
}
