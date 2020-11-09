using Microsoft.Extensions.DependencyInjection;
using StarWarsWiki.Data.Repositories;
using StarWarsWiki.Domain.Interfaces;
using StarWarsWikiApplication.Interfaces;
using StarWarsWikiApplication.Services;

namespace StarWars.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // injeta a classe por singleton, singleton é patter que verifica se existe instancia da classe case 
            // exista ele retorna essa instancia, caso não exista ele cria a instancia e retorna
            // example 
            // class B
            // if (B == null) new B() return B;
            // return B
            services.AddSingleton<IPeopleRepository, PeopleRepository>();
            services.AddSingleton<IPeopleService, PeopleService>();
            services.AddSingleton<IPlanetRepository, PlanetRepository>();
            services.AddSingleton<IStarshipRepository, StarshipRepository>();
        }
    }
}
