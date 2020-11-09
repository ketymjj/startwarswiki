using StarWarsWikiApplication.ViewModels.SearchPeople;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StarWarsWikiApplication.Interfaces
{
    public interface IPeopleService
    {
        public Task<IEnumerable<SearchPeopleViewModel>> Search(string word);
    }
}
