using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsWiki.Domain.Models
{
    // foi criado a classe do dominio mas como vi que não haveria comportamento 
    //decidi usar o dto seguindo mais ou menn cqrs que nos diz que para insert devemos validar dos dados de dominio
    //mas para get podemos desnormalizar os dados e fazer um get simples visto que o modelo é validado no insert
    // e como não temos insrt não adotei 
    public class People
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public float Mass { get; set; }
        public string HairColor { get; set; }
        public string SkinColor { get; set; }
        public string EyeColor { get; set; }
        public string BirthYear { get; set; }
        public Planet Planet { get; set; }
    }
}
