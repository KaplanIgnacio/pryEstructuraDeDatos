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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        private void btnVolver3_Click(object sender, EventArgs e)
        {
            FrmVentanaPrincipal a3 = new FrmVentanaPrincipal();
            a3.Show();
            this.Hide();
        }
    }
}
