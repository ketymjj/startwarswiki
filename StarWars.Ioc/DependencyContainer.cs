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
            // Injeta a classe por singleton, Singleton é patter que verifica se existe instancia da classe case 
            // exista ele retorna essa instância, caso não exista ele cria a instância e retorna
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
