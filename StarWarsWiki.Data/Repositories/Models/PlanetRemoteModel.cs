using Newtonsoft.Json;

namespace StarWarsWiki.Data.Repositories.Models
{
    public class PlanetRemoteModel
    {
        public string Name { get; set; }

        [JsonProperty(PropertyName = "rotation_period")]
        public string RotationPeriod { get; set; }

        [JsonProperty(PropertyName = "orbital_period")]
        public string OrbitalPeriod { get; set; }
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Terrain { get; set; }

        [JsonProperty(PropertyName = "surface_water")]
        public string SurfaceWater { get; set; }

        public string[] Residents { get; set; }
    }
}
