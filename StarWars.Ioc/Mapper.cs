using Microsoft.Extensions.DependencyInjection;
using StarWarsWiki.Data.Repositories.Models;
using StarWarsWiki.Domain.Dto;
using StarWarsWiki.Domain.Models;
using StarWarsWikiApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarWars.Ioc
{
    public class Mapper
    {
        public static void RegisterMappers(IServiceCollection services)
        {
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PeopleRemoteModelResult, People>();
                cfg.CreateMap<PeopleRemoteModelResult, GetPeopleDto>();
                cfg.CreateMap<PlanetRemoteModel, GetPlanetDto>();
                cfg.CreateMap<StarShipRemoteModel, GetStarShipDto>();
            });

            var mapper = config.CreateMapper();

            services.AddSingleton(mapper);
        }
    }
}
