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
    public partial class FrmBaseDatosOperaciones : Form
    {
        public FrmBaseDatosOperaciones()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmVentanaPrincipal a7 = new FrmVentanaPrincipal();
            a7.Show();
            this.Hide();
        }
    }
}
