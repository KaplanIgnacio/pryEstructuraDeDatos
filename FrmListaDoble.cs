using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    public partial class FrmListaDoble : Form
    {
        public FrmListaDoble()
        {
            InitializeComponent();
        }

        private void btnVolver5_Click(object sender, EventArgs e)
        {
            FrmVentanaPrincipal a5 = new FrmVentanaPrincipal();
            a5.Show();
            this.Hide();
        }

        private void btnAgregar4_Click(object sender, EventArgs e)
        {

        }
    }
}
