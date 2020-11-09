using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsWiki.Domain.Models
{
    // Foi criado a classe do domínio mas como vi que não haveria comportamento,
    // decidi usar o dto, para insert devemos validar dos dados de dominio,
    // mas para get podemos desnormalizar os dados e fazer um get simples visto que o modelo é validado no insert,
    // e como não temos insert não adote.

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
