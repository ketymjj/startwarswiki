using StarWarsWiki.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StarWarsWikiApplication.Interfaces
{
    public interface IPlanetService
    {
        public Task<IEnumerable<Planet>> GetByIdAsync(int id);
    }
}
