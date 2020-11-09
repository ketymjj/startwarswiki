using StarWarsWiki.Domain.Dto;
using StarWarsWiki.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsWiki.Domain.Interfaces
{
    public interface IPlanetRepository
    {
        Task<GetPlanetDto> GetByIdAsync(int id);
    }
}
