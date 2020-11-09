using System.Collections.Generic;

namespace StarWarsWiki.Domain.Models
{
    // Foi criado a classe do domínio mas como vi que não haveria comportamento,
    // decidi usar o dto, para insert devemos validar dos dados de dominio,
    // mas para get podemos desnormalizar os dados e fazer um get simples visto que o modelo é validado no insert,
    // e como não temos insert não adote.
    public class Planet
    {
        public string Name { get; set; }
        public string RotationPeriod { get; set; }
        public string OrbitalPeriod { get; set; }
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Terrain { get; set; }
        public string SurfaceWater { get; set; }
        public IEnumerable<People> Residents { get; set; }
    }
}
