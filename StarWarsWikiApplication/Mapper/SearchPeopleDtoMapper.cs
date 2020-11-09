using StarWarsWiki.Domain.Dto;

using StarWarsWikiApplication.ViewModels.GetPeople;
using StarWarsWikiApplication.ViewModels.SearchPeople;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarWarsWikiApplication.Mapper
{
    public static class SearchPeopleDtoMapper
    {
        // mapper dase entidades para viewmodel poderia ter usado o automapper mas quis variar sem motivo 
        public static SearchPeopleViewModel ToSearchPeopleViewModel(this GetPeopleDto getPeopleDto, GetPlanetDto getPlanetDto, GetPeopleDto[] residents, GetStarShipDto[] starShips)
        {
            return new SearchPeopleViewModel
            {
                BirthYear = getPeopleDto.BirthYear,
                EyeColor = getPeopleDto.EyeColor,
                HairColor = getPeopleDto.HairColor,
                Height = getPeopleDto.Height,   
                Mass = getPeopleDto.Mass,
                Name = getPeopleDto.Name,
                SkinColor = getPeopleDto.SkinColor,
                Planet = new Planet
                {
                    Name = getPlanetDto.Name,
                    Climate = getPlanetDto.Climate,
                    Diameter = getPlanetDto.Diameter,
                    Gravity = getPlanetDto.Gravity,
                    OrbitalPeriod = getPlanetDto.OrbitalPeriod,
                    RotationPeriod = getPlanetDto.RotationPeriod,
                    SurfaceWater = getPlanetDto.SurfaceWater,
                    Terrain = getPlanetDto.Terrain,
                    Residents = residents.Select(x => new Resident
                    {
                        BirthYear = x.BirthYear,
                        EyeColor = x.EyeColor,
                        HairColor = x.HairColor,
                        Height = x.Height,
                        Mass = x.Mass,
                        Name = x.Name,
                        SkinColor = x.SkinColor,
                    })
                },
                StarShips = starShips.Select(starShip => new StarShip 
                {
                    
                    CargoCapacity = starShip.CargoCapacity,
                    Consumables = starShip.Consumables,
                    CostInCredits = starShip.CostInCredits,
                    Crew = starShip.Crew,
                    HyperdriveRating = starShip.HyperdriveRating,
                    Length = starShip.Length,
                    Manufacturer = starShip.Manufacturer,
                    MaxAtmospheringSpeed = starShip.Max_atmosphering_speed,
                    Mglt = starShip.Mglt,
                    Model = starShip.Model,
                    Name = starShip.Name,
                    Passengers = starShip.Passengers
                })
            };
        }

        public static GetPeopleViewModel ToGetPeopleViewModel(this GetPeopleDto getPeopleDto)
        {
            return new GetPeopleViewModel
            {
                BirthYear = getPeopleDto.BirthYear,
                EyeColor = getPeopleDto.EyeColor,
                HairColor = getPeopleDto.HairColor,
                Height = getPeopleDto.Height,
                Mass = getPeopleDto.Mass,
                Name = getPeopleDto.Name,
                SkinColor = getPeopleDto.SkinColor,
                
            };
        }
    }
}
