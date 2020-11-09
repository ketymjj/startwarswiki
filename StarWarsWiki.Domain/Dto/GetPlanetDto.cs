
namespace StarWarsWiki.Domain.Dto
{
    public class GetPlanetDto
    {
        public string Name { get; set; }
        public string RotationPeriod { get; set; }
        public string OrbitalPeriod { get; set; }
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Terrain { get; set; }
        public string SurfaceWater { get; set; }
        public string[] Residents { get; set; }
    }
}
