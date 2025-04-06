using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gridview
{
    internal class Acciones
    {
        Diagnostico a = new Diagnostico();


        List<Diagnostico> listaPacientes = new List<Diagnostico>
        {
            new Diagnostico("Gato","Bequer","BEQ12","Gripe comun","Medicamento","A+"),
            new Diagnostico("Gato","Vina","TYU4R", "Fractura","Yeso","c+"),
            new Diagnostico("Perro","Juan","CA54E","Problemas de piel","Medicamento","B-"),
            new Diagnostico("Cotorro","Leche","JBR5A","Sarna","Medicamento piel","A-"),
            new Diagnostico("Hamster","Roberto","AE2F4","Fractura","Yeso","O"),

        };
        public List<Diagnostico> MostrarPaciente()
        {
            return listaPacientes; 
        }
        public bool ActualizarPacientes(string tipoAnimal, string nombre, string identificacionAnimal, string enfermedad, string tratamiento, string tipoSangre)
        {


            try
            {
                var objetliminar = listaPacientes.Find(x => x.identificacionAnimal == identificacionAnimal);
                objetliminar.TipoAnimal = tipoAnimal;
                objetliminar.Nombre = nombre;
                objetliminar.identificacionAnimal = identificacionAnimal;
                objetliminar.Enfermedad = enfermedad;
                objetliminar.Tratamiento = tratamiento;
                objetliminar.TipoSangre = tipoSangre;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool EliminarPaciente(string identificacionAnimal)
        {


            try
            {
                var objetliminar = listaPacientes.Find(x => x.identificacionAnimal == identificacionAnimal);
                if (objetliminar != null) 
                {
                    listaPacientes.Remove(objetliminar);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
      
        public bool AgregarPaciente(string tipoAnimal, string nombre, string identificacionAnimal, string enfermedad, string tratamiento, string tipoSangre)
        {
            try
            {
                listaPacientes.Add(new Diagnostico(a.TipoAnimal = tipoAnimal,a.Nombre = nombre,a.identificacionAnimal = identificacionAnimal,a.Enfermedad = enfermedad,a.Tratamiento = tratamiento,a.TipoSangre = tipoSangre));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
