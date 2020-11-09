using StarWarsWiki.Domain.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StarWarsWiki.Domain.Interfaces
{
    public interface IPeopleRepository
    {
        Task<GetPeopleDto> GetByIdAsync(int id);
        Task<IEnumerable<GetPeopleDto>> Search(string word);
    }
}
