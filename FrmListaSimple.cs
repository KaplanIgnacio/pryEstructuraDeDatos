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
    public partial class FrmListaSimple : Form
    {
        public FrmListaSimple()
        {
            InitializeComponent();
        }

        private void btnVolver4_Click(object sender, EventArgs e)
        {
            FrmVentanaPrincipal a4 = new FrmVentanaPrincipal();
            a4.Show();
            this.Hide();
        }
    }
}
