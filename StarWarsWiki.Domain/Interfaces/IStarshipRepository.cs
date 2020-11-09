using StarWarsWiki.Domain.Dto;
using System.Threading.Tasks;

namespace StarWarsWiki.Domain.Interfaces
{
    public interface IStarshipRepository
    {
        Task<GetStarShipDto> GetByIdAsync(int id);
    }
}
