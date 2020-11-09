using StarWarsWiki.Domain.Dto;
using System.Threading.Tasks;

namespace StarWarsWiki.Domain.Interfaces
{
    public interface IPlanetRepository
    {
        Task<GetPlanetDto> GetByIdAsync(int id);
    }
}
