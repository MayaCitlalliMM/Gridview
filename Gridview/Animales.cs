using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gridview
{
    internal class Animales
    {
        public Animales() { }
        public Animales(string tipoAnimal, string nombre)
        {
            TipoAnimal = tipoAnimal;
            Nombre = nombre;
        }
       
        public string TipoAnimal { get; set; }
        public string Nombre { get; set; }
    }
}
