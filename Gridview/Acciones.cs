using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gridview
{
    internal class Acciones
    {
        List<Diagnostico> listaPacientes = new List<Diagnostico>
        {
            new Diagnostico("Gato","Bequer","Gripe comun","Medicamento","A+"),
            new Diagnostico("Gato","Vina","Fractura","Yeso","c+"),
            new Diagnostico("Perro","Juan","Problemas de piel","Medicamento","B-"),
            new Diagnostico("Cotorro","Leche","Sarna","Medicamento piel","A-"),
            new Diagnostico("Hamster","Roberto","Fractura","Yeso","O"),

        };
        public List<Diagnostico> MostrarPaciente()
        {
            return listaPacientes; 
        }
    }
}
