using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gridview
{
    internal class Diagnostico:Animales
    {
        public Diagnostico() { }
        public Diagnostico(string tipoAnimal, string nombre, string identificacionAnimal, string enfermedad, string tratamiento, string tipoSangre)
            :base(tipoAnimal, nombre, identificacionAnimal)
        {
            Enfermedad = enfermedad;
            Tratamiento = tratamiento;
            TipoSangre = tipoSangre;
        }

        public string Enfermedad { get; set; }
        public string Tratamiento { get; set; }
        public string TipoSangre { get; set; }
    }
}
