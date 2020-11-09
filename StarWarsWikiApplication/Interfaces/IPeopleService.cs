using StarWarsWiki.Domain.Models;
using StarWarsWikiApplication.ViewModels;
using StarWarsWikiApplication.ViewModels.GetPeople;
using StarWarsWikiApplication.ViewModels.SearchPeople;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsWikiApplication.Interfaces
{
    public interface IPeopleService
    {
        public Task<IEnumerable<SearchPeopleViewModel>> Search(string word);
    }
}
