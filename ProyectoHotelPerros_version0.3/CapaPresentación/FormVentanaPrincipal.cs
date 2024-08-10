using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using CapaLogicaNegocio;
namespace CapaPresentación
{
    public partial class FormVentanaPrincipal : Form
    {
        public FormVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hotel entrar = new Hotel();
            entrar.Show();
            this.Hide();    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.Show();
            this.Hide();
        }
    }
}
