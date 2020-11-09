using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsWiki.Domain.Models
{
    // foi criado a classe do dominio mas como vi que não haveria comportamento 
    //decidi usar o dto seguindo mais ou menn cqrs que nos diz que para insert devemos validar dos dados de dominio
    //mas para get podemos desnormalizar os dados e fazer um get simples visto que o modelo é validado no insert
    // e como não temos insrt não adotei 
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
