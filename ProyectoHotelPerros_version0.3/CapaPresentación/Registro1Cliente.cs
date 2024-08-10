using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class Registro1Cliente : Form
    {
        public Registro1Cliente()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVentanaPrincipal formVentanaPrincipal = new FormVentanaPrincipal();
            formVentanaPrincipal.ShowDialog();
            this.Hide();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.ShowDialog();
            this.Hide();
        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            DataSet ingresarcliente = new DataSet();
            try
            {
                string CI = textBoxCI.Text;
                string nombre = textBoxNombre.Text;
                string apellido = textBoxApellido.Text;
                string telefono = textBoxTelefono.Text;

                ingresarcliente = persona.InsertarPersona(CI,nombre, apellido, telefono);
                MessageBox.Show("cliente ingresado correctamente!");
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
