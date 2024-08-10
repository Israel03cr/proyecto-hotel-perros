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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotelperrosDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.hotelperrosDataSet.clientes);

        }

        private void registrarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro1Cliente registro1Cliente = new Registro1Cliente();
            registro1Cliente.Show();
            this.Hide();
        }
    }
}
