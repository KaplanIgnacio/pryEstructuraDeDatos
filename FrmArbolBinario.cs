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
            Arbol.RecorrerAsc(dgvArbol);
            Arbol.Recorrer(tvArbol);
            Arbol.RecorrerAsc(lstArbol);
            Arbol.RecorrerAsc(cmbArbol);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Arbol.Raiz != null)
            {
                Int32 x = Convert.ToInt32(cmbArbol.Text);
                Arbol.Eliminar(x); Arbol.RecorrerAsc(dgvArbol);
                Arbol.RecorrerAsc(cmbArbol);
                Arbol.RecorrerAsc(lstArbol);
                Arbol.Recorrer(tvArbol);
                cmbArbol.Text = "";
            }
            else
            {
                MessageBox.Show("El árbol esta vacío"); cmbArbol.Text = "";
            }
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
            Arbol.RecorrerAsc(dgvArbol);
            Arbol.RecorrerAsc(cmbArbol);
            Arbol.RecorrerAsc(lstArbol);
            Arbol.Recorrer(tvArbol);
        }

        private void rbInOrdenAscendente_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerAsc(dgvArbol);
            Arbol.RecorrerAsc(cmbArbol);
            Arbol.RecorrerAsc(lstArbol);
        }

        private void rbInOrdenDescendente_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerDesc(dgvArbol);
            Arbol.RecorrerDesc(cmbArbol);
            Arbol.RecorrerDesc(lstArbol);
        }

        private void rbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerPre(dgvArbol);
            Arbol.RecorrerPre(cmbArbol);
            Arbol.RecorrerPre(lstArbol);
        }

        private void rbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerPost(dgvArbol);
            Arbol.RecorrerPost(cmbArbol);
            Arbol.RecorrerPost(lstArbol);
        }
    }
}
