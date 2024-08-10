using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaLogicaNegocio;
namespace CapaPresentación
{
    public partial class Registroperro1 : Form
    {
        public Registroperro1()
        {
            InitializeComponent();
        }


        private void buttonsiguiente_Click(object sender, EventArgs e)
        {
            DataSet DataSetPerro = new DataSet();
            Perro perro = new Perro();
            try
            {
                string nombreperro = textBoxnombreperro.Text;
                string fechanac = maskedTextBoxfecha.Text;
                DateTime fecha;
                DateTime.TryParseExact(fechanac, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fecha);
                string tamano = comboBoxtamano.Text;
                string raza = comboBoxraza.Text;
                string sexo;
                if (radioButtonmacho.Checked)
                {
                    sexo = "Macho";
                }
                else if (radioButtonhembra.Checked)
                {
                    sexo = "Hembra";
                }

                // DataSetPerro = Perro.InsertarPerro();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
