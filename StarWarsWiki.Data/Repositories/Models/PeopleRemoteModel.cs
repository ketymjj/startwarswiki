using Newtonsoft.Json;
using System.Collections.Generic;

namespace StarWarsWiki.Data.Repositories.Models
{
    public class PeopleRemoteModel
    {
        public List<PeopleRemoteModelResult> Results { get; set; }
    }

    public class PeopleRemoteModelResult
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }

        [JsonProperty(PropertyName = "hair_color")]
        public string HairColor { get; set; }

        [JsonProperty(PropertyName = "skin_color")]
        public string SkinColor { get; set; }

        [JsonProperty(PropertyName = "eye_color")]
        public string EyeColor { get; set; }

        [JsonProperty(PropertyName = "birth_year")]
        public string BirthYear { get; set; }

        public string Homeworld { get; set; }

        public string Gender { get; set; }
        public string[] Vehicles { get; set; }
        public string[] Species { get; set; }
        public string[] Starships { get; set; }

    }
}
