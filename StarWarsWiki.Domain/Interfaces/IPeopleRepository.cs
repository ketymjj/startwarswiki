using StarWarsWiki.Domain.Dto;
using StarWarsWiki.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsWiki.Domain.Interfaces
{
    public interface IPeopleRepository
    {
        Task<GetPeopleDto> GetByIdAsync(int id);
        Task<IEnumerable<GetPeopleDto>> Search(string word);
    }
}
