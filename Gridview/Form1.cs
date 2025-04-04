using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gridview
{
    public partial class Form1 : Form
    {
        Acciones acc = new Acciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = null;
           dataGridView1.DataSource = acc.MostrarPaciente();
        }

        private void btneliminar_Click(object sender, EventArgs e)

        {
        
            if (acc.EliminarPaciente(Convert.ToInt32(txbcode.Text)))
                MessageBox.Show("Eliminado con exito");
            else
                MessageBox.Show("fallo al eliminar");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tx
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            if(acc.AgregarPaciente(txbAnimal.Text, txbNombre.Text, txbCodeagregar.Text, txbEnfermedad.Text, txbTipoSangre.Text, txbTratamiento.Text))
                MessageBox.Show("Agregado con exito");
            else
                MessageBox.Show("Paciente no encontrado");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
