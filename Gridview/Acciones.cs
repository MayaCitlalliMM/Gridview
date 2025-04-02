﻿using System;
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
            new Diagnostico("Gato","Bequer",1120,"Gripe comun","Medicamento","A+"),
            new Diagnostico("Gato","Vina",1001, "Fractura","Yeso","c+"),
            new Diagnostico("Perro","Juan",1520,"Problemas de piel","Medicamento","B-"),
            new Diagnostico("Cotorro","Leche",1450,"Sarna","Medicamento piel","A-"),
            new Diagnostico("Hamster","Roberto",1850,"Fractura","Yeso","O"),

        };
        public List<Diagnostico> MostrarPaciente()
        {
            return listaPacientes; 
        }
        public bool ActualizarPacientes(int Code)
        {


            try
            {
                var objetliminar = listaPacientes.Find(x => x.code == Code);
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
        public bool EliminarPaciente(int Code )
        {


            try
            {
                var objetliminar = listaPacientes.Find(x => x.code == Code);
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
    }
}
