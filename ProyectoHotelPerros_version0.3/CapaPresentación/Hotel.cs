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
    public partial class Hotel : Form
    {
        public Hotel()
        {
            InitializeComponent();
        }

        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVentanaPrincipal formVentanaPrincipal = new FormVentanaPrincipal();
            formVentanaPrincipal.ShowDialog();
            this.Hide();
        }
    }
}
