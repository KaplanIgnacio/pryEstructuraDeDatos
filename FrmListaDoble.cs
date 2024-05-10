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

        clsListaDoble Lista = new clsListaDoble();

        private void btnVolver5_Click(object sender, EventArgs e)
        {
            FrmVentanaPrincipal a5 = new FrmVentanaPrincipal();
            a5.Show();
            this.Hide();
        }

        private void btnAgregar4_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            Lista.Agregar(ObjNodo);
            Lista.Recorrer(dgvCola);
            Lista.RecorrerDes(dgvCola);
            Lista.Recorrer(lstCola);
            Lista.RecorrerDes(lstCola);
            Lista.Recorrer(cmbLista);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbLista.Text);
                Lista.Eliminar(x);
                Lista.Recorrer(dgvCola);
                Lista.RecorrerDes(dgvCola);
                Lista.Recorrer(lstCola);
                Lista.RecorrerDes(lstCola);
                Lista.Recorrer();
            }
            else
            {
                MessageBox.Show("La lista está vacia");
                cmbLista.Items.Clear();
            }
        }

        private void rbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.Recorrer(dgvCola);
            Lista.Recorrer(lstCola);
        }

        private void rbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.RecorrerDes(dgvCola);
            Lista.RecorrerDes(lstCola);
        }
    }
}
