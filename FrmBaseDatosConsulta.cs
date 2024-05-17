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
    public partial class FrmBaseDatosConsulta : Form
    {
        public FrmBaseDatosConsulta()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmVentanaPrincipal a8 = new FrmVentanaPrincipal();
            a8.Show();
            this.Hide();
        }
    }
}
