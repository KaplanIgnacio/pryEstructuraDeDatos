using System;
using System.Collections;
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
    public partial class FrmArbolBinario : Form
    {
        public FrmArbolBinario()
        {
            InitializeComponent();
        }

        clsArbolBinario Arbol = new clsArbolBinario();

        private void btnVolver6_Click(object sender, EventArgs e)
        {
            FrmVentanaPrincipal a6 = new FrmVentanaPrincipal();
            a6.Show();
            this.Hide();
        }

        private void btnAgregar4_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            Arbol.Agregar(ObjNodo);
            Arbol.Recorrer(dgvCola);
            Arbol.Recorrer(treeView1);
            //Arbol.Recorrer(cmbLista);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
