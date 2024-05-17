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
    public partial class FrmBaseDatosRepasoOperaciones : Form
    {
        public FrmBaseDatosRepasoOperaciones()
        {
            InitializeComponent();
        }

        private void FrmBaseDatosRepasoOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmVentanaPrincipal a9 = new FrmVentanaPrincipal();
            a9.Show();
            this.Hide();
        }
    }
}
