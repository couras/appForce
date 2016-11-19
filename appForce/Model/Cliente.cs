using appForce.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace appForce.Model
{
    class Cliente : Persistencia
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sonrenome { get; set; }
        public int idade { get; set; }
    }
}
