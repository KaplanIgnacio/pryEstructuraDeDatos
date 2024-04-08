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
    public partial class FrmCola : Form
    {
        public FrmCola()
        {
            InitializeComponent();
        }

        private void btnVolver2_Click(object sender, EventArgs e)
        {
            FrmVentanaPrincipal a2 = new FrmVentanaPrincipal();
            a2.Show();
            this.Hide();
        }
    }
}
